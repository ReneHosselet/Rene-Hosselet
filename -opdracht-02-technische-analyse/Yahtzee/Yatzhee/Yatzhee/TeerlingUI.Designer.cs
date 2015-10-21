namespace Yatzhee
{
  partial class TeerlingUI
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
      this.btnWerp = new System.Windows.Forms.Button();
      this.lblTeerling = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnWerp
      // 
      this.btnWerp.Location = new System.Drawing.Point(4, 115);
      this.btnWerp.Name = "btnWerp";
      this.btnWerp.Size = new System.Drawing.Size(143, 32);
      this.btnWerp.TabIndex = 0;
      this.btnWerp.Text = "Werp";
      this.btnWerp.UseVisualStyleBackColor = true;
      this.btnWerp.Click += new System.EventHandler(this.btnWerp_Click);
      // 
      // lblTeerling
      // 
      this.lblTeerling.AutoSize = true;
      this.lblTeerling.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTeerling.Location = new System.Drawing.Point(39, 19);
      this.lblTeerling.Name = "lblTeerling";
      this.lblTeerling.Size = new System.Drawing.Size(70, 76);
      this.lblTeerling.TabIndex = 1;
      this.lblTeerling.Text = "1";
      this.lblTeerling.Click += new System.EventHandler(this.lblTeerling_Click);
      // 
      // TeerlingUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblTeerling);
      this.Controls.Add(this.btnWerp);
      this.Name = "TeerlingUI";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnWerp;
    private System.Windows.Forms.Label lblTeerling;
  }
}
