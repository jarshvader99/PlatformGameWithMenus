﻿
namespace PlatformGame
{
    partial class optionsScreen
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
            this.Options = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.BackColor = System.Drawing.SystemColors.Window;
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(224, 54);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(196, 55);
            this.Options.TabIndex = 0;
            this.Options.Text = "Options";
            // 
            // optionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlatformGame.Properties.Resources.scene1_sm;
            this.ClientSize = new System.Drawing.Size(624, 729);
            this.Controls.Add(this.Options);
            this.MaximizeBox = false;
            this.Name = "optionsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "optionsScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Options;
    }
}