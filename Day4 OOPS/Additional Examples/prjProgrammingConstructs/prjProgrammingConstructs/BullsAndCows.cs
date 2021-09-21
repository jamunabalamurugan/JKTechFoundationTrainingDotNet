using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProgrammingConstructs
{
    class BullsAndCows
    {
        string strWord = "LIKE";
        void Play()
        {
            string strUser;
            int iBulls,iCows;
            do
            {
                iBulls = 0;
                iCows = 0;
                Console.WriteLine("Please make your Guess");
                strUser = Console.ReadLine();
                if (strWord.ToLower() == strUser.ToLower())
                {
                    Console.WriteLine("You have Guessed it Right!!!Congrats");
                    Console.ReadKey();
                    break;
                }
                if(strUser.Length!=4)
                {
                    Console.WriteLine("Incorrect Word");
                  
                }
                else
                {
                    strWord = strWord.ToLower();
                    strUser = strUser.ToLower();
                    for(int j=0;j<4;j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if(strWord[j]==strUser[i])
                            {
                                if (i == j)
                                    iBulls++;
                                else
                                    iCows++;
                   
                            }
                        }
                    }
                    //Use Nested for Loop for remaining
                    Console.WriteLine("Bulls {0}, Cows {1}", iBulls, iCows);
                    Console.WriteLine("Bulls"+iBulls+","+"Cows"+iCows);
                }
            } while (true);




        }
        static void Main()
        {
            BullsAndCows bc = new BullsAndCows();
            bc.Play();
        }
    }
}
