namespace EFNorthwindManagement.Views
{
    partial class KargoFirmalarıManagement
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
            this.grpKargoFirmalarıBilgiler = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpKargoFirmalarıBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKargoFirmalarıBilgiler
            // 
            this.grpKargoFirmalarıBilgiler.Controls.Add(this.btnKaydet);
            this.grpKargoFirmalarıBilgiler.Controls.Add(this.txtTelefonNo);
            this.grpKargoFirmalarıBilgiler.Controls.Add(this.txtSirketAdi);
            this.grpKargoFirmalarıBilgiler.Controls.Add(this.label2);
            this.grpKargoFirmalarıBilgiler.Controls.Add(this.label1);
            this.grpKargoFirmalarıBilgiler.Location = new System.Drawing.Point(20, 17);
            this.grpKargoFirmalarıBilgiler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpKargoFirmalarıBilgiler.Name = "grpKargoFirmalarıBilgiler";
            this.grpKargoFirmalarıBilgiler.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpKargoFirmalarıBilgiler.Size = new System.Drawing.Size(375, 355);
            this.grpKargoFirmalarıBilgiler.TabIndex = 0;
            this.grpKargoFirmalarıBilgiler.TabStop = false;
            this.grpKargoFirmalarıBilgiler.Text = "Bilgiler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(163, 223);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(189, 64);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(185, 128);
            this.txtTelefonNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(164, 35);
            this.txtTelefonNo.TabIndex = 1;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(185, 58);
            this.txtSirketAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(164, 35);
            this.txtSirketAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı:";
            // 
            // dgvListele
            // 
            this.dgvListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListele.Location = new System.Drawing.Point(415, 30);
            this.dgvListele.MultiSelect = false;
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.ReadOnly = true;
            this.dgvListele.RowTemplate.Height = 28;
            this.dgvListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListele.Size = new System.Drawing.Size(906, 611);
            this.dgvListele.TabIndex = 1;
            this.dgvListele.DoubleClick += new System.EventHandler(this.dgvListele_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 34);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // KargoFirmalarıManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 653);
            this.Controls.Add(this.dgvListele);
            this.Controls.Add(this.grpKargoFirmalarıBilgiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "KargoFirmalarıManagement";
            this.Text = "KargoFirmalarıManagement";
            this.Load += new System.EventHandler(this.KargoFirmalarıManagement_Load);
            this.grpKargoFirmalarıBilgiler.ResumeLayout(false);
            this.grpKargoFirmalarıBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKargoFirmalarıBilgiler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}