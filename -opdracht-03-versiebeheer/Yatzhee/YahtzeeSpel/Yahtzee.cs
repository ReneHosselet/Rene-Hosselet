using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeSpel
{
  public class Yahtzee
  {
    private Teerling[] teerlingen;
    private int aantalWorpen;
    private List<YahtzeeUI> observersList = new List<YahtzeeUI>();

    public const int MAX_AANTAL_WORPEN = 3;
    public const int AANTAL_TEERLINGEN = 5;
    
    public Yahtzee()
    {
      teerlingen = new Teerling[AANTAL_TEERLINGEN];
      for (int i = 0; i < Yahtzee.AANTAL_TEERLINGEN;i++)
      {
        teerlingen[i] = new Teerling();
      }
      aantalWorpen = 0;
      observersList = new List<YahtzeeUI>();      
    }
    public bool isFinished()
    {
      return aantalWorpen == MAX_AANTAL_WORPEN;
    }
    public int getAantalWorpen
    {
      get { return aantalWorpen; }
    }
    public int getScore()
    {
      int score = 0;
      foreach (Teerling teerling in teerlingen)
      {
        score += teerling.getAantalOgen;       
      }
      return score;     
    }
    public Teerling getTeerling(int index)
    {
      return teerlingen[index];
    }
    public void werp()
    {
      if (!isFinished())
      {
        foreach (Teerling teerling in teerlingen)
        {
          teerling.werp();
        }
      }
      aantalWorpen++;
      notifyObservers();
    }
    public void reset()
    {
      aantalWorpen = 0;
      foreach (Teerling teerling in teerlingen)
      {
        teerling.maakLos();
      }
      notifyObservers();
    }  
    public void addObserver(YahtzeeUI observer)
    {
      observersList.Add(observer);
    }
    private void notifyObservers()
    {
      foreach (YahtzeeUI y in observersList)
      {
        y.updateUI();
      }
    }
  }
}
