using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH_APIs.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Prince { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Category Category { get; set; }
        public virtual IList<ItemImage> ItemImage { get; set; }
    }
}
