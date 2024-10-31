//Math game project for C# academy
//You should record previous games in a List and there should be an option in the 
//menu for the user to visualize a history of previous games.

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

Random rnd = new Random();

int points = 0;
int healthPoints = 5;

WelcomeMessage();


while (healthPoints > 0){
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
	/*
	4

A simple approach would be:

Generate a random first number (n1)
Generate a random multiplier (m)
Use the product of the first number and the multiplier as the second number (n2 = n1 * m)
*/
	int intA = rnd.Next(25);
	int intB = intA * 2;
	int correctAnswer = intA / intB;
	Console.WriteLine($"What is {intA} / {intB}?");
	CheckAnswer(GetAnswer(), correctAnswer);
}

int GetAnswer()
{
	int number = 0;
	bool validInput = false;
	do {
	bool success = int.TryParse(Console.ReadLine(),	out number);
	
	if (success)
	{
		validInput = true;
	}
	else
	
	{
		Console.WriteLine("You must only input numbers");
	}
	
	}while(validInput == false);
	
	return number;
}


bool CheckAnswer(int answer, int correctAnswer)
{
	if (answer == correctAnswer)
	{
		Console.WriteLine($"{answer} is correct!");
		points ++;
		Console.WriteLine($"Points: {points}");
		return true;
	}
	else
	{
		Console.WriteLine($"Incorrect the correct answer is {correctAnswer} ");
		healthPoints --;
		Console.WriteLine($"You have {healthPoints} health points left");
		return false;
	}

}
