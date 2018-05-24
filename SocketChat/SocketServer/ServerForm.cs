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
using System.IO;

namespace SocketServer
{
    public partial class ServerForm : Form
    {
        private TcpClient client;
        public StreamReader strRead;
        public StreamWriter strWrite;
        public string recieve;
        public String textToSend;
        public ServerForm()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());      //Get any IP
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    tb_IPAdress.Text = address.ToString();
                }
            }
        }

        private void StartServer_button_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(s =>
            {
                try
                {
                    TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(textBox5.Text));
                    listener.Start();
                    client = listener.AcceptTcpClient();
                    strRead = new StreamReader(client.GetStream());
                    strWrite = new StreamWriter(client.GetStream());
                    strWrite.AutoFlush = true;

                    Listen_backgroundWorker.RunWorkerAsync();                         //Start recieving data 
                    Listen_backgroundWorker.WorkerSupportsCancellation = true;  
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            })
            { IsBackground = true }.Start();
        }

        private void Listen_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = strRead.ReadLine();
                    this.Receive_textBox.Invoke(new MethodInvoker(delegate () { Receive_textBox.AppendText("C发送 : " + recieve + "\n"); }));
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (SendtextBox.Text != "")
            {
                textToSend = SendtextBox.Text;
                Send_backgroundWorker.RunWorkerAsync();
            }
            SendtextBox.Text = "";
        }

        private void Send_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                strWrite.WriteLine(textToSend);
                this.Receive_textBox.Invoke(new MethodInvoker(delegate () { Receive_textBox.AppendText("S发送 :  " + textToSend + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send Failed!");
            }
            Send_backgroundWorker.CancelAsync();
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Send_backgroundWorker.IsBusy)
            {
                Send_backgroundWorker.CancelAsync();
            }
            else
            {
                Send_backgroundWorker.Dispose();
            }
            if (Listen_backgroundWorker.IsBusy)
            {
                Listen_backgroundWorker.CancelAsync();
            }
            else
            {
                Listen_backgroundWorker.Dispose();
            }
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
