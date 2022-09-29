int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()?? "0");
    return number;
}
void PrintData(string msg, int value)
{
     Console.WriteLine(msg+value);
}
int PowAtoB(int a, int b)
{
int res = 1;
for (int i = 0; i<b; i++)
{
res = res*a;
}
return res;
}

int a = ReadData("Введите число А: ");
int b = ReadData("Введите число B: ");
int res = PowAtoB(a,b);
PrintData("Число А в натуральной степени В: ", res);