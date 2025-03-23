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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TimerAPII = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelVecka = new System.Windows.Forms.Label();
            this.labelManad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Engelska Translater";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "AMD - RYZEN 9800XD3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "RTX 3090";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "32 GB RAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "34c";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "48c";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "40c";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "PC API";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            // FormHOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 472);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelManad);
            this.Controls.Add(this.labelVecka);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.TimerAPII);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormHOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.FormHOME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormHOME_Load(object sender, EventArgs e)
        {
            timeUpdater = new Timer();
            timeUpdater.Interval = 1000; // 1 sekund
            timeUpdater.Tick += TimeUpdater_Tick;
            timeUpdater.Start();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TimerAPII;
        private System.Windows.Forms.Label label12;
        private Label labelDatum;
        private Label labelVecka;
        private Label labelManad;
    }



}