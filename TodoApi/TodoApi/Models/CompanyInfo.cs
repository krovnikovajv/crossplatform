using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class CompanyInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CEO { get; set; }
        public string Country { get; set; }

        public ICollection<TodoItem> companies { get; set; }

        public int getCountOfComp()
        {
            return companies.Count;
        }
    }
}

