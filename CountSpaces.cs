namespace Assignment_3._1;

public class CountSpaces
{
    int numberOfSpaces;
    
    public int CountSpacesInString(string stringToTest)
    {
        numberOfSpaces = 0;
        foreach (char character in stringToTest)
        {
            if (character == ' ')
            {
                numberOfSpaces++;
            }
        }
        return numberOfSpaces;
    }

    public void PrintNumberOfSpaces()
    {
        Console.Write("Please enter a string: ");
        string stringToTest = Console.ReadLine();
        CountSpacesInString(stringToTest);
        Console.WriteLine($"There are {numberOfSpaces} spaces in this string.");
    }
}