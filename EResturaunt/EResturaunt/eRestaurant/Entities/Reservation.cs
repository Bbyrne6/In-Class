using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Reservation
    {

        #region Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion

    }
}
