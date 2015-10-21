using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzhee
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      Teerling model = new Teerling();
      TeerlingController controller = new TeerlingController(model);
      TeerlingUI view = controller.getTeerlingUI();
      view.Location = new System.Drawing.Point(10, 36);
      view.Size = new System.Drawing.Size(150, 150);
      this.Controls.Add(view);


      TeerlingUI view2 = controller.getTeerlingUI();
      view2.Location = new System.Drawing.Point(160, 36);
      view2.Size = new System.Drawing.Size(150, 150);
      this.Controls.Add(view2);

      TeerlingUI view3 = controller.getTeerlingUI();
      view3.Location = new System.Drawing.Point(310, 36);
      view3.Size = new System.Drawing.Size(150, 150);
      this.Controls.Add(view3);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
