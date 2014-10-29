using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKPIsDataLogger
{
    class Task
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CloseDate { get; set; }
        public Request Request { get; set; }
        public Admin AssignedAdmin { get; set; }
        public SLA SLA { get; set; }
    }

    class Request
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime DueDate { get; set; }
        public Service Service { get; set; }
    }

    class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Admin
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class SLA
    {
        public int ID { get; set; }
        public TimeSpan SLATime { get; set; }
    }
}
