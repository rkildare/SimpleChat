using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SimpleChat
{
    public partial class Form1 : Form
    {
        Socket soc;
        EndPoint rem;
        EndPoint loc;
        byte[] buffer = new byte[1024];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            txtLocIP.Text = GetLocalIP();
        }

        private string GetLocalIP()
        {
            IPHostEntry iphost;
            iphost = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in iphost.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void btnHost_Click(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            loc = new IPEndPoint(IPAddress.Parse(txtLocIP.Text), Convert.ToInt32(txtLocPort.Text));
            rem = new IPEndPoint(IPAddress.Parse(txtRemIP.Text), Convert.ToInt32(txtRemPort.Text));
            soc.Bind(loc);

            soc.Connect(rem);

            buffer = new byte[1024];

            soc.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(acall), soc);
        }

        private void acall(IAsyncResult ar)
        {
            try
            {
                int rec = soc.EndReceive(ar);
                byte[] data = new byte[rec];
                Array.Copy(buffer, data, rec);
                rtxtLog.AppendText("Them: " + Encoding.ASCII.GetString(data) + '\n');
                soc.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(acall), soc);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMsg();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLocIP.Text = "127.0.0.1";
            txtRemIP.Text = "127.0.0.1";
            txtLocPort.Text = "1234";
            txtRemPort.Text = "1234";
        }

        private void rtxtOut_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMsg();
            }
        }
        private void SendMsg()
        {
            soc.Send(Encoding.ASCII.GetBytes(rtxtOut.Text));
            rtxtLog.AppendText("Me: " + rtxtOut.Text + '\n');
            //rtxtOut.Text = "";
            rtxtOut.Clear();
        }
    }
}
