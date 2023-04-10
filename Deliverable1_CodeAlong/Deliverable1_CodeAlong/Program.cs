// Restocking the Store
int sodaCount = 100;
int sodaRestock = 40;

int chipsCount = 40;
int chipsRestock = 20;

int candyCount = 60;
int candyRestock = 40;

Console.WriteLine("How many sodas have been sold? 100 are in stock.");
string sodaSold = Console.ReadLine();
int s = int.Parse(sodaSold);

if (s > sodaCount)
{
    Console.WriteLine("That number is too high, soda stock not adjusted.");
}
else
{
    sodaCount -= s;

    //This is a string interpolation - this makes strings easier to put togther
    Console.WriteLine($" {s} sodas have been sold. {sodaCount} sodas are left in stock.");
}

Console.WriteLine("How many chips have been sold? 40 are in stock.");
string chipsSold = Console.ReadLine();
int c = int.Parse(chipsSold);

if (c > chipsCount)
{
    Console.WriteLine("That number is too high, chips stock not adjusted.");
}
else
{
    chipsCount -= c;

    //This is a string interpolation - this makes strings easier to put togther
    Console.WriteLine($" {c} chips have been sold. {chipsCount} chips are left in stock.");
}

Console.WriteLine("How many candies have been sold? 60 are in stock.");
string candySold = Console.ReadLine();
int can = int.Parse(candySold);

if (can > candyCount)
{
    Console.WriteLine("That number is too high, candy stock not adjusted.");
}
else
{
    candyCount -= can;

    //This is a string interpolation - this makes strings easier to put togther
    Console.WriteLine($" {can} chips have been sold. {candyCount} chips are left in stock.");
}
if(sodaCount <= sodaRestock)
{
    Console.WriteLine("Sodas need to be restocked.");
}

if(chipsCount <= chipsRestock)
{
    Console.WriteLine("Chips nee to be restocked.");
}

if(candyCount <= candyRestock)
{
    Console.WriteLine("Candies need to be restocked.");
}