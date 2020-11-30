using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Zadacha
{
    class zadacha3MidExam
    {
        static void Main(string[] args)
        {
            List<long> range = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine().ToLower();
            string typeOfPriceRating = Console.ReadLine().ToLower();
            long leftSum = 0;
            long rightSum = 0;

           
            if (typeOfPriceRating == "positive" && typeOfItems == "cheap")
            {
                for (int i = entryPoint + 1; i < range.Count; i++)
                {
                    if (range[i] > 0 && range[i] < entryPoint)
                    {
                        rightSum += range[i];
                    }
                   
                }

                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (range[i] > 0 && range[i] < entryPoint)
                    {
                        leftSum += range[i];
                    }
                  
                }
            }
            else if (typeOfPriceRating == "negative" && typeOfItems == "cheap")
            {
                for (int i = entryPoint + 1; i < range.Count; i++)
                {
                    if (range[i] < 0 && range[i] <= entryPoint)
                    {
                        rightSum += range[i];
                    }

                }

                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (range[i] < 0 && range[i] <= entryPoint)
                    {
                        leftSum += range[i];
                    }

                }
            }
            else if (typeOfPriceRating == "all" && typeOfItems == "cheap")
            {
                for (int i = entryPoint + 1; i < range.Count; i++)
                {
                    if (range[i] <= entryPoint)
                    {
                        rightSum += range[i];
                    }
                   
                       
                    

                }

                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (range[i] <= entryPoint)
                    {
                        leftSum += range[i];
                    }
                    
                        
                    

                }
            }


            if (typeOfPriceRating == "positive" && typeOfItems == "expensive")
            {
                for (int i = entryPoint + 1; i < range.Count; i++)
                {
                    if (range[i] > 0)
                    {
                        rightSum += range[i];
                    }

                }

                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (range[i] > 0)
                    {
                        leftSum += range[i];
                    }

                }
            }
            else if (typeOfPriceRating == "negative" && typeOfItems == "expensive")
            {
                for (int i = entryPoint + 1; i < range.Count; i++)
                {
                    if (range[i] < 0)
                    {
                        rightSum += range[i];
                    }

                }

                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (range[i] < 0)
                    {
                        leftSum += range[i];
                    }

                }
            }
            else if (typeOfPriceRating == "all" && typeOfItems == "expensive")
            {
                for (int i = entryPoint + 1; i < range.Count; i++)
                {

                    if (range[i] >= entryPoint)
                    {
                        rightSum += range[i];
                    }
                        
                    
                   
                        
                 
                }

                for (int i = entryPoint - 1; i >= 0; i--)
                {
                    if (range[i] >= entryPoint)
                    {
                        leftSum += range[i];
                    }
                        
                 

                }
            }
            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }



        }

    }
}
