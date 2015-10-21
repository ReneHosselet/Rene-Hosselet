using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeSpel
{
  public class TeerlingController
  {
    Teerling myTeerling;
    public TeerlingController(Teerling t)
    {
      myTeerling = t;
    }
    public TeerlingUI getTeerlingUI()
    {
      TeerlingUI view = new TeerlingUI(myTeerling, this);
      myTeerling.addObserver(view);
      return view;
    }
    public void lblTeerlingClick()
    {
      if (myTeerling.isVast == false)
      {
        myTeerling.zetVast();
      }
      else
      {
        myTeerling.maakLos();
      }
    }
    public void btnWerpClick()
    {
      myTeerling.werp();
    }
  }
}
