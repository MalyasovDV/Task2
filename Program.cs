int Compare (int a,int b)
{
    int max;

    if (a > b)
        max = a;
    else
        max = b;
    
    return max;
}

a = 7;
b = 2;

Console.Writeline(Compare(a,b));

