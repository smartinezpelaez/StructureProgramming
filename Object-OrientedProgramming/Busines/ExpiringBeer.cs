using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_OrientedProgramming.Busines
{
    public class ExpiringBeer: Beer
    {
        public DateTime Expriration { get; set; }
        public ExpiringBeer(string name, decimal price, decimal alcohol,
            DateTime expiration, int quantity)
            : base(name,price, alcohol, quantity)
        {
            Expriration = expiration;
            var p = Price;
        }

        public override string GetInfo()
        {
            return "Cervesa con caducidad : " + Name + ", "+ 
                "precio $ " + Price + ", Alcohol: " + Alcohol +
                ", Caducidad: " + Expriration.Date.ToString();
        }
    }
}
