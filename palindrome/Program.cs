// может ли слово стать палиндромом?
// количество отличных от повторяющихся символов не более одного


Console.WriteLine("Введите слово: ");
string word = Console.ReadLine().ToLower()!;
// char[] array = new char[word.Length];
// for (int i = 0; i < word.Length; i++) 
// { 
// array[i] = word[i];
// }
int j = 0;
int n = word.Length;
int count = 0;
while (j < n)
{if (word[j]==word[n-j-1])
{
    count++;
    j++;
        if (count == n)
{Console.WriteLine($"Слово <{word}> является палиндромом");}
}
    else
{Console.WriteLine($"Слово <{word}> не является палиндромом");
    break;}}
