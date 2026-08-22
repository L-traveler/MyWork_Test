using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp8_20
{
    internal class RenRetManager
    {
        private string Path { get; } = "./rentreturn.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };


        //添加租车记录
        public void RentCar()
        {
            // 提示输入
            Console.WriteLine("请输入要租车的车辆id");
            int carid;
            int userid;
            if (!int.TryParse(Console.ReadLine(), out  carid))
            {
                Console.WriteLine("车辆id输入格式有误");
                return;
            }
            Console.WriteLine("请输入要租车的用户id");
            if (!int.TryParse(Console.ReadLine(), out userid))
            {
                Console.WriteLine("用户id输入格式有误");
                return;
            }
            // 实例化用户管理类,调用判断客户是否存在方法
            UserManager UM = new UserManager();
            if (!UM.IdSeachUser(userid))
            {
                Console.WriteLine("输入客户ID有误！！！");
                return;
            }

            // 实例化车辆管理类  调用 根据id修改车辆状态方法
            CarManager CM = new CarManager();
            var (resStr, isUpdated) = CM.UpdateStatus(carid);
            //判断是否修改车辆成功
            if (!isUpdated)
            {
                Console.WriteLine(resStr);
                return;
            }
            // 修改状态成功--->此时已经租车成功，但是的 添加租车记录
            // 定义租车记录列表
            List<RenReturn> rrList = new();
            // 判断文件是否存在--->存在 读取文件， 反序列化， 并将列表赋值给 rrList
            if (File.Exists(this.Path))
            {
                string jsonStr = File.ReadAllText(this.Path);
                rrList = JsonSerializer.Deserialize<List<RenReturn>>(jsonStr);
            }

            // 创建租车记录对象--->将对象添加到 rrList中，序列化后的写入文件
            int id = rrList.Count == 0 ? 1 : rrList[rrList.Count - 1].Id + 1;
            string rentTime = DateTime.Now.ToString();
            RenReturn RR = new RenReturn(id, carid, userid, rentTime, "", 0);

            rrList.Add(RR);
            string jsonrrStr = JsonSerializer.Serialize(rrList, this.JsonOpt);
            File.WriteAllText(this.Path, jsonrrStr);

            Console.WriteLine(resStr);
        }

        //public void RenLog()
        //{
        //    List<RenReturn> renReturnList = new List<RenReturn>();
        //    var UM = new UserManager();
        //    var CM = new CarManager();
        //    //输入-判断文件存在{存在-读-反-判断是否有输入的两个id{有：添加（组装类）-序列化-写；不存在{添加-序列化-写
        //    Console.WriteLine("请输入要租车的车辆id");
        //    if (!int.TryParse(Console.ReadLine(), out int carId))
        //    {
        //        Console.WriteLine("车辆id输入格式有误");
        //        return;
        //    }
        //    Console.WriteLine("请输入要租车的用户id");
        //    if (!int.TryParse(Console.ReadLine(), out int userId))
        //    {
        //        Console.WriteLine("用户id输入格式有误");
        //        return;
        //    }
        //    if (File.Exists(this.Path))
        //    {
        //        var jsonStre = File.ReadAllText(this.Path);
        //        renReturnList = JsonSerializer.Deserialize<List<RenReturn>>(jsonStre);

        //        if (!UM.IdSeachUser(userId))
        //        {
        //            Console.WriteLine("用户id输入有误");
        //            return;
        //        }
        //        if (!CM.IdSeachCar(carId))
        //        {
        //            Console.WriteLine("车辆id输入有误");
        //            return;
        //        }

        //    }
        //    var RenReturnObj = new RenReturn(userId, carId, DateTime.Now.ToString(), "", 0);
        //    renReturnList.Add(RenReturnObj);
        //    var newJsonStr = JsonSerializer.Serialize(renReturnList, JsonOpt);
        //    File.WriteAllText(this.Path, newJsonStr);
        //    Console.WriteLine("租车成功");
        //    return;

        //}


        ////添加还车记录
        public void RetLog()
        {
            Console.WriteLine("请输入租车记录ID: ");
            int id;
            if (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("用户id输入格式有误");
                return;
            }
            // 判断文件是否存在---> 不存在 ----提示
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有租车信息！！！");
                return;
            }
            // 文件存在---->读取文件 -----> 反序列话====》 租车记录列表
            string jsonStr = File.ReadAllText(this.Path);
            List<RenReturn> rrList = JsonSerializer.Deserialize<List<RenReturn>>(jsonStr);
            // 根据id 在租车记录列表中查找记录对象
            RenReturn rrObj = rrList.Find(item => item.Id == id);
            // 找不到 ----> 提示
            if (rrObj == null)
            {
                Console.WriteLine("租车记录ID有误！！！");
                return;
            }
            // 如果 该租车记录 已经是 还车的 则 提示
            if (rrObj.RetTime != "")
            {
                Console.WriteLine("该车辆已还！！！");
                return;
            }

            // 找到了租车记录 则根据 车辆id 去获取 时租费， 并修改车辆的状态（改为空闲）
            //  在车辆管理类中添加方法实现 
            CarManager CM = new CarManager();
            double price = CM.UpAndGetInfo(rrObj.CarID);
            // 计算支付金额  归还时间（当前时间） - 租赁时间  结果转为小时数
            //   得到的小时数 * 车辆的时租费
            TimeSpan diff = DateTime.Now - DateTime.Parse(rrObj.RenTime);
            double payMoney = (double)diff.TotalHours * price;
            // 修改租车记录对象 -----》 将租车列表序列化 ---->写回文件
            rrObj.PayPrice = payMoney;
            rrObj.RetTime = DateTime.Now.ToString();

            string jsonrrStr = JsonSerializer.Serialize(rrList, this.JsonOpt);
            File.WriteAllText(this.Path, jsonrrStr);

            Console.WriteLine("***还车成功***");

        }


        // 查看所有租车记录 方法
        public void SearchAll()
        {
            // 判断文件是否存在---> 不存在 ----提示
            if (!File.Exists(this.Path))
            {
                Console.WriteLine("没有租车信息！！！");
                return;
            }
            // 文件存在---->读取文件 -----> 反序列话====》 租车记录列表
            string jsonStr = File.ReadAllText(this.Path);
            List<RenReturn> rrList = JsonSerializer.Deserialize<List<RenReturn>>(jsonStr);
            if (rrList.Count == 0)
            {
                Console.WriteLine("没有租车信息！！！");
                return;
            }
            // 遍历输出
            rrList.ForEach(item =>
            {
                Console.WriteLine($"租车记录ID: {item.Id} -- 车辆ID: {item.CarID} -- 客户ID: {item.UserID} -- 租赁时间: {item.RenTime} -- 还车时间: {item.RetTime} -- 费用: {item.PayPrice}");
            });

        }
    }
}
