using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppTest9_2.Mysql
{
    
    internal class MySql
    {
        public string Server { get; set; }="127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Database { get; set; }
        public string Uid { get; set; } = "root";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";
        public string conStr { get; set; }

        public MySql(string database)
        {
            this.Database = database;
        }
        public async Task<bool> ConAndHandler(string sql,Func<MySqlCommand,bool>handlerCall)
        {
            conStr = $"server={Server};port={Port};database={Database};uid={Uid};password={Password};charset={Charset}";
            using(MySqlConnection conn=new MySqlConnection(conStr))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    return handlerCall(cmd);
                }
            }


        }






    }
}
