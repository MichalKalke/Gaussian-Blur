namespace GaussianBlur
{
    partial class GaussBlur
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

      

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.threadsnum = new System.Windows.Forms.Label();
            this.blur = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chck1 = new System.Windows.Forms.CheckBox();
            this.chck2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.threadsSum = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(432, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCoral;
            this.textBox1.Location = new System.Drawing.Point(476, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(451, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wprowadź nazwę pliku:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(654, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(432, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Czas wykonania[ms]:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // time
            // 
            this.time.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.time.Location = new System.Drawing.Point(441, 289);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(173, 42);
            this.time.TabIndex = 8;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.Click += new System.EventHandler(this.label5_Click);
            // 
            // threadsnum
            // 
            this.threadsnum.Location = new System.Drawing.Point(0, 0);
            this.threadsnum.Name = "threadsnum";
            this.threadsnum.Size = new System.Drawing.Size(100, 23);
            this.threadsnum.TabIndex = 16;
            // 
            // blur
            // 
            this.blur.BackColor = System.Drawing.Color.LightCoral;
            this.blur.Location = new System.Drawing.Point(323, 442);
            this.blur.Maximum = 100;
            this.blur.Minimum = 1;
            this.blur.Name = "blur";
            this.blur.Size = new System.Drawing.Size(393, 45);
            this.blur.TabIndex = 11;
            this.blur.Value = 10;
            this.blur.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(372, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Moc rozmycia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(12, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 27);
            this.label5.TabIndex = 13;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(470, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 45);
            this.label6.TabIndex = 15;
            this.label6.Text = "10";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // chck1
            // 
            this.chck1.AutoSize = true;
            this.chck1.Location = new System.Drawing.Point(455, 57);
            this.chck1.Name = "chck1";
            this.chck1.Size = new System.Drawing.Size(69, 17);
            this.chck1.TabIndex = 17;
            this.chck1.Text = "Asembler";
            this.chck1.UseVisualStyleBackColor = true;
            this.chck1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chck2
            // 
            this.chck2.AutoSize = true;
            this.chck2.Location = new System.Drawing.Point(564, 57);
            this.chck2.Name = "chck2";
            this.chck2.Size = new System.Drawing.Size(40, 17);
            this.chck2.TabIndex = 18;
            this.chck2.Text = "C#";
            this.chck2.UseVisualStyleBackColor = true;
            this.chck2.CheckedChanged += new System.EventHandler(this.chck2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(482, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Wybierz język:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(495, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Wątki:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // threadsSum
            // 
            this.threadsSum.AutoSize = true;
            this.threadsSum.BackColor = System.Drawing.Color.LightCoral;
            this.threadsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.threadsSum.ForeColor = System.Drawing.Color.Black;
            this.threadsSum.Location = new System.Drawing.Point(559, 504);
            this.threadsSum.Name = "threadsSum";
            this.threadsSum.Size = new System.Drawing.Size(24, 25);
            this.threadsSum.TabIndex = 21;
            this.threadsSum.Text = "0";
            this.threadsSum.Click += new System.EventHandler(this.label9_Click);
            // 
            // threads
            // 
            this.threads.BackColor = System.Drawing.Color.LightCoral;
            this.threads.Location = new System.Drawing.Point(323, 539);
            this.threads.Maximum = 64;
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(393, 45);
            this.threads.TabIndex = 22;
            this.threads.Scroll += new System.EventHandler(this.threads_Scroll);
            // 
            // GaussBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1093, 644);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.threadsSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chck2);
            this.Controls.Add(this.chck1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blur);
            this.Controls.Add(this.threadsnum);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "GaussBlur";
            this.Text = "GaussianBlur - Michał Kalke";
            this.Load += new System.EventHandler(this.GaussBlur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label time;
        //private System.Windows.Forms.TrackBar threads;
        private System.Windows.Forms.Label threadsnum;
        private System.Windows.Forms.TrackBar blur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chck1;
        private System.Windows.Forms.CheckBox chck2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label threadsSum;
        private System.Windows.Forms.TrackBar threads;
    }
}

