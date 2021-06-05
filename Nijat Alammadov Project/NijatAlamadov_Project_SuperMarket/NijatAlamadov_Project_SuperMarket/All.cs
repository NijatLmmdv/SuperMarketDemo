using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NijatAlamadov_Project_SuperMarket
{
    class All
    {
          

        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Unit { get; set; }
        public string Type { get; set; }
        public int Expirationdate { get; set; }
        public All(int ID, string Name, int Price, int Unit, string Type, int Expirationdate)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.Unit = Unit;
            this.Type = Type;
            this.Expirationdate = Expirationdate;
        }
    }
}
