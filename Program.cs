// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равно 3 символам. 
// Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// ***Примеры:***
// ["hello","2","world",":-)"] -> ["2",":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine()!);

string[] arr1 = new string[size];

for (int i = 0; i < size; i++)
{
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine()!;
	arr1[i] = result;  
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", arr1));
Console.Write("]");

int count = 0;
int maxSymbols = 3;

for (int i = 0; i < arr1.Length; i++)
{
	if(arr1[i].Length <= maxSymbols) count++;   
}
Console.Write(" -> [");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if(arr1[i].Length <= maxSymbols)
    {
        if (i == 0)
        {
        arr2[j] = arr1[i];
        Console.Write (arr2[j]);
        j++;
        }
        else
        {
        arr2[j] = arr1[i];
        Console.Write (","+arr2[j]);
        j++;
        }
    }
}

Console.Write("]");