using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlak_if_sats
{
    internal class Application
    {

        public void Run()


        {

            //UPPGIFT 4: Be användaren mata in sin ålder. Om den är mindre än 18 är användaren ej myndig. Om den är över 65 är den pensionär.
            //Annars är den myndig men inte pensionär. Meddela användaren om vad som gäller beroende på dennes ålder.
            //ÖVERKURS: Kontrollera också att användaren har matat in ett riktigt tal.Har den matat in andra tecken än
            //siffror meddela användaren att den har matat in en felaktig ålder.

            Console.WriteLine("Ange ålder");
            int ålder = Convert.ToInt32(Console.ReadLine());
            if (ålder > 0 && ålder < 18)
            {
                Console.WriteLine("Du är ej myndig");
            }
            else if (ålder > 65 && ålder <120)
            {
                Console.WriteLine("Du är pensionär");
            }
            else
            {
                Console.WriteLine("Du är medelålder");
            }
            
            //------------------------------------------------------------------------------------------------------------------------------------------
            //UPPGIFT 3: Be användaren mata in temperaturen tagen från en febertermometer. Om tempen är över 37.8 skriv- Du har feber.
            //Om den är över 39.5 skriv-Du bör uppsöka läkare. Om den är mindre än 37.8 skriv- Du har inte feber.

            //Console.WriteLine("Mata in temperaturen");
            // double tal = Convert.ToDouble(Console.ReadLine());
            // if (tal >= 37.8 && tal <= 39.5)
            // {
            //     Console.WriteLine("Du har feber.");
            // }
            // else if (tal >= 39.5)
            // {
            //     Console.WriteLine("Du bör uppsöka läkare");
            // }
            // if (tal < 37.8)
            // {
            //     Console.WriteLine("Du har inte feber");
            // }
            //Console.ReadKey();

            //UPPGIFT 2: Be användaren att mata in hur många paket mjölk som finns kvar. Är det mindre än 10 skriv- Beställ 30 paket.
            //Är det mellan 10 och 20 skriv-Beställ 20 paket. Annars skriv-Du behöver inte beställa någon mjölk.

            //Console.WriteLine("Mata in hur många mjölkpaket du har");
            //int Mjölk = Convert.ToInt32(Console.ReadLine());
            //if (Mjölk < 10)
            //{
            //    Console.WriteLine("Beställ 30 paket");
            //}
            //else if (Mjölk >= 10 && Mjölk <= 20)
            //{
            //    Console.WriteLine("beställ 20 paket");
            //}
            //else
            //{
            //    Console.WriteLine("Du behöver inte beställa någon mjölk");
            //}
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //UPPGIFT 1: Be användaren att mata in ett tal. Kontrollera om talet är större än 10. Meddela användaren om talet är större än 10- Talet är större än 10.
            //Om det är mindre än 10 meddela användaren – Talet är mindre än 10

            //Console.WriteLine("Mata in ett nummer");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n < 10)
            //{
            //    Console.WriteLine("Talet är MINDRE än 10");

            //}
            //else if (n > 10)
            //{
            //    Console.WriteLine("Talet är STÖRRE än 10");
            //}


            //-------------------------------------------------------------------------------------------
            //Console.WriteLine("Ange tröjnummer");
            //int jerseyNumber = Convert.ToInt32(Console.ReadLine());
            //switch (jerseyNumber)
            //{
            //    case 21:
            //        Console.WriteLine("Foppa");
            //        break;

            //    case 13:
            //        Console.WriteLine("Mats Sundin");
            //        break;
            //}

            //---------------------------------------------------------------------------------   
            //if (jerseyNumber == 21)
            //{
            //    Console.WriteLine("Foppa");
            //}
            //else if (jerseyNumber == 13)
            //{
            //      Console.WriteLine("Mats Subdin")
            //}


            //--------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("Var är du S/K:");
            //string location = Console.ReadLine();
            //Console.WriteLine("Hur gammal är du?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Vilken promillehalt:");
            //Double promille = Convert.ToDouble(Console.ReadLine());

            //if (age >= 18 && location == "K" && promille < 1.0)     //&& betyder and
            //{
            //    Console.WriteLine("Du får köpa öl");
            //}
            //else if (age >= 20 && location == "S" && promille < 1.0)
            //{
            //    Console.WriteLine("Du får köpa öl");
            //}
            //else
            //{
            //    Console.WriteLine("DU får inte köpa öl");
            //}
            //------------------------------------------------------------------------------------------------------------------------
            //string namn;
            //Console.WriteLine("Vad heter du?");
            //namn = Console.ReadLine();
            ////Console.WriteLine(namn == "Alex"
            //if (namn == "Alex")
            //{
            //    Console.WriteLine("Vilket fint namn!");
            //    Console.WriteLine("Alex är ett fint namn!");

            //}
            //else if (namn == "Oliver")
            //{
            //    Console.WriteLine("kul namn!");
            //}
            //else
            //{
            //    Console.WriteLine("DItt namn duger väll");
            //}
            //-------------------------------------------------------------------------------------------------------------------
            //if (age == 20 || age == 50) || betyder eller
            // if (age ! ==50) ! betyder not



        }
    }
}
