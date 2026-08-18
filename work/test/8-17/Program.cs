using System;
using System.Text.Json;

namespace ConsoleAppTest8_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BookSManager BM = new("./book.json", new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                WriteIndented = true,
            });

        string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("=====欢迎来到图书管理系统=====");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 编辑图书");
                Console.WriteLine("3: 删除图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("--新增图书--");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price = double.Parse(Console.ReadLine());
                        Dictionary<string, dynamic> bookdic = new Dictionary<string, dynamic>()
                        {
                            ["图书名称"] = bookName,
                            ["作者"] = author,
                            ["是否外借"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["图书类型"] = mark,
                            ["图书价格"] = price,

                        };
                        var res1=BM.BookAdd(bookdic);
                        Console.WriteLine(res1);

                        break;
                    case "2":
                        Console.WriteLine("--编辑图书--");
                        Console.WriteLine("请输入要编辑的书名：");
                        string WritebookName = Console.ReadLine();
                      var res2= BM.WriteBook(WritebookName);
                        Console.WriteLine(res2);


                        break;
                    case "3":
                        Console.WriteLine("--删除图书--");
                        Console.WriteLine("--查询单个图书--");
                        Console.WriteLine("请输入要删除的图书的名字：");
                        string removebook = Console.ReadLine();
                        var res3=BM.BookNameRemove(removebook);
                        Console.WriteLine(res3);

                        break;
                    case "4":
                        Console.WriteLine("--查询所有图书--");
                        var res4=BM.BookSelectAll();
                        Console.WriteLine(res4);

                        break;
                    case "5":
                        Console.WriteLine("--查询单个图书--");
                        Console.WriteLine("请输入要查询图书的名字：");
                        string selectBookName= Console.ReadLine();
                        var res5=BM.BookNameSelect(selectBookName);
                        Console.WriteLine(res5);
                        break;
                    case "0":
                        Console.WriteLine("--退出--");
                        break;
                    default:
                        Console.WriteLine("输入有误");
                        break;
                }
            }


        }
    }
}
