int Compare (int a,int b)
{
    int max;

    if (a > b)
        max = a;
    else
        max = b;
    
    return max;
}

int a = 5,b = 7;
Console.WriteLine(a + " and " + b + ':' + " max = " + Compare(a,b));

a = 2; b = 10;
Console.WriteLine(a + " and " + b + ':' + " max = " + Compare(a,b));

a = -9; b = -3;
Console.WriteLine(a + " and " + b + ':' + " max = " + Compare(a,b));
