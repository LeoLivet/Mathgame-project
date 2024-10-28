//Math game project for C# academy
//You should record previous games in a List and there should be an option in the 
//menu for the user to visualize a history of previous games.

Random random = new Random();

int points = 0;
int healthPoints = 0;

int lowNumber = 0;
int highNumber = 20;

string input = "";
bool validInput = false;

WelcomeMessage();
ChooseMenu(Console.ReadLine();)


input = Console.ReadLine();

do
{
	while (input == "")
	{

	}
} while (validInput == false);


void WelcomeMessage()
{
	Console.WriteLine("Welcome to the Math game");
	Console.WriteLine("Press enter to start!");
}
void AddToHistory()//put nogle overrides ind her
{
	// lav en array her som tager input fra console og sætter det ind her.
}

void ChooseMenu(int input) 
{
	switch (input)
	{
		case 1: //+
		Console.WriteLine("You have chosen Additon!");
		// TODO add option to press enter to continue or e(?) to go back (like a method)
		AdditionGame();
		break;
		
		case 2: //-
		Console.WriteLine("You have chosen Subtraction!");
		break;
		
		case 3: // *
		Console.WriteLine("You have chosen Multiplicaton!");
		break;
		
		case 4: // /
		Console.WriteLine("You have chosen Division!");
		break;
		
		case 5: //Se tidligere resultater
		
		
		default:
		Console.WriteLine("please only pick between the specified choices");
		break;
	}
}

void AdditionGame()
{

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