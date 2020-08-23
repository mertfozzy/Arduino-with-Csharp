using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                comboBox1.Items.Add(port);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label1.Text = "Led Açık";  //Label1'e "Led Açık" yaz
            button2.Enabled = true;    //Button2'yi tıklanabilir hale getir
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            label1.Text = "Led Kapalı"; 
            button2.Enabled = false;    
            button1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Open();
        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
    }
}
