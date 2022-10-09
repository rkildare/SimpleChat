package main

import (
	"bufio"
	"log"
	"net"
)

func main() {
	ln, err := net.Listen("tcp", "127.0.0.1:1234") // Start the serer on port 1234
	if err != nil {
		log.Println(err.Error())
	}
	aconns := make(map[net.Conn]string) //Create a 2-column matrix of active connections and their associated username
	conns := make(chan net.Conn)        //Channel for new connections
	dconns := make(chan net.Conn)       //Channel for disconnecions
	msgs := make(chan string)           //Channel for messagestc
	active := make(chan net.Conn)       // Channel to pass the conn that is actively messaging
	log.Println("Server Running...")

	//(begin block) - Start a process in the background to handle new connections.
	go func() {
		for {
			conn, err := ln.Accept() //whenever a connection is accepted(by the listener) create a connection object.
			if err != nil {
				log.Println(err.Error())
			}
			conns <- conn //Pass the new connection object into the conns channel to be processed on the main thread.
		}
	}()
	//(end block)

	// The following for-loop is the main loop of this program.
	for {
		// Using this switch-case constantly look through all channels individually to see if anything has been passed through, and deal with it accordingly
		select {
		// (begin block) - This case handles what to do if there is a new user.
		case user := <-conns: // If there is a conn object in the conns channel, remove it from the channel and store it as a variable named user
			log.Print(aconns)
			// create a background process for each new user. This function takes the conn (user) as input, asks for a username, logs that response, and locks into an infinite loop of looking for messages;
			//until, of course, the user disconnects, in which case the conn is sent to dconns
			go func(conn net.Conn) {
				rd := bufio.NewReader(conn) //create a message buffer associated with this conn
				user.Write([]byte("Username: " + "\n"))
				m, err := rd.ReadString('\n')
				m = m[0:(len(m) - 1)]
				//log.Println("here")
				if err != nil {
				}
				user.Write([]byte("Welcome " + m + "\n"))
				//aconns[user] = "hey"
				aconns[user] = m
				for {
					//log.Println(rd.ReadString('g'))
					m, err := rd.ReadString('\n') //read a line from the buffer associated with this conn
					m = m[0:(len(m) - 1)]
					if err != nil {
						break
					}
					log.Println(m)
					//msgs <- fmt.Sprintf("Client %v:%v", i, m)
					msgs <- m      //pass the message to the main thread with the msgs channel
					active <- conn //pass the active user conn to the main thread with the active channel
				}
				dconns <- conn //disconnect this conn
			}(user) //this is the input for the funcion
		// (end block)

		// (begin block) // this secion handles incomming messages.
		case msg := <-msgs: //read a message from the msgs channel and store it as a variable named msg.
			index := <-active //read a conn from the active channel and store it as a variable named index
			// check to see if this is a command and handle it accordingly. messages are a slash symbol, followed by three characters
			if msg[0] == '/' && len(msg) == 4 {
				log.Println(string(len(msg)))
				log.Print("have a command: ")
				log.Println(msg)
				if msg[1:4] == "sec" { // this command just writes a dumb message (used to check if commands are working)
					index.Write([]byte("Secret Message Just for you\r\n"))
				} else if msg[1:4] == "lis" {
					for conn := range aconns { // this command lists all active users
						index.Write([]byte(string(aconns[conn]) + conn.LocalAddr().String() + "\r\n"))
					}
				} else {
					for conn := range aconns { // if the message was a slash followed by three chars but is not a valid command, just post the message normally
						conn.Write([]byte(aconns[index] + ": " + msg))
					}
				}
				// if it's not a command, just post the message (with username) to all conns in the chat-room
			} else {
				for conn := range aconns {
					conn.Write([]byte(aconns[index] + ": " + msg))
				}
			}
		// (end block)

		case dconn := <-dconns:
			log.Printf("Client %v is gone\n", aconns[dconn])
			delete(aconns, dconn) // delete the entry in accons at index dconn
		}
	}
}

// This was a function left here to remind future-me to flesh out the command system.... well it's future-me and I never did it. Sorry me.
func cmd(string) {

}
