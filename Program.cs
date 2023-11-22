// See https://aka.ms/new-console-template for more information
//Console.Write("Hello, World!");
Console.Write("Replay: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Начали абзац...");
int n=0;
while (n<a)
{
    Console.Write("пишем...");
    n+=1;
}
Console.WriteLine("закончили абзац.");
Console.Write("Начали абзац...");
while (n>0)
{
    Console.Write("пишем...");
    n-=1;
}
Console.WriteLine("закончили абзац.");
Console.Write("Новый абзац...");