using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppTest8_25
{
    internal class BookClass
    {
        
        public string uid { get; set; }
        public string bookName { get; set; }
        public string authorName { get; set; }
        public string price { get; set; }
        public string test { get; set; }
        public bool isBorrow { get; set; }=false;

        public BookClass(string uid,string bookName, string authorName, string price, string test)
        {
            this.uid = uid;
            this.bookName = bookName;
            this.authorName = authorName;
            this.price = price;
            this.test = test;
        }
    }
}
