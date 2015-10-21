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
  public partial class TeerlingUI : UserControl
  {
    private Teerling teerling1;
    private TeerlingController teerController;

    public TeerlingUI(Teerling t, TeerlingController controller)
    {
      InitializeComponent();
      teerling1 = t;
      teerController = controller;
    }
    private void lblTeerling_Click(object sender, EventArgs e)
    {
       teerController.lblTeerlingClick();
       updateUI();
      }    
    public void updateUI()
    {
      lblTeerling.Text = teerling1.getAantalOgen.ToString();
      lblTeerling.BackColor = teerling1.isVast ? Color.Red : Color.Green; 
    }
    private void TeerlingUI_Load(object sender, EventArgs e)
    {
    }
    private void lblTeerling_Click_1(object sender, EventArgs e)
    {
    }
  }
}
