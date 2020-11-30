using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicGalavicProgram
{
    class Rjesenja
    {
        public int faktorial(int n)
        {
            if (n <= 1) return 1;

            return n * faktorial(n - 1);
        }
        public int kombinacija(int n, int r)
        {
            return faktorial(n)/(faktorial(r)*faktorial(n-r));
        }
        public int zadatak3(int broj)
        {
            int brojac = 0;
            for(int i=1;i<broj;i++)
            {
               // Console.WriteLine(i+"\n");

                for(int j=i+1;j<=broj;j++)
                {
                    //Console.WriteLine(j);
                    brojac++;
                }
                
            }
            return brojac;
        }
        public void zadatak1(int a,int b,int c)
        {
            int umnozak;
            umnozak = a * b * c;

            Console.WriteLine("Riješenje zadatka" + umnozak);
        }

        public void zadatak4 ()
        {
            int br = 5;
            int um=1;
            for(int i=0;i<5;i++)
            {
                um = um * br;
            }
            Console.WriteLine(um+"\n\n");
            Console.WriteLine("Lozinke: ");
            for (char a='a';a<='e';a++)
            {
                for(char b = 'a'; b <= 'e'; b++)
                {
                    for(char c='a';c<='e';c++)
                    {
                        for(char d='a';d<='e';d++)
                        {
                            for(char e = 'a'; e <= 'e'; e++)
                            {
                                Console.WriteLine(a+""+b+""+c+""+d+""+e);
                            }
                        }
                    }
                }
            }
        }

    }
}
