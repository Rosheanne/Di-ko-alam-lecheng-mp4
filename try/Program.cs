using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana_Pumili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you like to do?");
            Console.WriteLine("[1] Magdabog");
            Console.WriteLine("[2] Mag-ano");
            Console.WriteLine("[3] Itigil na natin 'to");
            Console.WriteLine("[4] Smth, ah basta may gagawin tau :)");
            Console.WriteLine("I would like to: ");
            string action = Console.ReadLine();

            if (action == "1")
            {
                Console.WriteLine("kahjlgdioajsgdikashjdfgaiuhdgjgJKLGKHJASGDFIJLASGDLKJASGDLJKASGDKLJASGDKLAJSGDAJKLSGDAJKLSGDAJSGDASJKLDGAKLSJDGAKLSJDGASKLDGJASKLJDGASJKLDGAKS\niagtuwdiouaugtsdiuasgdiasgdiluagsdasdKASJGDKLJASGHDKLAJSHDKAJSD");
                Console.ReadKey();
            }

            else if (action == "2")
            {
                Console.WriteLine("*Nag-ano*");
                Console.ReadKey();

            }

            else if (action == "3")
            {

            }

            else if (action == "4")
            {
                int num;
                
                Console.Write("Anong number gusto mo dagdagan natin ng 1?");
                Console.WriteLine("");
                num = Int32.Parse(Console.ReadLine());

                //or pwede rin na += if mas marami or ++1
                num = num + 1;
                Console.WriteLine($"Ang imong number ay edi..." + num);
                Console.ReadKey();
            }
        }
    }
}
