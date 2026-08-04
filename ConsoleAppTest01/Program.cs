// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//8-3

//作业1
int x;
int y;
Console.WriteLine("请输入第一个整数：");
string s1 = Console.ReadLine();
Console.WriteLine("请输入第二个整数：");
string s2 = Console.ReadLine();
x = int.Parse(s1);
y = int.Parse(s2);

int Add(int a, int b)
{
    int sum = 0;
    sum = a + b;
    return sum;

}
Console.WriteLine("俩个整数的和为：" + Add(x, y));


//作业2
double c;
int weishu = 3;
Console.WriteLine("请输入华氏度：");
string s3 = Console.ReadLine();
c = double.Parse(s3);
//摄氏度 = 5/9.0*(华氏度 - 32)保留3位小数）
double CelsiusConversion(double c)
{
    double x0 = 5 / 9.0 * (c - 32);
    double x = Math.Round(x0, weishu);
    return x;
}
Console.WriteLine("摄氏度：" + CelsiusConversion(c));



//作业3
Console.WriteLine("请输入要交换的两个整型值：");
string s4 = Console.ReadLine();
string s5 = Console.ReadLine();
int x1 = int.Parse(s4);
int y1 = int.Parse(s5);

void ChangeValues(int a, int b)
{
    int tmp;
    tmp = a;
    a = b;
    b = tmp;
    Console.WriteLine("{0},{1}", a, b);
}
ChangeValues(x1, y1);

//4
int hour;
Console.WriteLine("输入多少小时");
string s6 = Console.ReadLine();
hour = int.Parse(s6);
void Day_hour(int a)
{
    int d = a / 24;
    int h = a % 24;
    Console.WriteLine("{0}天,{1}小时", d, h);
}
Day_hour(hour);



/*int n = 10;
int res = n++ + ++n + n++ + ++n;//10+12+12+14
Console.WriteLine(res);
//Console.WriteLine(n++);
Console.WriteLine(n);*/


//8-5

//1
/*string useAdmin="admin";
string usePass="123456";
Console.WriteLine("请输入账号：");
string useAdmin_01=Console.ReadLine();
Console.WriteLine("请输入密码：");
string usePass_01=Console.ReadLine();
if (useAdmin_01==useAdmin&&usePass_01==usePass) {
    Console.WriteLine("登录成功");
}
else if(useAdmin_01!=useAdmin)
{
    Console.WriteLine("账号不存在");
}
else if(usePass_01!=usePass)
{
    Console.WriteLine("密码错误");
}*/


//2
/*Console.WriteLine("请选择菜单（add/edit/del）");
string caidan = Console.ReadLine();
switch (caidan)
{
    case "add":
        Console.WriteLine("新增成功");
        break;
    case "edit":
        Console.WriteLine("编辑成功");
        break;
    case "del":
        Console.WriteLine("删除成功");
        break;
}*/

//3


