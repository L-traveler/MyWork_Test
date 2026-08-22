using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_20
{
    internal class ProClasses
    {
    }
    //车类
    public class Car
    {
        public int CarId { get; }
        public string CarCard { get; set; }
        public string CarType { get; set; }
        public bool CarStatus { get; set; }
        public double CarHourPrice { get; }

        public Car(int CarId, string CarCard, string CarType, bool CarStatus,double CarHourPrice)
        {
            this.CarId = CarId;
            this.CarCard = CarCard;
            this.CarType = CarType;
            this.CarStatus = CarStatus;

            this.CarHourPrice = CarHourPrice;
        }
    }

    //用户类
    public class User
    {
        public int UserId { get; }
        public string UserName { get; set; }
        public string UserIDCard { get; set; }
        public string RegTime {  get; }
        public string Gender { get; set; }
        public string PhoneNum { get; set; }
        public string Motto { get; set; }


        public User(int UserId, string UserName, string UserIDCard, string RegTime, string Gender, string PhoneNum, string Motto)
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.UserIDCard = UserIDCard;
            this.RegTime = RegTime;
            this.Gender = Gender;
            this.PhoneNum = PhoneNum;
            this.Motto = Motto;

        }
    }

    //租还记录类

    class RenReturn
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public int UserID { get; set; }
        public string RenTime { get; set; }
        public string RetTime { get; set; }
        public double PayPrice { get; set; }

        public RenReturn(int Id, int CarID, int UserID, string RenTime,string RetTime, double PayPrice)
        {
            this.Id = Id;
            this.CarID = CarID;
            this.UserID = UserID;
            this.RenTime = RenTime;
            this.RetTime = RetTime;
            this.PayPrice = PayPrice;
        }
    }
}
