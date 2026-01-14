int c = 0;

void Tambah(int a,int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

void Kurang(int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}
void Kali(int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}
void Bagi(int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

Tambah(5, 5);
Kurang(11, 10);
Tambah(20, 10);
Kali(9, 4);
Bagi(12, 3);
