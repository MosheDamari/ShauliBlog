using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShauliBlog.Models
{
    public class FanClubModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Bday { get; set; }
        public int gender { get; set; }
        public int joinYear { get; set; }
        
    }

}