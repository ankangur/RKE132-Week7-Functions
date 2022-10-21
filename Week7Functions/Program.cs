Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

static void PrintHello() //function e method 
    //void tähendab, et funktsioon kustutakse vahemälust
{
    Console.WriteLine("Hello World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See You later, alligator.");
}