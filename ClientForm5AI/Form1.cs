﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm5AI
{
    public partial class Form1 : Form
    {
        //variabili globali della classe
        Socket client;

        public Form1()
        {
            InitializeComponent();

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            IPAddress ipaddr = null;
            int nPort = 0;
            bool errori = false;

            if(!IPAddress.TryParse(txtIPServer.Text,out ipaddr))
            {
                //ipaddress è vuoto o è non valido
                MessageBox.Show("Ip vuoto o non valido", "Errore");
                errori = true;
            }
            if(!int.TryParse(txtPorta.Text,out nPort))
            {
                //porta o è vuota o è non valida
                MessageBox.Show("La porta è vuota o non valida", "Errore");
                errori = true;
            }
            if (nPort<0 || nPort > 65535)
            {
                //la porta non è valida
                MessageBox.Show("La porta deve essere compresa fra 0 e 65535");
                errori = true;
            }

            if (!errori) {
                try { 
                    client.Connect(ipaddr, nPort);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Errore");
                    if (client != null)
                    {
                        if (client.Connected)
                        {
                            client.Shutdown(SocketShutdown.Both);
                        }
                        client.Close();
                        client.Dispose();
                    }

                }


                txtIPServer.Enabled = false;
                txtPorta.Enabled = false;
                btnConnetti.Enabled = false;

                txtMessaggio.Enabled = true;
                btnInvia.Enabled = true;
            }

        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            byte[] sendBuff = new byte[512];
            byte[] recvBuff = new byte[512];
            string recvString = "";
            int nRecvBytes = 0;

            try
            {
                sendBuff = Encoding.ASCII.GetBytes(txtMessaggio.Text);
                client.Send(sendBuff);


                nRecvBytes = client.Receive(recvBuff);
                recvString = Encoding.ASCII.GetString(recvBuff, 0, nRecvBytes);

                lstMessaggiServ.Items.Add(recvString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore");
                if (client != null)
                {
                    if (client.Connected)
                    {
                        client.Shutdown(SocketShutdown.Both);
                    }
                    client.Close();
                    client.Dispose();
                }

            }

        }
    }
}
