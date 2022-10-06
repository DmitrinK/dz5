// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("введите длинну массива: ");
int userM = Convert.ToInt32(Console.ReadLine());
double[] mas = new double[userM];
int count = 0;
while (count < userM)
{
    mas[count] = new Random().Next(-100, 100);
    count ++;
}
double min = 0;
double max = 0;
int count2 = 0;
while (count2 < userM -1 )
{
    if (mas[count2] < mas [count2 + 1])
    {
        min = mas[count2];
        max = mas[count2 + 1];
    }
    else
    {
        min = mas[count2 + 1];
        max = mas[count2];
    }
    count2++;
}    
int answer = 0;
answer = Convert.ToInt32(max-min);
Console.WriteLine($"разница между максимальным и минимальным элементами массива: {answer}");