using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_8._1
{
    internal class Authorization
    {
        public Authorization() { }
        Random rnd = new Random();
        public int Random() { return rnd.Next(1,4); }
        public string Formula()
        {
            int x = Random();
            int rand = Random();
            string a = $"{x}²";
            string b = $"{x}²+1";
            string c = $"{x}² + 3";
            if (rand == 1) 
            {
                return a;
            }
            else if (rand == 2) 
            {
                return b;
            }
            else 
            {
                return c;
            }
        }
        public double Result() 
        {
            int x = Random();
            int rand = Random();
            if (rand == 1)
            {
                double res_x = Math.Pow(x, 2);
                return res_x;
            }
            else if (rand == 2)
            {
                double res_x = Math.Pow(x, 2) + 1;
                return res_x;
            }
            else
            {
                double res_x = Math.Pow(x, 2) + 3;
                return res_x;
            }
        }
    }
}
