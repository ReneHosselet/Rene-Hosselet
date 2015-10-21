using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeSpel
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      Yahtzee model = new Yahtzee();
      YahtzeeController controller = new YahtzeeController(model);
      YahtzeeUI ui = controller.getYahtzeeUI();
      this.Controls.Add(ui);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
    }
  }
}
