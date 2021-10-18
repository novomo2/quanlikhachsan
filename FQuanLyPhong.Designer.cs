
namespace QLKSHOANGLONG
{
    partial class FQuanLyPhong
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
            this.btQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCapNhatDV = new System.Windows.Forms.Button();
            this.btCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.btCapNhatVatTu = new System.Windows.Forms.Button();
            this.dgvQuanLyPhong = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.White;
            this.btQuayLai.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Image = global::QLKSHOANGLONG.Properties.Resources.PinClipart_com_health_and_safety_clipart_207273;
            this.btQuayLai.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btQuayLai.Location = new System.Drawing.Point(12, 12);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(101, 44);
            this.btQuayLai.TabIndex = 1;
            this.btQuayLai.Text = "Quay Lại";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btCapNhatDV);
            this.panel1.Controls.Add(this.btCapNhatLoaiPhong);
            this.panel1.Controls.Add(this.btCapNhatVatTu);
            this.panel1.Controls.Add(this.dgvQuanLyPhong);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 362);
            this.panel1.TabIndex = 3;
            // 
            // btCapNhatDV
            // 
            this.btCapNhatDV.BackColor = System.Drawing.Color.White;
            this.btCapNhatDV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatDV.Image = global::QLKSHOANGLONG.Properties.Resources.PinClipart_com_health_and_safety_clipart_207273;
            this.btCapNhatDV.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btCapNhatDV.Location = new System.Drawing.Point(681, 212);
            this.btCapNhatDV.Name = "btCapNhatDV";
            this.btCapNhatDV.Size = new System.Drawing.Size(180, 44);
            this.btCapNhatDV.TabIndex = 4;
            this.btCapNhatDV.Text = "Cập Nhật Dịch Vụ";
            this.btCapNhatDV.UseVisualStyleBackColor = false;
            this.btCapNhatDV.Click += new System.EventHandler(this.btCapNhatDV_Click);
            // 
            // btCapNhatLoaiPhong
            // 
            this.btCapNhatLoaiPhong.BackColor = System.Drawing.Color.White;
            this.btCapNhatLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatLoaiPhong.Image = global::QLKSHOANGLONG.Properties.Resources.PinClipart_com_health_and_safety_clipart_207273;
            this.btCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btCapNhatLoaiPhong.Location = new System.Drawing.Point(681, 126);
            this.btCapNhatLoaiPhong.Name = "btCapNhatLoaiPhong";
            this.btCapNhatLoaiPhong.Size = new System.Drawing.Size(180, 44);
            this.btCapNhatLoaiPhong.TabIndex = 3;
            this.btCapNhatLoaiPhong.Text = "Cập Nhật Loại Phòng";
            this.btCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            this.btCapNhatLoaiPhong.Click += new System.EventHandler(this.btCapNhatLoaiPhong_Click);
            // 
            // btCapNhatVatTu
            // 
            this.btCapNhatVatTu.BackColor = System.Drawing.Color.White;
            this.btCapNhatVatTu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatVatTu.Image = global::QLKSHOANGLONG.Properties.Resources.PinClipart_com_health_and_safety_clipart_207273;
            this.btCapNhatVatTu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btCapNhatVatTu.Location = new System.Drawing.Point(681, 41);
            this.btCapNhatVatTu.Name = "btCapNhatVatTu";
            this.btCapNhatVatTu.Size = new System.Drawing.Size(180, 44);
            this.btCapNhatVatTu.TabIndex = 2;
            this.btCapNhatVatTu.Text = "Cập Nhật Vật Tư";
            this.btCapNhatVatTu.UseVisualStyleBackColor = false;
            this.btCapNhatVatTu.Click += new System.EventHandler(this.btCapNhatVatTu_Click);
            // 
            // dgvQuanLyPhong
            // 
            this.dgvQuanLyPhong.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenPhong,
            this.TenLoaiPhong,
            this.Gia});
            this.dgvQuanLyPhong.Location = new System.Drawing.Point(3, 3);
            this.dgvQuanLyPhong.Name = "dgvQuanLyPhong";
            this.dgvQuanLyPhong.Size = new System.Drawing.Size(642, 356);
            this.dgvQuanLyPhong.TabIndex = 0;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // TenPhong
            // 
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 150;
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.HeaderText = "Tên Loại Phòng";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            this.TenLoaiPhong.Width = 150;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá Phòng";
            this.Gia.Name = "Gia";
            this.Gia.Width = 200;
            // 
            // FQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuayLai);
            this.Name = "FQuanLyPhong";
            this.Text = "FQuanLyPhong";
            this.Load += new System.EventHandler(this.FQuanLyPhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCapNhatDV;
        private System.Windows.Forms.Button btCapNhatLoaiPhong;
        private System.Windows.Forms.Button btCapNhatVatTu;
        private System.Windows.Forms.DataGridView dgvQuanLyPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}