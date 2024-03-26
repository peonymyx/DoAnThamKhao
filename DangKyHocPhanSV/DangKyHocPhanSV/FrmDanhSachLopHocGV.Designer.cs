
namespace DangKyHocPhanSV
{
    partial class FrmDanhSachLopHocGV
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnTimKiemLH = new System.Windows.Forms.Button();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSVLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSinhVienLH = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienLH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Snow;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.btnTimKiemLH);
            this.panel.Controls.Add(this.txtMaLH);
            this.panel.Controls.Add(this.label5);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(22, 52);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(418, 61);
            this.panel.TabIndex = 108;
            // 
            // btnTimKiemLH
            // 
            this.btnTimKiemLH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTimKiemLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLH.Location = new System.Drawing.Point(308, 17);
            this.btnTimKiemLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiemLH.Name = "btnTimKiemLH";
            this.btnTimKiemLH.Size = new System.Drawing.Size(80, 35);
            this.btnTimKiemLH.TabIndex = 59;
            this.btnTimKiemLH.Text = "Tìm kiếm";
            this.btnTimKiemLH.UseVisualStyleBackColor = false;
            this.btnTimKiemLH.Click += new System.EventHandler(this.btnTimKiemLH_Click);
            // 
            // txtMaLH
            // 
            this.txtMaLH.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Location = new System.Drawing.Point(118, 20);
            this.txtMaLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(163, 26);
            this.txtMaLH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Lớp Học";
            // 
            // txtSVLH
            // 
            this.txtSVLH.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSVLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSVLH.Location = new System.Drawing.Point(159, 132);
            this.txtSVLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSVLH.Name = "txtSVLH";
            this.txtSVLH.ReadOnly = true;
            this.txtSVLH.Size = new System.Drawing.Size(163, 26);
            this.txtSVLH.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 106;
            this.label1.Text = "Tổng sinh viên";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(613, 520);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 35);
            this.btnReturn.TabIndex = 110;
            this.btnReturn.Text = "Quay trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(784, 36);
            this.label4.TabIndex = 107;
            this.label4.Text = "Danh Sách Lớp Học";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSinhVienLH
            // 
            this.dgvSinhVienLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVienLH.Location = new System.Drawing.Point(22, 182);
            this.dgvSinhVienLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSinhVienLH.Name = "dgvSinhVienLH";
            this.dgvSinhVienLH.ReadOnly = true;
            this.dgvSinhVienLH.RowHeadersVisible = false;
            this.dgvSinhVienLH.RowHeadersWidth = 51;
            this.dgvSinhVienLH.RowTemplate.Height = 24;
            this.dgvSinhVienLH.Size = new System.Drawing.Size(765, 334);
            this.dgvSinhVienLH.TabIndex = 111;
            // 
            // FrmDanhSachLopHocGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 573);
            this.Controls.Add(this.dgvSinhVienLH);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.txtSVLH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDanhSachLopHocGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.FrmDanhSachLopHocGV_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVienLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnTimKiemLH;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSVLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSinhVienLH;
    }
}