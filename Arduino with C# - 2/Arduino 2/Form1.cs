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

namespace Arduino_2
{
    public partial class Form1 : Form
    {
        private string data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close(); //seri portu kapa
            button2.Enabled = false;
            button1.Enabled = true;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true; //textboxu yalnızca okunabilir
            string[] ports = SerialPort.GetPortNames(); //portlardan dizi
            foreach (string port in ports)
                comboBox1.Items.Add(port); //comboya ekleme

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);// event oluşturduk
        }
        private void SerialPort1_DataReceived (object sender,SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine(); //veriyi al 
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt16(data); //bara eşitle
            textBox1.Text += DateTime.Now.ToString() + "        " + data + "\n";//textboxa zaman ekle
            label1.Text = "Value of Light = " + data; // geeln veriyi label 1 e eşitle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;  //ComboBox1'de seçili nesneyi port ismine ata
                serialPort1.BaudRate = 9600;            //BaudRate 9600 olarak ayarla
                serialPort1.Open();                     //Seri portu aç
                button2.Enabled = true;                  //Durdurma butonunu aktif hale getir
                button1.Enabled = false;                 //Başlatma butonunu pasif hale getir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //kaydet butonu
        {
            try
            {
                string filelocation = @"C:\Users\mertf\desktop\dosya\";
                string filename = "data.txt";
                System.IO.File.WriteAllText(filelocation + filename, "Time\t\t\tValue\n" + textBox1.Text);
                MessageBox.Show("File Saved Succesfully", "Mesaj");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Fail");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             textBox1.ResetText();           //textBox1'i sıfırla
        }
    }
}
