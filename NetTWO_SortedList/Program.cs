using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetTWO_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList licenseList = new SortedList();
            licenseList["C2D4S5"] = "Bob";
            licenseList["123"] = "Jeff";
            string license = "";
            do
            {

                Console.WriteLine("Enter License #: ");
                license = Console.ReadLine();
                if(!licenseList.ContainsKey(license))
                {
                    Console.WriteLine("This License doesn't exist.  Add? (1-Yes or 2-No)");
                    int decision = Convert.ToInt32(Console.ReadLine());
                    if (decision == 1)
                    {
                        Console.WriteLine("Name?");
                        string addName = Console.ReadLine();
                        licenseList[license] = addName;
                    }
                }
                else
                {
                    Console.WriteLine("Name for License: " + licenseList[license]);
                    Console.WriteLine("1-Change, 2-Delete, or 3-Leave it?");
                    int decisionTwo = Convert.ToInt32(Console.ReadLine());
                    if(decisionTwo==1)
                    {
                        Console.WriteLine("New Name? ");
                        string newName = Console.ReadLine();
                        licenseList[license] = newName;
                    }
                    if(decisionTwo==2)
                    {
                        licenseList.Remove(license);
                    }
                    if(decisionTwo==3)
                    {
                        //license = "";
                    }
                }
            } while (license != "");
        }
    }
}
