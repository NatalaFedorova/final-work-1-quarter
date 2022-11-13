void Task()
{
    int n = 3;
    string[] inputArray = { "В начале июля", "в чрезвычайно жаркое время", "под", "вечер", "один молодой человек вышел из своей каморки", 
                           "которую нанимал от жильцов", "в", "С —", "м переулке", "на", "улицу и медленно", "как бы в нерешимости", "отправился к К — ну мосту." };
    int len = inputArray.Length;
    PrintArray(inputArray, len);
    int count = LengthNewArray(inputArray, len, n);
    string[] outputArray = new string[count];
    FillNewArray (inputArray, outputArray, count);
    Console.WriteLine("Результат:");
    PrintArray(outputArray, count);
}

int LengthNewArray(string[] inputArray, int len, int n)
{ 
    int count = 0;
    for(int i = 0; i < len; i++)
    {
        if (inputArray[i].Length <= n)
        {
            inputArray[count] = inputArray[i];
            count++;           
        }
    }
    return count;
}

void FillNewArray(string[] inputArray, string[] outputArray, int count)
{
    for(int i = 0; i < count; i++)
    outputArray[i] = inputArray[i];
}

void PrintArray(string[] Array, int Length)
{
    for(int i = 0; i < Length; i++)
    {
    Console.Write(Array[i] + " + ");
    }
    Console.WriteLine();
}

Task();
