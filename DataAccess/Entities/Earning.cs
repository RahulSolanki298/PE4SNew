using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{

    [Index(nameof(EarnerId))]
    [Index(nameof(SourceUserId))]
    [Index(nameof(Level))]

    public class Earning
    {
        public int Id { get; set; }

        public string? EarnerId { get; set; }

        public string? SourceUserId { get; set; }

        public int Level { get; set; }

        public DateTime EarnedDate { get; set; } = DateTime.UtcNow;

        public string Path { get; set; }
        
    }

}
