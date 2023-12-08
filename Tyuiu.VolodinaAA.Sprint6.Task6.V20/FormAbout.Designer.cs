
namespace Tyuiu.VolodinaAA.Sprint6.Task6.V20
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatarka_VAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_VAA = new System.Windows.Forms.Label();
            this.buttonOK_VAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarka_VAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatarka_VAA
            // 
            this.pictureBoxAvatarka_VAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatarka_VAA.Image")));
            this.pictureBoxAvatarka_VAA.Location = new System.Drawing.Point(21, 33);
            this.pictureBoxAvatarka_VAA.Name = "pictureBoxAvatarka_VAA";
            this.pictureBoxAvatarka_VAA.Size = new System.Drawing.Size(190, 210);
            this.pictureBoxAvatarka_VAA.TabIndex = 0;
            this.pictureBoxAvatarka_VAA.TabStop = false;
            // 
            // labelInfo_VAA
            // 
            this.labelInfo_VAA.AutoSize = true;
            this.labelInfo_VAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_VAA.Location = new System.Drawing.Point(217, 33);
            this.labelInfo_VAA.Name = "labelInfo_VAA";
            this.labelInfo_VAA.Size = new System.Drawing.Size(384, 162);
            this.labelInfo_VAA.TabIndex = 1;
            this.labelInfo_VAA.Text = resources.GetString("labelInfo_VAA.Text");
            // 
            // buttonOK_VAA
            // 
            this.buttonOK_VAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOK_VAA.Location = new System.Drawing.Point(553, 207);
            this.buttonOK_VAA.Name = "buttonOK_VAA";
            this.buttonOK_VAA.Size = new System.Drawing.Size(108, 36);
            this.buttonOK_VAA.TabIndex = 2;
            this.buttonOK_VAA.Text = "OK";
            this.buttonOK_VAA.UseVisualStyleBackColor = true;
            this.buttonOK_VAA.Click += new System.EventHandler(this.buttonOK_VAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 255);
            this.Controls.Add(this.buttonOK_VAA);
            this.Controls.Add(this.labelInfo_VAA);
            this.Controls.Add(this.pictureBoxAvatarka_VAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatarka_VAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatarka_VAA;
        private System.Windows.Forms.Label labelInfo_VAA;
        private System.Windows.Forms.Button buttonOK_VAA;
    }
}