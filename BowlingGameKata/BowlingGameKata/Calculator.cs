using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
        public class Calculator
    {
        public static int CalculateScore(int[] score)
        {
            var count = 0;
            var total = 0;
            if (score.Length == 0) return total;
            
            for (var i = 0; i < 10; i++)
            {
                if (IsStrike(score[i]))
                {
                    total += 10 + score[count + 1] + score[count + 2];
                    count += 1;
                }
                else if (IsSpare(score[count], score[count + 1]))
                {
                    total += 10 + score[count + 2];
                    count += 2;
                }
                else
                {
                    total += score[count] + score[count + 1];
                    count += 2;
                }
            }
            return total;
        }


        private static bool IsStrike(int roll)
        {
            return roll == 10;
        }

        private static bool IsSpare(int firstRoll, int secondRoll)
        {
            return (firstRoll + secondRoll) == 10;
        }
    }
}

    //public class Calculator
    //{
    //    public static int CalculateScore(int[] score)
    //    {
    //        int count = 0; int total = 0;
    //        if (score.Length == 0) return total;
    //        Console.Write(score[count]);
            

    //        for (int i = 0; i < 10; i++)
    //        {
    //                //if (score[i] == 10) { total += 10 + score[count + 1] + score[count + 2]; count += 1; }
    //                //else if ((score[count] + score[count + 1]) == 10) { total += 10 + score[count + 2]; count += 2; }
    //                //else { total += score[count] + score[count + 1]; count += 2; }
    //        }
    //       return total;
    //    }
    //}
//}
