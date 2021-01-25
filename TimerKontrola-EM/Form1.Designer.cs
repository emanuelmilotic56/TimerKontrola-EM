namespace TimerKontrola_EM
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVrijeme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trenutno vrijeme:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVrijeme
            // 
            this.labelVrijeme.AutoSize = true;
            this.labelVrijeme.Location = new System.Drawing.Point(610, 144);
            this.labelVrijeme.Name = "labelVrijeme";
            this.labelVrijeme.Size = new System.Drawing.Size(46, 17);
            this.labelVrijeme.TabIndex = 1;
            this.labelVrijeme.Text = "label2";
            this.labelVrijeme.Click += new System.EventHandler(this.labelVrijeme_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVrijeme);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Upotreba Timer komponente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVrijeme;
        private System.Windows.Forms.Timer timer1;
    }
}

