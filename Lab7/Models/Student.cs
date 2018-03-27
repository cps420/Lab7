using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int[] Scores { get; set; }

        public String ScoresString()
        {
            string scoresStr = "[";
            for (int i = 0; i < Scores.Length - 1; i ++)
            {
                scoresStr = scoresStr + Scores[i].ToString() + ",";
            }
            if (Scores.Length > 0)
            {
                scoresStr = scoresStr + Scores[Scores.Length-1].ToString();
            }
            scoresStr = scoresStr + "]";

            return scoresStr;
        }

        public override string ToString()
        {
            return $"{this.LastName};{this.FirstName}:{this.ScoresString()}";
        }
    }
}
