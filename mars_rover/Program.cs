using mars_rover.Service;
using System;
using System.Globalization;

namespace mars_rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mars Rover app!");
            bool newAstronout = true;
            while (newAstronout)
            {
                Console.WriteLine("Please enter your current location information. orn (4,5, N)");
                int prmX, prmY;
                string prmAspect, prmDestinity;

                // DATA COLLECTION PART ######################################
                blCheck.CheckCoordinate("X", out prmX);
                blCheck.CheckCoordinate("Y", out prmY);
                blCheck.CheckAspect(out prmAspect);
                blCheck.ReceiveDestinationLocation(out prmDestinity);
                // DATA COLLECTION PART ######################################
                Console.WriteLine("##############################################################");
                blFindLocation findDestiny = new blFindLocation(prmX, prmY, prmAspect.ToUpper(), prmDestinity.ToUpper());
                string prmGiveDestiny = findDestiny.GiveDestiny();
                Console.WriteLine("Location :" + prmGiveDestiny);

                Console.WriteLine("Do you want to find a new location? (Y)");
                newAstronout = Console.ReadLine().ToUpper() == "Y" ? true : false;
                Console.WriteLine("##############################################################");

            }
        }
    }
}
