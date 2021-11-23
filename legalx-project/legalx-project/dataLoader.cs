using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace legalxproject
{
    public class dataLoader
    {
        public dataLoader()
        {
        }

        public void loadData()
        {
            List<String> data = File.ReadAllLines("lawyerDataBase.txt").ToList();

            foreach (string line in data)
            {
                if(line != data[0])
                {
                    if(line != data[1])
                    {
                        var columns = line.Split(';');
                        foreach (string variable in columns)
                        {
                            Console.WriteLine(variable);
                        }
                    }
                }
                
            }
        }
    }

}
