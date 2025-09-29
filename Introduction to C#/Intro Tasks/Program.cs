// Question 1
Console.WriteLine("Enter minutes: ");
int minutes = int.Parse(Console.ReadLine());

Console.Write("Enter seconds: ");
int seconds = int.Parse(Console.ReadLine());

double distanceMeters = 10000;
double distanceMiles = 10 / 1.60934;

int totalSeconds = minutes * 60 + seconds;
double speedMps = distanceMeters / totalSeconds;
double totalHours = totalSeconds / 3600.0;
double speedMph = distanceMiles / totalHours;

Console.WriteLine("Speed: " + speedMps.ToString("F2") + " m/s");
Console.WriteLine("Speed: " + speedMph.ToString("F2") + " mph");

// Question 2

Console.WriteLine("Enter an integer");
int value = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(value + " x " + i + " = " + (value * i));
}

// Question 3
Console.WriteLine("Input a radius length");
int radius = int.Parse(Console.ReadLine());
double pi = Math.PI;

double area = (radius*radius * pi);
Console.WriteLine("The area is" + area.ToString("F2"));


