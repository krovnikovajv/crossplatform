using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Revenue { get; set; }
        public int ProductionVolume { get; set; }
        public int Turnover { get; set; }
        public bool Gas { get; set; }
        public bool Oil { get; set;}
        public bool IsHere { get; set; }
        public IEnumerable<TodoItem> CompID { get; set; }

    }
}
