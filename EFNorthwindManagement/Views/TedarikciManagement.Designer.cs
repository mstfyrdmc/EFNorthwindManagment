namespace EFNorthwindManagement.Views
{
    partial class TedarikciManagement
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
            this.grpBilgilerTedarik = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtKontakUnvani = new System.Windows.Forms.TextBox();
            this.txtKontakAdi = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBilgilerTedarik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şirket Adı:";
            // 
            // grpBilgilerTedarik
            // 
            this.grpBilgilerTedarik.Controls.Add(this.btnKaydet);
            this.grpBilgilerTedarik.Controls.Add(this.txtTelefonNo);
            this.grpBilgilerTedarik.Controls.Add(this.txtUlke);
            this.grpBilgilerTedarik.Controls.Add(this.txtSehir);
            this.grpBilgilerTedarik.Controls.Add(this.txtAdress);
            this.grpBilgilerTedarik.Controls.Add(this.txtKontakUnvani);
            this.grpBilgilerTedarik.Controls.Add(this.txtKontakAdi);
            this.grpBilgilerTedarik.Controls.Add(this.txtSirketAdi);
            this.grpBilgilerTedarik.Controls.Add(this.label7);
            this.grpBilgilerTedarik.Controls.Add(this.label6);
            this.grpBilgilerTedarik.Controls.Add(this.label5);
            this.grpBilgilerTedarik.Controls.Add(this.label4);
            this.grpBilgilerTedarik.Controls.Add(this.label3);
            this.grpBilgilerTedarik.Controls.Add(this.label2);
            this.grpBilgilerTedarik.Controls.Add(this.label1);
            this.grpBilgilerTedarik.Location = new System.Drawing.Point(12, 25);
            this.grpBilgilerTedarik.Name = "grpBilgilerTedarik";
            this.grpBilgilerTedarik.Size = new System.Drawing.Size(432, 529);
            this.grpBilgilerTedarik.TabIndex = 1;
            this.grpBilgilerTedarik.TabStop = false;
            this.grpBilgilerTedarik.Text = "Bilgiler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(223, 476);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(175, 47);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(177, 414);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(221, 35);
            this.txtTelefonNo.TabIndex = 1;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(136, 358);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(262, 35);
            this.txtUlke.TabIndex = 1;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(136, 311);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(262, 35);
            this.txtSehir.TabIndex = 1;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(136, 247);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(262, 35);
            this.txtAdress.TabIndex = 1;
            // 
            // txtKontakUnvani
            // 
            this.txtKontakUnvani.Location = new System.Drawing.Point(202, 178);
            this.txtKontakUnvani.Name = "txtKontakUnvani";
            this.txtKontakUnvani.Size = new System.Drawing.Size(196, 35);
            this.txtKontakUnvani.TabIndex = 1;
            // 
            // txtKontakAdi
            // 
            this.txtKontakAdi.Location = new System.Drawing.Point(159, 107);
            this.txtKontakAdi.Name = "txtKontakAdi";
            this.txtKontakAdi.Size = new System.Drawing.Size(239, 35);
            this.txtKontakAdi.TabIndex = 1;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(159, 50);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(239, 35);
            this.txtSirketAdi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ülke:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şehir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kontak Ünvanı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kontak Adı:";
            // 
            // dgvListele
            // 
            this.dgvListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListele.Location = new System.Drawing.Point(476, 48);
            this.dgvListele.MultiSelect = false;
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.ReadOnly = true;
            this.dgvListele.RowTemplate.Height = 28;
            this.dgvListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListele.Size = new System.Drawing.Size(845, 581);
            this.dgvListele.TabIndex = 1;
            this.dgvListele.DoubleClick += new System.EventHandler(this.dgvListele_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 97);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // TedarikciManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 653);
            this.Controls.Add(this.dgvListele);
            this.Controls.Add(this.grpBilgilerTedarik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TedarikciManagement";
            this.Text = "TedarikciManagement";
            this.Load += new System.EventHandler(this.TedarikciManagement_Load);
            this.grpBilgilerTedarik.ResumeLayout(false);
            this.grpBilgilerTedarik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBilgilerTedarik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtKontakUnvani;
        private System.Windows.Forms.TextBox txtKontakAdi;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}