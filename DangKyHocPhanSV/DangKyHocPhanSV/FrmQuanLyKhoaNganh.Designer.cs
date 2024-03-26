
namespace DangKyHocPhanSV
{
    partial class FrmQuanLyKhoaNganh
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
            this.btnTimNganh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.btnXoaNganh = new System.Windows.Forms.Button();
            this.btnThemNganh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhaptenNganh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNhapMaNganh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.txtNhapTenKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapMaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnTimKhoa = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimNganh
            // 
            this.btnTimNganh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNganh.Location = new System.Drawing.Point(320, 21);
            this.btnTimNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimNganh.Name = "btnTimNganh";
            this.btnTimNganh.Size = new System.Drawing.Size(112, 43);
            this.btnTimNganh.TabIndex = 59;
            this.btnTimNganh.Text = "Tìm kiếm";
            this.btnTimNganh.UseVisualStyleBackColor = false;
            this.btnTimNganh.Click += new System.EventHandler(this.btnTimNganh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SeaShell;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã ngành";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnXoaNganh);
            this.panel3.Controls.Add(this.btnTimNganh);
            this.panel3.Controls.Add(this.txtMaNganh);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(510, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 75);
            this.panel3.TabIndex = 94;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganh.Location = new System.Drawing.Point(147, 25);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(167, 30);
            this.txtMaNganh.TabIndex = 2;
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNganh.Location = new System.Drawing.Point(438, 22);
            this.btnXoaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(90, 43);
            this.btnXoaNganh.TabIndex = 70;
            this.btnXoaNganh.Text = "Xóa ";
            this.btnXoaNganh.UseVisualStyleBackColor = false;
            this.btnXoaNganh.Click += new System.EventHandler(this.btnXoaNganh_Click);
            // 
            // btnThemNganh
            // 
            this.btnThemNganh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNganh.Location = new System.Drawing.Point(329, 161);
            this.btnThemNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNganh.Name = "btnThemNganh";
            this.btnThemNganh.Size = new System.Drawing.Size(190, 43);
            this.btnThemNganh.TabIndex = 59;
            this.btnThemNganh.Text = "Thêm ";
            this.btnThemNganh.UseVisualStyleBackColor = false;
            this.btnThemNganh.Click += new System.EventHandler(this.btnThemNganh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 66;
            this.label6.Text = "Mã khoa";
            // 
            // txtNhaptenNganh
            // 
            this.txtNhaptenNganh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhaptenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaptenNganh.Location = new System.Drawing.Point(196, 59);
            this.txtNhaptenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhaptenNganh.Name = "txtNhaptenNganh";
            this.txtNhaptenNganh.Size = new System.Drawing.Size(241, 30);
            this.txtNhaptenNganh.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SeaShell;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "Tên ngành";
            // 
            // txtNhapMaNganh
            // 
            this.txtNhapMaNganh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhapMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaNganh.Location = new System.Drawing.Point(196, 14);
            this.txtNhapMaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapMaNganh.Name = "txtNhapMaNganh";
            this.txtNhapMaNganh.Size = new System.Drawing.Size(241, 30);
            this.txtNhapMaNganh.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SeaShell;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã ngành";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 44);
            this.label2.TabIndex = 93;
            this.label2.Text = "Quản lý ngành";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbbKhoa);
            this.panel2.Controls.Add(this.btnThemNganh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNhaptenNganh);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNhapMaNganh);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(510, 157);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 217);
            this.panel2.TabIndex = 95;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThemKhoa);
            this.panel1.Controls.Add(this.txtNhapTenKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNhapMaKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 217);
            this.panel1.TabIndex = 91;
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoa.Location = new System.Drawing.Point(370, 21);
            this.btnXoaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(106, 43);
            this.btnXoaKhoa.TabIndex = 70;
            this.btnXoaKhoa.Text = "Xóa ";
            this.btnXoaKhoa.UseVisualStyleBackColor = false;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoa.Location = new System.Drawing.Point(247, 161);
            this.btnThemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(190, 43);
            this.btnThemKhoa.TabIndex = 59;
            this.btnThemKhoa.Text = "Thêm ";
            this.btnThemKhoa.UseVisualStyleBackColor = false;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // txtNhapTenKhoa
            // 
            this.txtNhapTenKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhapTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenKhoa.Location = new System.Drawing.Point(119, 83);
            this.txtNhapTenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapTenKhoa.Name = "txtNhapTenKhoa";
            this.txtNhapTenKhoa.Size = new System.Drawing.Size(241, 30);
            this.txtNhapTenKhoa.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tên khoa";
            // 
            // txtNhapMaKhoa
            // 
            this.txtNhapMaKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNhapMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapMaKhoa.Location = new System.Drawing.Point(119, 19);
            this.txtNhapMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapMaKhoa.Name = "txtNhapMaKhoa";
            this.txtNhapMaKhoa.Size = new System.Drawing.Size(241, 30);
            this.txtNhapMaKhoa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Snow;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnXoaKhoa);
            this.panel.Controls.Add(this.btnTimKhoa);
            this.panel.Controls.Add(this.txtMaKhoa);
            this.panel.Controls.Add(this.label5);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(10, 78);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(481, 75);
            this.panel.TabIndex = 88;
            // 
            // btnTimKhoa
            // 
            this.btnTimKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKhoa.Location = new System.Drawing.Point(256, 21);
            this.btnTimKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKhoa.Name = "btnTimKhoa";
            this.btnTimKhoa.Size = new System.Drawing.Size(103, 43);
            this.btnTimKhoa.TabIndex = 59;
            this.btnTimKhoa.Text = "Tìm kiếm";
            this.btnTimKhoa.UseVisualStyleBackColor = false;
            this.btnTimKhoa.Click += new System.EventHandler(this.btnTimKhoa_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(118, 25);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(129, 30);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khoa";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(821, 778);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(190, 43);
            this.btnReturn.TabIndex = 92;
            this.btnReturn.Text = "Quay trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 23);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1022, 369);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dgvDanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 378);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1034, 396);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 44);
            this.label4.TabIndex = 87;
            this.label4.Text = "Quản lý khoa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(196, 109);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(241, 28);
            this.cbbKhoa.TabIndex = 107;
            // 
            // FrmQuanLyKhoaNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "FrmQuanLyKhoaNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyKhoaNganh";
            this.Load += new System.EventHandler(this.FrmQuanLyKhoaNganh_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimNganh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Button btnXoaNganh;
        private System.Windows.Forms.Button btnThemNganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhaptenNganh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNhapMaNganh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.TextBox txtNhapTenKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapMaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnTimKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbKhoa;
    }
}