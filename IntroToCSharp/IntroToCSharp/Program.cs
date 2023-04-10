// In the current version of C#, the main method is optional.
Console.WriteLine("Enter a Radius:");
string r = Console.ReadLine();

// Takes in a sring and converts it to a double. 
double radius = double.Parse(r);

double area = radius * sq * Math.PI; 
Console.WriteLine("Area: " +  area);

double circumference = 2 * Math.PI  * radius;
Console.WriteLine("Circumference: " + circumference);