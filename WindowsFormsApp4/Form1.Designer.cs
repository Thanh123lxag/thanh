namespace QuanLyChamCong
{
    partial class MainForm
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpGioVao = new System.Windows.Forms.DateTimePicker();
            this.dtpGioRa = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.lvwDanhSachNV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(150, 43);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 4;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(150, 125);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 5;
            // 
            // dtpGioVao
            // 
            this.dtpGioVao.Location = new System.Drawing.Point(112, 199);
            this.dtpGioVao.Name = "dtpGioVao";
            this.dtpGioVao.Size = new System.Drawing.Size(200, 22);
            this.dtpGioVao.TabIndex = 6;
            // 
            // dtpGioRa
            // 
            this.dtpGioRa.Location = new System.Drawing.Point(112, 276);
            this.dtpGioRa.Name = "dtpGioRa";
            this.dtpGioRa.Size = new System.Drawing.Size(200, 22);
            this.dtpGioRa.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(112, 366);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm lương";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(237, 366);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhLuong.TabIndex = 9;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            // 
            // lvwDanhSachNV
            // 
            this.lvwDanhSachNV.HideSelection = false;
            this.lvwDanhSachNV.Location = new System.Drawing.Point(490, 199);
            this.lvwDanhSachNV.Name = "lvwDanhSachNV";
            this.lvwDanhSachNV.Size = new System.Drawing.Size(121, 97);
            this.lvwDanhSachNV.TabIndex = 10;
            this.lvwDanhSachNV.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwDanhSachNV);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpGioRa);
            this.Controls.Add(this.dtpGioVao);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTen);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpGioVao;
        private System.Windows.Forms.DateTimePicker dtpGioRa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.ListView lvwDanhSachNV;
    }
}

