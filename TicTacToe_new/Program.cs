using System;

string[,] array = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

bool win = false;
int line = 0;
int column = 0;
int step = 0;

void Instruction()
{
    Console.Clear();
    Console.WriteLine("Привет дорогой друг и будущий соперник ;-)");
    Console.WriteLine("мы начинаем играть в КРЕСТИКИ-НОЛИКИ.");
    Console.WriteLine("Ходим по очереди, первый играет Крестиками, второй Ноликами.");
    Console.WriteLine("После нажатия Enter/Return начнется игра");
    Console.WriteLine("и тебе нужно будет выбрать клетку в которую ты сделаешь ход.");
    Console.WriteLine();
    Console.WriteLine("Так как наша доска имеет размерность 3x3,");
    Console.WriteLine("то и каждая клетка имеет номер, состоящий из двух символов.");
    Console.WriteLine("Их тебе нужно будет набрать поочереди, между ними нажимая Enter/Return");
    Console.WriteLine("Номера клеток подписаны на доске.");
    Console.WriteLine();
    Console.WriteLine("Ну что же, начнем!");
    Console.WriteLine("ДЛЯ НАЧАЛА ИГРЫ НАЖМИТЕ ENTER/RETURN");
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
    Console.WriteLine($"\nЧтобы поставить {name} нужно ввести номер его клетки,");
    Console.WriteLine("Введите НОМЕР СТРОКИ, в которой расположена клетка и нажмите Enter/Return:");
    line = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите НОМЕР СТОЛБЦА, в котором расположена клетка и нажмите Enter/Return:");
    column = int.Parse(Console.ReadLine()!);
    if (line > 3 | line < 1 | column > 3 | column < 1) CheckDurak(name, C);
    else if (array[line - 1, column - 1] != " ") CheckDurak(name, C);
    step++;
    array[line - 1, column - 1] = C;
}
void Check(string C)
{
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
    Console.WriteLine("ДЛЯ ВВОДА НОВЫХ КООРДИНАТ НАЖМИТЕ ENTER/RETURN");
    Console.ReadKey();
    Desk(array);
    Step(name, C);
}


void ifWin(string name)
{
    if (win == true)
    {
        Console.WriteLine($"\nПобедили {name}! Поздравляю!!!");
    }
    else if (step == 9)
    {
        Console.WriteLine("\nНичья)) Победила дружба!!!");
    }
}

Instruction();
while (true)
{
    Desk(array);
    Step("КРЕСТИК", "X");
    Check("X");
    Desk(array);
    ifWin("КРЕСТИКИ");
    if (win == true || step == 9) break;
    Step("НОЛИК", "0");
    Check("0");
    Desk(array);
    ifWin("НОЛИКИ");
    if (win == true || step == 9) break;
}