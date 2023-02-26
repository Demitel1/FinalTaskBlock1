Console.Clear();

int ArrayCheck(string[] array)
{
 int count = 0;
 for (int i = 0; i < array.Length; i++)
    {
 if (array[i].Length <= 3) count++;
    }
 return count;
}

string[] FillResultArray(string[] array, int count)
{
 string[] result = new string[count];
 for (int i = 0; i < array.Length; i++)
    {
 if (array[i].Length <= 3)
        {
 result[result.Length - count] = array[i];
 count--;
        }
    }
 return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) 
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}


string[] array = {"2", "world", ":-)", "1234", "computer","error", "php", "AORUS", "iOS"};
int count = ArrayCheck(array);
string[] resultArray = FillResultArray(array, count);
PrintArray(resultArray);