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
    }
}
