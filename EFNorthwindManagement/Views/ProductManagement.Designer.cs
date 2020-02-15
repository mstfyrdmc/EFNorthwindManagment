namespace EFNorthwindManagement.Views
{
    partial class ProductManagement
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
            this.grpBilgiler = new System.Windows.Forms.GroupBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.cbTedarikciler = new System.Windows.Forms.ComboBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrStokMiktari = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.grpBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStokMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBilgiler
            // 
            this.grpBilgiler.Controls.Add(this.btnIslem);
            this.grpBilgiler.Controls.Add(this.cbTedarikciler);
            this.grpBilgiler.Controls.Add(this.cbKategoriler);
            this.grpBilgiler.Controls.Add(this.label5);
            this.grpBilgiler.Controls.Add(this.nmrStokMiktari);
            this.grpBilgiler.Controls.Add(this.label4);
            this.grpBilgiler.Controls.Add(this.label3);
            this.grpBilgiler.Controls.Add(this.nmrFiyat);
            this.grpBilgiler.Controls.Add(this.label2);
            this.grpBilgiler.Controls.Add(this.txtUrunAdi);
            this.grpBilgiler.Controls.Add(this.label1);
            this.grpBilgiler.Location = new System.Drawing.Point(13, 14);
            this.grpBilgiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBilgiler.Name = "grpBilgiler";
            this.grpBilgiler.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBilgiler.Size = new System.Drawing.Size(254, 367);
            this.grpBilgiler.TabIndex = 0;
            this.grpBilgiler.TabStop = false;
            this.grpBilgiler.Text = "Bilgiler";
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(21, 313);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(216, 36);
            this.btnIslem.TabIndex = 4;
            this.btnIslem.Text = "Kaydet";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // cbTedarikciler
            // 
            this.cbTedarikciler.FormattingEnabled = true;
            this.cbTedarikciler.Location = new System.Drawing.Point(21, 279);
            this.cbTedarikciler.Name = "cbTedarikciler";
            this.cbTedarikciler.Size = new System.Drawing.Size(216, 28);
            this.cbTedarikciler.TabIndex = 3;
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(21, 220);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(216, 28);
            this.cbKategoriler.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tedarikçi";
            // 
            // nmrStokMiktari
            // 
            this.nmrStokMiktari.Location = new System.Drawing.Point(21, 168);
            this.nmrStokMiktari.Name = "nmrStokMiktari";
            this.nmrStokMiktari.Size = new System.Drawing.Size(216, 26);
            this.nmrStokMiktari.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stok Miktarı";
            // 
            // nmrFiyat
            // 
            this.nmrFiyat.Location = new System.Drawing.Point(21, 114);
            this.nmrFiyat.Name = "nmrFiyat";
            this.nmrFiyat.Size = new System.Drawing.Size(216, 26);
            this.nmrFiyat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(21, 57);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(216, 26);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // dgvListele
            // 
            this.dgvListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListele.Location = new System.Drawing.Point(283, 48);
            this.dgvListele.MultiSelect = false;
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.ReadOnly = true;
            this.dgvListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListele.Size = new System.Drawing.Size(734, 333);
            this.dgvListele.TabIndex = 1;
            this.dgvListele.DoubleClick += new System.EventHandler(this.dgvListele_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.dgvListele_DoubleClick);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(283, 16);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(734, 26);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 392);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dgvListele);
            this.Controls.Add(this.grpBilgiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.grpBilgiler.ResumeLayout(false);
            this.grpBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStokMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBilgiler;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.NumericUpDown nmrFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.ComboBox cbTedarikciler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmrStokMiktari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TextBox txtArama;
    }
}