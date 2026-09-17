using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsAppTest9_12_02.MySql
{
    internal static class MySqlHander
    {
        private static Mysql MyConn = new Mysql("test01");

        // 写入一条数据,返回布尔值
        //internal static async Task<bool> Add<T>(string table,T t)
        //{
        //    return await MyConn.Hander($"INSERT INTO {table}() VALUE()");
        //}

        // 查询所有
        internal static async Task<DataTable> SearchAll(string table)
        {
            return await MyConn.Search($"select * from {table} ");
        }

        internal static async Task<DataTable> SearchAll(string table, string col, string obj)
        {
            return await MyConn.Search($"select * from {table} where {col}='{obj}'");
        }

        internal static async Task<bool> SearchOne(string table,string col,string obj)
        {
            string sqlname = $"select * from {table} where {col}='{obj}'";
            return await MyConn.Search(sqlname, obj);
            
        }


    }
}
