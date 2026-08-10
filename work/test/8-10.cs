//8-10

//1

string str = "hello, I am 刘德华,your name is 黎明？";
string reg = @"[\u4e00-\u9fa5]{2,5}";
var res = Regex.Matches(str, reg);
foreach (var item in res) Console.WriteLine(item);


//2

string str = "abc  dd  ee  ff  gg  HH  h j k";
string reg = @"\s";
Console.WriteLine(Regex.Replace(str, reg, ""));

//3
string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
// 书写正则, 找到字符串中的身份证号及 出生年,月,日
string reg = @"(\d{6})(\d{4})(\d{2})(\d{2})((\d{3}[\dXx]))";

MatchCollection res = Regex.Matches(str, reg);

foreach (Match item in res)
{
    string idNum = item.Groups[0].Value;
    string year = item.Groups[2].Value;
    string month = item.Groups[3].Value;
    string day = item.Groups[4].Value;
    Console.WriteLine("身份证号:" + idNum + " 年:" + year + " 月:" + month + " 日:" + day);
}


//4

// 请输入密码（字母、数字、特殊符号）
//密码中可以有数字,字母,特殊符号;长度要求8~15 
//如果只有一种则 强度为弱
//如果只有两种则 强度为中
//如果两种都有则 强度为强
//验证密码长度是否符合,并输出密码强度

Console.WriteLine("请输入密码（字母、数字、特殊符号）");
string passWord = Console.ReadLine();

string reg1 = @"\d";
string reg2 = @"[A-Za-z]";
string reg3 = @"[^0-9A-Za-z]";

if (passWord == null || passWord.Length < 8 || passWord.Length > 15)
{
    Console.WriteLine("密码长度要求8~15个字符");
}
else
{
    int typeCount = 0;
    if (Regex.IsMatch(passWord, reg1)) typeCount++;
    if (Regex.IsMatch(passWord, reg2)) typeCount++;
    if (Regex.IsMatch(passWord, reg3)) typeCount++;
    string level;
    if (typeCount == 1)
    {
        level = "弱";
    }
    else
    if (typeCount == 2)
    {
        level = "中";
    }
    else
    {
        level = "强";

    }
    Console.WriteLine("密码合格，密码强度为" + level);
}