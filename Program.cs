using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Enter number of rolls and pass it to second class method
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate? ");
        int numRolls = 0;
        numRolls = int.Parse(System.Console.ReadLine());
        int[] diceRollsCount = Mission2Methods.diceRolls(numRolls);

        // Print out histogram
        System.Console.WriteLine("\n\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + numRolls + "\n\n");

        string[] asterisksArray = Asterisks(numRolls, diceRollsCount);

        // Loop through each possible roll and print out number of asterisks
        for (int num = 0; num < asterisksArray.Length; num++)
        {
            System.Console.WriteLine((num+2) + ": " + asterisksArray[num]);
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }

    public static string[] Asterisks(int rolls, int[] diceRollsCount)
    {
        // Initialize variables
        string[] asterisksArray = new string[diceRollsCount.Length];
        int numAsterisks = 0;
        string asterisks = "";

        // Determine percentage of rolls to determine number of asterisks for each number
        for (int num = 0; num < diceRollsCount.Length; num++)
        {
            asterisks = "";
            numAsterisks = (int)Math.Round(((double)diceRollsCount[num] / rolls) * 100);

            for (int a = 0; a < numAsterisks; a++)
            {
                asterisks += "*";
            }

            asterisksArray[num] = asterisks;

        }

        return asterisksArray;

    }

}