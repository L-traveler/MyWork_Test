using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppTest9_12_02.Class
{
    internal class Car
    {
        public string CarUid { get; set; }
        public string CarTp { get; set; }
        public bool Status { get; set; }//true为空闲
        public decimal Price { get; set; }
        public Car(string CarUid, string CarTp, bool Status, decimal Price)
        {
            this.CarUid = CarUid;
            this.CarTp = CarTp;
            this.Status = Status;
            this.Price = Price;
        }
    }
}
