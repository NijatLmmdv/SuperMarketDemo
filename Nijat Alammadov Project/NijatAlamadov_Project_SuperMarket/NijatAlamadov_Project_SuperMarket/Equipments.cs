using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NijatAlamadov_Project_SuperMarket
{
    class Equipments :All
    {
        public Equipments(int ID, string Name, int Price, int Unit, string Type, int Expirationdate) : base(ID, Name, Price, Unit, Type, Expirationdate)
        {
        }
    }
}
