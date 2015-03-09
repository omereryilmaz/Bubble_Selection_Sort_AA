using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubble_selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kac elamanli olsun? :");
            int es = int.Parse(Console.ReadLine());
            int[] dizi = new int[es];
            int[] dizi2 = new int[es];

            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = 0;

            Random r = new Random();
            int a = 0;
            // Sayi uret ve diziye aktar
            for (int i = 0; i < dizi.Length; i++)
            {
                a = r.Next(1000);
                dizi[i] = a;
                dizi2[i] = a;

                //Console.WriteLine(i+1 + ".eleman : " +dizi[i]);
            }

            bubble_sort(dizi);
            selectsort(dizi2);

            Console.ReadKey();
        }
        public static void bubble_sort(int[] dizi)
        {
            int swap = 0, comp = 0;
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 1; j < dizi.Length - i; j++)
                {
                    if (dizi[j] < dizi[j - 1])
                    {
                        int gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                        swap++;
                    }
                    comp++;
                }
            }
            Console.WriteLine("Bubble sort comparison sayisi :" + comp);
            Console.WriteLine("Bubble sort swap sayisi :" + swap);
            

        }

        static void selectsort(int[] dizi2)
        {
            int swap2 = 0, comp2 = 0;
            int i, j;



            for (i = 0; i < dizi2.Length; i++)
            {
                int min = i;
                for (j = i + 1; j < dizi2.Length; j++)
                {
                    if (dizi2[j] < dizi2[min])
                    {
                        min = j;
                        swap2++;
                    }
                    comp2++;
                }


                int temp = dizi2[i];
                dizi2[i] = dizi2[min];
                dizi2[min] = temp;

            }

            
            Console.WriteLine("Selection sort comparison sayisi :" + comp2);
            Console.WriteLine("Selection sort swap sayisi :" + swap2);

        }

    }
}
