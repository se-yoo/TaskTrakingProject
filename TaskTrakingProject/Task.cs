using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrakingProject
{
    public class Task
    {
        public int seq { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string rgstMemId { get; set; }
        public string chargeMemId { get; set; }
        public string chargeMemName { get; set; }
        public int status { get; set; }
        public string rgstDate { get; set; }
        public int updateRead { get; set; }
    }
}
