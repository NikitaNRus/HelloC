// прога принимает три числа и проверяет может ли существовать треугольник со сторонами такой длины
// Каждая сторона треугольника меньше суммы двух других сторон
// Вывести периметр, площадь, значение углов в градусах, является ли он равнобедренным, прямоугольным, равносторонним

Console.WriteLine("Введите число первой стороны 1");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число первой стороны 2");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число первой стороны 3");
int C = Convert.ToInt32(Console.ReadLine());

bool Triangular (int A, int B, int C)
{
    if (A<(B+C)&&B<(A+C)&&C<(A+B)) return true;
    else return false;
}

void Angle (int A, int B, int C)
{   
    
        double FirstAngle = Math.Acos((Math.Pow(A,2)+Math.Pow(C,2)-Math.Pow(B,2))/(2*A*C));
        double SecondAngle = Math.Acos((Math.Pow(A,2)-Math.Pow(C,2)+Math.Pow(B,2))/(2*A*B));
        double ThirdAngle = Math.Acos((-Math.Pow(A,2)+Math.Pow(C,2)+Math.Pow(B,2))/(2*C*B));
        double Angle1 = Math.Round(FirstAngle*180/Math.PI,2);
        double Angle2 = Math.Round(SecondAngle*180/Math.PI,2);
        double Angle3 = Math.Round(ThirdAngle*180/Math.PI,2);

        Console.WriteLine($"Первая сторона треугольника равна {Angle1.ToString()}");
        Console.WriteLine($"Вторая сторона треугольника равна {Angle2.ToString()}");
        Console.WriteLine($"Третья сторона треугольника равна {Angle3.ToString()}");
}

int Perimetr (int A, int B, int C)
{
    int perimetr = A+B+C;
    return perimetr;
}

Console.WriteLine($"Данная фигура может быть треугольником? - {Triangular(A,B,C)}");
if (Triangular(A,B,C)==true)
{
Console.WriteLine($"Углы данного треугольника равны:");
Angle(A, B, C);
Console.WriteLine($"Периметр данного треугольника равен:{Perimetr(A,B,C)}");
}
else Console.WriteLine("Эти стороны не могут составлять треугольник");

// прога преобразовывает десятичное число в двоичное

// int ConvertToBinary(int N)
// {
//     string binary=string.Empty;
//     while (N!=0)
//     {
//         binary = N%2+binary;
//         N/=2;
//     }
//     return Convert.ToInt32(binary);
// }

// Console.WriteLine("Введите десятичное число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"В двоичном виде число {N} = {ConvertToBinary(N)}");