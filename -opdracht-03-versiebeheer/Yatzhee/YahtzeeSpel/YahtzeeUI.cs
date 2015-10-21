using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeSpel
{
  public partial class YahtzeeUI : UserControl
  {
    private Yahtzee model;
    private YahtzeeController controller;
    private TeerlingUI[] teerlingUIs = new TeerlingUI[Yahtzee.AANTAL_TEERLINGEN];

    private const string AANTAL_WORPEN_TEKST = "Aantal worpen: ";
    private const string SCORE = "Score: ";

    public YahtzeeUI(Yahtzee model, YahtzeeController controller)
    {
      InitializeComponent();
      this.model = model;
      this.controller = controller;
      for (int i = 0; i < Yahtzee.AANTAL_TEERLINGEN; i++)
      {
        teerlingUIs[i] = this.controller.getTeerlingUI(i);
        teerlingUIs[i].Location = new Point(12 + i * 110, 55);
        this.Controls.Add(this.teerlingUIs[i]);
      }
      updateUI();
    }

    public void updateUI()
    {
      lblAantalWorpen.Text = AANTAL_WORPEN_TEKST + model.getAantalWorpen;
      lblScore.Text = SCORE + model.getScore();  

      //buttons enable/disable
      if (model.isFinished())
      {
        btnReset.Enabled = true;
        btnWerp.Enabled = false;
      }
      else
      {
        btnReset.Enabled = false;
        btnWerp.Enabled = true;
      }
    }

    private void btnWerp_Click(object sender, EventArgs e)
    {
     // for (int i = 0; i < Yahtzee.AANTAL_TEERLINGEN; i++)
      //{
        
        controller.btnWerpClick();
      //}
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      controller.btnResetClick();
    }


  }
}
