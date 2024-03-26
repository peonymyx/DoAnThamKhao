
namespace DangKyHocPhanSV
{
    partial class FrmTrangAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangAdmin));
            this.dgvDSSinhVien = new System.Windows.Forms.DataGridView();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnQLGV = new System.Windows.Forms.Button();
            this.btnQLKhoa = new System.Windows.Forms.Button();
            this.btnQLPH = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQLMonHoc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenQL = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSSinhVien
            // 
            this.dgvDSSinhVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSSinhVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSSinhVien.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDSSinhVien.Location = new System.Drawing.Point(178, 135);
            this.dgvDSSinhVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSSinhVien.Name = "dgvDSSinhVien";
            this.dgvDSSinhVien.RowHeadersVisible = false;
            this.dgvDSSinhVien.RowHeadersWidth = 51;
            this.dgvDSSinhVien.RowTemplate.Height = 24;
            this.dgvDSSinhVien.Size = new System.Drawing.Size(676, 311);
            this.dgvDSSinhVien.TabIndex = 23;
            // 
            // btnQLSV
            // 
            this.btnQLSV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQLSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLSV.Location = new System.Drawing.Point(4, 27);
            this.btnQLSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(142, 35);
            this.btnQLSV.TabIndex = 10;
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQLGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLGV.Location = new System.Drawing.Point(4, 67);
            this.btnQLGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(142, 35);
            this.btnQLGV.TabIndex = 9;
            this.btnQLGV.Text = "Quản lý giảng viên ";
            this.btnQLGV.UseVisualStyleBackColor = false;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // btnQLKhoa
            // 
            this.btnQLKhoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQLKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLKhoa.Location = new System.Drawing.Point(4, 106);
            this.btnQLKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLKhoa.Name = "btnQLKhoa";
            this.btnQLKhoa.Size = new System.Drawing.Size(142, 35);
            this.btnQLKhoa.TabIndex = 8;
            this.btnQLKhoa.Text = "Quản lý Khoa";
            this.btnQLKhoa.UseVisualStyleBackColor = false;
            this.btnQLKhoa.Click += new System.EventHandler(this.btnQLKhoa_Click);
            // 
            // btnQLPH
            // 
            this.btnQLPH.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQLPH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLPH.Location = new System.Drawing.Point(4, 186);
            this.btnQLPH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLPH.Name = "btnQLPH";
            this.btnQLPH.Size = new System.Drawing.Size(142, 35);
            this.btnQLPH.TabIndex = 6;
            this.btnQLPH.Text = "Quản lý phòng học";
            this.btnQLPH.UseVisualStyleBackColor = false;
            this.btnQLPH.Click += new System.EventHandler(this.btnQLPH_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btnQLMonHoc);
            this.groupBox3.Controls.Add(this.btnQLSV);
            this.groupBox3.Controls.Add(this.btnQLGV);
            this.groupBox3.Controls.Add(this.btnQLKhoa);
            this.groupBox3.Controls.Add(this.btnQLPH);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Brown;
            this.groupBox3.Location = new System.Drawing.Point(12, 135);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(155, 259);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHỨC NĂNG";
            // 
            // btnQLMonHoc
            // 
            this.btnQLMonHoc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQLMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMonHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQLMonHoc.Location = new System.Drawing.Point(4, 146);
            this.btnQLMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLMonHoc.Name = "btnQLMonHoc";
            this.btnQLMonHoc.Size = new System.Drawing.Size(142, 35);
            this.btnQLMonHoc.TabIndex = 11;
            this.btnQLMonHoc.Text = "Quản lý Môn Học";
            this.btnQLMonHoc.UseVisualStyleBackColor = false;
            this.btnQLMonHoc.Click += new System.EventHandler(this.btnQLMonHoc_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản trị ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtTenQL);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(2, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(861, 54);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtTenQL
            // 
            this.txtTenQL.Location = new System.Drawing.Point(82, 17);
            this.txtTenQL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenQL.Multiline = true;
            this.txtTenQL.Name = "txtTenQL";
            this.txtTenQL.Size = new System.Drawing.Size(174, 33);
            this.txtTenQL.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTrangAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 470);
            this.Controls.Add(this.dgvDSSinhVien);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTrangAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Quản lý";
            this.Load += new System.EventHandler(this.FrmTrangAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSinhVien;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnQLGV;
        private System.Windows.Forms.Button btnQLKhoa;
        private System.Windows.Forms.Button btnQLPH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTenQL;
        private System.Windows.Forms.Button btnQLMonHoc;
    }
}