using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeSpel
{
  public class YahtzeeController
  {
     Yahtzee model;
     TeerlingController[] teerlingControllers;

    public YahtzeeController(Yahtzee y)
    {      
      model = y;
      teerlingControllers = new TeerlingController[Yahtzee.AANTAL_TEERLINGEN];
      for (int i = 0; i < Yahtzee.AANTAL_TEERLINGEN; i++)
      {
        teerlingControllers[i] = new TeerlingController(model.getTeerling(i));
      }
    }
    public TeerlingUI getTeerlingUI(int index)
    {
      return teerlingControllers[index].getTeerlingUI();
    }
    public YahtzeeUI getYahtzeeUI()
    {
      YahtzeeUI view = new YahtzeeUI(model, this);
      model.addObserver(view);
      return view;
    }
     public void btnWerpClick()
    {
      model.werp();
    }
    public void btnResetClick()
    {
      model.reset();     
    }
  }
}
