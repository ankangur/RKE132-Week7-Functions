//kui arve total < 10 eurot, siis on allahindlus on 1%
//kui arve total >= 10 && total < 20 eurot, siis on allahindlus on 5%
//kui arve total >= 20 eurot, siis on allahindlus on 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount}%");

//double newTotal = userInput - (userInput * discount) / 100;

double newTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}%: {newTotal}");

static double CalculateDiscount(int total) //sõltuvalt andmetüübist tuleb kasutada static int või static string
    //double tähendab andmetüüpi, mis salvestatakse vahemällu (salvestatakse ainult üks väärtustest)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}
static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}

