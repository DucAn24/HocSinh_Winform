namespace thucHanh
{
    partial class FormGV
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
            this.uc1 = new thucHanh.UserControl1();
            this.SuspendLayout();
            // 
            // uc1
            // 
            this.uc1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uc1.Location = new System.Drawing.Point(12, 1);
            this.uc1.Name = "uc1";
            this.uc1.Size = new System.Drawing.Size(918, 510);
            this.uc1.TabIndex = 0;
            this.uc1.Load += new System.EventHandler(this.userControl11_Load_1);
            // 
            // FormGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 523);
            this.Controls.Add(this.uc1);
            this.Name = "FormGV";
            this.Text = "FormGV";
            this.Load += new System.EventHandler(this.FormGV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public UserControl1 uc1;
    }
}