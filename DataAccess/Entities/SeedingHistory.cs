using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class SeedingHistory
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }

    }
}
