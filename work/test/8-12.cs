//1  装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？

Console.WriteLine("请输入圆的半径：");
double r;
try
{
    r = double.Parse(Console.ReadLine());
    Console.WriteLine("装修总价:" + GetZhuangXiu());
    Console.WriteLine("装修一半:" + GetZhuangXiu() / 2);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}

double GetYuanS(double r)
{
    double S = r * r * 3.14;
    return S;
}
double GetZhuangXiu()
{

    double price = GetYuanS(r) * 200;
    return price;
}

//2 计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。

string str = "sakfakeufshffsfgsagfds";
Console.WriteLine("请输入要统计次数的字符");
try
{
    string s = Console.ReadLine();
    if (s.Length == 1)
    {
        Console.WriteLine(GetCounts(s));
    }
    else
    {
        Console.WriteLine("输入的不是单个字符");
    }
}
catch (Exception)
{

    throw;
}

int GetCounts(string s)
{
    int n = 0;
    foreach (char s1 in str)
    {
        if (s == s1.ToString()) n++;
    }

    return n;
}

//3  计算一个整型数组中，最小值第一次出现的下标。
int[] arr = [10, 20, 5, 30, 50, 6, 7, 1, 1, 1,];

int GetMinIndex(int[] arr)
{
    int min = arr.Min();
    int minFirIndex = arr.ToList().IndexOf(min);
    return minFirIndex;
}
Console.WriteLine(GetMinIndex(arr));


//4  判断一个字符串是否为回文，返回布尔值类型。
string str = "abcdcba";

bool IsHuiWen(string str)
{
    if (str.Length % 2 != 0)
    {
        int x = 0;//计数
        int i = str.Length / 2 + 1;//中值
        for (int n = 0; n < i; n++)
        {
            if (str[n] == str[str.Length - 1 - n])
            {
                x++;
            }
            if (i == x)
            {
                Console.WriteLine("是回文");
                return true;
            }
        }
    }
    Console.WriteLine("不是回文");
    return false;
}
IsHuiWen(str);
