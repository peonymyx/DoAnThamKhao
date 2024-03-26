
namespace DangKyHocPhanSV
{
    partial class FrmThoiKhoaBieuSV
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnXoaDangKyLH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(9, 10);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(848, 375);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(715, 400);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 35);
            this.btnReturn.TabIndex = 103;
            this.btnReturn.Text = "Quay trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnXoaDangKyLH
            // 
            this.btnXoaDangKyLH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoaDangKyLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDangKyLH.Location = new System.Drawing.Point(538, 400);
            this.btnXoaDangKyLH.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDangKyLH.Name = "btnXoaDangKyLH";
            this.btnXoaDangKyLH.Size = new System.Drawing.Size(142, 35);
            this.btnXoaDangKyLH.TabIndex = 104;
            this.btnXoaDangKyLH.Text = "Xóa Lớp Học";
            this.btnXoaDangKyLH.UseVisualStyleBackColor = false;
            this.btnXoaDangKyLH.Click += new System.EventHandler(this.btnXoaDangKyLH_Click);
            // 
            // FrmThoiKhoaBieuSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 446);
            this.Controls.Add(this.btnXoaDangKyLH);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvDanhSach);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmThoiKhoaBieuSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời Khóa Biểu Sinh Viên";
            this.Load += new System.EventHandler(this.FrmThoiKhoaBieuSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnXoaDangKyLH;
    }
}