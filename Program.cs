using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //prilozenie prosit polzovatelja vvesti ego god rozdenija
            //prilozenie vishisljaet vozrast polzovatelja (2022 - god rozdenija polzovatelja)
            //esli polzovatel moloze 18 let, to v konsoli vivoditsa "too young to drive"
            //esli polzovatel starwe 18 let,to v konsoli vivoditsa "drive carefully"
            //a esli polzovatelju 18 let, to v konsoli vivoditsa "Congratulations,you my apply
            //for your deiving licence now"

            Console.WriteLine("Please enter your year of birth:");
            int result = 2022 - Convert.ToInt32(Console.ReadLine());





            if (result < 18)


            {
                Console.WriteLine("You are too young to drive.");

            }
             else if (result > 18)
            {
                Console.WriteLine("drive csrefully!");

            }
            else
            {
                Console.WriteLine("Congratulations,you my apply for your driving licence now");

            }
           
        }
        
    }
}
