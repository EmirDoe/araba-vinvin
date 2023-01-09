namespace Araba_Kiralama
{
    partial class invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_unpaid = new System.Windows.Forms.DataGridView();
            this.dg_paid = new System.Windows.Forms.DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pay_button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_unpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_paid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ödenmemiş Faturalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ödenmiş Faturalar";
            // 
            // dg_unpaid
            // 
            this.dg_unpaid.AllowUserToAddRows = false;
            this.dg_unpaid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dg_unpaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_unpaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_unpaid.BackgroundColor = System.Drawing.Color.White;
            this.dg_unpaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_unpaid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_unpaid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_unpaid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_unpaid.ColumnHeadersHeight = 18;
            this.dg_unpaid.EnableHeadersVisualStyles = false;
            this.dg_unpaid.Location = new System.Drawing.Point(13, 60);
            this.dg_unpaid.Name = "dg_unpaid";
            this.dg_unpaid.ReadOnly = true;
            this.dg_unpaid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_unpaid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_unpaid.RowTemplate.Height = 25;
            this.dg_unpaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_unpaid.Size = new System.Drawing.Size(743, 209);
            this.dg_unpaid.TabIndex = 17;
            // 
            // dg_paid
            // 
            this.dg_paid.AllowUserToAddRows = false;
            this.dg_paid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dg_paid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_paid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_paid.BackgroundColor = System.Drawing.Color.White;
            this.dg_paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_paid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_paid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_paid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_paid.ColumnHeadersHeight = 18;
            this.dg_paid.EnableHeadersVisualStyles = false;
            this.dg_paid.Location = new System.Drawing.Point(13, 329);
            this.dg_paid.Name = "dg_paid";
            this.dg_paid.ReadOnly = true;
            this.dg_paid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_paid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_paid.RowTemplate.Height = 25;
            this.dg_paid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_paid.Size = new System.Drawing.Size(743, 209);
            this.dg_paid.TabIndex = 17;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pay_button
            // 
            this.pay_button.BackColor = System.Drawing.Color.Transparent;
            this.pay_button.BorderRadius = 17;
            this.pay_button.CustomizableEdges = customizableEdges1;
            this.pay_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pay_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pay_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pay_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pay_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pay_button.ForeColor = System.Drawing.Color.White;
            this.pay_button.Location = new System.Drawing.Point(655, 12);
            this.pay_button.Name = "pay_button";
            this.pay_button.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.pay_button.Size = new System.Drawing.Size(101, 34);
            this.pay_button.TabIndex = 69;
            this.pay_button.Text = "Faturayı Öde";
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Araba_Kiralama.Resource1.Artboard_1_2x1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(768, 550);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.dg_paid);
            this.Controls.Add(this.dg_unpaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoice";
            this.Text = "Faturalarım";
            this.Load += new System.EventHandler(this.fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_unpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_paid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dg_unpaid;
        private DataGridView dg_paid;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button pay_button;
    }
}