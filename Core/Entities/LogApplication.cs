using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class LogApplication : BaseEntity
    {
        public string detail { get; set; }
        public string title { get; set; }
        public HttpStatusCode status { get; set; }
        public DateTime logDate { get; set; }
    }
}
