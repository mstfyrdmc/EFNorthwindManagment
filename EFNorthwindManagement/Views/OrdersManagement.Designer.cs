namespace EFNorthwindManagement.Views
{
    partial class OrdersManagement
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
            this.grpOrderBilgiler = new System.Windows.Forms.GroupBox();
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipAdress = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOrderBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrderBilgiler
            // 
            this.grpOrderBilgiler.Controls.Add(this.btnKaydet);
            this.grpOrderBilgiler.Controls.Add(this.txtShipCountry);
            this.grpOrderBilgiler.Controls.Add(this.txtShipCity);
            this.grpOrderBilgiler.Controls.Add(this.txtFreight);
            this.grpOrderBilgiler.Controls.Add(this.txtShipAdress);
            this.grpOrderBilgiler.Controls.Add(this.txtShippedDate);
            this.grpOrderBilgiler.Controls.Add(this.txtShipName);
            this.grpOrderBilgiler.Controls.Add(this.txtOrderDate);
            this.grpOrderBilgiler.Controls.Add(this.label7);
            this.grpOrderBilgiler.Controls.Add(this.label6);
            this.grpOrderBilgiler.Controls.Add(this.label5);
            this.grpOrderBilgiler.Controls.Add(this.label3);
            this.grpOrderBilgiler.Controls.Add(this.label4);
            this.grpOrderBilgiler.Controls.Add(this.label2);
            this.grpOrderBilgiler.Controls.Add(this.label1);
            this.grpOrderBilgiler.Location = new System.Drawing.Point(12, 12);
            this.grpOrderBilgiler.Name = "grpOrderBilgiler";
            this.grpOrderBilgiler.Size = new System.Drawing.Size(361, 475);
            this.grpOrderBilgiler.TabIndex = 0;
            this.grpOrderBilgiler.TabStop = false;
            this.grpOrderBilgiler.Text = "Bilgiler";
            // 
            // dgvListele
            // 
            this.dgvListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListele.Location = new System.Drawing.Point(403, 32);
            this.dgvListele.MultiSelect = false;
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.ReadOnly = true;
            this.dgvListele.RowTemplate.Height = 28;
            this.dgvListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListele.Size = new System.Drawing.Size(830, 541);
            this.dgvListele.TabIndex = 1;
            this.dgvListele.DoubleClick += new System.EventHandler(this.dgvListele_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 67);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Date:";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(152, 37);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(203, 32);
            this.txtOrderDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shipped Date:";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(175, 96);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(180, 32);
            this.txtShippedDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Freight:";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(152, 155);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(203, 32);
            this.txtFreight.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ship Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ship Adress:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ship City:";
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(152, 213);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(203, 32);
            this.txtShipName.TabIndex = 4;
            // 
            // txtShipAdress
            // 
            this.txtShipAdress.Location = new System.Drawing.Point(152, 272);
            this.txtShipAdress.Name = "txtShipAdress";
            this.txtShipAdress.Size = new System.Drawing.Size(203, 32);
            this.txtShipAdress.TabIndex = 4;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(152, 331);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(203, 32);
            this.txtShipCity.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(207, 427);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(148, 42);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ship Country:";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(169, 380);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(186, 32);
            this.txtShipCountry.TabIndex = 4;
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // OrdersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 585);
            this.Controls.Add(this.dgvListele);
            this.Controls.Add(this.grpOrderBilgiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrdersManagement";
            this.Text = "OrdersManagement";
            this.Load += new System.EventHandler(this.OrdersManagement_Load);
            this.grpOrderBilgiler.ResumeLayout(false);
            this.grpOrderBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderBilgiler;
        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShipAdress;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}