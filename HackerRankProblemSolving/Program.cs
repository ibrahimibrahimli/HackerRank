namespace HackerRankProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static int sockMerchant(int n, List<int> ar)
            {
                int pairs = 0;
                int[] arr = new int[n];
                var ix = 0;
                for (int i = 0; i < ar.Count; i++)
                {

                    for (int j = 0; j < ar.Count; j++)
                    {

                        if (ar[i] == ar[j] && i < j && (!arr.Contains(i) || i == 0))
                        {
                            arr[ix] = j;
                            ix++;
                            pairs += 1;
                            break;
                        }
                    }

                }
                return pairs;
            }

           // List<int> arr = new List<int>();
            //arr.Add(1);
            //arr.Add(3);
            //arr.Add(1);
            //arr.Add(4);
            //arr.Add(3);
            //arr.Add(1);
            //arr.Add(2);




            // Console.WriteLine(sockMerchant(7, arr));




            static string kangaroo(int x1, int v1, int x2, int v2)
            {
                string Result = "";

                List<int> Kangaroo1 = new ();
                List<int> Kangaroo2 = new ();
                Kangaroo1.Add(x1);
                Kangaroo2.Add(x2);
                
                for(int i = 0; i <= 10000; i++)
                {
                    Kangaroo1.Add(Kangaroo1[i] + v1);
                    Kangaroo2.Add(Kangaroo2[i]  + v2);

                    if (Kangaroo1[i] == Kangaroo2[i])
                    {
                        Result = "Yes";
                        break;
                    }
                    else
                    {
                        Result = "NO";
                        continue;
                    }
                  
                }


                return Result;
            }


            // Console.WriteLine(kangaroo(0,2, 5, 3));



            static int divisibleSumPairs(int n, int k, List<int> ar)
            {

                int Pairs = 0;

                for(int i = 0; i < ar.Count; i++)
                {
                    i = 0;
                    for (int j = 1 ; j < ar.Count; j++)
                    {

                        if ((ar[i] + ar[j]) % k == 0)
                        {
                            
                            Pairs++;
                        }
                        if(j == ar.Count - 1)
                        {
                            ar.Remove(ar[i]);
                            
                        }
                    }
                }

                return Pairs;
            }
            List<int> ar = new();

            ar.Add(5);
            ar.Add(9);
            ar.Add(10);
            ar.Add(7);
            ar.Add(4);
            // ar.Add(2);


            //    Console.WriteLine(divisibleSumPairs(5, 2, ar));


            

         //   Console.WriteLine(99 / 2);

            static void StairCase(int n)
            {

               for(int i = 1; i <= n; i++)
                {
                    if (i < n)
                    {
                        for(int j = 1; j <= n-i; j++)
                        {
                            Console.Write(" ");
                           
                        }
                        for(int x = 0; x <= i-1; x++)
                        {
                             Console.Write("#");
                        }
                             
                        Console.WriteLine();
                    }
                    else
                    {
                        for(int t = 0; t < n; t++)
                        {
                             Console.Write("#");
                        }
                       
                    }
                   

                }
            }

          //  StairCase(100);

            static void MinMaxSum(int[] arr){
                

                long maxSum =Convert.ToInt64( arr.Sum()) -Convert.ToInt64( arr.Min());
                long minSum =Convert.ToInt64( arr.Sum()) - Convert.ToInt64( arr.Max());

                Console.WriteLine($" {minSum} {maxSum}");
            }
            int[] arr = new int[] { 1, 3, 5, 7, 9 };

           // MinMaxSum(arr);

            static void CatAndMouse(int x, int y, int z)
            {


                for (int i = 0; i <= 2; i++)
                {
                    int CatA = 0;
                    int CatB = 0;

                    if (x > z)
                    {
                        CatA = x - z;
                    }
                    else
                    {
                        CatA = z - x;
                    }
                    if (y > z)
                    {
                        CatB = y - z;
                    }
                    else
                    {
                        CatB = z - y;
                    }

                    if (CatA < CatB)
                    {
                        Console.WriteLine("Cat A");
                    }
                    else if (CatA > CatB)
                    {
                        Console.WriteLine("Cat B");
                    }
                    else
                    {
                        Console.WriteLine("Mouse C");
                    }
                }
                
            }

            // CatAndMouse(2, 9, 6);

             static int birthdayCakeCandles(List<int> candles)
            {
                int MaxCandles = 0;
                for (int i = 0; i < candles.Count; i++)
                {
                    if (candles[i] == candles.Max())
                    {
                        MaxCandles++;
                    }
                }

                return MaxCandles;
            }

            List<int> candles = new();
            candles.Add(3);
            candles.Add(2);
            candles.Add(1);
            candles.Add(3);
            candles.Add(3);
            Console.WriteLine(birthdayCakeCandles(candles));

        }
    }
}