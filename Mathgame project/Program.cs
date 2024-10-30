//Math game project for C# academy
//You should record previous games in a List and there should be an option in the 
//menu for the user to visualize a history of previous games.

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

Random rnd = new Random();

int points = 0;
int healthPoints = 0;

int lowNumber = 0;
int highNumber = 20;

bool validInput = false;
WelcomeMessage();



ChooseMenu();




void WelcomeMessage()
{
	Console.WriteLine("Welcome to the Math game");
	Console.WriteLine("Press enter to start!");
}


void ChooseMenu()
{



	string input = Console.ReadLine();

	int result = int.Parse(input);


	switch (result)
	{
		case 1: //+
			Console.WriteLine("You have chosen Additon!");

			AdditionGame();
			break;

		case 2: //-
			Console.WriteLine("You have chosen Subtraction!");
			int intA = rnd.Next(50);
			int intB = rnd.Next(50);

			break;

		case 3: // *
			Console.WriteLine("You have chosen Multiplicaton!");
			break;

		case 4: // /
			Console.WriteLine("You have chosen Division!");

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
	int answer = GetAnswer();


	for (int i = 0; i < 4; i++)
	{

		if (answer == correctAnswer)
		{
			System.Console.WriteLine("Congrats thats correct!");
		}
		else
		{
			System.Console.WriteLine("Incorrect 100 points from gryffindor!");

		}
	}
}

void SubtractionGame()
{

}

void MultiplicatonGame()
{

}

void DivisionGame()
{
	/*
	4

A simple approach would be:

Generate a random first number (n1)
Generate a random multiplier (m)
Use the product of the first number and the multiplier as the second number (n2 = n1 * m)
*/
}

int GetAnswer()
{
	int input = Convert.ToInt32(Console.ReadLine());
	return input;
}