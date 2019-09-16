using System;

namespace Beast_Blitz.Domain.Models
{
    public class CareStats
    {
        // DATA
        public int CareStatsID { get; set; }
        // Properties 
        public int Happiness { get; set; }
        public int Fullness { get; set; }
        public int Cleanliness { get; set; }
        public DateTime LastFed { get; set; } 
        public DateTime LastPlayed { get; set; }

        // Constants
        readonly int MAX = 100;
        readonly int MIN = 0;
        readonly int DAILY_DECREASE = 5;
        readonly int BATTLE_DECREASE = 10;
        readonly int FEED_DECREASE = 5; 
        readonly int PLAY_AMT = 5;
        readonly int CLEAN_AMT = 20;

        // Constructor
        public CareStats()
        {
          Happiness = MAX;
          Fullness = MAX;
          Cleanliness = MAX;
          LastFed = DateTime.Now.Date;
          LastPlayed = DateTime.Now.Date;
        }

        // Methods
        public void AddHappiness(int amt)
        {
          if (Happiness + amt <= MAX)
          {
            Happiness = Happiness + amt;
          } else
          {
            Happiness = MAX;
          }
        }  

        public void SubtractHappiness(int amt)
        {
          if (Happiness - amt >= MIN)
          {
            Happiness = Happiness - amt;
          } else
          {
            Happiness = MIN;
          }
        }

        public void SubtractFullness(int amt)
        {
          if (Fullness - amt >= MIN)
          {
            Fullness = Fullness - amt;
          } else
          {
            Fullness = MIN;
          }
        }

        public void Feed(Food food)
        {
          if (food.FullnessAmt + Fullness <= MAX)
          {
            Fullness = Fullness + food.FullnessAmt;
          } else
          {
            Fullness = MAX;
          } 
          if (Cleanliness - FEED_DECREASE >= MIN)
          {
            Cleanliness = Cleanliness - FEED_DECREASE;
          } else
          {
            Cleanliness = MIN;
          }
          LastFed = DateTime.Now.Date;
        }     

        public void DailyDecrease(Hat h)
        {
          DateTime today = DateTime.Now.Date;
          int sinceLastFed = Convert.ToInt32((today - LastFed).TotalDays);
          int sinceLastPlayed = Convert.ToInt32((today - LastFed).TotalDays);
          SubtractFullness(DAILY_DECREASE * sinceLastFed);
          SubtractHappiness(DAILY_DECREASE * sinceLastPlayed);
          AddHappiness(h.Happiness);
        } 

        public void DailyDecrease()
        {
          DateTime today = DateTime.Now.Date;
          int sinceLastFed = Convert.ToInt32((today - LastFed).TotalDays);
          int sinceLastPlayed = Convert.ToInt32((today - LastFed).TotalDays);
          SubtractFullness(DAILY_DECREASE * sinceLastFed);
          SubtractHappiness(DAILY_DECREASE * sinceLastPlayed);
        } 

        public void Clean()
        {
          if (Cleanliness + CLEAN_AMT <= MAX)
          {
            Cleanliness = Cleanliness + CLEAN_AMT;
          } else 
          {
            Cleanliness = MAX;
          }
          
        }
    }
}