

int sum = 0;    

for (int i = 0; i < 10; i++)//i-- = i - 1
{
    Console.WriteLine($"I = {i + 1}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum + = i;
}

Console.WriteLine($"Final total {sum}");