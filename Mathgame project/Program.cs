//Math game project for C# academy
//You should record previous games in a List and there should be an option in the 
//menu for the user to visualize a history of previous games.

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

Random rnd = new Random();

int points = 0;
int healthPoints = 5;

WelcomeMessage();


while (healthPoints > 0)
{
	ChooseMenu();
}



void WelcomeMessage()
{
	Console.WriteLine("Welcome to the Math game");
	Console.WriteLine("Press enter to start!");
	Console.ReadLine();
}


void ChooseMenu()
{

	Console.WriteLine("Enter a number for your choice of game:");
	Console.WriteLine("1: Addition");
	Console.WriteLine("2: Subtraction");
	Console.WriteLine("3: Multiplicaton");
	Console.WriteLine("4: Division");



	switch (GetAnswer())
	{
		case 1: //+
			Console.WriteLine("You have chosen Additon!");
			AdditionGame();
			break;

		case 2: //-
			Console.WriteLine("You have chosen Subtraction!");
			SubtractionGame();
			break;

		case 3: // *
			Console.WriteLine("You have chosen Multiplicaton!");
			MultiplicatonGame();
			break;

		case 4: // /
			Console.WriteLine("You have chosen Division!");
			DivisionGame();
			break;

		case 5: //Se tidligere resultater

			break;


		default:
			Console.WriteLine("please only pick between the specified choices");
			break;
	}
}

void AdditionGame()
{
	int intA = rnd.Next(50);
	int intB = rnd.Next(50);
	int correctAnswer = intA + intB;
	Console.WriteLine($"What is {intA} + {intB}?");
	CheckAnswer(GetAnswer(), correctAnswer);
}

void SubtractionGame()
{
	int intA = rnd.Next(50);
	int intB = rnd.Next(50);
	int correctAnswer = intA - intB;
	Console.WriteLine($"What is {intA} - {intB}?");
	CheckAnswer(GetAnswer(), correctAnswer);
}

void MultiplicatonGame()
{
	int intA = rnd.Next(50);
	int intB = rnd.Next(50);
	int correctAnswer = intA * intB;
	Console.WriteLine($"What is {intA} * {intB}?");
	CheckAnswer(GetAnswer(), correctAnswer);
}

void DivisionGame()
{
	int intA = rnd.Next(1, 10);
	int intB = intA * rnd.Next(10);
	int correctAnswer = intB / intA;
	Console.WriteLine($"What is {intB} / {intA}? (Rounded down)");
	CheckAnswer(GetAnswer(), correctAnswer);
}

int GetAnswer()
{
	int number = 0;
	bool validInput = false;
	do
	{
		string input = Console.ReadLine().ToLower();

		if (input == "exit")
		{
			Console.WriteLine("exiting");
			
			break;
		}
		else
		{

			bool success = int.TryParse(input, out number);

			if (success)
			{
				validInput = true;
			}
			else
			{
				Console.WriteLine("You must only input numbers");
			}
		}

	} while (validInput == false);

	return number;
}


bool CheckAnswer(int answer, int correctAnswer)
{
	if (answer == correctAnswer)
	{
		Console.WriteLine($"{answer} is correct!");
		points++;
		Console.WriteLine($"Points: {points}");
		return true;
	}
	else
	{
		Console.WriteLine($"Incorrect the correct answer is {correctAnswer} ");
		healthPoints--;
		Console.WriteLine($"You have {healthPoints} health points left");
		return false;
	}

}
