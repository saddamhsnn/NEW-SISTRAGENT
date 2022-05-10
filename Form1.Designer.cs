namespace SISTRAGENT
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
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.KLIKLOGIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KLIKLOGIN
            // 
            this.KLIKLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.KLIKLOGIN.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KLIKLOGIN.Location = new System.Drawing.Point(398, 273);
            this.KLIKLOGIN.Name = "KLIKLOGIN";
            this.KLIKLOGIN.Size = new System.Drawing.Size(129, 42);
            this.KLIKLOGIN.TabIndex = 5;
            this.KLIKLOGIN.Text = "LOGIN";
            this.KLIKLOGIN.UseVisualStyleBackColor = false;
            this.KLIKLOGIN.Click += new System.EventHandler(this.KLIKLOGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELAMAT DATANG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::SISTRAGENT.Properties.Resources.WhatsApp_Image_2022_04_25_at_11_55_07;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KLIKLOGIN);
            this.Name = "Form1";
            this.Text = "SISTRAGENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.Button KLIKLOGIN;
        private System.Windows.Forms.Label label1;
    }
}

