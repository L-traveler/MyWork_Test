using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8_20
{
    internal class UserManager
    {
        private string Path = "./user.json";
        private JsonSerializerOptions JsonOpt = new JsonSerializerOptions()
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping

        };
        //添加用户
        public void AddUser()
        {
            List<User> userlist = new List<User>();
            //输入提示-判断文件存在{存在-读-反（建list）-判断有无添加过{无-添加（组装类）-序列化-写-打印；有{打印存在；不存在{添加-序列化-写-打印
            Console.WriteLine("请输入姓名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入身份证号码");
            string userIdCard = Console.ReadLine();
            if (!Regex.IsMatch(userIdCard, @"^[1-9][0-9]{16}[Xx0-9]$"))
            {
                Console.WriteLine("身份证号输入有误！！");
                return;
            }
            Console.WriteLine("请输入性别");
            string userGender = Console.ReadLine();
            Console.WriteLine("请输入手机号");
            string userPhomeNum = Console.ReadLine();
            if (!Regex.IsMatch(userPhomeNum, @"^[1-9][0-9]{10}$"))
            {
                Console.WriteLine("手机号输入有误！！");
                return;
            }
            Console.WriteLine("请输入座右铭");
            string userMotto = Console.ReadLine();


            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                userlist = JsonSerializer.Deserialize<List<User>>(jsonStr);
                if (userlist.Exists(item => item.UserIDCard == userIdCard))
                {
                    Console.WriteLine("用户存在，添加失败！！");
                    return;
                }
            }
            int id = userlist.Count == 0 ? 1 : userlist[userlist.Count - 1].UserId + 1;
            string regTime = DateTime.Now.ToString();
            User userObj = new User(id, userName, userIdCard, regTime, userGender, userPhomeNum, userMotto);
            userlist.Add(userObj);
            var newJsonStr = JsonSerializer.Serialize(userlist, JsonOpt);
            File.WriteAllText(this.Path, newJsonStr);
            Console.WriteLine("添加成功");
            return;
        }

        //查看所有客户信息
        public void SeachAllUser()
        {
            //判断文件存在{存在-读-反-查找-打印；不存在{打印
            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                var userlist = JsonSerializer.Deserialize<List<User>>(jsonStr);
                if (!string.IsNullOrEmpty(userlist.ToString()))
                {
                    foreach (var item in userlist)
                    {
                        Console.WriteLine("id:" + item.UserId + " -- " +
                            "客户姓名：" + item.UserName + " -- " +
                            "身份证号：" + item.UserIDCard + " -- " +
                            "注册时间：" + item.RegTime + " -- " +
                            "性别：" + item.Gender + " -- " +
                            "手机号：" + item.PhoneNum + " -- " +
                            "座右铭：" + item.Motto);
                    }
                    return;
                }


            }
            Console.WriteLine("暂无用户信息，请添加");

        }


        //根据id查看单条用户信息

        public void IdSeachUser()
        {
            //输入id-判断文件存在{读-反--查找{存在：打印；。。打印
            Console.WriteLine("输入用户id");
            if (!int.TryParse(Console.ReadLine(), out int userId))
            {
                Console.WriteLine("用户id输入有误");
                return;
            }


            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                var userlist = JsonSerializer.Deserialize<List<User>>(jsonStr);

                var carObj = userlist.Find(item => item.UserId == userId);
                if (carObj!=null)
                {
                    Console.WriteLine("id:" + carObj.UserId + " -- " +
                    "客户姓名：" + carObj.UserName + " -- " +
                    "身份证号：" + carObj.UserIDCard + " -- " +
                    "注册时间：" + carObj.RegTime + " -- " +
                    "性别：" + carObj.Gender + " -- " +
                    "手机号：" + carObj.PhoneNum + " -- " +
                    "座右铭：" + carObj.Motto);

                    return;
                }
                
            }
            Console.WriteLine("没有该用户，查找失败");
        }


        //根据id查看用户是否存在
        public bool IdSeachUser(int id)
        {
            //判断文件存在{读-反-查找有误{有&不为空true
            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                var userlist = JsonSerializer.Deserialize<List<User>>(jsonStr);

                var carObj = userlist.Find(item => item.UserId == id);
                if (carObj != null)
                {
                    return true;
                }

            }
            Console.WriteLine("没有该用户，查找失败");
            return false;
        }


    }


}

