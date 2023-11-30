namespace kiemtra3
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
            this.dataqldonhang = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsanpham = new System.Windows.Forms.TextBox();
            this.txtkhach = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataqldonhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataqldonhang
            // 
            this.dataqldonhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataqldonhang.Location = new System.Drawing.Point(83, 264);
            this.dataqldonhang.Name = "dataqldonhang";
            this.dataqldonhang.RowHeadersWidth = 51;
            this.dataqldonhang.RowTemplate.Height = 24;
            this.dataqldonhang.Size = new System.Drawing.Size(621, 132);
            this.dataqldonhang.TabIndex = 0;
            this.dataqldonhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataqldonhang_CellContentClick);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(83, 448);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(65, 43);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "them";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(192, 448);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(67, 43);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "cap nhat";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(305, 448);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(55, 43);
            this.btxoa.TabIndex = 1;
            this.btxoa.Text = "xoa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(601, 20);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(85, 29);
            this.bttimkiem.TabIndex = 1;
            this.bttimkiem.Text = "tim kiem";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(152, 20);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(351, 22);
            this.txttimkiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "san pham";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "khach hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "so luong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tim kiem";
            // 
            // txtsanpham
            // 
            this.txtsanpham.Location = new System.Drawing.Point(152, 57);
            this.txtsanpham.Name = "txtsanpham";
            this.txtsanpham.Size = new System.Drawing.Size(157, 22);
            this.txtsanpham.TabIndex = 5;
            // 
            // txtkhach
            // 
            this.txtkhach.Location = new System.Drawing.Point(152, 104);
            this.txtkhach.Name = "txtkhach";
            this.txtkhach.Size = new System.Drawing.Size(157, 22);
            this.txtkhach.TabIndex = 6;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(152, 150);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(157, 22);
            this.txtsoluong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "gia";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(152, 190);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(157, 22);
            this.txtgia.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtkhach);
            this.Controls.Add(this.txtsanpham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dataqldonhang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataqldonhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataqldonhang;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsanpham;
        private System.Windows.Forms.TextBox txtkhach;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgia;
    }
}

