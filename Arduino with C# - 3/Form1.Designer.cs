namespace RGB_Control
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.kirmizi = new System.Windows.Forms.Button();
            this.yesil = new System.Windows.Forms.Button();
            this.mavi = new System.Windows.Forms.Button();
            this.mor = new System.Windows.Forms.Button();
            this.sari = new System.Windows.Forms.Button();
            this.magenta = new System.Windows.Forms.Button();
            this.cyan = new System.Windows.Forms.Button();
            this.beyaz = new System.Windows.Forms.Button();
            this.turuncu = new System.Windows.Forms.Button();
            this.pembe = new System.Windows.Forms.Button();
            this.kahverengi = new System.Windows.Forms.Button();
            this.yesil2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.R = new System.Windows.Forms.TrackBar();
            this.G = new System.Windows.Forms.TrackBar();
            this.B = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.SuspendLayout();
            // 
            // kirmizi
            // 
            this.kirmizi.BackColor = System.Drawing.Color.Red;
            this.kirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kirmizi.ForeColor = System.Drawing.Color.Red;
            this.kirmizi.Location = new System.Drawing.Point(32, 116);
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(75, 38);
            this.kirmizi.TabIndex = 0;
            this.kirmizi.Text = "button1";
            this.kirmizi.UseVisualStyleBackColor = false;
            this.kirmizi.Click += new System.EventHandler(this.kirmizi_Click);
            // 
            // yesil
            // 
            this.yesil.BackColor = System.Drawing.Color.Lime;
            this.yesil.ForeColor = System.Drawing.Color.Lime;
            this.yesil.Location = new System.Drawing.Point(123, 116);
            this.yesil.Name = "yesil";
            this.yesil.Size = new System.Drawing.Size(75, 38);
            this.yesil.TabIndex = 1;
            this.yesil.Text = "button2";
            this.yesil.UseVisualStyleBackColor = false;
            this.yesil.Click += new System.EventHandler(this.yesil_Click);
            // 
            // mavi
            // 
            this.mavi.BackColor = System.Drawing.Color.Blue;
            this.mavi.ForeColor = System.Drawing.Color.Blue;
            this.mavi.Location = new System.Drawing.Point(216, 116);
            this.mavi.Name = "mavi";
            this.mavi.Size = new System.Drawing.Size(75, 38);
            this.mavi.TabIndex = 2;
            this.mavi.Text = "button3";
            this.mavi.UseVisualStyleBackColor = false;
            this.mavi.Click += new System.EventHandler(this.button3_Click);
            // 
            // mor
            // 
            this.mor.BackColor = System.Drawing.Color.Purple;
            this.mor.ForeColor = System.Drawing.Color.Purple;
            this.mor.Location = new System.Drawing.Point(312, 116);
            this.mor.Name = "mor";
            this.mor.Size = new System.Drawing.Size(75, 38);
            this.mor.TabIndex = 3;
            this.mor.Text = "mor";
            this.mor.UseVisualStyleBackColor = false;
            this.mor.Click += new System.EventHandler(this.mor_Click);
            // 
            // sari
            // 
            this.sari.BackColor = System.Drawing.Color.Yellow;
            this.sari.ForeColor = System.Drawing.Color.Yellow;
            this.sari.Location = new System.Drawing.Point(32, 170);
            this.sari.Name = "sari";
            this.sari.Size = new System.Drawing.Size(75, 38);
            this.sari.TabIndex = 4;
            this.sari.Text = "sari";
            this.sari.UseVisualStyleBackColor = false;
            this.sari.Click += new System.EventHandler(this.sari_Click);
            // 
            // magenta
            // 
            this.magenta.BackColor = System.Drawing.Color.Fuchsia;
            this.magenta.ForeColor = System.Drawing.Color.Fuchsia;
            this.magenta.Location = new System.Drawing.Point(123, 170);
            this.magenta.Name = "magenta";
            this.magenta.Size = new System.Drawing.Size(75, 38);
            this.magenta.TabIndex = 5;
            this.magenta.Text = "magenta";
            this.magenta.UseVisualStyleBackColor = false;
            this.magenta.Click += new System.EventHandler(this.magenta_Click);
            // 
            // cyan
            // 
            this.cyan.BackColor = System.Drawing.Color.Aqua;
            this.cyan.ForeColor = System.Drawing.Color.Aqua;
            this.cyan.Location = new System.Drawing.Point(214, 170);
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(75, 38);
            this.cyan.TabIndex = 6;
            this.cyan.Text = "cyan";
            this.cyan.UseVisualStyleBackColor = false;
            this.cyan.Click += new System.EventHandler(this.cyan_Click);
            // 
            // beyaz
            // 
            this.beyaz.BackColor = System.Drawing.Color.White;
            this.beyaz.ForeColor = System.Drawing.Color.White;
            this.beyaz.Location = new System.Drawing.Point(312, 170);
            this.beyaz.Name = "beyaz";
            this.beyaz.Size = new System.Drawing.Size(75, 38);
            this.beyaz.TabIndex = 7;
            this.beyaz.Text = "beyaz";
            this.beyaz.UseVisualStyleBackColor = false;
            this.beyaz.Click += new System.EventHandler(this.beyaz_Click);
            // 
            // turuncu
            // 
            this.turuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.turuncu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.turuncu.Location = new System.Drawing.Point(32, 228);
            this.turuncu.Name = "turuncu";
            this.turuncu.Size = new System.Drawing.Size(75, 39);
            this.turuncu.TabIndex = 8;
            this.turuncu.Text = "button9";
            this.turuncu.UseVisualStyleBackColor = false;
            this.turuncu.Click += new System.EventHandler(this.turuncu_Click);
            // 
            // pembe
            // 
            this.pembe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pembe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pembe.Location = new System.Drawing.Point(122, 227);
            this.pembe.Name = "pembe";
            this.pembe.Size = new System.Drawing.Size(75, 40);
            this.pembe.TabIndex = 9;
            this.pembe.Text = "button10";
            this.pembe.UseVisualStyleBackColor = false;
            this.pembe.Click += new System.EventHandler(this.pembe_Click);
            // 
            // kahverengi
            // 
            this.kahverengi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kahverengi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kahverengi.Location = new System.Drawing.Point(214, 227);
            this.kahverengi.Name = "kahverengi";
            this.kahverengi.Size = new System.Drawing.Size(75, 40);
            this.kahverengi.TabIndex = 10;
            this.kahverengi.Text = "button11";
            this.kahverengi.UseVisualStyleBackColor = false;
            this.kahverengi.Click += new System.EventHandler(this.kahverengi_Click);
            // 
            // yesil2
            // 
            this.yesil2.BackColor = System.Drawing.Color.Green;
            this.yesil2.ForeColor = System.Drawing.Color.Green;
            this.yesil2.Location = new System.Drawing.Point(311, 226);
            this.yesil2.Name = "yesil2";
            this.yesil2.Size = new System.Drawing.Size(75, 41);
            this.yesil2.TabIndex = 11;
            this.yesil2.Text = "button12";
            this.yesil2.UseVisualStyleBackColor = false;
            this.yesil2.Click += new System.EventHandler(this.yesil2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(482, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 225);
            this.panel1.TabIndex = 13;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(47, 378);
            this.R.Maximum = 255;
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(151, 45);
            this.R.TabIndex = 14;
            this.R.Scroll += new System.EventHandler(this.R_Scroll);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(312, 378);
            this.G.Maximum = 255;
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(151, 45);
            this.G.TabIndex = 15;
            this.G.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(590, 378);
            this.B.Maximum = 255;
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(151, 45);
            this.B.TabIndex = 16;
            this.B.Scroll += new System.EventHandler(this.B_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(312, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(590, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "B";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Azure;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(97, 286);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(224, 35);
            this.button13.TabIndex = 20;
            this.button13.Text = "Renk Paleti";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(214, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 21;
            this.button2.Text = "BAĞLAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.yesil2);
            this.Controls.Add(this.kahverengi);
            this.Controls.Add(this.pembe);
            this.Controls.Add(this.turuncu);
            this.Controls.Add(this.beyaz);
            this.Controls.Add(this.cyan);
            this.Controls.Add(this.magenta);
            this.Controls.Add(this.sari);
            this.Controls.Add(this.mor);
            this.Controls.Add(this.mavi);
            this.Controls.Add(this.yesil);
            this.Controls.Add(this.kirmizi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button kirmizi;
        private System.Windows.Forms.Button yesil;
        private System.Windows.Forms.Button mavi;
        private System.Windows.Forms.Button mor;
        private System.Windows.Forms.Button sari;
        private System.Windows.Forms.Button magenta;
        private System.Windows.Forms.Button cyan;
        private System.Windows.Forms.Button beyaz;
        private System.Windows.Forms.Button turuncu;
        private System.Windows.Forms.Button pembe;
        private System.Windows.Forms.Button kahverengi;
        private System.Windows.Forms.Button yesil2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar R;
        private System.Windows.Forms.TrackBar G;
        private System.Windows.Forms.TrackBar B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button2;
    }
}

