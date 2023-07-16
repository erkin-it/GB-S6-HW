// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

string InputTxt (string TxtSrting) // Модуль приглашения для ввода данных в виде текста с клавиатуры
{
    Console.Write (TxtSrting);
    return Console.ReadLine();
}

// Решение методом Крамера

double Determinant (double a1, double a2, double a3, double a4)
{
    return (a1 * a4) - (a2 * a3);
}


double[] Kramer(double a11, double a12, double b1, double a21, double a22, double b2)
{
    double[] x = new double[2];
    x[0] = Determinant(b1,a12,b2,a22)/ Determinant(a11,a12,a21,a22);
    x[1] = Determinant(a11,b1,a21,b2)/Determinant(a11,a12,a21,a22);
    return x;
}

//-----------------------------------------------------------------------------------------

Console.WriteLine ("Для двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");

int B1 = int.Parse(InputTxt("Введите величину b1: "));
int K1 = int.Parse(InputTxt("Введите величину к1: "));
int B2 = int.Parse(InputTxt("Введите величину b2: "));
int K2 = int.Parse(InputTxt("Введите величину к2: "));

if (K1 == K2) 
{
    Console.WriteLine("Прямые линии паралельны");
}
else
{
    double[] P = Kramer(-K1,1,B1,-K2,1,B2);

    Console.WriteLine($"Координаты точки пересечения [{P[0]};{P[1]}]");

}