// ����� ������� ����� ����� �� 1 �� N
// Console.WriteLine("������� �����");
// int num = Convert.ToInt32(Console.ReadLine());
// int Summa(int num)
// {
//     int sum = 0;
//     while (true)
//     {
//         if (num==0) break;
//         sum = sum+num;
//         num--;
//     }
//     return sum;
// }

// Console.WriteLine($"����� ����� ����� {SummaRec(num)}");


// int SummaRec(int Num)
// {
//     if (Num==0) return 0;
//     return Num+ SummaRec(Num-1); 
// }



// ������� �������� N. �������� ���������, ������� ������� ����� �� 1 �� N.

// Console.WriteLine("������� �����");
// int num = Convert.ToInt32(Console.ReadLine());

// string NumPrint (int num)
// {
//     if (num==1) return 
//     Convert.ToString(num);
//     return NumPrint(num-1) +" "+
//     Convert.ToString(num);
// }
// Console.WriteLine(NumPrint(num));


// ������� �������� M � N � �������� �������� � ���� ����������

// Console.WriteLine("������� ����� �������");
// int numBig = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("������� ����� �������");
// int numSmall = Convert.ToInt32(Console.ReadLine());



// string NumRec(int N, int M)
// {
//     if (N==M) return Convert.ToString(N);
//     return NumRec(N-1,M) + " " + Convert.ToString(N);
// }
// Console.WriteLine(NumRec(numBig,numSmall));

// �������� �����, ������� ��������� ����� � ������� ����� ��� ����
// Console.WriteLine("������� ����� �������");
// int numBig = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumDigits(numBig));

// int SumDigits (int numBig)
// {
//     if (numBig==0) return 0;
//     return numBig%10 + SumDigits(numBig/10);
// }

// ��������� ��� ����� � ���� �������� � ������� �������

Console.WriteLine("������� ����� �������");
int numPow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("������� ����� ���������");
int numCore = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"����� {numCore} � ������� {numPow} ����� {Power(numPow, numCore)}");

int Power(int numPow, int numCore)
{
    if (numPow==0) return 1;
    return numCore*Power(numPow-1,numCore);
}