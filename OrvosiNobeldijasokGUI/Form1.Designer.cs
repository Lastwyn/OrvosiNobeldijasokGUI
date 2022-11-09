namespace OrvosiNobeldijasokGUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_ev = new System.Windows.Forms.TextBox();
            this.textBox2_nev = new System.Windows.Forms.TextBox();
            this.textBox3_szh = new System.Windows.Forms.TextBox();
            this.textBox4_orszag = new System.Windows.Forms.TextBox();
            this.button1_beiras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sz/H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // textBox1_ev
            // 
            this.textBox1_ev.Location = new System.Drawing.Point(73, 60);
            this.textBox1_ev.Name = "textBox1_ev";
            this.textBox1_ev.Size = new System.Drawing.Size(87, 20);
            this.textBox1_ev.TabIndex = 4;
            // 
            // textBox2_nev
            // 
            this.textBox2_nev.Location = new System.Drawing.Point(73, 98);
            this.textBox2_nev.Name = "textBox2_nev";
            this.textBox2_nev.Size = new System.Drawing.Size(193, 20);
            this.textBox2_nev.TabIndex = 5;
            // 
            // textBox3_szh
            // 
            this.textBox3_szh.Location = new System.Drawing.Point(73, 137);
            this.textBox3_szh.Name = "textBox3_szh";
            this.textBox3_szh.Size = new System.Drawing.Size(125, 20);
            this.textBox3_szh.TabIndex = 6;
            // 
            // textBox4_orszag
            // 
            this.textBox4_orszag.Location = new System.Drawing.Point(73, 178);
            this.textBox4_orszag.Name = "textBox4_orszag";
            this.textBox4_orszag.Size = new System.Drawing.Size(87, 20);
            this.textBox4_orszag.TabIndex = 7;
            // 
            // button1_beiras
            // 
            this.button1_beiras.Location = new System.Drawing.Point(99, 221);
            this.button1_beiras.Name = "button1_beiras";
            this.button1_beiras.Size = new System.Drawing.Size(118, 23);
            this.button1_beiras.TabIndex = 8;
            this.button1_beiras.Text = "Adatok mentése";
            this.button1_beiras.UseVisualStyleBackColor = true;
            this.button1_beiras.Click += new System.EventHandler(this.button1_beiras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 275);
            this.Controls.Add(this.button1_beiras);
            this.Controls.Add(this.textBox4_orszag);
            this.Controls.Add(this.textBox3_szh);
            this.Controls.Add(this.textBox2_nev);
            this.Controls.Add(this.textBox1_ev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_ev;
        private System.Windows.Forms.TextBox textBox2_nev;
        private System.Windows.Forms.TextBox textBox3_szh;
        private System.Windows.Forms.TextBox textBox4_orszag;
        private System.Windows.Forms.Button button1_beiras;
    }
}

