internal class Program
{
    private static void Main(string[] args)
    {
        string destination;
        double ashford = 8.9;
        double dover = 9.4;
        double london = 37;
        string firstClass;
        double firstClassAsh = 13.30;
        double firstClassDov = 14.90;
        double firstClassLon = 63;
        double priceBefore;


        int userAge;
        double ticket;



        //Prompt the user for the destination
        Console.WriteLine("What is the destination: Ashford, Dover or London?");


        // Read the user's answer into the destination variable
        destination = Console.ReadLine().ToLower();



        
        while (destination == "ashford") 
        {
          
            Console.WriteLine("Do you want to upgrade: to first class: yes/no?");
            firstClass = Console.ReadLine().ToLower();


            if (firstClass == "yes")

            {
                ticket = firstClassAsh;
            }
            else if (firstClass == "no")
            {
                ticket = ashford;
            }

             // Ask user the age
            Console.WriteLine("Please enter your age: ");
            userAge = int.Parse(Console.ReadLine());


            if (userAge <= 2)
            {
                Console.WriteLine("Price is : 0");
            }
            else if (userAge <= 3 && userAge <= 16)
            {
                priceBefore = 0.1 * ticket;
                Console.WriteLine("Price is : " + (ticket - priceBefore));
            }
            else if (userAge >= 65)
            {
                priceBefore = 0.15 * ticket;
                Console.WriteLine("Price is: " + (ticket - priceBefore));
            }
        }

       
        while (destination == "dover")
        {
            Console.WriteLine("Do you want to upgrade: to first class: yes/no?");
            firstClass = Console.ReadLine().ToLower();


            if (firstClass == "yes")

            {
                ticket = firstClassDov;
            }
            else if (firstClass == "no")
            {
                ticket = dover;
            }


            Console.WriteLine("Please enter your age: ");
            userAge = int.Parse(Console.ReadLine());


            if (userAge <= 2)
            {
                Console.WriteLine("Price is : 0");
            }
            else if (userAge <= 3 && userAge <= 16)
            {
                priceBefore = 0.10 * ticket;
                Console.WriteLine("Price: " + (ticket - priceBefore));
            }
            else if (userAge >= 65)
            {

                priceBefore = 0.15 * ticket;
                Console.WriteLine("Price is: " + (ticket - priceBefore));


            }

            while (destination == "London")
            {
                Console.WriteLine("Do you want to upgrade: to first class: yes/no?");
                firstClass = Console.ReadLine().ToLower();


                if (firstClass == "yes")

                {
                    ticket = firstClassLon;
                }
                else if (firstClass == "no")
                {
                    ticket = london;
                }


                Console.WriteLine("Please enter your age: ");
                userAge = int.Parse(Console.ReadLine());


                if (userAge <= 2)
                {
                    Console.WriteLine("Price is : 0");
                }
                else if (userAge <= 3 && userAge <= 16)
                {
                    priceBefore = 0.10 * ticket;
                    Console.WriteLine("Price: " + (ticket - priceBefore));
                }
                else if (userAge >= 65)
                {

                    priceBefore = 0.15 * ticket;
                    Console.WriteLine("Price is: " + (ticket - priceBefore));


                }

            }
        }
    }
}