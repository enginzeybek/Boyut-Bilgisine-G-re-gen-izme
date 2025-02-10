public class dimensionValue
{
    public static int dimensionNumber()
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Sıfırdan büyük sayı giriniz");
        }

        return number;
    }
}