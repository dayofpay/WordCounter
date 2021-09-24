using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ArgumentTester
{
    class Program
    {
        public static int words;
        static void Main(string[] args)
        {
        Restart:
            try
            {
                Console.WriteLine(@"
░██╗░░░░░░░██╗░█████╗░██████╗░██████╗░  ░██████╗░███████╗███╗░░██╗███████╗██████╗░░█████╗░████████╗░█████╗░██████╗░
░██║░░██╗░░██║██╔══██╗██╔══██╗██╔══██╗  ██╔════╝░██╔════╝████╗░██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗
░╚██╗████╗██╔╝██║░░██║██████╔╝██║░░██║  ██║░░██╗░█████╗░░██╔██╗██║█████╗░░██████╔╝███████║░░░██║░░░██║░░██║██████╔╝
░░████╔═████║░██║░░██║██╔══██╗██║░░██║  ██║░░╚██╗██╔══╝░░██║╚████║██╔══╝░░██╔══██╗██╔══██║░░░██║░░░██║░░██║██╔══██╗
░░╚██╔╝░╚██╔╝░╚█████╔╝██║░░██║██████╔╝  ╚██████╔╝███████╗██║░╚███║███████╗██║░░██║██║░░██║░░░██║░░░╚█████╔╝██║░░██║
░░░╚═╝░░░╚═╝░░░╚════╝░╚═╝░░╚═╝╚═════╝░  ░╚═════╝░╚══════╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝

  ██████╗░░█████╗░██╗░░░██╗░█████╗░███████╗██████╗░░█████╗░██╗░░░██╗  
  ██╔══██╗██╔══██╗╚██╗░██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗╚██╗░██╔╝  
  ██║░░██║███████║░╚████╔╝░██║░░██║█████╗░░██████╔╝███████║░╚████╔╝░  
  ██║░░██║██╔══██║░░╚██╔╝░░██║░░██║██╔══╝░░██╔═══╝░██╔══██║░░╚██╔╝░░  
  ██████╔╝██║░░██║░░░██║░░░╚█████╔╝██║░░░░░██║░░░░░██║░░██║░░░██║░░░  
  ╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░░░░╚═╝░░░░░╚═╝░░╚═╝░░░╚═╝░░░  

░██████╗░██╗████████╗██╗░░██╗██╗░░░██╗██████╗░
██╔════╝░██║╚══██╔══╝██║░░██║██║░░░██║██╔══██╗
██║░░██╗░██║░░░██║░░░███████║██║░░░██║██████╦╝
██║░░╚██╗██║░░░██║░░░██╔══██║██║░░░██║██╔══██╗
╚██████╔╝██║░░░██║░░░██║░░██║╚██████╔╝██████╦╝
░╚═════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝░╚═════╝░╚═════╝░");
                Console.Title = "Word Counter | GitHub | dayofpay | Testings";
                System.Threading.Thread.Sleep(1250);
                string illegal = "\"M\"\\a/ry/ h**ad:>> a\\/:*?\"| li*tt|le|| la\"mb.?";
                string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

                foreach (char c in invalid)
                {
                    illegal = illegal.Replace(c.ToString(), "");
                }
                words = 0;
                Console.Clear();
                Console.Write("Please, Drag the file into the Console ... : ");
                var argLine = Console.ReadLine();
                var readLine = File.ReadAllText(argLine);
                string[] argument = readLine.Split(' ');
                foreach (var word in argument)
                {

                    words++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine($"Word #{words}{word}");
                }

                System.Threading.Thread.Sleep(3000);
                goto Restart;
            }catch(Exception error)
            {
                Console.WriteLine("Oops ... We ran into Error ! Type:" + error.Message);
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                goto Restart;
            }
        }
    }
}
