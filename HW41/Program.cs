// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

double[] InitArray (int LenArray) //Иннициализация массива вещественных чисел
{
    double[] arr = new double[LenArray];

    for (int i = 0; i < LenArray; i++)
    {
        arr[i] = double.Parse(InputTxt($"Введите {i+1} элемент массива: "));
    }

    return arr;
}

int CountValue (double[] arr)
{
    int CountNumber = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            CountNumber+=1;
        }
    }

    return CountNumber;

}


void PrintArray (double[] arr) //Вывод на экран массив вещественных чисел
{
    Console.Write ("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i<arr.Length-1)
        {
            Console.Write ($"{arr[i]}, ");
        }
        else
        {
            Console.Write ($"{arr[i]}]");
        }
    }
}

//---------------------------------------------------------------------------------------------------

int Len = int.Parse(InputTxt("Введите величину массива: "));

double[] ArrayNum = InitArray (Len);

int resCount = CountValue(ArrayNum);

string  strNumber = "";

if (resCount > 0 && resCount < 5)
{
    strNumber = "Числа";
}
else
{
    strNumber = "Чисел";
}


PrintArray (ArrayNum);

Console.Write ($" => {resCount} {strNumber} больше нуля");
