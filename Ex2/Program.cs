int a = 44;
int b = 5;
int c = 78;
int max = 0; 
if (a > b)
{
max = a;
}
else
{
    max = b;
} 
if (c > max)
max = c;

Console.WriteLine(max);
