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

        public String ScoresString
        {
            get
            {
                string scoresStr = "";
                for (int i = 0; i < Scores.Length - 1; i++)
                {
                    scoresStr = scoresStr + Scores[i].ToString() + ",";
                }
                if (Scores.Length > 0)
                {
                    scoresStr = scoresStr + Scores[Scores.Length - 1].ToString();
                }

                return scoresStr;
            }
        }

        public float Average
        {
            get
            {
                float avg = 0;
                foreach (int score in Scores)
                {
                    avg = avg + score;
                }
                avg = avg / Scores.Length;
                return avg;
            }
        }

        public override string ToString()
        {
            return $"{this.LastName};{this.FirstName}:{this.ScoresString}";
        }
    }
}
