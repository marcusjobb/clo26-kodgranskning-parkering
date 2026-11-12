// Parkeringsavgift
// Programmet är skrivet med medvetna fel. Granska det enligt kravlistan i README.md.

Console.Write("Parkerad tid i minuter: ");
int minutes = int.Parse(Console.ReadLine());

if (minutes < 15)
{
    Console.WriteLine("Avgift: 0 kr");
    return;
}

int hours = minutes / 60;
int fee = 20;
for (int h = 1; h < hours; h++)
    fee += 15;

if (fee > 150)
    fee = 150;

Console.WriteLine($"Avgift: {fee} kr");
