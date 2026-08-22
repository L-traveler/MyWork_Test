using System;

namespace ConsoleApp8_20
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string optNum = "";
            var CM = new CarManager();
            var UM = new UserManager();
            var RM = new RenRetManager();
            //提示
            while (optNum != "0")
            {
                Console.WriteLine("====================欢迎来到车辆租还系统====================");
                Console.WriteLine("1.添加车辆");
                Console.WriteLine("2.查看所有车辆信息");
                Console.WriteLine("3.根据ID查看车辆信息");
                Console.WriteLine("4.查看所有空闲车辆信息");
                Console.WriteLine("5.添加客户");
                Console.WriteLine("6.查看所有客户信息");
                Console.WriteLine("7.根据ID查看客户信息");
                Console.WriteLine("8.添加租车记录");
                Console.WriteLine("9.添加还车记录");
                Console.WriteLine("10.查看所有租车记录");
                Console.WriteLine("0.退出");
                Console.WriteLine("=============================================================");

                optNum = Console.ReadLine();




                switch (optNum)
                {
                    //添加车辆
                    case "1":
                        CM.CarAdd();

                        break;
                    //查看所有车辆信息
                    case "2":
                        CM.CarSeachAll();
                        break;
                    //根据ID查看车辆信息
                    case "3":
                        CM.CarIDSeach();
                        break;
                    //查看所有空闲车辆信息
                    case "4":
                        CM.CarFreeSeach();
                        break;
                    //添加客户
                    case "5":
                        UM.AddUser();
                        break;
                    //6.查看所有客户信息
                    case "6":
                        UM.SeachAllUser();
                        break;
                    //根据ID查看客户信息
                    case "7":
                        UM.IdSeachUser();
                        break;
                    //添加租车记录

                    case "8":
                        RM.RentCar();
                        break;
                    //添加还车记录

                    case "9":
                        RM.RetLog();
                        break;
                    //.查看所有租车记

                    case "10":
                        RM.SearchAll();
                        break;
                    //退出
                    case "0":
                        break;

                    default:
                        Console.WriteLine("输入格式有误！！！");
                        break;
                }

            }


        }
    }
}
