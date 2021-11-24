using System;
namespace legalxproject
{
    public class Processor
    {
        string userName = "legalx";
        string passWord = "12345";
        string usernameInput;
        string passwordInput;
        bool loggedIn = false;
        EEmployeeType employeetype = 0;


        public void login()
        {
            Console.WriteLine("*****Welcome to LegalX Legal Services*****");
            //provide user with options
            Console.WriteLine("Please choose one of the following options by typing the number and pressing enter:");
            Console.WriteLine("1. Lawyer");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Receptionist");

            //select employee type
            switch (Console.ReadLine())
            {
                case "1":
                    employeetype = EEmployeeType.lawyer;
                    break;
                case "2":
                    employeetype = EEmployeeType.admin;
                    break;
                case "3":
                    employeetype = EEmployeeType.receptionist;
                    break;
            }

            //prompt user to provide username
            Console.WriteLine("Please provide your username");
            usernameInput = Console.ReadLine();

            //prompt user to provide password
            Console.WriteLine("Please insert your password");
            passwordInput = Console.ReadLine();

            if (usernameInput != userName || passwordInput != passWord)
            {
                Console.WriteLine("Username or password incorrect");
            }
            else
            {
                loggedIn = true;
            }
        }

        public void Process()
        { 
            if (loggedIn) //only run if login was successful
            {
                switch (employeetype) //navigation for different employee types between commands
                {
                    case EEmployeeType.lawyer:
                        Console.WriteLine("Here are your options. Choose one by typing the number and pressing enter");
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

                        break;

                    case EEmployeeType.admin:
                        Console.WriteLine("Here are your options. Choose one by typing the number and pressing enter");
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

                        break;

                    case EEmployeeType.receptionist:
                        Console.WriteLine("Here are your options. Choose one by typing the number and pressing enter");
                        Console.WriteLine("1. Register a new client");
                        Console.WriteLine("2. Add a new appointment");
                        Console.WriteLine("3. List all appointments");
                        Console.WriteLine("4. List all clients");

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

                        break;
                }

                
            }

        }


        //methods
        private void AddNewClient()
        {

        }

        private void AddNewAppointment()
        {

        }

        private void AddNewCase()
        {

        }

        private void ListClients()
        {

        }

        private void ListCases()
        {

        }

        private void ListAppointments()
        {

        }


    }
}