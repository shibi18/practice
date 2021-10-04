using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissor
{
    class Program
    {
        static void Main(string[] args)
        {   // BOTCHOICE
            // 1 = rock
            // 2 = paper
            // 3 = scissor
            Console.WriteLine("enter your choice of weapon");
            string humchoice = (Console.ReadLine());

            Random r = new Random();
            int botchoice = r.Next(4);
            if (botchoice == 1)
            {
                if(humchoice == "rock") 
                {
                    Console.WriteLine("opponent cho0se rock");
                    Console.WriteLine("mathc ties : !");
                }
                else if (humchoice == "paper")
                {
                    Console.WriteLine("opponent cho0se rock");
                    Console.WriteLine("hurray!!");
                    Console.WriteLine("you have won : )");
                }
                else if (humchoice == "scissor")
                {
                    Console.WriteLine("opponent cho0se rock");
                    Console.WriteLine("o0ps");
                    Console.WriteLine("you lost ; (");
                }
                else
                {
                    Console.WriteLine("choose rock, paper or scissor");
                }
            }
            if (botchoice == 2)
            {
                if (humchoice == "rock")
                {
                    Console.WriteLine("opponent cho0se paper");
                    Console.WriteLine("o0ps");
                    Console.WriteLine("you lost ; (");
                }
                else if (humchoice == "paper")
                {
                    Console.WriteLine("opponent cho0se paper");
                    Console.WriteLine("match ties : !");
                }
                else if (humchoice == "scissor")
                {
                    Console.WriteLine("opponent cho0se paper");
                    Console.WriteLine("hurray!!");
                    Console.WriteLine("you have won : )");
                }
                else
                {

                    Console.WriteLine("choose rock, paper or scissor");
                }
            }
            if (botchoice == 3)
            {
                if (humchoice == "rock")
                {
                    Console.WriteLine("opponent cho0se scissor");
                    Console.WriteLine("hurray!!");
                    Console.WriteLine("you have won : )");
                }
                else if (humchoice == "paper")
                {
                    Console.WriteLine("opponent cho0se scissor");
                    Console.WriteLine("o0ps");
                    Console.WriteLine("you lost ; )");
                }
                else if (humchoice == "scissor")
                {
                    Console.WriteLine("opponent cho0se scissor");
                    Console.WriteLine("match ties : !");
                }
                else
                {
                    Console.WriteLine("choose rock, paper or scissor");
                }
            }
            Console.ReadLine();
        }
    }
}
