using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Jobs : Base
    {
        public string Title { get; set; }
        public string Industry { get; set; }
        public string Summary { get; set; }
        public string Level { get; set; }
        public string Stack { get; set; }
        public List<Skills> Skills { get; set; }
    }
}
