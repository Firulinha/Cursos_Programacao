using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;// Porta Serial

namespace IHM1
{
    public partial class Form1 : Form
    {
        string Rx;// leituta da informação
        delegate void chamaLeituraSerial();
        bool ST = false;
        string T1, T2, T3, T4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ConfigBaudRate
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400" };// bps
            cbxBaudRate.Items.AddRange(BaudRate);
            #endregion
            #region ConfigPortCom
            string[] PortCom = SerialPort.GetPortNames();
            cbxPortCom.Items.AddRange(PortCom);
            #endregion
            //PilotoConectar.Enabled = true;
            btnDesconectar.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
            else
            {
                serialPort1.BaudRate = int.Parse(cbxBaudRate.Text);// config baud-rate
                serialPort1.PortName = cbxPortCom.Text;// config portcom
                serialPort1.Open();// porta conectada
                btnConectar.Enabled = false;
                PilotoConectar.Value = true;
                btnDesconectar.Enabled = true;
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                PilotoConectar.Value = false;
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
            }
        }


        void RxData()
        {
            if (ST==true)
            {
                
                Rx = serialPort1.ReadLine();
                lblA0.Text = Rx;

                string[] vetor = Rx.Split(':');
                T1 = vetor[0];
                T2 = vetor[1];
                T3 = vetor[2];
                T4 = vetor[3];

                lblT1.Text = T1;
                lblT2.Text = T2;
                lblT3.Text = T3;
                lblT4.Text = T4;
                
                tank1.Value = (float)double.Parse(T1);
                tank2.Value = (float)double.Parse(T2);
                tank3.Value = (float)double.Parse(T3);
                tank4.Value = (float)double.Parse(T4);

                if (Rx.IndexOf("[EN]") != -1)
                {
                    pilotL1.Value = true;
                }
                if (Rx.IndexOf("[DN]") != -1)
                {
                    pilotL1.Value = false;
                }

            }
           
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            chamaLeituraSerial obj_1 = new chamaLeituraSerial(RxData);
            Invoke(obj_1);
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[EN]");
                ST = true;
                pilotL1.Value = true;
            }
            else
            {
                MessageBox.Show("Falha de conexão");
            }

          
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[DN]");
                ST = false;
                pilotL1.Value = false;
            }
            else
            {
                MessageBox.Show("Falha de conexão");
            }

            
        }
    }
}
