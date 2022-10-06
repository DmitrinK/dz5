// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("введите длинну массива: ");
int userM = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[userM];
int count = 0;
while (count < userM)
{
    mas[count] = new Random().Next(0, 1000);
    count ++;
}
int count2 = 1;
int sum = 0;
while (count2 < userM)
{
    if (mas[count2] % 2 > 0)
    {
        sum = sum + mas[count2];
    }
    count2++;
}    
Console.WriteLine ($"сумма элементов, стоящих на нечётных позициях: {sum}");