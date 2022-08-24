// Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].

int [] mass=new int[123];
int Count=0;
for(int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1,123);
    Console.Write(mass[i]+" ");
    if (mass[i]>10 && mass[i]<99)
        {
         Count=Count+1;
        }
}
Console.WriteLine();
Console.Write("Колличество элементов в отрезке: ");
Console.WriteLine(Count);


