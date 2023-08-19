do
{
    Console.WriteLine("Odd or Even!");
    Console.WriteLine("============");
    Console.Write("Enter a number: ");
    var numberString = Console.ReadLine();
    try
    {
        var numerInteger = Convert.ToInt32(numberString);
        if (numerInteger % 2 == 0)
        {
            Console.WriteLine($"The number: {numerInteger} is odd.");
        }
        else
        {
            Console.WriteLine($"The number: {numerInteger} is even.");
        }
    }
    catch (Exception)
    {
        Console.WriteLine($"The input: {numberString} is not a number.");
    }
} while (true);
