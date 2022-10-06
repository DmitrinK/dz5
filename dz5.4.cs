/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
второй и предпоследний и т.д. Результат запишите в новом массиве.
*/
Console.WriteLine("введите длинну массива: ");
int userM = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[userM];
int count = 0;
while (count < userM)
{
    mas[count] = new Random().Next(0, 100);
    count ++;
}
count --;
int[] mas2 = new int[userM/2];
int count2 = 0;
while (count2 < userM/2)
{
    mas2[count2] = mas[count] * mas[count2];
    
    count --;
    count2 ++;
}
int count3 = 0;
Console.Write("[");
while (count3 < userM/2)
{
    Console.Write(mas2[count3]);
    if (count3 < userM/2-1)
    {
        Console.Write(",");
    }
    count3++;
}
Console.WriteLine("]");