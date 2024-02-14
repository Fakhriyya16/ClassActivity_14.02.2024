////First Task
string Temp(int temperature)
{
    if (temperature > 20)
    {
        return "Isti";
    }
    else if (temperature < 20)
    {
        return "Soyug";
    }
    else
    {
        return "Normal";
    }
}
Console.WriteLine("Temperature:");
int temperature = int.Parse(Console.ReadLine());

string result = Temp(temperature);

Console.WriteLine(result);




//// Second Task
int AmountOfNumbers(int a, int b)
{
    int count = 0;
    for (int i = a + 1; i < b; i++)
    {
        count++;
    }
    return count;
}
Console.WriteLine("Add input a:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Add input b:");
int b = int.Parse(Console.ReadLine());

int result1 = AmountOfNumbers(a, b);

Console.WriteLine(result1);



//////Third Task
int SumOfArrays(int[] nums1, int[] nums2)
{
    int sum = 0;
    foreach (int num in nums1)
    {
        sum += num;
    }
    foreach (int num in nums2)
    {
        sum += num;
    }
    return sum;
}

int[] nums1 = { 1, 2, 3, 4, 5 };
int[] nums2 = { 5, 6, 7, 8, 9 };

Console.WriteLine(SumOfArrays(nums1, nums2));



////// Forth Task
int Square(int m)
{
    int result = m * m;
    return result;
}

Console.WriteLine("Add input:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine(Square(m));



//////Fifth Task
int SumOfEvenNums(int x)
{
    int sum = 0;
    for (int i = 1; i < x; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    return sum;
}

Console.WriteLine("Add input:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfEvenNums(x));




