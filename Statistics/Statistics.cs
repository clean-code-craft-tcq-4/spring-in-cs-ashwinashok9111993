using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public float average(List<float> numbers)
        {
            float avg = 0;
            int count = 0;
            foreach(float num in numbers)
            {
                avg = avg + num;
                count++;
            }

            return avg/count;
        }
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here

            Stats stats = new Stats();
            return stats;
        }
    }
}
