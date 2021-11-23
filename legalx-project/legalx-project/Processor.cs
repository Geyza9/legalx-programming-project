using System;
namespace legalxproject
{
    public class Processor
    {
        public void Process()
        {
            Console.WriteLine("*****Welcome to LegalX Legal Services*****");
            //provide user with options
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Lawyer");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Receptionist");

            string userName = "legalX";
            string passWord = "12345";
            string usernameInput;
            string passwordInput;
            bool loggedIn = false;
            EEmployeeType employetype = 0;

            //prompt user to provide username
            Console.WriteLine("Please provide the username");
            usernameInput = Console.ReadLine();

            //prompt user to provide password
            Console.WriteLine("Please insert the password");
            passwordInput = Console.ReadLine();

            if (usernameInput != userName | passwordInput != passWord)
            {
                Console.WriteLine("You are not authorized to access this service");
            }
            else
            {
                loggedIn = true;
            }

            //show menu options for each role; lawyer, admin, receptionist

            switch (Console.ReadLine())
            {
                case "1":
                    employetype = EEmployeeType.lawyer;
                    break;
                case "2":
                    employetype = EEmployeeType.admin;
                    break;
                case "3":
                    employetype = EEmployeeType.receptionist;
                    break;
            }

            if (employetype == EEmployeeType.lawyer)
               
            {
                Console.WriteLine("1. List all the cases");
                Console.WriteLine("2. Add a new case");
                Console.WriteLine("3. List all appointments");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            }

            if (employetype == EEmployeeType.admin)
            {
                Console.WriteLine("1. List all cases");
                Console.WriteLine("2. List all appointments");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                }
            }

            if (employetype == EEmployeeType.receptionist)
            {
                Console.WriteLine("Register a new client");
                Console.WriteLine("Add a new appointment");
                Console.WriteLine("List all appointments");
                Console.WriteLine("List all clients");
                switch (Console.ReadLine())
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            }

        }


        //methods
        public void AddNewClient()
        {

        }

        public void AddNewAppointment()
        {

        }

        public void AddNewCase()
        {

        }

        public void ListClients()
        {

        }

        public void ListCases()
        {

        }

        public void ListAppointments()
        {

        }


    }
}