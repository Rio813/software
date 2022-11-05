internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("请输入5个数（空格分隔）：");
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] intArr = new int[strArr.Length];
            List<int> intList = new List<int>();
            int num = 0, sum = 0; bool isNum = true;
            if (strArr.Length == 1) break;
            for (int i = 0; i < strArr.Length; i++)
            {
                isNum = int.TryParse(strArr[i], out num);
                if (isNum == false) break;
                intList.Add(int.Parse(strArr[i]));
            }
            if (isNum == false)
            {
                Console.WriteLine("输入有误，请重新输入");
                continue;
            }
            else
            {
                intList.Sort();
                Console.Write("正序：");
                foreach (int i in intList)
                {
                    Console.Write($"{i} ");
                    sum += i;
                }
                Console.WriteLine();
                Console.Write("逆序：");
                for (int i = strArr.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                decimal averageNum = (decimal)sum / (decimal)strArr.Length;
                averageNum = Math.Round(averageNum, 1);
                Console.WriteLine($"平均值：{averageNum}");
                Console.WriteLine($"最大值：{intList[strArr.Length - 1]}");
                break;
            }
        }


    }
}

