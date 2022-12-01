/*

*/


int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите целое число больше 0");
        }
    }

    return result;
}

int lin = GetNumber("Введите число");
for(int i=1;i<=lin;i++)
{
    Console.Write($" {Math.Pow(i,2)}, ");
}