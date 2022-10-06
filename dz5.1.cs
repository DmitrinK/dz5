//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("введите длинну массива: ");
int userM = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[userM];
int count = 0;
while (count < userM)
{
    mas[count] = new Random().Next(100, 1000);
    count ++;
}
int count2 = 0;
int answer = 0;
while (count2 < userM)
{
    if (mas[count2] % 2 == 0)
    {
        answer++;
    }
    count2++;
}    
Console.WriteLine ($"количество чётных чисел в массиве: {answer}");