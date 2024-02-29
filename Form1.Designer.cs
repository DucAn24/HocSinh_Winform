namespace thucHanh
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
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.uc2 = new thucHanh.UserControl1();
            this.SuspendLayout();
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Location = new System.Drawing.Point(729, 447);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(346, 49);
            this.btnGiangVien.TabIndex = 3;
            this.btnGiangVien.Text = "GiangVien";
            this.btnGiangVien.UseVisualStyleBackColor = true;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click_1);
            // 
            // uc2
            // 
            this.uc2.Location = new System.Drawing.Point(-32, 12);
            this.uc2.Name = "uc2";
            this.uc2.Size = new System.Drawing.Size(1280, 573);
            this.uc2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 605);
            this.Controls.Add(this.btnGiangVien);
            this.Controls.Add(this.uc2);
            this.Name = "Form1";
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGiangVien;
        public UserControl1 uc2;
    }
}

