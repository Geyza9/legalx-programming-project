using System;
using System.Collections.Generic;

namespace legalxproject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Processor p = new Processor();

            //p.login(); //login procedure
            p.generateAndLoadDatabase(); //generate and load the data of employees
            p.Process();

        }

    }
}
