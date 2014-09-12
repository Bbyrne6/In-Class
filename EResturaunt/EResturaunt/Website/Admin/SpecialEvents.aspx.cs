using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;// was added for key attribute 
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eRestaurant.Entities
{
    public class SpecialEvent
    {
        [Key] // identifies this property as mapping to a primary key
        public string EventCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}