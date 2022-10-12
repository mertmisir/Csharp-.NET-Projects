using CodingTask;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("======= Welcome to the Collegue Payment App - Mert Misir :) =======");
        Console.WriteLine("Please press 1 to see your collegues' payment details");
        Console.WriteLine("Please press any key to quit");
        Console.Write("What's your choice ? : ");

        string choice;
        choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "1")
        {
            Console.WriteLine("OK! Retrieving your collegues details from a file......");
            InitializeCollegueDetails();
        }
        else
        {
            Console.WriteLine("Tschüss! :)");
        }
    }
    public static void InitializeCollegueDetails()
    {
        try
        {
            string path = "C:\\Users\\mertm\\Desktop\\CodingTask\\Collegues.txt";
            List<string> docs = new List<string>(); // to handle multiple lines of data issue (overwriting multiple lines to a file in run time!) 

            //instantiation of an objects:  
            Collegue collegue = new Collegue("Mert Misir", 10);
            Collegue collegue2 = new Collegue("Lebron James", 5);
            Collegue collegue3 = new Collegue("Leo Messi", 5);
            Collegue collegue4 = new Collegue("Cristiano Ronaldo", 10);
            Collegue collegue5 = new Collegue("Dirk Nowitzki", 20);

            docs.Add(collegue.getName() + " " + collegue.getMoney() + "\n" + collegue2.getName() + " " + collegue2.getMoney() + "\n" + collegue3.getName() + " " + collegue3.getMoney() + "\n" + collegue4.getName() + " " + collegue4.getMoney() + "\n" + collegue5.getName() + " " + collegue5.getMoney()); // string concatanation , add the collegue info to the string list so that I can solve overwriting issue!
            File.WriteAllLines(path, docs); // write collegue info to the file

            string[] tempStorage = File.ReadAllLines(path); //temporary string array to retrieve and display back what we have in the file!
            foreach (string temp in tempStorage)
                Console.WriteLine(temp);

            Console.WriteLine();
            //to find and display who paid the most among collegues!
            if (collegue.getMoney() > collegue2.getMoney() && collegue.getMoney() > collegue3.getMoney() && collegue.getMoney() > collegue4.getMoney() && collegue.getMoney() > collegue5.getMoney())
                Console.WriteLine(collegue.getName() + " has paid the most!");

            else if (collegue2.getMoney() > collegue.getMoney() && collegue2.getMoney() > collegue3.getMoney() && collegue2.getMoney() > collegue4.getMoney() && collegue2.getMoney() > collegue5.getMoney())
                Console.WriteLine(collegue2.getName() + " has paid the most!");

            else if (collegue3.getMoney() > collegue.getMoney() && collegue3.getMoney() > collegue2.getMoney() && collegue3.getMoney() > collegue4.getMoney() && collegue3.getMoney() > collegue5.getMoney())
                Console.WriteLine(collegue3.getName() + " has paid the most!");

            else if (collegue4.getMoney() > collegue.getMoney() && collegue4.getMoney() > collegue2.getMoney() && collegue4.getMoney() > collegue3.getMoney() && collegue4.getMoney() > collegue5.getMoney())
                Console.WriteLine(collegue4.getName() + " has paid the most!");

            else
                Console.WriteLine(collegue5.getName() + " has paid the most!");


            Console.ReadKey(true);
        }
        catch (Exception e) { Console.WriteLine(e.Message); }
    }
}