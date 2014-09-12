using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    class SpecialEvent
    {
        #region Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual SpecialEvent SpecialEvent { get; set; }
        #endregion
    }
}
