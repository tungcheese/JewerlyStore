namespace JewelryStore
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
            this.lblJewelryStore = new System.Windows.Forms.Label();
            this.picJewelry = new Guna.UI2.WinForms.Guna2PictureBox();
            this.progressbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picJewelry)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJewelryStore
            // 
            this.lblJewelryStore.AutoSize = true;
            this.lblJewelryStore.Font = new System.Drawing.Font("Galano Grotesque Alt DEMO", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJewelryStore.ForeColor = System.Drawing.Color.Gold;
            this.lblJewelryStore.Location = new System.Drawing.Point(225, 18);
            this.lblJewelryStore.Name = "lblJewelryStore";
            this.lblJewelryStore.Size = new System.Drawing.Size(268, 41);
            this.lblJewelryStore.TabIndex = 0;
            this.lblJewelryStore.Text = "JEWELRY STORE";
            // 
            // picJewelry
            // 
            this.picJewelry.Image = global::JewelryStore.Properties.Resources.jewelry;
            this.picJewelry.ImageRotate = 0F;
            this.picJewelry.Location = new System.Drawing.Point(293, 53);
            this.picJewelry.Name = "picJewelry";
            this.picJewelry.Size = new System.Drawing.Size(132, 94);
            this.picJewelry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJewelry.TabIndex = 1;
            this.picJewelry.TabStop = false;
            // 
            // progressbar
            // 
            this.progressbar.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.progressbar.BorderRadius = 10;
            this.progressbar.BorderThickness = 1;
            this.progressbar.FillColor = System.Drawing.Color.Beige;
            this.progressbar.Location = new System.Drawing.Point(30, 245);
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.Goldenrod;
            this.progressbar.Size = new System.Drawing.Size(673, 13);
            this.progressbar.TabIndex = 2;
            this.progressbar.Text = "guna2ProgressBar1";
            this.progressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblLoading.Location = new System.Drawing.Point(34, 202);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(106, 28);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading...";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPercent.Location = new System.Drawing.Point(146, 202);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(31, 28);
            this.lblPercent.TabIndex = 4;
            this.lblPercent.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(728, 284);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.picJewelry);
            this.Controls.Add(this.lblJewelryStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJewelry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJewelryStore;
        private Guna.UI2.WinForms.Guna2PictureBox picJewelry;
        private Guna.UI2.WinForms.Guna2ProgressBar progressbar;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblPercent;
    }
}

