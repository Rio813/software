internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("请输入一个大于100的整数：");
        string str = Console.ReadLine();
        Console.WriteLine($"该整数共有{str.Length}位");
        Console.Write("字符提取法：每一位的值分别为");
        int sum = 0;
        for(int i = 0; i < str.Length; i++)
        {
            Console.Write($"{str[i] - 48}, ");
            sum += str[i] - 48;
        }
        Console.Write($"这些位之和为{sum}");
        Console.WriteLine(); 
        Console.Write("整数提取法：每一位的值分别为");
        int num = int.Parse(str);
        List<int> intList = new List<int>();
        int nextNum = num;
        while(nextNum != 0)
        {
            int bit = nextNum % 10;
            intList.Add(bit);
            nextNum = nextNum / 10;
        }
        for(int i = intList.Count - 1; i >= 0; i--)
        {
            Console.Write($"{intList[i]}, ");
        }
        Console.Write($"这些位之和为{sum}");
        Console.WriteLine(); 
    }
}

