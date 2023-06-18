int Prompt(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine()); 
    return a;
}
void PromptMass(int M)
{
    int count = 0;
    int[] a = new int[M];
    for (int i=0;i<M;i++)
    {
        Console.WriteLine($"Введите элемент под номером {i}:");
        int temp=Convert.ToInt32(Console.ReadLine());
        if (temp>0){count++;}
        a[i]=temp;
    }
    Console.WriteLine($"Всего чисел больше нуля {count}");


}
Console.Clear();
int M = Prompt("Введите М:");
PromptMass(M);