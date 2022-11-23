Console.Clear();
double Cappuccino = 3.5;
double Tea = 1.5;
double Cacao = 2.5;
string product = "";
int twoEuroCount = 0;
int oneEuroCount = 0;
int fiftyCentCount = 0;
Console.WriteLine("Please enter the amount of money");
double money = double.Parse(Console.ReadLine()!);

if( money % 0.5 != 0)
{
    Console.Write("invalid input");
    Environment.Exit(0);
}

while( product != "f" && money >= 1.5)
{
    Console.Write("What product do you want, choose between [Cappuccino , Tea, Cacao or [f]inish");
    product = (Console.ReadLine()!);
    if (product == "Cappuccino" || product == "Tea" || product == "Cacao")
    {
        if (product == "Cappuccino")
        {
            money -= Cappuccino;
        }

        else if (product == "Tea")
        {
            money -= Tea;
        }
        else if (product == "Cacao")
        {
            money -= Cacao;
        }
    }
    else if (product != " " || product != "Cappuccino" || product != "Tea" || product != "Cacao")
    {
        Console.WriteLine("Invalid Product!");
    }

}

double returnMoney = money;
double returnTmp = returnMoney;

while (money >= 2)
{
    twoEuroCount++;
    money -= 2;
}
while (money >= 1)
{
    oneEuroCount++;
    money -= 1;
}
while (money >= 0.5)
{
    fiftyCentCount++;
    money -= 0.5;
}

Console.WriteLine($"The returned coins of {returnMoney} is : {twoEuroCount}x2€ pieces, {oneEuroCount}x1€ pieces, {fiftyCentCount}x0.5€ pieces ");

