//3.Create a console application that plays rock - paper - scissors
//There should be a menu with thee options:
//Play
//a.The user picks rock paper or scissors option
//b. The application picks rock paper scissors on random
//c. The user pick and the application pick are shown on the screen
//d. The application shows the winner
//e. The application saves 1 score to the user or the computer in the background
//f. When the user hits enter it returns to the main menu
//Stats
//a. It shows how many wins the user and how many wins the computer has
//b. It shows percentage of the wins and loses of the user
//C When the user hits enter it returns to the main menu
//Exit
//a. It closes the application

Console.WriteLine(" rock - paper - scissors ");

try
{
    int tie = 0;
    int userWins = 0;
    int computerWins = 0;

    //method for win ratio

    void WinRatio(int gamesWon, int gamesPlayed)
    {
        int result = userWins * 100 / gamesPlayed;

        Console.WriteLine($"Your win ratio is {result} % ");
    }


    while (true)
    {
        //menu options 
        Console.WriteLine("================");
        Console.WriteLine("Menu");
        Console.WriteLine("Pick an option:");
        Console.WriteLine(" a) Play");
        Console.WriteLine(" b) Stats");
        Console.WriteLine(" c) Exit");

        string option = Console.ReadLine();

        int computerOptin = new Random().Next(1, 3);



        //logic of the game 



        if (option.ToLower() == "a")
        {
            Console.WriteLine("Pick 1) rock - 2)  paper - 3)scissors");
            Console.WriteLine("=======================================");

            int inputOp = int.Parse(Console.ReadLine());


            if (inputOp == 1 && computerOptin == 1)
            {
                Console.WriteLine("You picked rock .");
                Console.WriteLine("the app  picked : rock ");
                Console.WriteLine("Its a tie");
                tie = tie + 1;
            }
            else if (inputOp == 1 && computerOptin == 2)
            {
                Console.WriteLine("You picked rock.");
                Console.WriteLine("================");


                Console.WriteLine("The app picks paper ");
                Console.WriteLine("=================================");

                Console.WriteLine("You lost ");
                computerWins = computerWins + 1;


            }
            else if (inputOp == 1 && computerOptin == 3)
            {
                Console.WriteLine("You picked rock .");
                Console.WriteLine("================");

                Console.WriteLine("The app  picks scissors");
                Console.WriteLine("==============================");

                Console.WriteLine("You won");
                userWins = userWins + 1;
            }



            if (inputOp == 2 && computerOptin == 1)
            {
                Console.WriteLine("You picked paper .");
                Console.WriteLine("================");

                Console.WriteLine("The app picks rock");
                Console.WriteLine("==============================");

                Console.WriteLine("You win");
                userWins = userWins + 1;


            }
            else if (inputOp == 2 && computerOptin == 2)
            {
                Console.WriteLine("You picked paper .");
                Console.WriteLine("================");

                Console.WriteLine("The app picks paper");
                Console.WriteLine("=================================");


                Console.WriteLine("Its a tie ");
                tie = tie + 1;


            }
            else if (inputOp == 2 && computerOptin == 3)
            {
                Console.WriteLine("You picked paper .");
                Console.WriteLine("================");

                Console.WriteLine($"The app  picks scissor");
                Console.WriteLine("==================================");

                Console.WriteLine("You lost");
                computerWins = computerWins + 1;

            }


            if (inputOp == 3 && computerOptin == 1)
            {
                Console.WriteLine("You picked scissors .");
                Console.WriteLine("================");


                Console.WriteLine($"The app picks Rock");
                Console.WriteLine("==============================");

                Console.WriteLine("You lose");
                computerWins = computerWins + 1;


            }
            else if (inputOp == 3 && computerOptin == 2)
            {
                Console.WriteLine("You picked scissors .");
                Console.WriteLine("================");


                Console.WriteLine($"The app  picks paper");
                Console.WriteLine("===============================");


                Console.WriteLine("You win ");
                userWins = userWins + 1;


            }
            else if (inputOp == 3 && computerOptin == 3)

            {
                Console.WriteLine("You picked scissors .");
                Console.WriteLine("================");


                Console.WriteLine($"The app picks scissors");
                Console.WriteLine("=============================");

                Console.WriteLine("Its a tie");
                tie = tie + 1;

            }
            else if  (inputOp > 3)
            {
               
                Console.WriteLine("Select a number between 1 - 3");
             

            }


        }

        //stats option
        else if (option.ToLower() == "b")
        {

            Console.WriteLine($"You won {userWins} times");
            Console.WriteLine("=========================");

            Console.WriteLine($"The app won  {computerWins} times");
            Console.WriteLine("==================================");

            Console.WriteLine($"You had a tie  {tie} times");
            Console.WriteLine("===========================");

            Console.WriteLine("=================");

            int gamesPlayed = tie + userWins + computerWins;//we have to add the total num of games we played 


            WinRatio(userWins, gamesPlayed);


        }
        //Exiting the game
        else if (option.ToLower() == "c")
        {
            break;
        }

    }

}catch(NullReferenceException e)
{
    Console.WriteLine("Null");
}
catch (FormatException e)
{
    Console.WriteLine("Wrong input!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}