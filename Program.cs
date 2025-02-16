namespace RockPaperScissors_Neal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameIdea2();
        }

        static void GameIdea2()
        {
            int playerScore = 0;
            int computerScore = 0;
            string[] choices = { "rock", "paper", "scissors", "lizard", "spock" };
            Random rand = new Random();

            Console.WriteLine("Choose from the following options: Rock, Paper, Scissors, Lizard, or Spock");
            Console.WriteLine("Best out of 5!");
            while (playerScore != 5 && computerScore != 5)
            {
                Console.WriteLine("Scores are Player: " + playerScore + " and Computer: " + computerScore);
                string? userInput = Console.ReadLine();
                string computerInput = choices[rand.Next(choices.Length)];

                switch (userInput)
                {
                    case "rock":
                        if (computerInput == "lizard" || computerInput == "scissors")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Player wins!");
                            playerScore += 1;
                        }
                        else if (computerInput == "paper" || computerInput == "spock")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Computer wins!");
                            computerScore += 1;
                        }
                        else if (userInput == computerInput)
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("It's a Tie!");
                        }
                        continue;

                    case "paper":
                        if (computerInput == "rock" || computerInput == "spock")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Player wins!");
                            playerScore = +1;
                        }
                        else if (computerInput == "lizard" || computerInput == "scissors")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Computer wins!");
                            computerScore = +1;
                        }
                        else if (userInput == computerInput)
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("It's a Tie!");
                        }
                        continue;

                    case "scissors":
                        if (computerInput == "lizard" || computerInput == "paper")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Player wins!");
                            playerScore = +1;
                        }
                        else if (computerInput == "rock" || computerInput == "spock")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Computer wins!");
                            computerScore = +1;
                        }
                        else if (userInput == computerInput)
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("It's a Tie!");
                        }
                        continue;

                    case "lizard":
                        if (computerInput == "spock" || computerInput == "paper")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Player wins!");
                            playerScore = +1;
                        }
                        else if (computerInput == "scissors" || computerInput == "rock")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Computer wins!");
                            computerScore = +1;
                        }
                        else if (userInput == computerInput)
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("It's a Tie!");
                        }
                        continue;

                    case "spock":
                        if (computerInput == "rock" || computerInput == "scissors")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Player wins!");
                            playerScore = +1;
                        }
                        else if (computerInput == "paper" || computerInput == "lizard")
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("Computer wins!");
                            computerScore = +1;
                        }
                        else if (userInput == computerInput)
                        {
                            Console.WriteLine("Player chooses " + userInput + " and Computer chooses " + computerInput);
                            Console.WriteLine("It's a Tie!");
                        }
                        continue;
                }
            }
        }
    }
}
