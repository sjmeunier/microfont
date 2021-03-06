﻿namespace MicroFontApp
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
            this.butGenerate = new System.Windows.Forms.Button();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.picGeneratedImage = new System.Windows.Forms.PictureBox();
            this.chkInvertColours = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGeneratedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(360, 185);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(75, 23);
            this.butGenerate.TabIndex = 0;
            this.butGenerate.Text = "&Generate";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(13, 13);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(422, 166);
            this.txtInputText.TabIndex = 1;
            this.txtInputText.Text = "The quick brown fox\r\njumped over the lazy dog\r\n0123456789\r\n!\"\'#$%&*()-+=:;@<>,.?/" +
    "[]";
            // 
            // picGeneratedImage
            // 
            this.picGeneratedImage.BackColor = System.Drawing.Color.Black;
            this.picGeneratedImage.Location = new System.Drawing.Point(12, 235);
            this.picGeneratedImage.Name = "picGeneratedImage";
            this.picGeneratedImage.Size = new System.Drawing.Size(423, 198);
            this.picGeneratedImage.TabIndex = 2;
            this.picGeneratedImage.TabStop = false;
            // 
            // chkInvertColours
            // 
            this.chkInvertColours.AutoSize = true;
            this.chkInvertColours.Location = new System.Drawing.Point(13, 185);
            this.chkInvertColours.Name = "chkInvertColours";
            this.chkInvertColours.Size = new System.Drawing.Size(90, 17);
            this.chkInvertColours.TabIndex = 3;
            this.chkInvertColours.Text = "Invert colours";
            this.chkInvertColours.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 451);
            this.Controls.Add(this.chkInvertColours);
            this.Controls.Add(this.picGeneratedImage);
            this.Controls.Add(this.txtInputText);
            this.Controls.Add(this.butGenerate);
            this.Name = "Form1";
            this.Text = "MicroFont Test App";
            ((System.ComponentModel.ISupportInitialize)(this.picGeneratedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.PictureBox picGeneratedImage;
		private System.Windows.Forms.CheckBox chkInvertColours;
	}
}

