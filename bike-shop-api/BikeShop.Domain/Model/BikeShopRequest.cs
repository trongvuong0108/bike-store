using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Domain.Model
{
    public class BikeShopRequest<T>
    {
        public T dataObject { get; set; }
    }
}
