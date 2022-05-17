using System;
using System.Collections.Generic;

namespace Statistics
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent;
        public bool status
        {
            get => emailSent;
            set => emailSent = value;
        }
    }

    public class LEDAlert : IAlerter
    {
        public bool ledGlows;

        public bool status
        {
            get => ledGlows;
            set => ledGlows = value;
        }
    }

    public interface IAlerter
    {
        bool status
        {
            set;
            get;
        }
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
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(numbers);
            if(statsComputer.max > maxThreshold)
            {
                foreach (IAlerter alert in alerters)
                {
                    alert.status = true;
                }
            }
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
                average = float.NaN;
                max = float.NaN;
                min = float.NaN;
            }
            else
            {

                float sum = 0;
                foreach (float num in numbers)
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




