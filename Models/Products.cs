using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchool.MvcSolution.OnlineStore.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
    }
}
