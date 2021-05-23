using System;
using System.Collections.Generic;
using System.Numerics;
namespace shubhamtestapp
{
    class April_LunchTime
    {
        //UtilityFunctions
        public void vGetInput()
        {

        }

        ///Coldplay
        public void vNumOfTimesSongCanBePlayedFull()
        {
            string t = "";
            Console.WriteLine("Enter T");
            t = Console.ReadLine();
            int T = -1;

            int.TryParse(t, out T);

            int[] Result = new int[T];
            if (1 <= T && T <= 1000)
            {
                for (int ndex = 0; ndex < T; ndex++)
                {
                    string line = Console.ReadLine();
                    string[] tokens = line.Split(' ');
                    int[] InputLine = Array.ConvertAll(tokens, int.Parse);
                    int M = InputLine[0], S = InputLine[1];

                    if (1 <= M && M <= 100 && 1 <= S && S <= 10)
                    {
                        int ResultSingle = 0;
                        // int MTemp=M;
                        while (M > 0 && M >= S)
                        {
                            M = M - S;
                            ResultSingle++;
                        }

                        Result[ndex] = ResultSingle;

                    }
                }
                for (int i = 0; i < T; i++)
                {
                    Console.WriteLine(Result[i]);
                }
            }
        }


        ///EQUINOX
        public void vEquinox()
        {
            string t = "";
            t = Console.ReadLine();
            int T = -1;
            int.TryParse(t, out T);

            int[] ResultSarthak = new int[T];
            int[] ResultAnuradha = new int[T];
            string[] Result = new string[T];
            if (1 <= T && T <= 100)
            {
                for (int ndex = 0; ndex < T; ndex++)
                {
                    ResultSarthak[ndex] = 0;
                    ResultAnuradha[ndex] = 0;
                    string line = Console.ReadLine();
                    string[] tokens = line.Split(' ');
                    int[] InputLine = Array.ConvertAll(tokens, int.Parse);
                    int N = InputLine[0], A = InputLine[1], B = InputLine[2];

                    if (1 <= N && N <= 100
                        && 1 <= A && (A <= Math.Pow(10, 9))
                        && 1 <= B && (B <= Math.Pow(10, 9)))
                    {
                        for (int ndexInner = 0; ndexInner < N; ndexInner++)
                        {

                            string S = Console.ReadLine();
                            if (S.Length >= 1 && S.Length <= 100)
                            {
                                S = S.ToUpper();
                                if (S[0] == 'E' || S[0] == 'Q' || S[0] == 'U' || S[0] == 'I' || S[0] == 'N' || S[0] == 'O' || S[0] == 'X')
                                {
                                    ResultSarthak[ndex] += A;
                                }
                                else
                                {
                                    ResultAnuradha[ndex] += B;
                                }
                            }
                            // else1
                            // {
                            //      ResultAnuradha[ndex]   
                            // }
                            if (ResultSarthak[ndex] > ResultAnuradha[ndex])
                            {
                                Result[ndex] = "SARTHAK";
                            }
                            else if (ResultSarthak[ndex] < ResultAnuradha[ndex])
                            {
                                Result[ndex] = "ANURADHA";
                            }
                            else
                            {
                                Result[ndex] = "DRAW";
                            }

                        }
                    }


                }
                for (int ndex = 0; ndex < T; ndex++)
                {
                    Console.WriteLine(Result[ndex]);
                }
            }
        }
    }
}