namespace İkiliAgac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBT = new System.Windows.Forms.Button();
            this.cmbTraverseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDugumSayisi = new System.Windows.Forms.Button();
            this.btnYaprakSayisi = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBT
            // 
            this.btnBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBT.Location = new System.Drawing.Point(12, 38);
            this.btnBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(503, 37);
            this.btnBT.TabIndex = 2;
            this.btnBT.Text = "Örnek 1. İkili Ağaç Oluştur Gezinme İçin...";
            this.btnBT.UseVisualStyleBackColor = true;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click_1);
            // 
            // cmbTraverseType
            // 
            this.cmbTraverseType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTraverseType.FormattingEnabled = true;
            this.cmbTraverseType.Items.AddRange(new object[] {
            "Preorder",
            "Inorder",
            "Postorder"});
            this.cmbTraverseType.Location = new System.Drawing.Point(178, 126);
            this.cmbTraverseType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTraverseType.Name = "cmbTraverseType";
            this.cmbTraverseType.Size = new System.Drawing.Size(120, 24);
            this.cmbTraverseType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gezinme Şekli:";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrder.Location = new System.Drawing.Point(374, 118);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(148, 37);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Dolaş";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(20, 178);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(502, 26);
            this.txtSonuc.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(526, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 395);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(563, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Örnek 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 336);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(563, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Örnek2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDugumSayisi
            // 
            this.btnDugumSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDugumSayisi.Location = new System.Drawing.Point(20, 234);
            this.btnDugumSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDugumSayisi.Name = "btnDugumSayisi";
            this.btnDugumSayisi.Size = new System.Drawing.Size(245, 37);
            this.btnDugumSayisi.TabIndex = 10;
            this.btnDugumSayisi.Text = "2.1.Düğüm Sayısı";
            this.btnDugumSayisi.UseVisualStyleBackColor = true;
            this.btnDugumSayisi.Click += new System.EventHandler(this.btnDugumSayisi_Click);
            // 
            // btnYaprakSayisi
            // 
            this.btnYaprakSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaprakSayisi.Location = new System.Drawing.Point(299, 234);
            this.btnYaprakSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYaprakSayisi.Name = "btnYaprakSayisi";
            this.btnYaprakSayisi.Size = new System.Drawing.Size(224, 37);
            this.btnYaprakSayisi.TabIndex = 11;
            this.btnYaprakSayisi.Text = "2.2.Yaprak Sayısı";
            this.btnYaprakSayisi.UseVisualStyleBackColor = true;
            this.btnYaprakSayisi.Click += new System.EventHandler(this.btnYaprakSayisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 432);
            this.Controls.Add(this.btnYaprakSayisi);
            this.Controls.Add(this.btnDugumSayisi);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTraverseType);
            this.Controls.Add(this.btnBT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Binary Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.ComboBox cmbTraverseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDugumSayisi;
        private System.Windows.Forms.Button btnYaprakSayisi;

    }
}

