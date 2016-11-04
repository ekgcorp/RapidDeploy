namespace StoredValues
{
    partial class AafesStoredValueForm
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
            this._imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // _imgLogo
            // 
            this._imgLogo.Image = global::StoredValues.Properties.Resources.ekgLogo_Trans;
            this._imgLogo.Location = new System.Drawing.Point(12, 12);
            this._imgLogo.Name = "_imgLogo";
            this._imgLogo.Size = new System.Drawing.Size(100, 50);
            this._imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imgLogo.TabIndex = 0;
            this._imgLogo.TabStop = false;
            this._imgLogo.Click += new System.EventHandler(this.OnShowAboutBox);
            // 
            // AafesStoredValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 493);
            this.Controls.Add(this._imgLogo);
            this.Name = "AafesStoredValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAFES Stored Value Tool";
            this.Load += new System.EventHandler(this.AafesStoredValueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _imgLogo;
    }
}

