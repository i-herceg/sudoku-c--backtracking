using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUP_sudoku
{
    class SUDOKU
    {

        public static bool jeValjan(int[,] ploca,
                                  int red, int stupac,
                                  int br)
        {

            for (int i = 0; i < ploca.GetLength(0); i++)
            {
                // ako vec postoji broj u tom redu
                if (ploca[red, i] == br)
                {
                    return false;
                }
            }

            for (int j = 0; j < ploca.GetLength(0); j++)
            {
                // ako postoji u stupcu
                if (ploca[j, stupac] == br)
                {
                    return false;
                }
            }


            int sqrt = (int)Math.Sqrt(ploca.GetLength(0));
            int startrow = red - red % sqrt;
            int startcol = stupac - stupac % sqrt;

            for (int p = startrow;
                 p < startrow + sqrt; p++)
            {
                for (int l = startcol;
                     l < startcol + sqrt; l++)
                {
                    if (ploca[p, l] == br)
                    {
                        return false;
                    }
                }
            }


            return true;
        }

        public static bool Sudoku(int[,] ploca, int n)
        {
            int red = -1;
            int stupac = -1;
            bool prazno = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ploca[i, j] == 0)
                    {
                        red = i;
                        stupac = j;
                        prazno = false;
                        break;
                    }
                }
                if (!prazno)
                {
                    break;
                }
            }

            if (prazno)
            {
                return true;
            }

            // backtrack
            for (int br = 1; br <= n; br++)
            {
                if (jeValjan(ploca, red, stupac, br))
                {
                    ploca[red, stupac] = br;
                    if (Sudoku(ploca, n))
                    {
                        // Ispis(ploca, n); 
                        return true;
                    }
                    else
                    {
                        ploca[red, stupac] = 0;
                    }
                }
            }
            return false;
        }

        public static void Ispis(int[,] ploca, int N)
        {

            for (int r = 0; r < N; r++)
            {
                for (int d = 0; d < N; d++)
                {
                    Console.Write(ploca[r, d]);
                    Console.Write(" ");
                }
                Console.Write("\n");

                if ((r + 1) % (int)Math.Sqrt(N) == 0)
                {
                    Console.Write("");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                int[,] ploca = new int[,] {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };



                int N = ploca.GetLength(0);

                if (Sudoku(ploca, N))
                {
                    Ispis(ploca, N);
                }
                else
                {
                    Console.Write("Nema rješenja");
                }


                Console.ReadKey();

            }
        }
    }
}