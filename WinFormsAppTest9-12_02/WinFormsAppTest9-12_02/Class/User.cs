using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppTest9_12_02.Class
{
    internal class User
    {
        public string  name { get; set; }
        public string  idCard { get; set; }
        public DateTime  reg_time { get; set; }
        public string gender { get; set; }
        public string tel { get; set; }
        public string motto { get; set; }

        public User(string name, string idCard, string gender, string tel, string motto)
        {
            this.name = name;
            this.idCard = idCard;
            //DateTime reg_time= DateTime.Now;
            this.gender = gender;
            this.tel = tel;
            this.motto = motto;
        }


    }
}
