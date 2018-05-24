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

namespace SocketClient
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string recieve;
        public String textToSend;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ConnectToServer_button_Click(object sender, EventArgs e)
        {           
            try
            {
                client = new TcpClient();
                IPEndPoint ip_End = new IPEndPoint(IPAddress.Parse(textBox6.Text), int.Parse(textBox4.Text));
                client.Connect(ip_End);
                if (client.Connected)
                {
                    Receive_textBox.AppendText("Connected to server" + "\n");
                    stw = new StreamWriter(client.GetStream());
                    str = new StreamReader(client.GetStream());
                    stw.AutoFlush = true;      
                    Receive_backgroundWorker.RunWorkerAsync();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void Send_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(textToSend);
                this.Receive_textBox.Invoke(new MethodInvoker(delegate () { Receive_textBox.AppendText("C发送 :  " + textToSend + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send Failed!");
            }
            Send_backgroundWorker.CancelAsync();
        }

        private void Send_button_Click(object sender, EventArgs e)
        {
            if (Send_textBox.Text != "")
            {
                textToSend = Send_textBox.Text;
                Send_backgroundWorker.RunWorkerAsync();
            }
            Send_textBox.Text = "";
        }

        private void Receive_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = str.ReadLine();
                    this.Receive_textBox.Invoke(new MethodInvoker(delegate () { Receive_textBox.AppendText("S发送 : " + recieve + "\n"); }));
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Send_backgroundWorker.IsBusy)
            {
                Send_backgroundWorker.CancelAsync();
            }
            else
            {
                Send_backgroundWorker.Dispose();
            }
            if (Receive_backgroundWorker.IsBusy)
            {
                Receive_backgroundWorker.CancelAsync();
            }
            else
            {
                Receive_backgroundWorker.Dispose();
            }
            if (client != null)
            {
                client.Close();
            }
        }
    }
}
