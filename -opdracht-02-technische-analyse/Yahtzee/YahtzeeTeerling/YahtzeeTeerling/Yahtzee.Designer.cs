﻿namespace YahtzeeTeerling
{
    partial class Yahtzee
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
      this.SuspendLayout();
      // 
      // Yahtzee
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1174, 250);
      this.Name = "Yahtzee";
      this.Text = "Yahtzee";
      this.Load += new System.EventHandler(this.Yahtzee_Load);
      this.ResumeLayout(false);

        }

        #endregion
        private ControlHighscore controlHighscore;

        public Yahtzee(ControlHighscore controlHighscore)
        {
            this.controlHighscore = controlHighscore;
        }
    }
}