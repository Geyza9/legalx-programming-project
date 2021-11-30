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
        bool loggedIn = false; //should be false by default
        EEmployeeType employeetype = (EEmployeeType)0; //should be 0 by default


        // Instantiating Lists
        List<Employee> lawyers = new List<Employee>();
        List<Receptionist> receptionists = new List<Receptionist>();
        List<Administrator> administrators = new List<Administrator>();
        List<Client> clients = new List<Client>();
        List<Cases> cases = new List<Cases>();
        List<Appointments> appointments = new List<Appointments>();
        List<MeetingRooms> meetingRooms = new List<MeetingRooms>();
        


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

            // add meeting rooms
            meetingRooms.Add(new MeetingRooms("Aquarium", 20));
            meetingRooms.Add(new MeetingRooms("Cube", 10));
            meetingRooms.Add(new MeetingRooms("Cave", 8));

            //load lists for testing
            clients.Add(new Client(0,"Testing","D","Ummy",new DateTime(1998,02,10),ESpecialisation.Corporate,"Vesterbro","22","2000","New York"));
            cases.Add(new Cases(0,0,ESpecialisation.Corporate,new DateTime(2012,10,10),"5 months",3,1,"Bad stuff happened","Nothing"));
            appointments.Add(new Appointments(0,0,0,new DateTime(2018,08,22,12,00,00),"Cave","Weekly meeting"));

        }

        public bool Process()
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
                        Console.WriteLine("4. Sign Out");



                        switch (Console.ReadLine())
                        {
                            case "1":
                                ListCases();
                                break;

                            case "2":
                                AddNewCase();
                                break;

                            case "3":
                                ListAppointments();
                                break;

                            case "4":
                                returnToLogin();
                                break;
                        }

                        break;

                    case EEmployeeType.admin:
                        Console.WriteLine("Here are your options. Choose one by typing the number and pressing enter");
                        Console.WriteLine("1. List all the cases");
                        Console.WriteLine("2. List all appointments");
                        Console.WriteLine("3. Sign Out");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                ListCases();
                                break;

                            case "2":
                                ListAppointments();
                                break;

                            case "3":
                                returnToLogin();
                                break;

                        }

                        break;

                    case EEmployeeType.receptionist:
                        Console.WriteLine("Here are your options. Choose one by typing the number and pressing enter");
                        Console.WriteLine("1. Register a new client");
                        Console.WriteLine("2. Add a new appointment");
                        Console.WriteLine("3. List all appointments");
                        Console.WriteLine("4. List all clients");
                        Console.WriteLine("5. Sign Out");


                        switch (Console.ReadLine())
                        {
                            case "1":
                                AddNewClient();
                                break;

                            case "2":
                                AddNewAppointment();
                                break;

                            case "3":
                                ListAppointments();
                                break;

                            case "4":
                                ListClients();
                                break;

                            case "5":
                                returnToLogin();
                                break;
                        }

                        break;

                }
                
            }
            if (loggedIn && runAnotherTask()) { return true; } else { return false; } //check if user wants to run another task, and return bool based on it
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
            } while (!Enum.IsDefined(typeof(ESpecialisation),client.casetype)); //run the code while the casetype is not defined

            Console.WriteLine("Please type in the client's street and press enter");
            client.street = Console.ReadLine();
            Console.WriteLine("Please type in the client's street number and press enter");
            client.streetnr = Console.ReadLine();
            Console.WriteLine("Please type in the client's zip code and press enter");
            client.zip = Console.ReadLine();

            Console.WriteLine("Please type in the client's city and press enter");
            client.city = Console.ReadLine();

            clients.Add(client);
            Console.WriteLine($"Client {client.firstname} registered successfully. Client ID is {client.clientid}");
            
        }

        private void AddNewAppointment()
        {
            Appointments appointment = new Appointments();
            appointment.appointmentid = appointments.Count; //set appointment id automatically (so first appointment is id-1)

            ClientsIdDialog(); //dialog that lists all clients and their id

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
            } while (appointment.clientid == -1); //-1 is never an actual id, so while it's -1, the proper id has not been registered

            LawyersIdDialog(); //dialog that lists all lawyers and their id

            Console.WriteLine("Please type the lawyer's ID and press enter");

            appointment.lawyerid = -1; //set to an never used lawyer id, to allow to check if the proper lawyer id was successfully registered by user
            do
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    bool lawyerExists = false;
                    foreach (Employee lawyer in lawyers)
                    {
                        if (input == lawyer.EmployeeId)
                        {
                            lawyerExists = true;
                            appointment.lawyerid = input;
                            break;
                        }
                    }
                    if (!lawyerExists) { throw new Exception("No lawyer exists with this ID"); }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} \n Try again");
                }
            } while (appointment.lawyerid == -1);

            Console.WriteLine("Please type in the appointment's date and time in the following format, and press enter \n (YYYY-MM-DD HH:MM)");

            do
            {
                try
                {
                    appointment.dateandtime = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Incorrect format, try again. Format: YYYY-MM-DD-HH-MM");
                }

            } while (appointment.dateandtime == new DateTime(0001, 01, 01, 00, 00, 00));

            Console.WriteLine("Please select the meeting room for the appointment by entering the corresponding number from the list and pressing enter");
            {
                int i = 1; //index for listing meeting rooms
                foreach (MeetingRooms meetingRoom in meetingRooms) //list 
                {
                    Console.WriteLine(i++ + ". " + meetingRoom.ToString());
                }
            }

            //select meeting room by typing number
            do
            {
                try
                {
                    appointment.meetingroom = meetingRooms[int.Parse(Console.ReadLine())-1].name; //get the name of the meeting room chosen by finding it in the List of meetingrooms. The -1 is needed because the first object in the list is [0], but the user types 1 to select it
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (appointment.meetingroom == null);

            Console.WriteLine("Please type in a short description for the appointment and press enter");
            appointment.shortdescription = Console.ReadLine();

            appointments.Add(appointment);
        }

        private void AddNewCase()
        {
            Cases cCase = new Cases();
            cCase.caseid = cases.Count; //set case id based on how many cases there are

            ClientsIdDialog(); //dialog that lists all clients and their id

            Console.WriteLine("Type the client's ID and press enter");
            cCase.clientid = -1; //set to an never used client id, to allow to check if the proper client id was successfully registered by user
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
                            cCase.clientid = input;
                            break;
                        }
                    }
                    if (!clientExists) { throw new Exception("No client exists with this ID"); }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} \n Try again");
                }
            } while (cCase.clientid == -1);

            Console.WriteLine("Please choose a case type from the list by typing the number and pressing enter");
            // list all possible values for case type (ESpecialisation)
            {
                int i = 0; //use variable i to count the iterations of the loop, so that no matter how many values are in ESpecialisation, the number is accurate
                foreach (ESpecialisation e in Enum.GetValues(typeof(ESpecialisation)))
                {
                    if (i != 0) //leave out the first ("Unknown") value of the list
                    {
                        Console.WriteLine($"{i}. {e}");
                    }
                    i++;
                }
            }

            do
            {
                try
                {
                    cCase.casetype = (ESpecialisation)Enum.Parse(typeof(ESpecialisation), Console.ReadLine());

                    //if the number is not connected to any value in the enum, throw an exception
                    if (!Enum.IsDefined(typeof(ESpecialisation), cCase.casetype))
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number or input, try again");
                }
            } while (!Enum.IsDefined(typeof(ESpecialisation), cCase.casetype));

            Console.WriteLine("Please type in the case's start date in the following format, and press enter \n (YYYY-MM-DD)");

            // Try to parse the date input, until the input is correct
            do
            {
                try
                {
                    cCase.startdate = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Incorrect format, try again. Format: YYYY-MM-DD");
                }

            } while (cCase.startdate == new DateTime(0001, 01, 01));

            Console.WriteLine("Please type in the expected process duration for the case and press enter");
            cCase.expectedprocessduration = Console.ReadLine();

            Console.WriteLine("Please type in the total number of charges in the case and press enter");
            do
            {
                try
                {
                    cCase.totalcharges = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input, try again");
                }
            } while (cCase.totalcharges == -1);


            LawyersIdDialog(); //dialog that lists all lawyers and their id

            Console.WriteLine("Please type the lawyer's ID and press enter");

            cCase.lawyerid = -1; //set to an never used lawyer id, to allow to check if the proper lawyer id was successfully registered by user
            do
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    bool lawyerExists = false;
                    foreach (Employee lawyer in lawyers)
                    {
                        if (input == lawyer.EmployeeId)
                        {
                            lawyerExists = true;
                            cCase.lawyerid = input;
                            break;
                        }
                    }
                    if (!lawyerExists) { throw new Exception("No lawyer exists with this ID"); }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} \n Try again");
                }
            } while (cCase.lawyerid == -1);

            Console.WriteLine("Please type in the description of the situation and press enter");
            cCase.situationdescription = Console.ReadLine();
            Console.WriteLine("Please type in any other notes you might have and press enter");
            cCase.othernotes = Console.ReadLine();

            cases.Add(cCase);

        }



        private void ListClients()
        {
            Console.Clear();
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine(clients[i]);
            }
        }

        private void ListCases()
        {
            Console.Clear();
            for (int i = 0; i < cases.Count; i++) 
            {
                
                Console.WriteLine(cases[i]);
            }
        }

        private void ListAppointments()
        {
            Console.Clear();
            for (int i = 0; i < appointments.Count; i++)
            {
                
                Console.WriteLine(appointments[i]);
            }
        }

        // function to ask for client ID and optionally display all the clients to choose from
        private void ClientsIdDialog()
        {
            Console.WriteLine("Please provide the ID of the client. Would you like to see a list of all clients and their ID's? Press Y to show list, press N to proceed without it");
            {
                char input = Console.ReadKey(true).KeyChar;
                while (true)
                {
                    if (input == 'Y' || input == 'y')
                    {
                        Console.Clear();
                        Console.WriteLine("Client's name - ID");
                        foreach (Client client in clients)
                        {
                            Console.WriteLine($"{client.firstname} {client.middlename} {client.lastname} - {client.clientid}");
                        }
                        break;
                    }
                    if (input == 'n' || input == 'N') { break; }
                    input = Console.ReadKey().KeyChar;
                }
            }
        }

        // function to ask for lawyer ID and optionally display all the lawyers to choose from
        private void LawyersIdDialog()
        {
            Console.WriteLine("Please provide the ID of the lawyer. Would you like to see a list of all lawyers and their ID's? Press Y to show list, press N to proceed without it");
            {
                char input = Console.ReadKey(true).KeyChar;
                while (true)
                {
                    if (input == 'Y' || input == 'y')
                    {
                        Console.Clear();
                        Console.WriteLine("Lawyer's name - ID");
                        foreach (Employee lawyer in lawyers)
                        {
                            Console.WriteLine($"{lawyer.FullName} - {lawyer.EmployeeId}");
                        }
                        break;
                    }
                    if (input == 'n' || input == 'N') { break; }
                    input = Console.ReadKey().KeyChar;
                }
            }
        }

        private bool runAnotherTask()
        {
            Console.WriteLine("Task complete. Press Y to perform another task, or Q to quit the program.");
            char input = Console.ReadKey(true).KeyChar;
            while (true)
            {
                if (input == 'y'|| input == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                if (input == 'q' || input == 'Q') { return false; }
                input = Console.ReadKey().KeyChar;
            }
        }
        private void returnToLogin()
        {
            Console.WriteLine("Press R to select a different user, or Q to quit the program");
            char input = Console.ReadKey().KeyChar;
            if (input == 'r' || input == 'R')
            {
                Console.Clear();
                login();
            }
            if (input == 'q' || input == 'Q')
            {
                Environment.Exit(0);
            }

        }
       
    }
}