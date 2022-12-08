using System;

string[,] array = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

bool win = false;
int line = 0;
int column = 0;
int step = 0;

void Instruction()
{
    Console.Clear();
    Console.WriteLine("ПРИВЕТ, МОЙ ДОРОГОЙ КРИВОРУК И БУДУЩИЙ СОПЕРНИК ;-)");
    Console.WriteLine("МЫ начинаем играть в КРЕСТИКИ-НОЛИКИ. И Я БУДУ ТЕБЯ РВАТЬ");
    Console.WriteLine("Ходим по очереди, первый играет КРЕСТАМИ, второй НУЛЯМИ.");
    Console.WriteLine("ЖМИ Enter и ПРЕБУДЕТ С НАМИ СИЛА");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("ВОТ МОИ ПРАВИЛА:");
    Console.WriteLine("Тебе нужно будет выбрать клетку, в которую ты сделаешь ход.");
    Console.WriteLine("Так как наша доска имеет размер 3x3,");
    Console.WriteLine("то и каждая клетка имеет номер, состоящий из двух номеров - НОМЕР СТРОКИ и НОМЕР СТОЛБЦА.");
    Console.WriteLine("Их тебе нужно будет набрать своими рученками поочередно, между ними нажимая Enter");
    Console.WriteLine("Номера клеток подписаны на доске.");
    Console.WriteLine();
    Console.WriteLine("НУ ЧТО, ПОНЕСЛОСЬ!");
    Console.WriteLine("ДЛЯ НАЧАЛА ИГРЫ ЖМИ УЖЕ НА КНОПКУ ENTER");
    Console.ReadKey();
}

void Desk(string[,] mass)
{
    Console.Clear();
    Console.WriteLine("    1      2      3  ");
    Console.WriteLine(" ____________________");
    Console.WriteLine("|      |      |      |");
    Console.WriteLine($"|  {array[0, 0]}   |  {array[0, 1]}   |  {array[0, 2]}   |  1");
    Console.WriteLine("|______|______|______|");
    Console.WriteLine("|      |      |      |");
    Console.WriteLine($"|  {array[1, 0]}   |  {array[1, 1]}   |  {array[1, 2]}   |  2");
    Console.WriteLine("|______|______|______|");
    Console.WriteLine("|      |      |      |");
    Console.WriteLine($"|  {array[2, 0]}   |  {array[2, 1]}   |  {array[2, 2]}   |  3");
    Console.WriteLine("|______|______|______|");
}


void Step(string name, string C)
{
    try
    {
        Console.WriteLine($"\nЧтобы поставить {name} нужно ввести номер его клетки,");
        Console.WriteLine("Вводи своими рученками НОМЕР СТРОКИ, в которой находится твоя клетка и жми Enter:");
        line = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Вводи НОМЕР СТОЛБЦА, в котором находится клетка и жми Enter:");
        column = int.Parse(Console.ReadLine()!);
    }
    catch
    {
        Console.WriteLine("НУ ТЫ И КРИВОРУК! СМОТРИ КУДА ЖМЕШЬ!");
    }
    finally
    {
        if (line > 3 | line < 1 | column > 3 | column < 1) CheckDurak(name, C);
        else if (array[line - 1, column - 1] != " ") CheckDurak(name, C);
        array[line - 1, column - 1] = C;
    }
}
void Check(string C)
{
    step++;
    if (array[0, 0] == C & array[0, 1] == C & array[0, 2] == C |
        array[1, 0] == C & array[1, 1] == C & array[1, 2] == C |
        array[2, 0] == C & array[2, 1] == C & array[2, 2] == C |
        array[0, 0] == C & array[1, 0] == C & array[2, 0] == C |
        array[0, 1] == C & array[1, 1] == C & array[2, 1] == C |
        array[0, 2] == C & array[1, 2] == C & array[2, 2] == C |
        array[0, 0] == C & array[1, 1] == C & array[2, 2] == C |
        array[2, 0] == C & array[1, 1] == C & array[0, 2] == C)
    {
        win = true;
    }
}

void CheckDurak(string name, string C)
{
    Console.WriteLine("Клетки с введенными координатами не существует или она занята");
    Console.WriteLine("ДЛЯ ВВОДА НОВЫХ КООРДИНАТ ЖМИ ENTER");
    Console.ReadKey();
    Desk(array);
    Step(name, C);
}


void ifWin(string name)
{
    if (win == true)
    {
        Console.WriteLine($"\nПОБЕДИЛИ {name}! МОЛОРИК!!!");
    }
    else if (step == 9)
    {
        Console.WriteLine("\nНИЧЬЯ)) ПОБЕДИЛА СИЛА ЗЕМЛИ!!!");
    }
}

Instruction();
while (true)
{
    Desk(array);
    Step("КРЕСТ", "X");
    Check("X");
    Desk(array);
    ifWin("КРЕСТы");
    if (win == true || step == 9) break;
    Step("НОЛь", "0");
    Check("0");
    Desk(array);
    ifWin("НУЛИ");
    if (win == true || step == 9) break;
}