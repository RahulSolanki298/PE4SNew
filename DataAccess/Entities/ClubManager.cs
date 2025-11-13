using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ClubManager
    {
        public int Id { get; set; }

        public string? ClubName { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }

        public decimal? Price { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDefault { get; set; }


        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public int? Step { get; set; } = 0;


    }
}
