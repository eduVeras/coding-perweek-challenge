﻿namespace Coding.PerWeek.Challenge.Challenges._2022.November
{
    public class AverageExcludingMinAndMax
    {
        public double Average(int[] salary)
        {
            var max = salary.Max();

            var min = salary.Min();

            double total = (salary.Sum() - (max + min)) / (salary.Length - 2.0);

            return total;
        }

        public double BetterSolution(int[] salary)
        {
            int min = int.MaxValue;
            int max = 0;
            int total = 0;

            var lenght = salary.Length;
            for (int i = 0; i < lenght; i++)
            {
                total += salary[i];
                if(salary[i] > max)
                {
                    max = salary[i];
                }

                if(salary[i] < min)
                {
                    min = salary[i];
                }
            }

            total -= max;
            total -= min;

            return total / lenght - 2.0;

        }
    }
}
