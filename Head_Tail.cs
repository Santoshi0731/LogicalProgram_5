using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_5
{
    public class Head_Tail
    {
        public static void HeadTail()
        {
            int count = 0;
            int tails = 0;
            int heads = 0;

            while (count < 10)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("Tails!");
                    tails = tails + 1;
                    count = count + 1;

                }
                else if (result == 0)
                {
                    Console.WriteLine("Heads!");
                    heads = heads + 1;
                    count = count + 1;
                }
            }
            Console.WriteLine("Heads = " + heads + "Tails = " + tails + " Counts = " + count);
            Console.ReadLine();
            //int heads = 0;
            //int tails = 0;
            //int numFlips=1;

            //Random r = new Random();
            //int randNum = r.Next();

            //Console.WriteLine("Guess Heads And Tails ");
            //string guess = Console.ReadLine();

            //if (randNum == 1 && guess == "Heads")
            //{
            //    Console.WriteLine("The coin flip was Heads ");

            //} 
            //else if (randNum == 2 && guess == "Tails")
            //{
            //    Console.WriteLine("The coin flip was Tails ");
            //}
            //else
            //{
            //    string result;

            //    if(randNum == 1)
            //    {
            //        result = "Heads";

            //    }
            //    else
            //    {
            //        result = "Tails";
            //    }
            //    Console.WriteLine("You Lose the coin flip was {0} : ",result);


            //}

            double percentHeads = (heads /  10) * 100;
            double percentTails = (10 - tails) / 10 * 100;
            Console.WriteLine("The Persentage is : ", percentHeads);
            Console.WriteLine("The Persentage is : ", percentTails);
        }
    }
}
