using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppTest9_12_02.Class
{
    internal class RenRet
    {
      
        public int car_id { get; set; }
        public int user_id { get; set; }
       
        public DateTime rent_time { get; set; }
        public DateTime return_time { get; set; }
        
        public decimal pay_money { get; set; }

        public RenRet(int car_id, int user_id, DateTime rent_time, DateTime return_time, decimal pay_money)
        {
           this.car_id = car_id;
            this.user_id = user_id;
            this.rent_time = rent_time;
            this.return_time = return_time;
            this.pay_money = pay_money;



        }
    }
}
