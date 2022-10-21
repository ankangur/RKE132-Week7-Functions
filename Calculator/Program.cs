Console.WriteLine("Enter the operation (+/-):"); //lõpetame testis jagamise ja korrutamse funktsioonid
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter first number:");
int firstNum = Int32.Parse(Console.ReadLine()); //argument
Console.WriteLine("Enter second number:");
int secondNum = Int32.Parse(Console.ReadLine()); 

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Substarction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

static void Addition(int a, int b) //võib olla mitu väärtust ja mitu erinevat kuid mingit kindlat tüüpi väärtused
{
    Console.WriteLine($"{a} + {b} = {a + b}"); //parameters
}
static void Substarction(int a, int b)
{
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }
}
