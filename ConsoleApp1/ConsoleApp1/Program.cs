using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string target, x, temp;
            int i;
            string[,] Arr = { { "R", "R", "W" }, { "G", "C", "W" }, { "G", "B", "B" } };
            DrawArray(Arr);

            while (true)
            {
                Console.Write("입력 : ");
                target = Console.ReadLine();

                x = target.ToUpper();
                x = x + "A";

                if (x[0].ToString().Equals("Q"))
                {
                    Console.WriteLine("Bye~");
                    break;
                }

                for (i = 0; i < (x.Length); i++)
                {
                    if ((x[i]).ToString().Equals("U"))
                    {
                        if ((x[i + 1]) == 39)
                        {
                            temp = Arr[0, 2];
                            Arr[0, 1] = Arr[0, 0];
                            Arr[0, 2] = Arr[0, 1];
                            Arr[0, 0] = temp;

                            Console.WriteLine("");
                            Console.WriteLine(x[i] + "'");
                            DrawArray(Arr);
                        }

                        else
                        {
                            temp = Arr[0, 0];
                            Arr[0, 0] = Arr[0, 1];
                            Arr[0, 1] = Arr[0, 2];
                            Arr[0, 2] = temp;

                            Console.WriteLine("");
                            Console.WriteLine(x[i]);
                            DrawArray(Arr);
                        }

                    }

                    if ((x[i]).ToString().Equals("R"))
                    {
                        if ((x[i + 1]) == 39)
                        {
                            temp = Arr[0, 2];
                            Arr[0, 2] = Arr[2, 2];
                            Arr[2, 2] = Arr[1, 2];
                            Arr[1, 2] = temp;

                            Console.WriteLine("");
                            Console.WriteLine(x[i] + "'");
                            DrawArray(Arr);
                        }
                        else
                        {
                            temp = Arr[0, 2];
                            Arr[0, 2] = Arr[1, 2];
                            Arr[1, 2] = Arr[2, 2];
                            Arr[2, 2] = temp;

                            Console.WriteLine("");
                            Console.WriteLine(x[i]);
                            DrawArray(Arr);
                        }
                    }

                    if ((x[i]).ToString().Equals("L"))
                    {
                        if ((x[i + 1]) == 39)
                        {
                            temp = Arr[0, 0];
                            Arr[0, 0] = Arr[2, 0];
                            Arr[2, 0] = Arr[1, 0];
                            Arr[1, 0] = temp;

                            Console.WriteLine("");
                            Console.WriteLine(x[i] + "'");
                            DrawArray(Arr);
                        }
                        else
                        {
                            temp = Arr[0, 0];
                            Arr[0, 0] = Arr[1, 0];
                            Arr[1, 0] = Arr[2, 0];
                            Arr[2, 0] = temp;

                            Console.WriteLine("");
                            Console.WriteLine(x[i]);
                            DrawArray(Arr);
                        }
                    }

                    if ((x[i]).ToString().Equals("B"))
                    {
                        if ((x[i + 1]) == 39)
                        {
                            temp = Arr[2, 1];
                            Arr[2, 1] = Arr[2, 2];
                            Arr[2, 2] = Arr[2, 0];
                            Arr[2, 0] = temp;


                            Console.WriteLine("");
                            Console.WriteLine(x[i] + "'");
                            DrawArray(Arr);
                        }
                        else
                        {
                            temp = Arr[2, 1];
                            Arr[2, 1] = Arr[2, 0];
                            Arr[2, 0] = Arr[2, 2];
                            Arr[2, 2] = temp;

                            Console.WriteLine("");
                            Console.WriteLine(x[i]);
                            DrawArray(Arr);
                        }
                    }
                    
                }

            }
        }

        static void DrawArray(string[,] Arr)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(Arr[j, k]);
                }
                Console.WriteLine("");
            }
        }
    }
}
