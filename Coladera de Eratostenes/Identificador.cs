using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coladera_de_Eratostenes
{
    class Identificador
    {
        public int[] vec;
        public Identificador (int cant)
        {
            vec = new int[cant];
        }

        public void llenar()
        {
            for (int i=1; i<vec.Length;i++)
            {
                vec[i] = 1;
            }
        }

        public string primos()
        {
            string re = "";
            for (int i = 2; i < vec.Length; i++)
            {
                for (int j = i + 1; j < vec.Length; j++)
                {

                    if (j % i == 0)
                    {
                        vec[j] = 0;
                    }
                }
            }
            for(int i = 2; i < vec.Length; i++)
            {
                if (vec[i] == 1)
                {
                    re += i + ",";
                }
            }
            return re;
        }   
    }
}
