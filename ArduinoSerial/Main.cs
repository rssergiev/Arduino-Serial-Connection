using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSerial
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txtBaudRate.Text = "9600";
            serialPort1.BaudRate = 9600;
            comboBox1.Text = serialPort1.PortName;
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    serialPort1.Write(comboSend.SelectedItem.ToString());
                    serialPort1.Close();
                }
                catch
                {
                    MessageBox.Show("There was an error. \n\r" +
                                    "Please make sure that the correct port \n\r" +
                                    "was selected, and the device, plugged in." + "\n\r" +
                                    "Port selected:\t" + serialPort1.PortName + "\n\r" +
                                    "Baud Rate:\t" + serialPort1.BaudRate);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    serialPort1.Write(txtSendBox.Text);
                    serialPort1.Close();
                }
                catch
                {
                    MessageBox.Show("There was an error. \n\r" +
                                    "Please make sure that the correct port \n\r" +
                                    "was selected, and the device, plugged in." + "\n\r" +
                                    "Port selected:\t" + serialPort1.PortName + "\n\r" +
                                    "Baud Rate:\t" + serialPort1.BaudRate);
                }
            }
        }

        private void comboSend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
        }
    }
}
