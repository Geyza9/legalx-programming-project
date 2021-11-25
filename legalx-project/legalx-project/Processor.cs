using System;
using System.Collections.Generic;

namespace legalxproject
{
    public class Processor
    {
        string userName = "a";
        string passWord = "a";
        string usernameInput;
        string passwordInput;
        bool loggedIn = true; //should be false by default
        EEmployeeType employeetype = (EEmployeeType)3; //should be 0 by default

        //DEBUGGING TOOLS
        public bool loadTestingClients = true;

        // Instantiating Lists
        List<Employee> lawyers = new List<Employee>();
        List<Receptionist> receptionists = new List<Receptionist>();
        List<Administrator> administrators = new List<Administrator>();
        List<Client> clients = new List<Client>();
        List<Cases> cases = new List<Cases>();
        List<Appointments> appointments = new List<Appointments>();
        


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

        public void generateAndLoadDatabase()
        {
            dataLoader d = new dataLoader();
            lawyers = d.loadData(); //load the lawyers to a List from the txt database

            // add receptionist to list
            receptionists.Add(new Receptionist(17, "Pam Beasly", new DateTime(1997, 10, 22), "Drawing"));

            // add administrative staff to list
            administrators.Add(new Administrator(18, "Bat Man", new DateTime(2011, 08, 19), "Martial arts", "Protector of Gotham"));
            administrators.Add(new Administrator(19, "John Smith", new DateTime(2016, 02, 20), "Crafting", "Office Mood Manager"));
            administrators.Add(new Administrator(20, "Mr. Randy", new DateTime(1996, 11, 01), "Cheeseburgers", "Weekend Trailer Park Supervisor"));
            administrators.Add(new Administrator(21, "Jim Lahey", new DateTime(1995, 04, 06), "Drinks", "Trailer Park Supervisor"));
            administrators.Add(new Administrator(22, "Donald Smith", new DateTime(2013, 05, 19), "Excel", "Case Manager"));

            //load lists for testing
            if (loadTestingClients)
            {
                for(int i = 0; i<10; i++)
                {
                    Client client = new Client();
                    client.clientid = i;
                    client.firstname = "Testing";
                    client.middlename = "D";
                    client.lastname = "ummy";
                    clients.Add(client);
                }
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
                                AddNewClient();
                                break;

                            case "2":
                                AddNewAppointment();
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
            //add new client dialog
            Client client = new Client();
            client.clientid = clients.Count; //set client id based on how many clients have been added to the list already
            Console.WriteLine(client.clientid);
            Console.WriteLine("Please type in the client's first name and press enter");
            client.firstname = Console.ReadLine();
            Console.WriteLine("Please type in the client's middle name if applicable and press enter");
            client.middlename = Console.ReadLine();
            Console.WriteLine("Please type in the client's last name and press enter");
            client.lastname = Console.ReadLine();
            Console.WriteLine("Please type in the client's date of birth in the following format, and press enter \n (YYYY-MM-DD)");

            // Try to parse the date input, until the input is correct
            do
            {
                try
                {
                    client.DOB = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Incorrect format, try again. Format: YYYY-MM-DD");
                }

            } while (client.DOB == new DateTime(0001,01,01));

            Console.WriteLine("Please choose a case type from the list by typing the number and pressing enter");
            // list all possible values for case type (ESpecialisation)
            { int i = 0; //use variable i to count the iterations of the loop, so that no matter how many values are in ESpecialisation, the number is accurate
                foreach (ESpecialisation e in Enum.GetValues(typeof(ESpecialisation)))
                {
                    if(i != 0) //leave out the first ("Unknown") value of the list
                    {
                        Console.WriteLine($"{i}. {e}");
                    }
                    i++;
                } }

            do
            {
                try
                {
                    client.casetype = (ESpecialisation)Enum.Parse(typeof(ESpecialisation), Console.ReadLine());

                    //if the number is not connected to any value in the enum, throw an exception
                    if(!Enum.IsDefined(typeof(ESpecialisation), client.casetype))
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number or input, try again");
                }
            } while (!Enum.IsDefined(typeof(ESpecialisation),client.casetype));

            Console.WriteLine("Please type in the client's street and press enter");
            client.street = Console.ReadLine();
            Console.WriteLine("Please type in the client's street number and press enter");
            client.streetnr = Console.ReadLine();
            Console.WriteLine("Please type in the client's zip code and press enter");
            do
            {
                try
                {
                    client.zip = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please make sure to only use numbers");
                }
            } while (client.zip == 0);

            Console.WriteLine("Please type in the client's city and press enter");
            client.city = Console.ReadLine();

            clients.Add(client);
            Console.WriteLine($"Client {client.firstname} registered successfully. Client ID is {client.clientid}");
            
        }

        private void AddNewAppointment()
        {
            Appointments appointment = new Appointments();
            appointment.appointmentid = appointments.Count;
            Console.WriteLine("Please provide the ID of the client for the appointment. Would you like to see a list of all clients and their ID's? Press Y to show list, press N to proceed without it");
            { char input = Console.ReadKey(true).KeyChar;
                while (true)
                {
                    if (input == 'Y' || input == 'y')
                    {
                        Console.WriteLine("Client's name - ID");
                        foreach (Client client in clients)
                        {
                            Console.WriteLine($"{client.firstname} {client.middlename} {client.lastname} - {client.clientid}");
                        }
                        break;
                    }
                    if (input == 'n' || input == 'N') { break; }
                    input = Console.ReadKey().KeyChar;
                } }
            Console.WriteLine("Type the client's ID and press enter");
            appointment.clientid = -1; //set to an never used client id, to allow to check if the proper client id was successfully registered by user
            do
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    bool clientExists = false;
                    foreach (Client client in clients)
                    {
                        if (input == client.clientid)
                        {
                            clientExists = true;
                            appointment.clientid = input;
                            break;
                        }
                    }
                    if (!clientExists) { throw new Exception("No client exists with this ID"); }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} \n Try again");
                }
            } while (appointment.clientid == -1);

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