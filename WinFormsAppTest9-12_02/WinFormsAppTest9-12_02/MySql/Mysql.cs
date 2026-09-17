using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsAppTest9_12_02.MySql
{
    internal class Mysql
    {
        public string Ip { get; set; } = "127.0.0.1";
        public int Port { get; set; } = 3306;
        
        public string DataBase { get; set; }
        public string Uid { get; set; } = "root";
        public string Pwd { get; set; }= "root";

        private string ConStr = "";
        DataTable dt;

        public Mysql(string DataBase)
        {
            ConStr = $"server={Ip};port={Port};database={DataBase};uid={Uid};password={Pwd}";
        }

        //增删改
        public async Task<bool>  Hander(string sql)
        {
            using (var Com=new MySqlConnection(ConStr))
            {
                await Com.OpenAsync();
                using (var Cmd=new MySqlCommand(sql, Com))
                {
                    int row=await Cmd.ExecuteNonQueryAsync();
                    if (row>0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        //查
        public async Task<DataTable> Search(string sql)
        {
             dt=new DataTable();
            using (var Com = new MySqlConnection(ConStr))
            {
                await Com.OpenAsync();
                using (var Cmd = new MySqlCommand(sql, Com))
                {
                    //Cmd.ExecuteReader();
                    var ada=new MySqlDataAdapter(Cmd);
                    ada.Fill(dt);
                   
                }
            }
            return dt;
        }
        public async Task<bool> Search(string sql,string obj)
        {
           
            using (var Com = new MySqlConnection(ConStr))
            {
                await Com.OpenAsync();
                using (var Cmd = new MySqlCommand(sql, Com))
                {

                    MySqlDataReader reader = Cmd.ExecuteReader();
                    bool isrow = reader.Read();
                    if (isrow)
                    {
                        MessageBox.Show(obj + "已存在");
                        return false;
                    }
                    

                }
            }
            return true;
        }
    }
}
