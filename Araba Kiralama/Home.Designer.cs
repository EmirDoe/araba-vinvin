namespace Araba_Kiralama
{
    partial class Home
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 72);
            this.button2.TabIndex = 0;
            this.button2.Text = "Arabalar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 72);
            this.button3.TabIndex = 0;
            this.button3.Text = "Rezervasyon";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 72);
            this.button4.TabIndex = 0;
            this.button4.Text = "Fatura";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(359, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 72);
            this.button5.TabIndex = 0;
            this.button5.Text = "Çıkış";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}