int num = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while (num > 0)
{
    if (command == "Inc")
    {
        num++;
        command = Console.ReadLine();

    }
    if (command == "Dec")
    {
        num--;
        command = Console.ReadLine();

    }
    if (command == "End")
    {
        Console.WriteLine(num);
        break;
    }
}
