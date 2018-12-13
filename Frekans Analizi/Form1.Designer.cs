namespace Frekans_Analizi
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
            this.tx_analizmetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstb_analizsonucu = new System.Windows.Forms.ListBox();
            this.prgb_durum = new System.Windows.Forms.ProgressBar();
            this.btn_analizet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_analizmetin
            // 
            this.tx_analizmetin.Location = new System.Drawing.Point(82, 9);
            this.tx_analizmetin.Multiline = true;
            this.tx_analizmetin.Name = "tx_analizmetin";
            this.tx_analizmetin.Size = new System.Drawing.Size(307, 238);
            this.tx_analizmetin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analiz Metni";
            // 
            // lstb_analizsonucu
            // 
            this.lstb_analizsonucu.FormattingEnabled = true;
            this.lstb_analizsonucu.Location = new System.Drawing.Point(395, 9);
            this.lstb_analizsonucu.Name = "lstb_analizsonucu";
            this.lstb_analizsonucu.Size = new System.Drawing.Size(96, 264);
            this.lstb_analizsonucu.TabIndex = 2;
            // 
            // prgb_durum
            // 
            this.prgb_durum.Location = new System.Drawing.Point(82, 253);
            this.prgb_durum.Name = "prgb_durum";
            this.prgb_durum.Size = new System.Drawing.Size(307, 23);
            this.prgb_durum.TabIndex = 3;
            // 
            // btn_analizet
            // 
            this.btn_analizet.Location = new System.Drawing.Point(82, 282);
            this.btn_analizet.Name = "btn_analizet";
            this.btn_analizet.Size = new System.Drawing.Size(75, 23);
            this.btn_analizet.TabIndex = 4;
            this.btn_analizet.Text = "Analiz Et";
            this.btn_analizet.UseVisualStyleBackColor = true;
            this.btn_analizet.Click += new System.EventHandler(this.btn_analizet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 312);
            this.Controls.Add(this.btn_analizet);
            this.Controls.Add(this.prgb_durum);
            this.Controls.Add(this.lstb_analizsonucu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_analizmetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_analizmetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstb_analizsonucu;
        private System.Windows.Forms.ProgressBar prgb_durum;
        private System.Windows.Forms.Button btn_analizet;
    }
}

