int [] array = {12,23,3,4,5,6,7,8,9,10,11,12,15,65};
int n = array.Length;
int find = 12;

int index =0;

while (index <n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1; // Или index++ 
}
