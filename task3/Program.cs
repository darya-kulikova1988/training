// найти наибольший общий делитель для 4-х произвольных чисел
// 15 и 18, общий делитель максимальный = 3


Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int c = Console.ReadLine()!;
// Console.WriteLine("Введите четвертое число: ");
// int d = Console.ReadLine()!;
int divider = 1;
int max = divider;
while (divider<=a | divider<=b)
    {
        if (a%divider==0 & b%divider==0)
        {
            if(divider>max) 
            {max = divider;}
                                    }
    divider++;
    }
    Console.WriteLine(max);