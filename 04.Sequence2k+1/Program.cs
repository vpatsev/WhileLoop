int num = int.Parse(Console.ReadLine());
int firstNum = 1;
while(firstNum <= num)
{
    Console.WriteLine(firstNum);
    firstNum = firstNum * 2 + 1;
}