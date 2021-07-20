using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            string cor = "Amarelo";
            switch(cor)
            {
                case "Vermelho":
                    Console.WriteLine("Vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Amarelo");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            


            // Console.ReadLine();
        }
    }
}

