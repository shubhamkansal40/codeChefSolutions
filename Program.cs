using System;
using System.Collections.Generic;
using System.Numerics;
namespace shubhamtestapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // FCTRL2();
            //FLOW002();
            //INTEST();
            //TSORT();
            //FLOW004();
            //LUCKFOUR();
            //FLOW007();
            CHEGLOVE();
        }
        public static void CHEGLOVE()
        {
            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            string[] ArrResult = new string[T];

            for (int ndex = 0; ndex < T; ndex++)
            {
                {
                    int NumberofFingers = 0;

                    NumberofFingers = int.Parse(Console.ReadLine());
                    string line = Console.ReadLine();
                    string[] tokens = line.Split(' ');
                    int[] LengthofFingers = Array.ConvertAll(tokens, int.Parse);
                    line = "";

                    line = Console.ReadLine();
                    tokens = line.Split(' ');
                    int[] LengthofSheaths = Array.ConvertAll(tokens, int.Parse);
                    if (ndex == (T - 1))
                    {
                        string Result = "none";
                        bool fFront = true, fBack = true;

                        ///Loop for Front
                        for (int ndexOuter = 0; ndexOuter < LengthofFingers.Length; ndexOuter++)
                        {
                            for (int ndexInner = 0; ndexInner < LengthofSheaths.Length; ndexInner++)
                            {
                                if (LengthofFingers[ndexOuter] != LengthofSheaths[ndexInner])
                                {
                                    fFront = false;
                                    break;
                                }
                                else
                                {
                                    fFront = true;
                                    break;
                                }
                            }
                            if (!fFront)
                            {
                                break;
                            }
                        }

                        ///Loop for back
                        for (int ndexOuter = 0; ndexOuter < LengthofFingers.Length; ndexOuter++)
                        {
                            for (int ndexInner = (LengthofSheaths.Length - 1); ndexInner >= 0; ndexInner--)
                            {
                                if (LengthofFingers[ndexOuter] == LengthofSheaths[ndexInner])
                                {
                                    fBack = true;
                                  
                                }
                                else
                                {
                                    fBack =      false;                              
                                }
                            }
                            if (!fBack)
                            {
                                break;
                            }
                        }


                        while (NumberofFingers > 0)
                        {
                            int nUp = 0, nDown = NumberofFingers;
                            if (LengthofFingers[nUp] == LengthofSheaths[nDown])
                                nUp++;
                            nDown--;
                            NumberofFingers--;
                        }

                        if (fFront && fBack)
                        {
                            Result = "both";
                        }
                        else if (fFront)
                        {
                            Result = "front";
                        }
                        else if (fBack)
                        {
                            Result = "back";
                        }
                        else
                        {
                            Result = "none";
                        }

                        ArrResult[ndex] = Result;
                    }
                }
            }



            for (int ndex = 0; ndex < T; ndex++)
            {
                Console.WriteLine(ArrResult[ndex]);
            }
        }
        public static void FLOW007()
        {
            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            int[] ArrResult = new int[T];

            for (int ndex = 0; ndex < T; ndex++)
            {
                int num = int.Parse(Console.ReadLine());
                int temp = num, sum = 0, rem;

                while (num > 0)
                {
                    rem = num % 10;
                    sum = (sum * 10) + rem;
                    num = num / 10;
                }



                ArrResult[ndex] = sum;//count;
            }
            for (int ndex = 0; ndex < T; ndex++)
            {
                Console.WriteLine(ArrResult[ndex]);
            }
        }
        public static void LUCKFOUR()
        {
            ///Count the number of 'fours' in an integer

            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            int[] ArrResult = new int[T];

            for (int ndex = 0; ndex < T; ndex++)
            {
                int num = int.Parse(Console.ReadLine());
                string str = num.ToString();
                int count = 0;
                for (int ndex2 = 0; ndex2 < str.Length; ndex2++)
                {
                    if (str[ndex2] == '4')
                    {
                        count++;
                    }
                }

                ArrResult[ndex] = count;
            }
            for (int ndex = 0; ndex < T; ndex++)
            {
                Console.WriteLine(ArrResult[ndex]);
            }
        }

        public static void FLOW004()
        {
            ///Sum of first and last digits

            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            int[] ArrResult = new int[T];

            for (int ndex = 0; ndex < T; ndex++)
            {
                int num = int.Parse(Console.ReadLine());
                int last = 0, first = 0;
                int temp = num;
                while (num > 0)
                {
                    if (num == temp)
                    {
                        last = num % 10;
                    }

                    if (num < 10)
                    {
                        first = num;
                    }
                    num = num / 10;

                }

                ArrResult[ndex] = first + last;
            }
            for (int ndex = 0; ndex < T; ndex++)
            {
                Console.WriteLine(ArrResult[ndex]);
            }
        }
        public static void TSORT()
        {
            // int a, b;
            // int[] arr;
            // a = int.Parse(Console.ReadLine());

            // while (a > 0)
            // {
            //     a--;
            //     b = int.Parse(Console.ReadLine());

            //     // count the number of times a
            //     //element appeared in input
            //     arr[b]++;
            // }
            // for (int i = 0; i < 1000001; i++)
            // {
            //     // print every element number of
            //     //times it appeared
            //     while (arr[i] > 0)
            //     {
            //         printf("%d\n", i);
            //         arr[i]--;
            //     }
            // }
        }
        public static void FCTRL2()
        {

            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            if (T >= 1 && T <= 100)
            {
                BigInteger[] ArrResult = new BigInteger[T];

                for (int ndex = 0; ndex < T; ndex++)
                {
                    int line = int.Parse(Console.ReadLine());
                    if (line >= 1 && line <= 100)
                    {
                        BigInteger fact = new BigInteger(1);
                        while (line > 0)
                        {
                            fact = fact * line;

                            line--;
                        }
                        ArrResult[ndex] = fact;
                    }
                }
                for (int ndex = 0; ndex < T; ndex++)
                {

                    Console.WriteLine(ArrResult[ndex]);
                }
            }
        }
        public static void FLOW002()
        {
            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            int[] ArrResult = new int[T];

            for (int ndex = 0; ndex < T; ndex++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split(' ');
                int[] numbers = Array.ConvertAll(tokens, int.Parse);
                ArrResult[ndex] = numbers[0] % numbers[1];
            }
            for (int ndex = 0; ndex < T; ndex++)
            {
                Console.WriteLine(ArrResult[ndex]);
            }
        }
        public static void INTEST()
        {
            string line = "";
            line = Console.ReadLine();
            if (line != null && line.Length > 0)
            {
                string[] tokens = line.Split(' ');
                int[] numbers = Array.ConvertAll(tokens, int.Parse);
                if (numbers.Length >= 2)
                {
                    int n = numbers[0];
                    int k = numbers[1];
                    if (n < Math.Pow(10, 7) && k < Math.Pow(10, 7))
                    {
                        int count = 0;
                        for (int ndex = 0; ndex < n; ndex++)
                        {
                            int inp = int.Parse(Console.ReadLine());
                            if (inp % k == 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                }
            }

        }
        public static void START01()
        {
            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            if (T > 0 && T < Math.Pow(10, 5))
            {
                Console.WriteLine(T);
            }
        }
        public static void FLOW001()
        {
            string Tstr = Console.ReadLine();
            int T = 0;
            int.TryParse(Tstr, out T);
            int[] ArrResult = new int[T];
            for (int ndex = 0; ndex < T; ndex++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split(' ');
                int[] numbers = Array.ConvertAll(tokens, int.Parse);
                ArrResult[ndex] = numbers[0] + numbers[1];
            }
            for (int ndex = 0; ndex < T; ndex++)
            {
                Console.WriteLine(ArrResult[ndex]);
            }

        }

    }
}
