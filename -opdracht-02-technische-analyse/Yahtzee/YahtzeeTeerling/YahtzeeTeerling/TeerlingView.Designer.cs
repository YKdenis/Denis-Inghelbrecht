﻿namespace YahtzeeTeerling
{
    partial class TeerlingView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWerp = new System.Windows.Forms.Label();
            this.buttonWerp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWerp
            // 
            this.labelWerp.Location = new System.Drawing.Point(22, 21);
            this.labelWerp.Name = "labelWerp";
            this.labelWerp.Size = new System.Drawing.Size(151, 100);
            this.labelWerp.TabIndex = 0;
            this.labelWerp.Text = "Werp";
            this.labelWerp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWerp.Click += new System.EventHandler(this.labelWerp_Click);
            // 
            // buttonWerp
            // 
            this.buttonWerp.Location = new System.Drawing.Point(53, 137);
            this.buttonWerp.Name = "buttonWerp";
            this.buttonWerp.Size = new System.Drawing.Size(85, 41);
            this.buttonWerp.TabIndex = 1;
            this.buttonWerp.Text = "Werp";
            this.buttonWerp.UseVisualStyleBackColor = true;
            this.buttonWerp.Click += new System.EventHandler(this.buttonWerp_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.buttonWerp);
            this.Controls.Add(this.labelWerp);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(197, 181);
            this.Load += new System.EventHandler(this.TeerlingView_Load);
            this.Click += new System.EventHandler(this.TeerlingView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWerp;
        private System.Windows.Forms.Button buttonWerp;
    }
}
