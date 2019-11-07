using System;

namespace ovn3_while_for
{
    class Program
    {
        static void Main(string[] args)
        {            
            var svar = "";
            var antRader = 1;

            // instruktion till användaren
            Console.WriteLine("Avsluta med 'Q'");

            // loop tills bokstaven Q anges
            // testar både stor och liten bokstav
            while ((svar != "Q") && (svar != "q"))
            {
                for (int ind=1; ind <= antRader ; ind++)
                {
                    Console.WriteLine("och sen då?");
                } 

                // antalet utskrifter dubbleras varje varv
                antRader *= 2;

                // inläsning från skärmen
                svar = Console.ReadLine();
            }             
        }
    }
}
