//Math game project for C# academy


Random random = new Random();

int points = 0;
int healthPoints = 0;

int lowNumber = 0;
int highNumber = 20;

string input = "";
bool validInput = false;

WelcomeMessage();

System.Console.WriteLine($"now you must guess a number between {lowNumber} and {highNumber}");

input = Console.ReadLine();

do
{
    while (input == "")
    {

    }
} while (validInput == false);




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
    if cr == 3;





*/


void WelcomeMessage()
{
    System.Console.WriteLine("Welcome to the first edition of the math games international 2024 edition for the awareness of the fun impact of math and knowledge for man and woman kind.");
}