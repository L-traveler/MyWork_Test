using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppTest8_25
{
    public class Area
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int FatherId { get; set; }
        public Area(int Id, string Name, int FatherId)
        {
            this.Id = Id;
            this.Name = Name;
            this.FatherId = FatherId;
        }

    }
}
