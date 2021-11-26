using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace legalxproject
{
    public class dataLoader
    {
        //List<String> data = File.ReadAllLines("lawyerDataBase.txt").ToList();
        //list to keep employees in
        //List<Employee> employees = new List<Employee>();


        public List<Employee> loadData()
        {
            //find txt file based on path and add it to a string list
            List<String> data = File.ReadAllLines("lawyerDataBase.txt").ToList();

            //list to keep employees in
            List<Employee> employees = new List<Employee>();

            foreach (string line in data)
            {
                if (line != data[0]) //skip the first line as it's the headline
                {
                        var columns = line.Split(';'); //split rows with ;
                        if (columns[0] == "senior")
                        {
                            SeniorLawyer lawyer = new SeniorLawyer();

                            try
                            {
                                lawyer.EmployeeId = int.Parse(columns[1]);
                                lawyer.FullName = columns[2];
                                lawyer.DateofBirth = DateTime.Parse(columns[3]);
                                lawyer.JoinedDate = DateTime.Parse(columns[4]);
                                lawyer.OtherExpertise = columns[5];
                                lawyer.YearsExperience = int.Parse(columns[6]);
                                lawyer.Specialisation = (ESpecialisation)Enum.Parse(typeof(ESpecialisation), columns[7]);

                                employees.Add(lawyer);
                              
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"Incorrect database entry:");
                                Console.WriteLine(e.Message);
                                Console.WriteLine($"Employee {columns[2]} was not added to the database.");
                                employees.Remove(lawyer);
                            }

                        }
                        else if (columns[0] == "junior")
                        {
                            JuniorLawyer lawyer = new JuniorLawyer();

                            try
                            {
                                lawyer.EmployeeId = int.Parse(columns[1]);
                                lawyer.FullName = columns[2];
                                lawyer.DateofBirth = DateTime.Parse(columns[3]);
                                lawyer.JoinedDate = DateTime.Parse(columns[4]);
                                lawyer.OtherExpertise = columns[5];
                                lawyer.YearsExperience = int.Parse(columns[6]);
                                lawyer.Specialisation = (ESpecialisation)Enum.Parse(typeof(ESpecialisation), columns[7]);


                                employees.Add(lawyer);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Incorrect database entry:");
                                Console.WriteLine(e.Message);
                                Console.WriteLine($"Employee {columns[2]} was not added to the database.");
                                employees.Remove(lawyer);
                            }

                        

                    }


                }

            }
            return employees;
        }
    }

}
