using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yatzhee
{
  public class Teerling
  {
    protected static Random generator;
    protected int aantalOgen;
    protected bool vast;

    private List<TeerlingUI> observersList = new List<TeerlingUI>();



    public Teerling()
    {
      aantalOgen = 1;
      if (generator == null)
      {
        generator = new Random();
      }
    }

    public int getAantalOgen
    {
      get { return aantalOgen; }
      
    }
    public bool isVast
    {
      get { return vast; }
     
    }

    public void werp()
    {
      if (!vast)
      {
        aantalOgen = generator.Next(1, 7);
        notifyObservers();
      }
    }
    public void maakLos()
    {
      vast = false;
      notifyObservers();
    }
    public void zetVast()
    {
      vast = true;
      notifyObservers();
    }

    public void addObserver(TeerlingUI observer)
    {
      observersList.Add(observer);
    }
    private void notifyObservers()
    {
      foreach (TeerlingUI t in observersList)
      {
        t.updateUI();
      }

    }
  }
}
