// Example010 MethodArray
int [] array = {1,2,31,4,8,6,7,18};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    // или
    index++;
}