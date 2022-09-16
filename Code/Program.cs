    void GetArray(string[] arr)
    {
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write("Введите элемент массива: ");
    arr[i] = Console.ReadLine();
    }
    }

    void PrintArray(string[] arr)
    {

    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    }

    void GetNewArray(string[] newArr)
    {
    for (int i = 0; i < newArr.Length; i++)
    {
    if(newArr[i].Length <= 3 ) Console.Write($"{newArr[i]} ");
    }
    Console.WriteLine();
    }

    string[] array = new string [4];
    GetArray(array);
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    Console.WriteLine("Новый массив:");
    GetNewArray(array);


