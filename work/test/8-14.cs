// 作业:  使用读写文件配合命令行窗口  模拟实现注册功能
// 要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)
Action WriteLog = () =>
{
    Console.WriteLine("请输入用户名");
    var username = Console.ReadLine();
    Console.WriteLine("请输入密码");
    var password = Console.ReadLine();
    var str = username + "===" + password + "\n";
    // 写入文件
    File.AppendAllText("user.txt", str);
    Console.WriteLine("注册成功");
};
WriteLog();


//2
// 定义变量
string num = ""; // 输入的指令
string userReg = @"^[a-zA-Z][a-zA-Z0-9]{3,14}$";
string pwdReg = @"^\S{4,12}$";
string path = "./user.json";
var JsonOpt = new JsonSerializerOptions
{
    WriteIndented = true,
    AllowTrailingCommas = true,
};

// 定义的函数
// 用户注册函数
Func<string, string, string> register = (userName, pwd) =>
{
    // 正则校验用户名和密码
    if (!Regex.IsMatch(userName, userReg) || !Regex.IsMatch(pwd, pwdReg)) return "用户名或密码格式错误!";

    List<Dictionary<string, dynamic>> userList = new();
    //组装用户信息字典
    Dictionary<string, dynamic> userDic = new Dictionary<string, dynamic>()
    {
        ["username"] = userName,
        ["password"] = pwd,
        ["dateTime"] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
    };

    // 判断文件是否存在
    if (File.Exists(path))
    {
        // 判断文件是否存在====>存在读取文件内容
        //  反序列化转为List列表 ===> 组装用户信息字典
        //  判断用户名是否已经注册===>如果注册过则返回信息
        //  未注册===>将用户字典添加到List列表中
        //  序列化List列表  =====> 写会回(覆盖)
        var jsonStr = File.ReadAllText(path);
        userList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);
        // 判断用户名是否已经注册
        bool isRegister = userList.Exists(item => item["username"].ToString() == userName); // **
        if (isRegister) return "用户已经存在!!!";


    }
    // 添加到list
    userList.Add(userDic);
    var newJsonStr = JsonSerializer.Serialize(userList, JsonOpt);
    // 写入文件
    File.WriteAllText(path, newJsonStr);

    return "注册成功";
};

while (num != "0")
{
    // 提示信息
    Console.WriteLine("=====欢迎来到用户管理=====");
    Console.WriteLine("1: 用户注册");
    Console.WriteLine("2: 用户登录");
    Console.WriteLine("0: 退出");
    num = Console.ReadLine();
    switch (num)
    {
        case "1":
            Console.WriteLine("--用户注册--");
            Console.WriteLine("请输入用户名(4~15)");
            var username = Console.ReadLine();
            Console.WriteLine("请输入密码(4~12)");
            var password = Console.ReadLine();
            string resStr = register(username, password);
            Console.WriteLine(resStr);
            break;
        case "2":
            Console.WriteLine("--用户登录--");
            break;
        case "0":
            Console.WriteLine("--退出--");
            break;
        default:
            Console.WriteLine("输入有误");
            break;
    }
}