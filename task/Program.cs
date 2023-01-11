string[] input = new string[5] {"123", "23", "hello", "world", "res"};
string[] output = new string[input.Length];
void SecondArray (string[] input, string[] output)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
    if(input[i].Length <= 3)
        {
        output[count] = input[i];
        count++;
        }
    }
}
void PrintArray(string[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        Console.Write($"{input[i]} ");
    }
    Console.WriteLine();
}
SecondArray (input, output);
PrintArray(output);