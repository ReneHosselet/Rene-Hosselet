namespace YahtzeeSpel
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
            this.lblTeerling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTeerling
            // 
            this.lblTeerling.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeerling.Location = new System.Drawing.Point(24, 15);
            this.lblTeerling.Name = "lblTeerling";
            this.lblTeerling.Size = new System.Drawing.Size(57, 62);
            this.lblTeerling.TabIndex = 0;
            this.lblTeerling.Click += new System.EventHandler(this.lblTeerling_Click);
            // 
            // TeerlingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblTeerling);
            this.Name = "TeerlingUI";
            this.Size = new System.Drawing.Size(110, 114);
            this.Load += new System.EventHandler(this.TeerlingUI_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblTeerling;
  }
}
