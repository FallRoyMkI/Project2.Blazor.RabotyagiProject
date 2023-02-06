using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotyagiProject.Bll.Models
{
    public class OrderServiceWorkerOutputModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ServiceId { get; set; }
        public int? WorkerId { get; set; }
        public int Workload { get; set; }
    }
}
