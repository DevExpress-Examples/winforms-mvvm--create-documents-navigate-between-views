using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSample.MVVM.Data {
    public class Order {
        [Required]
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Freight { get; set; }
    }
}
