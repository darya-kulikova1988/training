Console.WriteLine("Введите слово: ");
string word = Console.ReadLine()!;
char[] ch = new char[word.Length];
for (int i = 0; i < word.Length; i++) 
{ 
ch[i] = word[i];
}
int j = 0;
int n = word.Length;
int count = 0;
while (j < n)
{if (ch[j]==ch[n-j-1])
{
    count++;
    j++;
        if (count == n)
{Console.WriteLine(word + " является палиндромом");}
}
    else
{Console.WriteLine(word + " не является палиндромом");
    break;}}
