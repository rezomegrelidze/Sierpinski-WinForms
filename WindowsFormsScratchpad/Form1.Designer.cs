﻿namespace WindowsFormsScratchpad
{
    partial class SierpinskiForm
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
            this.CoordinatePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CoordinatePictureBox
            // 
            this.CoordinatePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoordinatePictureBox.Location = new System.Drawing.Point(0, 0);
            this.CoordinatePictureBox.Name = "CoordinatePictureBox";
            this.CoordinatePictureBox.Size = new System.Drawing.Size(978, 944);
            this.CoordinatePictureBox.TabIndex = 0;
            this.CoordinatePictureBox.TabStop = false;
            this.CoordinatePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.CoordinatePictureBox_Paint);
            // 
            // SierpinskiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.CoordinatePictureBox);
            this.Name = "SierpinskiForm";
            this.Text = "Sierpinski Triangle";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CoordinatePictureBox;
    }
}

