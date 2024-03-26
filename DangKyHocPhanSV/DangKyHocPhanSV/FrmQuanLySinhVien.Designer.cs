
namespace DangKyHocPhanSV
{
    partial class FrmQuanLySinhVien
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
            this.btnTimKiemNganh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnTimKiemKhoa = new System.Windows.Forms.Button();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSVKhoa = new System.Windows.Forms.TextBox();
            this.dgvSinhVienKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiemNganh
            // 
            this.btnTimKiemNganh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiemNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNganh.Location = new System.Drawing.Point(409, 21);
            this.btnTimKiemNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemNganh.Name = "btnTimKiemNganh";
            this.btnTimKiemNganh.Size = new System.Drawing.Size(137, 43);
            this.btnTimKiemNganh.TabIndex = 59;
            this.btnTimKiemNganh.Text = "Tìm kiếm";
            this.btnTimKiemNganh.UseVisualStyleBackColor = false;
            this.btnTimKiemNganh.Click += new System.EventHandler(this.btnTimKiemNganh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SeaShell;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã ngành";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnTimKiemNganh);
            this.panel3.Controls.Add(this.txtMaNganh);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(483, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 75);
            this.panel3.TabIndex = 103;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNganh.Location = new System.Drawing.Point(167, 25);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(227, 30);
            this.txtMaNganh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 44);
            this.label2.TabIndex = 102;
            this.label2.Text = "Sinh viên ngành";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Snow;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnTimKiemKhoa);
            this.panel.Controls.Add(this.txtMaKhoa);
            this.panel.Controls.Add(this.label5);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(1, 78);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(470, 75);
            this.panel.TabIndex = 98;
            // 
            // btnTimKiemKhoa
            // 
            this.btnTimKiemKhoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiemKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKhoa.Location = new System.Drawing.Point(339, 21);
            this.btnTimKiemKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            this.btnTimKiemKhoa.Size = new System.Drawing.Size(106, 43);
            this.btnTimKiemKhoa.TabIndex = 59;
            this.btnTimKiemKhoa.Text = "Tìm kiếm";
            this.btnTimKiemKhoa.UseVisualStyleBackColor = false;
            this.btnTimKiemKhoa.Click += new System.EventHandler(this.btnTimKiemKhoa_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(117, 25);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(216, 30);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã khoa";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(805, 647);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(190, 43);
            this.btnReturn.TabIndex = 101;
            this.btnReturn.Text = "Quay trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSV.Location = new System.Drawing.Point(426, 647);
            this.btnAddSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(277, 43);
            this.btnAddSV.TabIndex = 104;
            this.btnAddSV.Text = "Quản lý lớp  - sinh viên";
            this.btnAddSV.UseVisualStyleBackColor = false;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 44);
            this.label4.TabIndex = 97;
            this.label4.Text = "Sinh viên khoa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tổng sinh viên";
            // 
            // txtSVKhoa
            // 
            this.txtSVKhoa.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSVKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVKhoa.Location = new System.Drawing.Point(200, 170);
            this.txtSVKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSVKhoa.Name = "txtSVKhoa";
            this.txtSVKhoa.Size = new System.Drawing.Size(216, 30);
            this.txtSVKhoa.TabIndex = 60;
            // 
            // dgvSinhVienKhoa
            // 
            this.dgvSinhVienKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVienKhoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSinhVienKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVienKhoa.Location = new System.Drawing.Point(6, 0);
            this.dgvSinhVienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSinhVienKhoa.Name = "dgvSinhVienKhoa";
            this.dgvSinhVienKhoa.RowHeadersVisible = false;
            this.dgvSinhVienKhoa.RowHeadersWidth = 51;
            this.dgvSinhVienKhoa.RowTemplate.Height = 24;
            this.dgvSinhVienKhoa.Size = new System.Drawing.Size(1022, 404);
            this.dgvSinhVienKhoa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dgvSinhVienKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1034, 408);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            // 
            // FrmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 701);
            this.Controls.Add(this.txtSVKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "FrmQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên";
            this.Load += new System.EventHandler(this.FrmQuanLySinhVien_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemNganh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSVKhoa;
        private System.Windows.Forms.DataGridView dgvSinhVienKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}