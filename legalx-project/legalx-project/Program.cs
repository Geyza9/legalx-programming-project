using System;
using System.Collections.Generic;

namespace legalxproject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            dataLoader d = new dataLoader();
            Processor p = new Processor();

            List<Employee> lawyers = d.loadData(); //load the lawyers from the txt database

            foreach (Employee lawyer in lawyers)
            {
                Console.WriteLine(lawyer);
            }

            p.login(); //login procedure

        }

    }
}
