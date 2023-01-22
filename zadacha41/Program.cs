// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int[] FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        array[i] = A;
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum+=1;
        }
    }
    return sum;
}

Console.WriteLine("Какое количество чисел вы хотите ввести?: ");
int AllNumbers = Convert.ToInt32(Console.ReadLine());

int[] array = new int[AllNumbers];
array = FillArray(array);
Console.Write("Вы ввели : ");
Console.WriteLine(string.Join(", ", array));
Console.Write($"Из них {PositiveNumbers(array)} положительных!!! ");

