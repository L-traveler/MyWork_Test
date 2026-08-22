using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp8_20
{
    internal class CarManager
    {
        private string Path { get; } = "./car.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        //添加车辆
        public void CarAdd()
        {
            Console.WriteLine("请输入车牌号：");
            string carCard = Console.ReadLine();
            if (!Regex.IsMatch(carCard, @"^.{7}$"))
            {
                Console.WriteLine("车牌号格式不对");
                return;
            }
            Console.WriteLine("请输入车辆类型：");
            string carType = Console.ReadLine();
            if (!Regex.IsMatch(carType, @"^[\u4e00-\u9fa5]{2,3}$"))
            {
                Console.WriteLine("车辆类型格式不对，请输入2‑3个中文");
                return;
            }
            Console.WriteLine("请输入每小时费用：");
            if (!double.TryParse(Console.ReadLine(), out double carPrice))
            {
                Console.WriteLine("每小时费用输入有误");
                return;
            }

            //新建空list类型是Car类
            List<Car> cars = new List<Car>();

            //判断文件是否存在=》存在：读取-反序列化-添加(组装类：实例化)到空list-写入；  不存在-添加(组装类：实例化)到空list-写入
            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                cars = JsonSerializer.Deserialize<List<Car>>(jsonStr);
                if (cars.Exists(item => item.CarCard == carCard))
                {
                    Console.WriteLine("该车辆已添加，添加失败");
                    return;
                }
            }
            int carid = cars.Count == 0 ? 1 : cars[cars.Count - 1].CarId + 1;
            Car CM = new Car(carid, carCard, carType, true, carPrice);
            cars.Add(CM);
            var carJsonList = JsonSerializer.Serialize(cars, JsonOpt);
            File.WriteAllText(this.Path, carJsonList);
            Console.WriteLine("添加成功");


        }

        //查看所有车辆信息
        public void CarSeachAll()
        {
            List<Car> Carlist = new List<Car>();
            //判断文件存在》存在：读-反-遍历查；不存在：无；
            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                Carlist = JsonSerializer.Deserialize<List<Car>>(jsonStr);
                foreach (var item in Carlist)
                {
                    Console.WriteLine("id:" + item.CarId + "  --  " +
                        "车牌号：" + item.CarCard + "  --  " +
                        "车辆类型：" + item.CarType + "  --  " +
                        "车辆状态：" + item.CarStatus + "  --  " +
                        "每小时费用：" + item.CarHourPrice);


                }
                return;

            }
            Console.WriteLine("没有车辆信息，请先添加");
        }

        //根据id查看一辆车的信息
        public void CarIDSeach()
        {
            //判断文件存在》存在{读-反-输入ID 》判断ID存在{存在：查找id相同的车辆信息-打印  不存在{：打印；文件不存在-打印
            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                var carlist = JsonSerializer.Deserialize<List<Car>>(jsonStr);
                Console.WriteLine("请输入查找到车辆id:");
                if (!int.TryParse(Console.ReadLine(), out int carId))
                {
                    Console.WriteLine("id输入有误");
                    return;
                }
                Car carObj = carlist.Find(item => item.CarId == carId);
                if (carObj != null)
                {
                    Console.WriteLine("id:" + carObj.CarId +
                    "车牌号：" + carObj.CarCard +
                    "车辆类型：" + carObj.CarType +
                    "车辆状态：" + carObj.CarStatus +
                    "每小时费用：" + carObj.CarHourPrice);
                    return;
                }
            }
            Console.WriteLine("车辆不存在");
        }

        //查看所有空闲车辆
        public void CarFreeSeach()
        {
            //判断文件存在{存在：读-反-findall空闲车{找到-打印；找不到{打印；不存在{打印
            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                var carlist = JsonSerializer.Deserialize<List<Car>>(jsonStr);
                var carFreeList = carlist.FindAll(item => item.CarStatus == true);
                if (carFreeList != null)
                {
                    foreach (var item in carFreeList)
                    {
                        Console.WriteLine("id：" + item.CarId + "  --  " +
                            "车牌号：" + item.CarCard + "  --  " +
                            "车辆类型：" + item.CarType + "  --  " +
                            // "车辆状态：" + item.CarStatus "  --  "+
                            "每小时费用：" + item.CarHourPrice);

                    }
                    return;
                }

            }
            Console.WriteLine("没有空闲车辆");
        }

        //根据id查看车是否存在
        public (string, bool) UpdateStatus(int id)
        {
            // 不存在====》没有车辆信息，请先添加
            if (!File.Exists(this.Path)) return ("暂无车辆！！！", false);
            // 判断文件是否存在===存在，读取文件，反序列化 ===》根据id查找车辆对象===》找不到则提示
            string jsonStr = File.ReadAllText(this.Path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(jsonStr);
            // 使用列表的Find 实现查找
            Car carObj = cars.Find(item => item.CarId == id);
            if (carObj == null) return ("没有对应ID的车辆！！！", false);
            if (!carObj.CarStatus) return ("该车辆已被租出！！！", false);
            // 修改车辆状态
            carObj.CarStatus = false;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(cars, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);
            return ("租车成功！！！", true);
        }

        /*public bool IdSeachCar(int id)
        {
            
            if (File.Exists(this.Path))
            {
                var jsonStr = File.ReadAllText(this.Path);
                var carlist = JsonSerializer.Deserialize<List<Car>>(jsonStr);
                
                Car carObj = carlist.Find(item => item.CarId == id);
                if (carObj != null)
                {
                    if (carObj.CarStatus == true)
                    {
                        carObj.CarStatus = false;
                        var newJosnStr=JsonSerializer.Serialize(carlist,JsonOpt);
                        File.WriteAllText(this.Path,newJosnStr);
                        
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("该车已租出");
                        return false;
                    }
                 
                }
                if (carObj == null)
                {
                    Console.WriteLine("车辆不存在");
                    return false;
                }
            }
            Console.WriteLine("车辆不存在");
            return false;

        }*/



        // 修改状态并获取 时租费
        public double UpAndGetInfo(int id)
        {
            // 读文件---》 反序列化 ---》车辆列表 ---》根据id查找---》修改状态 并获取数据返回
            string jsonStr = File.ReadAllText(this.Path);
            List<Car> cars = JsonSerializer.Deserialize<List<Car>>(jsonStr);

            Car carObj = cars.Find(item => item.CarId == id);

            // 修改车辆状态
            carObj.CarStatus = true;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(cars, this.JsonOpt);
            File.WriteAllText(this.Path, resStr);

            return carObj.CarHourPrice;
        }

    }
}
