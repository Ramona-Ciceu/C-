Console.WriteLine("Welcome to the NumberGuess game!");

Console.WriteLine("Enter a number between 1 and 10. You have 3 attempts!");

Console.WriteLine("If you guess the number, you win! Good luck.");





//Random class



Random Number = new Random();



while (true)

{



    int rand = Number.Next(1, 10);

    int numOfGuesses = 0;



    while (numOfGuesses < 3)

    {


        string Num;

        int NumInt;

        Console.WriteLine("Enter a number : ");

        Num = Console.ReadLine();

        NumInt = int.Parse(Num);



        if (NumInt < 0 || NumInt > 10)

        {

            Console.WriteLine("Invalid guess number!");

        }



        else if (rand != NumInt)

        {



            numOfGuesses++;

            Console.WriteLine("The number is Incorrect! Try again");

        }



        else

        {

            Console.WriteLine("Correct! Congratulations!");

            break;

        }



    }



    //ask to play again

    Console.WriteLine("Do you want to play again? (yes/no)");

    string playAgain = Console.ReadLine();

    if (playAgain == "no")

    {

        break;

    }

    else

    {

        Console.WriteLine("Let's play!");

    }




    Console.WriteLine("Thank you for playing!");
}




