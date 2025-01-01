namespace TheFourSistersAndTheDuckbear;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of eggs gathered today: ");
        int numOfEggsGathered = Convert.ToInt32(Console.ReadLine());
        
        int numOfSisters = 4;
        
        Console.WriteLine($"Each sister gets {numOfEggsGathered/numOfSisters} egg(s).");
        Console.WriteLine($"The duckbear gets {numOfEggsGathered % numOfSisters} eggs.");
    }
}
