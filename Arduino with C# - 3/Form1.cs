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

namespace RGB_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetColor(Color color)
        {
            try
            {
                panel1.BackColor = color;
                label1.Text = "R = " + color.R.ToString();
                label2.Text = "G = " + color.G.ToString();
                label3.Text = "B = " + color.B.ToString();

                R.Value = color.R;
                G.Value = color.G;
                B.Value = color.B;

                SerialPort.Write(new[] { color.R, color.G, color.B }, 0, 3);

            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Hata");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetColor(Color.Blue);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SetColor(colorDialog1.Color);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme
        }

        private void kirmizi_Click(object sender, EventArgs e)
        {
            SetColor(Color.Red);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SerialPort.IsOpen)
                {
                    SerialPort.PortName = comboBox1.Text; //Port ismini comboBox1'den al
                    SerialPort.BaudRate = 9600;           //BaudRate'i 9600 olarak ayarla
                    SerialPort.Open();                    //Seri portu aç
                    button2.Text = "KES";                 //Buton2 yazısını değiştir
                }
                else
                {

                    SetColor(Color.Black);                //Rengi siyah olarak ayarla
                    button2.Text = "BAĞLAN";              //Buton2 yazısını değiştir
                    SerialPort.Close();                   //Seri portu kapa

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");      //Hata mesajı
            }
        }

        private void yesil_Click(object sender, EventArgs e)
        {
            SetColor(Color.Lime);
        }

        private void mor_Click(object sender, EventArgs e)
        {
            SetColor(Color.Purple);
        }

        private void sari_Click(object sender, EventArgs e)
        {
            SetColor(Color.Yellow);
        }

        private void magenta_Click(object sender, EventArgs e)
        {
            SetColor(Color.Fuchsia);
        }

        private void cyan_Click(object sender, EventArgs e)
        {
            SetColor(Color.Aqua); 
        }

        private void beyaz_Click(object sender, EventArgs e)
        {
            SetColor(Color.White);

        }

        private void turuncu_Click(object sender, EventArgs e)
        {
            SetColor(Color.Orange);
        }

        private void pembe_Click(object sender, EventArgs e)
        {
            SetColor(Color.DeepPink);
        }

        private void kahverengi_Click(object sender, EventArgs e)
        {
            SetColor(Color.Brown);
        }

        private void yesil2_Click(object sender, EventArgs e)
        {
            SetColor(Color.Green);
        }

        private void R_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value));
        }

        private void B_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value));
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SerialPort.IsOpen) SerialPort.Close();    //Seri port açıksa kapat
        }
    }
}
