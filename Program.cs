// See https://aka.ms/new-console-template for more information
Console.WriteLine("Boyut bilgisi giriniz: ");

int dimension = dimensionValue.dimensionNumber();

for (int i = 1; i <= dimension; i++)
{
    // Boşlukları yazdır
    for (int j = 1; j <= dimension - i; j++)
    {
        Console.Write(" ");
    }

    // Yıldızları yazdır
    for (int k = 1; k <= i; k++)
    {
        Console.Write("*");
    }

    // Her satır sonunda yeni bir satıra geç
    Console.WriteLine();
}
