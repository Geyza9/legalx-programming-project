namespace legalxproject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Processor p = new Processor();

            p.login(); //login procedure
            p.generateAndLoadDatabase(); //generate and load the data of employees

            //Process() returns a boolean based on whether or not the user wants to run another task. If they don't want to run more tasks, Process() doesn't run again
            while (true)
            {
                if (!p.Process()) { break; }
            }

        }

    }
}
