// int i = 1;
// while (i <= 100);
// {
//     if (i % 3 == 0)
//     { Console.Write("Fizz"); }
//     if (i % 5 == 0)
//     { Console.Write("Buzz"); }
//     if (i % 3 == 0 & i % 5 == 0)
//     { Console.Write("FizzBuzz"); }
//     else
//     {
//         Console.Write(i);
//     }
//     i++;
// }


for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 & i % 5 == 0)
    { Console.Write(" FizzBuzz "); }
    else if (i % 3 == 0)
    { Console.Write(" Fizz "); }
    else if (i % 5 == 0)
    { Console.Write(" Buzz "); }
    else { Console.Write(" " + i); }
}
