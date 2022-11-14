using static System.Console;

Clear();

WriteLine("Введите слова (строки), разделяя их пробелами и(или) запятыми");
string originalArray = Console.ReadLine();
char[] separators = new char[] { ' ', ',' };
string[] newArray = originalArray.Split(separators, StringSplitOptions.RemoveEmptyEntries);
WriteLine("Введите максимальную длину слов:");
int maxLength = int.Parse(Console.ReadLine());
string[] finalArray = FilterArray(newArray, maxLength);

WriteLine();

WriteLine($"Данные обработаны. Выводим строки, удовлетворяющие заданному условию (длина строки <= {maxLength}):");

foreach (string line in finalArray)
{
    Write($"{line}\t");
}

WriteLine();








// Метод для создания нового массива по заданному условию
string[] FilterArray(string[] array, int maxLength)
{
    int count = 0;
    // считаем количество элементов будущего массива
    for (int i = 0; i < array.Count(); i++)
    {
        if (array[i].Length <= maxLength) count++;
    }
    
    string[] array2 = new string[count];
    count = 0; 

    // заполняем массив нужными элементами
    for (int i = 0; i < array.Count(); i++)
    {
        if (array[i].Length <= maxLength)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}