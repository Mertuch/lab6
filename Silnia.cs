using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Silnia
    {

        private int n;
        

        public Silnia(int n)
        {
            if (n < 0) { n = 0; }
            this.n = n;

        }

        public int Oblicz()
        {
            if (n == 0) return 1;
            int temp = 1;
            for(int i = 1; i <= this.n; i++)
            {
                temp *= i;
            }
            return temp;
        }


    }
}
