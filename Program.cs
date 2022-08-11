int Compare (int a,int b)
{
    int max;

    if (a > b)
        max = a;
    else
        max = b;
    
    return max;
}

int a = 7;
int b = 2;

Console.Writeline(Compare(a,b));

