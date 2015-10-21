namespace YahtzeeSpel
{
  partial class YahtzeeUI
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
      this.lblAantalWorpen = new System.Windows.Forms.Label();
      this.lblScore = new System.Windows.Forms.Label();
      this.btnWerp = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblAantalWorpen
      // 
      this.lblAantalWorpen.AutoSize = true;
      this.lblAantalWorpen.Location = new System.Drawing.Point(32, 23);
      this.lblAantalWorpen.Name = "lblAantalWorpen";
      this.lblAantalWorpen.Size = new System.Drawing.Size(81, 13);
      this.lblAantalWorpen.TabIndex = 0;
      this.lblAantalWorpen.Text = "Aantal Worpen:";
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.Location = new System.Drawing.Point(32, 47);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(69, 13);
      this.lblScore.TabIndex = 1;
      this.lblScore.Text = "Totale score:";
      // 
      // btnWerp
      // 
      this.btnWerp.Location = new System.Drawing.Point(66, 279);
      this.btnWerp.Name = "btnWerp";
      this.btnWerp.Size = new System.Drawing.Size(98, 41);
      this.btnWerp.TabIndex = 2;
      this.btnWerp.Text = "Werp";
      this.btnWerp.UseVisualStyleBackColor = true;
      this.btnWerp.Click += new System.EventHandler(this.btnWerp_Click);
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(198, 279);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(98, 41);
      this.btnReset.TabIndex = 3;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // YahtzeeUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnReset);
      this.Controls.Add(this.btnWerp);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.lblAantalWorpen);
      this.Name = "YahtzeeUI";
      this.Size = new System.Drawing.Size(582, 353);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblAantalWorpen;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Button btnWerp;
    private System.Windows.Forms.Button btnReset;
  }
}
