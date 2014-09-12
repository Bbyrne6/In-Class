using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    class Table
    {


        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
