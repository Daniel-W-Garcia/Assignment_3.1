namespace Assignment_3._1;

public class ConsecutiveNumbers
{
    private int[] myArray = {1, 1, 2, 2, 1, 1, 3, 2};
    
    public int[] ReplaceConsecutiveInts (int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == 1 && array[i + 1] == 1)
            {
                array[i] = 0;
                array[i + 1] = 0;
            }
            break;
        }
        return array;
    }
    
    public void PrintArray()
    {
        ReplaceConsecutiveInts(myArray);
        Console.WriteLine(string.Join(", ", myArray));
    }
}