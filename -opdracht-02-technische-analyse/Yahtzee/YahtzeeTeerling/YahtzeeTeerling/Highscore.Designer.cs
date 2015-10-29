namespace YahtzeeTeerling
{
    partial class Highscore
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
      this.labelHighscore = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelHighscore
      // 
      this.labelHighscore.AutoSize = true;
      this.labelHighscore.Location = new System.Drawing.Point(16, 19);
      this.labelHighscore.Name = "labelHighscore";
      this.labelHighscore.Size = new System.Drawing.Size(51, 20);
      this.labelHighscore.TabIndex = 0;
      this.labelHighscore.Text = "label1";
      // 
      // Highscore
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelHighscore);
      this.Name = "Highscore";
      this.Size = new System.Drawing.Size(219, 102);
      this.Load += new System.EventHandler(this.Highscore_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHighscore;
  }
}
