using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;

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
                Console.WriteLine("6: 图书借阅");
                Console.WriteLine("7: 图书归还");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        //新增

                        Console.WriteLine("--新增图书--");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine().Trim();

                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine().Trim();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine().Trim();
                        Console.WriteLine("请输入价格");
                        //double price = double.Parse(Console.ReadLine());
                        string priceStr = Console.ReadLine().Trim();
                        //价格的正则：@"[1-9]+[0-9]*(\.[0-9]+)?"
                        if (Regex.IsMatch(priceStr, @"^[1-9]+[0-9]*(\.[0-9]+)?$") && !string.IsNullOrEmpty(bookName) && !string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(mark))
                        {
                            Dictionary<string, dynamic> bookdic = new Dictionary<string, dynamic>()
                            {
                                ["图书名称"] = bookName,
                                ["作者"] = author,
                                ["是否外借"] = false,
                                ["id"] = new Random().NextDouble(),
                                ["图书类型"] = mark,
                                ["图书价格"] = double.Parse(priceStr)

                            };
                            var res1 = BM.BookAdd(bookdic);
                            Console.WriteLine(res1);
                        }
                        else
                        {
                            Console.WriteLine("输入内容的格式不对");
                        }


                        break;
                    case "2":
                        //编辑

                        Console.WriteLine("--编辑图书--");
                        Console.WriteLine("请输入要编辑的书名：");

                        string WritebookName = Console.ReadLine().Trim();
                        if (!string.IsNullOrEmpty(WritebookName))
                        {
                            var res2 = BM.WriteBook(WritebookName);
                            Console.WriteLine(res2);
                        }
                        else
                        {
                            Console.WriteLine("输入内容的格式不对");
                        }



                        break;
                    case "3":
                        //删除
                        Console.WriteLine("--删除图书--");
                        Console.WriteLine("--查询单个图书--");
                        Console.WriteLine("请输入要删除的图书的名字：");

                        string removebook = Console.ReadLine().Trim();
                        if (!string.IsNullOrEmpty(removebook))
                        {
                            var res3 = BM.BookNameRemove(removebook);
                            Console.WriteLine(res3);
                        }
                        else
                        {
                            Console.WriteLine("输入内容的格式不对");
                        }


                        break;
                    case "4":
                        //查询所有

                        Console.WriteLine("--查询所有图书--");
                        var res4 = BM.BookSelectAll();
                        Console.WriteLine(res4);

                        break;
                    case "5":
                        //查询单个

                        Console.WriteLine("--查询单个图书--");
                        Console.WriteLine("请输入要查询图书的名字：");

                        string selectBookName = Console.ReadLine().Trim();
                        if (!string.IsNullOrEmpty(selectBookName))
                        {
                            var res5 = BM.BookNameSelect(selectBookName);
                            Console.WriteLine(res5);
                        }
                        else
                        {
                            Console.WriteLine("输入内容的格式不对");
                        }

                        break;
                    case "6":
                        //外借

                        Console.WriteLine("--查询所有可外借的图书--");
                        var res6 = BM.BookBorrow();
                        Console.WriteLine(res6);
                        Console.WriteLine("请输入要借阅书籍的名称");
                        string borrowBookName = Console.ReadLine().Trim();
                        if (!string.IsNullOrEmpty(borrowBookName))
                        {
                            res6 = BM.BookBorrow(borrowBookName);
                            Console.WriteLine(res6);
                        }
                        else
                        {
                            Console.WriteLine("输入内容的格式不对");
                        }


                        break;
                    case "7":
                        //外借


                        Console.WriteLine("请输入要归还书籍的名称");
                        string backBookName = Console.ReadLine().Trim();
                        if (!string.IsNullOrEmpty(backBookName))
                        {
                            var res7 = BM.BookBack(backBookName);
                            Console.WriteLine(res7);
                        }
                        else
                        {
                            Console.WriteLine("输入内容的格式不对");
                        }


                        break;
                    case "0":
                        //退出

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
