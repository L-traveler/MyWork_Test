//8-5


Login();
MenuSelect();
PayMoney();
JiJie();
JiSuanYunFei();
SelectVipLevel();
AutoShouHuoJi();
SpeedCW();
void Login()
{
    string useAdmin = "admin";
    string usePass = "123456";
    Console.WriteLine("请输入账号：");
    string useAdmin_01 = Console.ReadLine();
    Console.WriteLine("请输入密码：");
    string usePass_01 = Console.ReadLine();
    if (useAdmin_01 == useAdmin && usePass_01 == usePass)
    {
        Console.WriteLine("登录成功");
    }
    else if (useAdmin_01 != useAdmin)
    {
        Console.WriteLine("账号不存在");
    }
    else if (usePass_01 != usePass)
    {
        Console.WriteLine("密码错误");
    }
}



//2

void MenuSelect()
{
    Console.WriteLine("请选择菜单（add/edit/del）");
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
    }
}


//3

void PayMoney()
{
    Console.WriteLine("请输入自己的消费类型（VIP/USER）和消费金额");
    string p = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    double pay;
    if (p == "VIP")
    {
        if (price >= 1000)
        {
            pay = Math.Round(price * 0.9f, 1);
            Console.WriteLine("需要支付金额：" + pay);
        }
        else
            Console.WriteLine("需要支付金额：" + price);

    }
    else if (p == "USER")
    {
        if (price >= 2000)
        {
            pay = Math.Round(price * 0.95, 1);
            Console.WriteLine("需要支付金额：" + pay);
        }
        else
        {
            Console.WriteLine("需要支付金额：" + price);
        }
    }
    else
    {
        Console.WriteLine("消费类型输入错误！");
    }
}



//4

void JiJie()
{
    Console.WriteLine("请输入月份：");
    int m = int.Parse(Console.ReadLine());
    switch (m)
    {
        case 3:
        case 4:
        case 5:
            Console.WriteLine("春季");
            break;
        case 6:
        case 7:
        case 8:
            Console.WriteLine("夏季");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("秋季");
            break;
        case 12:
        case 1:
        case 2:
            Console.WriteLine("冬季");
            break;
        default:
            Console.WriteLine("月份输入不对");
            break;
    }
}



//5

void JiSuanYunFei()
{
    Console.WriteLine("请输入快递重量（KG）:");
    double g = double.Parse(Console.ReadLine());

    double price;
    if (g < 1)
    {
        price = 10;
        Console.WriteLine("快递费：" + price);
    }
    else if (g <= 5)
    {
        price = 20;
        Console.WriteLine("快递费：" + price);
    }
    else if (g > 5)
    {
        price = 50;
        Console.WriteLine("快递费：" + price);
    }
}


//6
void SelectVipLevel()
{
    Console.WriteLine("输入会员等级（3-5的整数）：");
    int level = int.Parse(Console.ReadLine());
    switch (level)
    {
        case 5:
            Console.WriteLine("终身免运费");
            break;
        case 4:
            Console.WriteLine("每月可领优惠卷");
            break;
        case 3:
            Console.WriteLine("购物打9折");
            break;
        default:
            Console.WriteLine("没有福利");
            break;

    }
}


//7
void AutoShouHuoJi()
{
    Console.WriteLine("输入商品编号：");
    int bianhao = int.Parse(Console.ReadLine());
    switch (bianhao)
    {
        case 1:
            Console.WriteLine("已购买可乐");
            break;

        case 2:
            Console.WriteLine("已购买雪碧");
            break;

        case 3:
            Console.WriteLine("已购买矿泉水");
            break;
        default:
            Console.WriteLine("无此商品");
            break;
    }
}


//8
void SpeedCW()
{
    Console.WriteLine("输入当前速度：");
    double speed = double.Parse(Console.ReadLine());
    if (speed > 0 && speed <= 30)
    {
        Console.WriteLine("低速通过");

    }
    else if (speed <= 60)
    {
        Console.WriteLine("中速通过");
    }
    else if (speed <= 100)
    {
        Console.WriteLine("高速通过");
    }
    else if (speed <= 120)
    {
        Console.WriteLine("超速通过");
    }
}

