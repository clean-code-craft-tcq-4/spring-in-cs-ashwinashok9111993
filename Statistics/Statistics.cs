using System;
using System.Collections.Generic;

namespace Statistics
{
    public class EmailAlert:IAlerter
    {
        public bool emailSent;
    }

    public class LEDAlert:IAlerter
    {
        public bool ledGlows;
    }

    public interface IAlerter
    {

    }

    public class StatsAlerter
    {
        public float maxThreshold;
        public IAlerter[] alerters;

        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(List<float> numbers)
        {

        }
    }
    public class Stats 
    {
        public float average = 0;
        public float max = 0;
        public float min = 0;
    }

    public class StatsComputer : Stats
    {

        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats stats = new StatsComputer();

            if (numbers.Count == 0)
            {
               
            }
            else
            {
                
                float sum = 0;
                foreach(float num in numbers)
                {
                    sum = sum + num;
                }
                average = sum / numbers.Count;

                numbers.Sort();
                min = numbers[0];
                max = numbers[numbers.Count - 1];

            }

            return stats;

        }
    
        
    }

}




