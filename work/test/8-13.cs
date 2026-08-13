
// 作业1

List<Dictionary<string, dynamic>> list1 = new() {
                new Dictionary<string, dynamic>(){
                    ["name"] = "zs",
                    ["age"] = 29,
                    ["isMan"] = true,
                    ["isSingle"] = true,
                    ["salary"] = 4200
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ls",
                    ["age"] = 20,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 3400
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "ww",
                    ["age"] = 19,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 6000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zl",
                    ["age"] = 14,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "sq",
                    ["age"] = 35,
                    ["isMan"] = true,
                    ["isSingle"] = false,
                    ["salary"] = 7000
                },
                new Dictionary<string, dynamic>(){
                    ["name"] = "zb",
                    ["age"] = 27,
                    ["isMan"] = false,
                    ["isSingle"] = true,
                    ["salary"] = 2900
                },
            };
//Find: 要求查找年龄小于20的


var name = list1.Find((item) =>
{
   return item["age"] < 20;
});
Console.WriteLine(name["name"]);


//FindLast: 要求查找年龄大于25的

var n = list1.FindLast((item) => item["age"] > 25);
Console.WriteLine(n["name"]);

//FindAll: 找出性别男的


var n1 = list1.FindAll((item) => item["isMan"] == true);
var opt = new JsonSerializerOptions()
{
    WriteIndented = true,
    AllowTrailingCommas = true,
};

Console.WriteLine(JsonSerializer.Serialize(n1, opt));

//FindIndex: 找出薪水大于5000

var n2 = list1.FindIndex((item) => item["salary"] > 5000);
Console.WriteLine(n2);

//FindLastIndex: 找出薪水小于3000

var n3 = list1.FindLastIndex((item) => item["salary"] < 3000);
Console.WriteLine(n3);

//Exists: 判断是否有薪水大于5000

var n4 = list1.Exists((item) => item["salary"] > 5000);
Console.WriteLine(n4);

//ForEach: 输出每个的 名字-年龄 - 薪水

 list1.ForEach((item) =>
{
    Console.WriteLine(string.Join("-", item["name"], item["age"], item["salary"]));
});

//ConvertAll: 映射得到一个所以薪水的list

var list2 = new List<dynamic>();

list2 = list1.ConvertAll((item) =>
{
    return item["salary"];

});
Console.WriteLine(JsonSerializer.Serialize(list2));

//TrueForAll: 判断是否都成年

bool iscn = list1.TrueForAll((item) =>
{
    return item["age"] > 18;
});
Console.WriteLine(iscn);


// 作业2:  封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数

//string str = "fkjsahfkfhhdshfksaf";
Console.WriteLine("请输入字符串：");
string input = Console.ReadLine();
Dictionary<string, int> dic(string str)
{

    Dictionary<string, int> dic1 = new Dictionary<string, int>();

    foreach (var item in str)
    {
        dic1.TryAdd(item.ToString(), GetCounts(item.ToString(), str));
    }


    return dic1;

}

int GetCounts(string s, string str)
{
    int n = 0;
    foreach (char s1 in str)
    {
        if (s == s1.ToString()) n++;
    }
    return n;
}

foreach (var item in dic(input))
{
    Console.WriteLine(item);
}