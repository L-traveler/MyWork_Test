using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace WinFormsAppTest8_25
{
    internal class MiddleWareClass
    {
        Dictionary<int,Action<object>> MsgBox = new Dictionary<int,Action<object>>();

        public void AddMes(int id,Action<object>data)
        {
            MsgBox.Add(id,data);
        }
        public void CallMes(int id,object data)
        {
            MsgBox[id].Invoke(data);
        }
        private MiddleWareClass() { }
        private static MiddleWareClass instance { get; set; }
        public static MiddleWareClass GetInstance()
        {
            if (instance==null)
            {
                instance=new MiddleWareClass();
            }
            return instance;
        }
    }
}
