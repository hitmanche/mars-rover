using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mars_rover.Service
{
    public static class blCheck
    {
        public static void CheckCoordinate(string prmLocation,out int prmValue)
        {
            Console.WriteLine("Please give position " + prmLocation + " as number : ");
            while (!int.TryParse(Console.ReadLine(), out prmValue))
            {
                Console.WriteLine("Please give position "+prmLocation+" as number : ");
            }
        }

        public static void CheckAspect(out string prmAspect)
        {
            Console.WriteLine("Please enter your direction information. exm (N, S, W, E) : ");
            prmAspect = Console.ReadLine();
            string[] aspectControl = new string[] { "N", "S", "W", "E" };
            while (!aspectControl.Contains(prmAspect.ToUpper()))
            {
                Console.WriteLine("Please enter your direction information. exm (N, S, W, E) : ");
                prmAspect = Console.ReadLine();
            }
        }

        public static void ReceiveDestinationLocation(out string prmDesctLoc)
        {
            Console.WriteLine("Please enter your destination location information. exm (LRMLRRMMLLRM) : ");
            prmDesctLoc = Console.ReadLine();
        }
    }
}
