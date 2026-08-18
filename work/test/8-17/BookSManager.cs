using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleAppTest8_17
{
    internal class BookSManager
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Mark { get; set; }
        public double Price { get; set; }

        public string Path { get; set; }
        public JsonSerializerOptions JsonOpt { get; set; }

        public BookSManager(string path, JsonSerializerOptions JsonOpt)
        {
            this.Path = path;
            this.JsonOpt = JsonOpt;

        }

        
        //图书添加
        public string BookAdd(Dictionary<string, dynamic> bookdic)
        {
            List<Dictionary<string, dynamic>> bookList = new List<Dictionary<string, dynamic>>();
            if (File.Exists(Path))
            {

                var JsonStr = File.ReadAllText(Path);
                if (!string.IsNullOrEmpty(JsonStr) && !string.IsNullOrWhiteSpace(JsonStr))
                {
                    bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(JsonStr);

                    if (bookList.Count != 0)
                    {
                        if (bookList.Find(item =>item["图书名称"].ToString() == bookdic["图书名称"])!=null )
                        {
                            return "该图书已存在！！";
                        }
                    }

                    
                }
                

            }
            bookList.Add(bookdic);
            var newJsonStr = JsonSerializer.Serialize(bookList, JsonOpt);
            File.WriteAllText(Path, newJsonStr);


            return "添加成功";
        }

        //查找所有图书
        public string BookSelectAll()
        {
            if (File.Exists(Path))
            {
                
                var JsonStr = File.ReadAllText(Path);
                if (!string.IsNullOrEmpty(JsonStr) && !string.IsNullOrWhiteSpace(JsonStr)) {
                    var newJsonStr = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(JsonStr);

                    Console.WriteLine("目前所有图书有：");
                    foreach (var item in newJsonStr)
                    {
                        Console.WriteLine("图书名称: " + item["图书名称"].ToString()+" -- "+ "作者: " + item["作者"].ToString() + " -- " + "图书类型: " + item["图书类型"].ToString() + " -- " + "图书价格: " + item["图书价格"].ToString());
                        //foreach (var key in item)
                        //{
                        //    Console.WriteLine(key);
                        //}
                    }
                    if (newJsonStr.Count==0)
                    {
                        Console.WriteLine("图书仓库为空（目前没有任何图书，请添加）");
                    }
                    return "以上是所有图书";
                }
                    
                
                

            }
            return "图书仓库为空（目前没有任何图书，请添加）";

        }

        //按名字查找图书

        public string BookNameSelect(string selectBookName)
        {
            if (File.Exists(Path))
            {

                var JsonStr = File.ReadAllText(Path);
                if (!string.IsNullOrEmpty(JsonStr) && !string.IsNullOrWhiteSpace(JsonStr))
                {
                    var newJsonStr = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(JsonStr);
                    Console.WriteLine("查询该图书如下：");
                    foreach (var item in newJsonStr)
                    {
                        if (selectBookName == item["图书名称"].ToString())
                        {
                            Console.WriteLine("图书名称: " + item["图书名称"].ToString() + " -- " + "作者: " + item["作者"].ToString() + " -- " + "图书类型: " + item["图书类型"].ToString() + " -- " + "图书价格: " + item["图书价格"].ToString());
                            //foreach (var key in item)
                            //{
                            //    Console.WriteLine(key);

                            //}

                        }
                    }
                    return "以上是所查询的图书";
                }
            }
            return "目前没有该图书，请添加";

        }

        //删除图书
        public string BookNameRemove(string removebook)
        {
            if (File.Exists(Path))
            {

                var JsonStr = File.ReadAllText(Path);
                if (!string.IsNullOrEmpty(JsonStr) && !string.IsNullOrWhiteSpace(JsonStr))
                {
                    var newJsonStr = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(JsonStr);
                    //Console.WriteLine("查询该图书如下：");
                    foreach (var item in newJsonStr)
                    {
                        if (removebook == item["图书名称"].ToString())
                        {
                            newJsonStr.Remove(item);

                            var newJsonStr1 = JsonSerializer.Serialize(newJsonStr, JsonOpt);
                            File.WriteAllText(Path, newJsonStr1);

                            return "删除成功"+ item["图书名称"].ToString();

                        }
                    }
                    
                }
            }

            return "删除失败";
        }

        //编辑图书
        public string WriteBook(string WritebookName)
        {
            if (File.Exists(Path))
            {

                var JsonStr = File.ReadAllText(Path);
                if (!string.IsNullOrEmpty(JsonStr) && !string.IsNullOrWhiteSpace(JsonStr))
                {
                    var newJsonStr = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(JsonStr);
                    Console.WriteLine("查询该图书如下：");
                    foreach (var item in newJsonStr)
                    {
                        if (WritebookName == item["图书名称"].ToString())
                        {
                            
                            Console.WriteLine("要修改什么（图书名称,作者,图书类型,图书价格）");
                            string input=Console.ReadLine();
                            Console.WriteLine("请输入你要将其改成什么：");
                            string input_change = Console.ReadLine();
                            switch (input)
                            {
                                case "图书名称":
                                    item["图书名称"] = input_change;
                                    break;
                                case "作者":
                                    item["作者"] = input_change;
                                    break;
                                case "图书类型":
                                    item["图书类型"] = input_change;
                                    break;
                                case "图书价格":
                                    item["图书价格"] = input_change;
                                    break;
                                default:
                                    Console.WriteLine("输入有误！");
                                    break;
                            }
                            var newJsonStr1 = JsonSerializer.Serialize(newJsonStr, JsonOpt);
                            File.WriteAllText(Path, newJsonStr1);



                        }
                    }
                    return "更改成功";
                }
            }


            return "更改失败";
        }


    }
}
