Console.Clear();

string[] arrayOne = new string[] {"Дом", "Работа", "hello", "world", "33", "16", "12"};
string[] arrayTwo = new string[arrayOne.Length];


SecondArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);

void SecondArray(string[] A, string[] N)
{
    int count = 0;
    for (int i = 0; i < A.Length; i++)
    {
    if(A[i].Length <= 3)
        {
        N[count] = A[i];
        count++;
        }
    }
}

void PrintArray(string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}
