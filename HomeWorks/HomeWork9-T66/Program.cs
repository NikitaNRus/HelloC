// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите цифру Большую");
int numBig = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру Меньшую");
int numSmall = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummaRec(numBig, numSmall));

int SummaRec(int numBig, int numSmall)
{
    if (numBig==numSmall) return numSmall;
    return numBig + SummaRec(numBig-1,numSmall); 
}
