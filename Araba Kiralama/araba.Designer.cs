﻿namespace Araba_Kiralama
{
    partial class araba
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
            this.lb_tc = new System.Windows.Forms.Label();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.lb_km = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.lb_marka = new System.Windows.Forms.Label();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.lb_model = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.lb_yil = new System.Windows.Forms.Label();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.lb_renk = new System.Windows.Forms.Label();
            this.txt_renk = new System.Windows.Forms.TextBox();
            this.lb_tur = new System.Windows.Forms.Label();
            this.txt_tur = new System.Windows.Forms.TextBox();
            this.lb_hp = new System.Windows.Forms.Label();
            this.txt_hp = new System.Windows.Forms.TextBox();
            this.lb_vites = new System.Windows.Forms.Label();
            this.txt_vites = new System.Windows.Forms.TextBox();
            this.lb_yakit = new System.Windows.Forms.Label();
            this.txt_yakit = new System.Windows.Forms.TextBox();
            this.lb_tuketim = new System.Windows.Forms.Label();
            this.txt_tuketim = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_tc
            // 
            this.lb_tc.AutoSize = true;
            this.lb_tc.Location = new System.Drawing.Point(83, 37);
            this.lb_tc.Name = "lb_tc";
            this.lb_tc.Size = new System.Drawing.Size(35, 15);
            this.lb_tc.TabIndex = 0;
            this.lb_tc.Text = "Plaka";
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(187, 34);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(100, 23);
            this.txt_plaka.TabIndex = 1;
            // 
            // lb_km
            // 
            this.lb_km.AutoSize = true;
            this.lb_km.Location = new System.Drawing.Point(83, 66);
            this.lb_km.Name = "lb_km";
            this.lb_km.Size = new System.Drawing.Size(25, 15);
            this.lb_km.TabIndex = 0;
            this.lb_km.Text = "KM";
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(187, 63);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(100, 23);
            this.txt_km.TabIndex = 1;
            // 
            // lb_marka
            // 
            this.lb_marka.AutoSize = true;
            this.lb_marka.Location = new System.Drawing.Point(83, 95);
            this.lb_marka.Name = "lb_marka";
            this.lb_marka.Size = new System.Drawing.Size(40, 15);
            this.lb_marka.TabIndex = 0;
            this.lb_marka.Text = "Marka";
            this.lb_marka.Click += new System.EventHandler(this.lb_marka_Click);
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(187, 92);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(100, 23);
            this.txt_marka.TabIndex = 1;
            this.txt_marka.TextChanged += new System.EventHandler(this.txt_marka_TextChanged);
            // 
            // lb_model
            // 
            this.lb_model.AutoSize = true;
            this.lb_model.Location = new System.Drawing.Point(83, 124);
            this.lb_model.Name = "lb_model";
            this.lb_model.Size = new System.Drawing.Size(41, 15);
            this.lb_model.TabIndex = 0;
            this.lb_model.Text = "Model";
            this.lb_model.Click += new System.EventHandler(this.lb_model_Click);
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(187, 121);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 23);
            this.txt_model.TabIndex = 1;
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            // 
            // lb_yil
            // 
            this.lb_yil.AutoSize = true;
            this.lb_yil.Location = new System.Drawing.Point(83, 153);
            this.lb_yil.Name = "lb_yil";
            this.lb_yil.Size = new System.Drawing.Size(20, 15);
            this.lb_yil.TabIndex = 0;
            this.lb_yil.Text = "Yıl";
            this.lb_yil.Click += new System.EventHandler(this.lb_yil_Click);
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(187, 150);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(100, 23);
            this.txt_yil.TabIndex = 1;
            this.txt_yil.TextChanged += new System.EventHandler(this.txt_yil_TextChanged);
            // 
            // lb_renk
            // 
            this.lb_renk.AutoSize = true;
            this.lb_renk.Location = new System.Drawing.Point(83, 182);
            this.lb_renk.Name = "lb_renk";
            this.lb_renk.Size = new System.Drawing.Size(33, 15);
            this.lb_renk.TabIndex = 0;
            this.lb_renk.Text = "Renk";
            this.lb_renk.Click += new System.EventHandler(this.lb_renk_Click);
            // 
            // txt_renk
            // 
            this.txt_renk.Location = new System.Drawing.Point(187, 179);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(100, 23);
            this.txt_renk.TabIndex = 1;
            this.txt_renk.TextChanged += new System.EventHandler(this.txt_renk_TextChanged);
            // 
            // lb_tur
            // 
            this.lb_tur.AutoSize = true;
            this.lb_tur.Location = new System.Drawing.Point(83, 211);
            this.lb_tur.Name = "lb_tur";
            this.lb_tur.Size = new System.Drawing.Size(24, 15);
            this.lb_tur.TabIndex = 0;
            this.lb_tur.Text = "Tür";
            this.lb_tur.Click += new System.EventHandler(this.lb_tur_Click);
            // 
            // txt_tur
            // 
            this.txt_tur.Location = new System.Drawing.Point(187, 208);
            this.txt_tur.Name = "txt_tur";
            this.txt_tur.Size = new System.Drawing.Size(100, 23);
            this.txt_tur.TabIndex = 1;
            this.txt_tur.TextChanged += new System.EventHandler(this.txt_tur_TextChanged);
            // 
            // lb_hp
            // 
            this.lb_hp.AutoSize = true;
            this.lb_hp.Location = new System.Drawing.Point(83, 240);
            this.lb_hp.Name = "lb_hp";
            this.lb_hp.Size = new System.Drawing.Size(71, 15);
            this.lb_hp.TabIndex = 0;
            this.lb_hp.Text = "Beygir Gücü";
            this.lb_hp.Click += new System.EventHandler(this.lb_hp_Click);
            // 
            // txt_hp
            // 
            this.txt_hp.Location = new System.Drawing.Point(187, 237);
            this.txt_hp.Name = "txt_hp";
            this.txt_hp.Size = new System.Drawing.Size(100, 23);
            this.txt_hp.TabIndex = 1;
            this.txt_hp.TextChanged += new System.EventHandler(this.txt_hp_TextChanged);
            // 
            // lb_vites
            // 
            this.lb_vites.AutoSize = true;
            this.lb_vites.Location = new System.Drawing.Point(83, 269);
            this.lb_vites.Name = "lb_vites";
            this.lb_vites.Size = new System.Drawing.Size(59, 15);
            this.lb_vites.TabIndex = 0;
            this.lb_vites.Text = "Vites Türü";
            this.lb_vites.Click += new System.EventHandler(this.lb_vites_Click);
            // 
            // txt_vites
            // 
            this.txt_vites.Location = new System.Drawing.Point(187, 266);
            this.txt_vites.Name = "txt_vites";
            this.txt_vites.Size = new System.Drawing.Size(100, 23);
            this.txt_vites.TabIndex = 1;
            this.txt_vites.TextChanged += new System.EventHandler(this.txt_vites_TextChanged);
            // 
            // lb_yakit
            // 
            this.lb_yakit.AutoSize = true;
            this.lb_yakit.Location = new System.Drawing.Point(83, 298);
            this.lb_yakit.Name = "lb_yakit";
            this.lb_yakit.Size = new System.Drawing.Size(61, 15);
            this.lb_yakit.TabIndex = 0;
            this.lb_yakit.Text = "Yakıt Cinsi";
            this.lb_yakit.Click += new System.EventHandler(this.lb_yakit_Click);
            // 
            // txt_yakit
            // 
            this.txt_yakit.Location = new System.Drawing.Point(187, 295);
            this.txt_yakit.Name = "txt_yakit";
            this.txt_yakit.Size = new System.Drawing.Size(100, 23);
            this.txt_yakit.TabIndex = 1;
            this.txt_yakit.TextChanged += new System.EventHandler(this.txt_yakit_TextChanged);
            // 
            // lb_tuketim
            // 
            this.lb_tuketim.AutoSize = true;
            this.lb_tuketim.Location = new System.Drawing.Point(83, 327);
            this.lb_tuketim.Name = "lb_tuketim";
            this.lb_tuketim.Size = new System.Drawing.Size(81, 15);
            this.lb_tuketim.TabIndex = 0;
            this.lb_tuketim.Text = "Yakıt Tüketimi";
            this.lb_tuketim.Click += new System.EventHandler(this.lb_tuketim_Click);
            // 
            // txt_tuketim
            // 
            this.txt_tuketim.Location = new System.Drawing.Point(187, 324);
            this.txt_tuketim.Name = "txt_tuketim";
            this.txt_tuketim.Size = new System.Drawing.Size(100, 23);
            this.txt_tuketim.TabIndex = 1;
            this.txt_tuketim.TextChanged += new System.EventHandler(this.txt_tuketim_TextChanged);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(68, 425);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(103, 54);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(187, 425);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(103, 54);
            this.btn_iptal.TabIndex = 2;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(195, 274);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 19);
            this.listBox1.TabIndex = 3;
            // 
            // araba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 505);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_vites);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.lb_vites);
            this.Controls.Add(this.lb_model);
            this.Controls.Add(this.txt_hp);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.lb_hp);
            this.Controls.Add(this.lb_marka);
            this.Controls.Add(this.txt_tur);
            this.Controls.Add(this.lb_tur);
            this.Controls.Add(this.txt_renk);
            this.Controls.Add(this.txt_tuketim);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.lb_renk);
            this.Controls.Add(this.lb_tuketim);
            this.Controls.Add(this.lb_km);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.lb_yil);
            this.Controls.Add(this.txt_yakit);
            this.Controls.Add(this.lb_yakit);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.lb_tc);
            this.Name = "araba";
            this.Text = "araba";
            this.Load += new System.EventHandler(this.araba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_tc;
        private TextBox txt_plaka;
        private Label lb_km;
        private TextBox txt_km;
        private Label lb_marka;
        private TextBox txt_marka;
        private Label lb_model;
        private TextBox txt_model;
        private Label lb_yil;
        private TextBox txt_yil;
        private Label lb_renk;
        private TextBox txt_renk;
        private Label lb_tur;
        private TextBox txt_tur;
        private Label lb_hp;
        private TextBox txt_hp;
        private Label lb_vites;
        private TextBox txt_vites;
        private Label lb_yakit;
        private TextBox txt_yakit;
        private Label lb_tuketim;
        private TextBox txt_tuketim;
        private Button btn_ekle;
        private Button btn_iptal;
        private ListBox listBox1;
    }
}