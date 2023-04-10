class Program
{
    static void Main(string[] args)
    {
        // Ввод исходного массива строк
        Console.Write("Введите массив строк через пробел: ");
        string[] arr = Console.ReadLine().Split();

        // Формирование нового массива из строк, длина которых меньше или равна 3 символам
        string[] new_arr = new string[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                new_arr[j] = arr[i];
                j++;
            }
        }
       
        
        
    }
}