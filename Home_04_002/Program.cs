void SumNum(int Num)
{
    int sum = 0;
    
    while (Num%10 > 0)
    {
        int num1 = Num % 10;
        Num = Num / 10;
        sum = sum + num1;

    }
    Console.WriteLine(sum);
}
SumNum(6);
