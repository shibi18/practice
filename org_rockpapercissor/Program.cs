using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org_rockpapercissor
{
    class Program
    {
        static void Main(string[] args)
        {


            choice aichoice = GetAIChoice();
            choice userchoice = GetHUMchoice();
            choosewinner (aichoice, userchoice);
            Console.ReadLine();
        }
        //////////////////////////////////////////////       


        #region getaichoice
        public static choice GetAIChoice()
        {
            Random r = new Random();
            choice aichoice = (choice)r.Next(1, 4);
            return aichoice;
        }
        #endregion


        #region gethumchoice
        public static choice GetHUMchoice()
        {

            Console.WriteLine(" ROCK PAPER SCISSOR ");
            Console.WriteLine(" enter 1 for rock || enter 2 for paper || enter 3 for scissor");
            Console.WriteLine(" enter your choice of weapon", 1, 3);
            int humchoice = Convert.ToInt32(Console.ReadLine());
            return (choice)humchoice;


        }
        #endregion


        #region choosewinner
        public static void choosewinner(choice botchoice, choice humchoice)
        {
            if (botchoice == choice.rock)
            {
                if (humchoice == choice.rock)
                {
                    Console.WriteLine("opponent cho0se rock");
                    Console.WriteLine("mathc ties : !");
                }
                else if (humchoice == choice.paper)
                {
                    Console.WriteLine("opponent cho0se rock");
                    Console.WriteLine("hurray!!");
                    Console.WriteLine("you have won : )");
                }
                else if (humchoice == choice.scissors)
                {
                    Console.WriteLine("opponent cho0se rock");
                    Console.WriteLine("o0ps");
                    Console.WriteLine("you lost ; (");
                }
                else
                {
                    Console.WriteLine("choose 1,2,3");
                }
            }
            if (botchoice == choice.paper)
            {
                if (humchoice == choice.rock)
                {
                    Console.WriteLine("opponent cho0se paper");
                    Console.WriteLine("o0ps");
                    Console.WriteLine("you lost ; (");
                }
                else if (humchoice == choice.paper)
                {
                    Console.WriteLine("opponent cho0se paper");
                    Console.WriteLine("match ties : !");
                }
                else if (humchoice == choice.scissors)
                {
                    Console.WriteLine("opponent cho0se paper");
                    Console.WriteLine("hurray!!");
                    Console.WriteLine("you have won : )");
                }
                else
                {

                    Console.WriteLine("1,2,3");
                }
            }
            if (botchoice == choice.scissors)
            {
                if (humchoice == choice.rock)
                {
                    Console.WriteLine("opponent cho0se scissor");
                    Console.WriteLine("hurray!!");
                    Console.WriteLine("you have won : )");
                }
                else if (humchoice == choice.paper)
                {
                    Console.WriteLine("opponent cho0se scissor");
                    Console.WriteLine("o0ps");
                    Console.WriteLine("you lost ; )");
                }
                else if (humchoice == choice.scissors)
                {
                    Console.WriteLine("opponent cho0se scissor");
                    Console.WriteLine("match ties : !");
                }
                else
                {
                    Console.WriteLine("1,2,3");
                }
            }
        }
        #endregion
      

    }
     public enum choice
        {
            rock   =1,
           paper   =2,
         scissors  =3
        }
}
