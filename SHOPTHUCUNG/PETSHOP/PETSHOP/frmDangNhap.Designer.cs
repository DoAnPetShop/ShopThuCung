namespace PETSHOP
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.fDangNhap1 = new GUI.fDangNhap();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // fDangNhap1
            // 
            this.fDangNhap1.Location = new System.Drawing.Point(0, 1);
            this.fDangNhap1.Name = "fDangNhap1";
            this.fDangNhap1.Size = new System.Drawing.Size(577, 640);
            this.fDangNhap1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 640);
            this.Controls.Add(this.fDangNhap1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);

        }

        #endregion

        private GUI.fDangNhap fDangNhap1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

    }
}