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
		MultiplicatonGame();
		break;
		
		case 2: //-
		
		break;
		
		case 3: // *
		
		break;
		
		case 4: // /
		
		break;
		
		
		default:
		Console.WriteLine("please only pick between the specified choices");
		break;
	}
}
//switch mode for game choice below

/*
switch

case 1:
	if input == 1
		game = addition game
			addition game er simple tal med plus med få tal (start med maks 100+100 og så tilføj sværhedsgrad senere)
	break;


case 2:
	if cr == 2
	game = subtracion game 
		subtraction game er minus spil 
	break;

case 3:
	if cr == 3;
	game = multiplikation game
		multiplakation er gange spil

	break

case 4:
	if cr == 4;
	game = division game
		Division spil må ikke kunne give decimaler dvs divider kun med lige tal brug evt %
		The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.





*/


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
	
}