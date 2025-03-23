using System;
using System.Windows.Forms;


namespace Modern.Forms
{
    partial class FormHOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TimerAPII = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelVecka = new System.Windows.Forms.Label();
            this.labelManad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1cpuNamn = new System.Windows.Forms.Label();
            this.label1gpuNamn = new System.Windows.Forms.Label();
            this.label1ramNamn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "34c";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "48c";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "40c";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TimerAPII
            // 
            this.TimerAPII.AutoSize = true;
            this.TimerAPII.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F);
            this.TimerAPII.Location = new System.Drawing.Point(819, 6);
            this.TimerAPII.Name = "TimerAPII";
            this.TimerAPII.Size = new System.Drawing.Size(106, 22);
            this.TimerAPII.TabIndex = 10;
            this.TimerAPII.Text = "yyyy-MM-dd";
            this.TimerAPII.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(446, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 11;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F);
            this.labelDatum.Location = new System.Drawing.Point(829, 34);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(96, 22);
            this.labelDatum.TabIndex = 10;
            this.labelDatum.Text = "TT:MM:SS";
            this.labelDatum.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelVecka
            // 
            this.labelVecka.AutoSize = true;
            this.labelVecka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F);
            this.labelVecka.Location = new System.Drawing.Point(835, 113);
            this.labelVecka.Name = "labelVecka";
            this.labelVecka.Size = new System.Drawing.Size(90, 22);
            this.labelVecka.TabIndex = 10;
            this.labelVecka.Text = "Vecka: 00";
            this.labelVecka.Click += new System.EventHandler(this.label11_Click);
            // 
            // labelManad
            // 
            this.labelManad.AutoSize = true;
            this.labelManad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F);
            this.labelManad.Location = new System.Drawing.Point(859, 91);
            this.labelManad.Name = "labelManad";
            this.labelManad.Size = new System.Drawing.Size(66, 22);
            this.labelManad.TabIndex = 10;
            this.labelManad.Text = "MMMM";
            this.labelManad.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(292, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 22);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1cpuNamn
            // 
            this.label1cpuNamn.AutoSize = true;
            this.label1cpuNamn.Location = new System.Drawing.Point(12, 34);
            this.label1cpuNamn.Name = "label1cpuNamn";
            this.label1cpuNamn.Size = new System.Drawing.Size(35, 16);
            this.label1cpuNamn.TabIndex = 15;
            this.label1cpuNamn.Text = "CPU";
            // 
            // label1gpuNamn
            // 
            this.label1gpuNamn.AutoSize = true;
            this.label1gpuNamn.Location = new System.Drawing.Point(12, 63);
            this.label1gpuNamn.Name = "label1gpuNamn";
            this.label1gpuNamn.Size = new System.Drawing.Size(36, 16);
            this.label1gpuNamn.TabIndex = 16;
            this.label1gpuNamn.Text = "GPU";
            // 
            // label1ramNamn
            // 
            this.label1ramNamn.AutoSize = true;
            this.label1ramNamn.BackColor = System.Drawing.Color.Transparent;
            this.label1ramNamn.Location = new System.Drawing.Point(11, 91);
            this.label1ramNamn.Name = "label1ramNamn";
            this.label1ramNamn.Size = new System.Drawing.Size(37, 16);
            this.label1ramNamn.TabIndex = 17;
            this.label1ramNamn.Text = "RAM";
            // 
            // FormHOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 472);
            this.Controls.Add(this.label1ramNamn);
            this.Controls.Add(this.label1gpuNamn);
            this.Controls.Add(this.label1cpuNamn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelManad);
            this.Controls.Add(this.labelVecka);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.TimerAPII);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "FormHOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.FormHOME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormHOME_Load(object sender, EventArgs e)
        {
            StartClock(); // För klockan
            GetHardwareInfo(); // För CPU, GPU, RAM
        }


        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TimerAPII;
        private System.Windows.Forms.Label label12;
        private Label labelDatum;
        private Label labelVecka;
        private Label labelManad;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1cpuNamn;
        private Label label1gpuNamn;
        private Label label1ramNamn;
    }



}