using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        
        public Bike(string color , int id, string type, int yearOfProd, int batch) : base(id, type, yearOfProd, batch)
        {
            Color = color;
        }
    }
}
