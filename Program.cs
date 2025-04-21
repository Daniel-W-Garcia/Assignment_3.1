
using System.Text;

string ReturnEvenNumbers()
{
    StringBuilder sb = new StringBuilder();
    
    for (int i = 2; i < 100; i += 2)
    {
        sb.Append(i);
        if (i < 98)
        {
            sb.Append(", ");
        }

    }
    return sb.ToString();
}

Console.WriteLine(ReturnEvenNumbers());
