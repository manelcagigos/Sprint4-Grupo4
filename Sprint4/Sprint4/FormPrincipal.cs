using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint4
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        string SecureCode;
        int counter = 60;
        SerialPort portArduino = new SerialPort();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports;

            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cmb_portsD.Items.Add(port);
            }

            for (int i = 1; i < 7; i++)
            {
                int dig = numaleatori();
                if (dig.ToString().StartsWith("-"))
                {
                    SecureCode += dig.ToString().Substring(1, 1);
                }
                else
                {
                    SecureCode += dig.ToString().Substring(0, 1);
                }
            }

        }

        private int numaleatori()
        {
            using (RNGCryptoServiceProvider rngCrypt = new RNGCryptoServiceProvider())

            {
                byte[] valor = new byte[4];

                rngCrypt.GetBytes(valor);

                return BitConverter.ToInt32(valor, 0);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                if (portArduino.IsOpen) portArduino.Close();
                MessageBox.Show("Se te ha acabado el tiempo");
                Application.Exit();
            }
            label1.Text = counter.ToString();
        }

        private void SendStartArdu()
        {
            portArduino.Open();
            portArduino.Write("SA");
            //portArduino.Close();

            //enviarmail

        }

        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (portArduino.IsOpen)
            {
                MessageBox.Show("Ya estas conectado al Arduino");
            }
            else
            {
                if (cmb_portsD.Text == "")
                {
                    MessageBox.Show("Se tiene que seleccionar un puerto");
                }
                else
                {
                    SendStartArdu();

                    timer1 = new Timer();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 1000; // 1 segundo
                    timer1.Start();
                    label1.Text = counter.ToString();

                    lb_codigo.Text = SecureCode;
                }
            }   
        }

        private void cmb_portsD_SelectedIndexChanged(object sender, EventArgs e)
        {
            portArduino = new SerialPort(cmb_portsD.SelectedItem.ToString(), 9600);
        }
    }
}