package main

import (
	"bufio"
	"log"
	"net"
)

func main() {
	ln, err := net.Listen("tcp", "127.0.0.1:1234")
	if err != nil {
		log.Println(err.Error())
	}
	aconns := make(map[net.Conn]string)
	conns := make(chan net.Conn)
	dconns := make(chan net.Conn)
	msgs := make(chan string)
	active := make(chan net.Conn)
	log.Println("Server Running...")
	go func() {
		for {
			conn, err := ln.Accept()
			if err != nil {
				log.Println(err.Error())
			}
			conns <- conn
		}
	}()

	for {
		select {
		case user := <-conns:
			log.Print(aconns)
			go func(conn net.Conn) {
				rd := bufio.NewReader(conn)
				user.Write([]byte("Username: " + "\n"))
				m, err := rd.ReadString('\n')
				m = m[0:(len(m) - 1)]
				log.Println(m)
				if err != nil {
				}
				aconns[user] = m
				for {
					m, err := rd.ReadString('\n')
					if err != nil {
						break
					}
					//msgs <- fmt.Sprintf("Client %v:%v", i, m)
					msgs <- m
					active <- conn
				}
				dconns <- conn
			}(user)
		case msg := <-msgs:
			index := <-active
			if msg[0] == '/' && len(msg) == 4 {
				log.Println(string(len(msg)))
				log.Print("have a command: ")
				log.Println(msg)
				if msg[1:4] == "sec" {
					index.Write([]byte("Secret Message Just for you\r\n"))
				} else if msg[1:4] == "lis" {
					for conn := range aconns {
						index.Write([]byte(string(aconns[conn]) + conn.LocalAddr().String() + "\r\n"))
					}
				} else {
					for conn := range aconns {
						conn.Write([]byte(aconns[index] + ": " + msg))
					}
				}
			} else {
				for conn := range aconns {
					conn.Write([]byte(aconns[index] + ": " + msg))
				}
			}
		case dconn := <-dconns:
			log.Printf("Client %v is gone\n", aconns[dconn])
			delete(aconns, dconn)
		}
	}
}

func cmd(string) {

}
