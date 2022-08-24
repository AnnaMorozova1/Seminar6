// Найдите произведение пар чисел в одномерном массиве. Парой 
// считаем первый и последний элемент, второй и предпоследний и т.д. Результат 
// запишите в новом массиве.

Console.Write("Введите размер массива: ");
int number=Convert.ToInt32(Console.ReadLine());

int [] mass=new int[number]; 
int [] array=new int[number]; 
 
Console.WriteLine("случайный массив:");

for (int i = 0; i < mass.Length; i++) 
{ 
    mass[i] = new Random().Next(1,10); 
    Console.Write(mass[i]+" "); 
}

Console.WriteLine("\n"+ "результат умножения:");

for (int j = 0, k = mass.Length-1; j < mass.Length/2; j++, k--)
{ 
    array[j]=mass[j] * mass[k]; 
    Console.WriteLine(array[j]); 
}