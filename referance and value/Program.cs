#region Ededin qarsisinda 3 yazilsin.
static void Number(int num)
{
    Console.WriteLine("- Her hansi bir eded yaz qarsisinda 3 yazdirim:");
    string numStr = Console.ReadLine();
    int num1 = Convert.ToInt32(numStr);

    for (int i = 1; i <= num1; i *= 10)
    {
        num = i;
    }
    if (num1 == 0)
    {
        int ress = 3 * 10;
        Console.WriteLine(ress);
        return;
    }
    num *= 10;
    int ress2 = 3 * num + num1;
    Console.WriteLine("- Abra Kadabra");
    Console.WriteLine(ress2);
}
Number(default);
    #endregion;

