using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureLibrary
{
    public class Temperature
    {
        public static bool IsSottoZero(int num)
        {
            bool negativo = false;
            if (num < 0)
            {
                negativo = true;
            }

            return negativo;
        }

        public static int ContaSottoZero(int[] Numeri)
        {
            int NumNegativi = 0;

            for (int i = 0; i < Numeri.Length; i++)

            {
                if (Numeri[i] < 0)
                {
                    NumNegativi++;
                }

            }
            return NumNegativi;
        }

        public static int[] Minime(int[] Minime2, int[] Minime3)
        {
            for (int i = 0; i < Minime2.Length; i++)

            {
                if (Minime2[i] > 0)
                {
                    Minime3[i] = Minime2[i];
                }

            }
            return Minime3;
        }
    }
}
}
