using Homweork02Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homweork02Domain.Interfaces
{
    public interface ICarWash
    {
        public void WashCar(Car car);

        public void WashTrailer(Truck truck);
    }
}
