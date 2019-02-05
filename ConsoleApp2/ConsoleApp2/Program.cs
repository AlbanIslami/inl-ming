using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace List_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int storlek= 81820;
            int talstorlek= 81820;
            List<int> osorterad = Randomlista(storlek, talstorlek);
            osorterad = insertionsort(osorterad, storlek);
        }

        private static List<int> insertionsort(List<int> osorterad, int storlek)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int i = 1;
            while (i < storlek)
            {
                int j = 1;
                while (j>0 && osorterad[j-1]> osorterad[j])
                {
                    int temp = osorterad[j];
                    osorterad[j] = osorterad[j - 1];
                    osorterad[j - 1] = temp;
                    j--;
                }
                i++;
            }
            sw.Stop();
            Console.WriteLine("tid som har gått: " + sw.Elapsed);
            return (osorterad);
        }
        static List<int> Randomlista(int storlek, int talstorlek)
        {
            List<int> tallista = new List<int>();
            Random slump = new Random();
            for (int i = 1; i <= storlek; i++)
            {
                tallista.Add(slump.Next(talstorlek));
            }
            return (tallista);
        }

        private static List<int> Bubblesort(List<int> osorterad, int storlek)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i< storlek- i - 1; i++)
            {
                for (int j = 0; j < storlek - i - 1; j++)
                {
                    if (osorterad[j] > osorterad[j + 1])
                     {
                        int temp = osorterad[j];
                        osorterad[j] = osorterad[j + 1];
                        osorterad[j + 1] = temp;
                    
                    }    
                }
            }
            sw.Stop();
            Console.WriteLine("tid som har gått: " + sw.Elapsed);
            return (osorterad);
        }
        

   
     
        }


    }
