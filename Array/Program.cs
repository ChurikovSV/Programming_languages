using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 15;
int c1 = 15;

int a2 = 56;
int b2 = 15;
int c2 = 33;

int a3 = 111;
int b3 = 1435;
int c3 = 22;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);