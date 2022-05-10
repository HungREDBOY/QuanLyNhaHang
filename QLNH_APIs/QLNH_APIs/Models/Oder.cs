using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Models
{
    public class Oder
    {
        [Key]
        public int Id { get; set; }
        public string OderNumber { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public bool Voided { get; set; }
        public double Totalprice { get; set; }
        public double PaidAmount { get; set; }
        public virtual IList<OderItem> OderItem { get; set; }

    }
}
