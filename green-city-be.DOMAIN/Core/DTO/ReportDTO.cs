using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_city_be.DOMAIN.Core.DTO
{
    public class ReportDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public string? Type { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
    }

    public class ReportAddDTO
    {
        public int? UserId { get; set; }
        public string? Title { get; set; }
        public string? Detail { get; set; }
        public string? Type { get; set; }
        public string? Location { get; set; }
    }

    public class ReportStatusDTO
    {
        public int Id { get; set; }
        public string? Status { get; set; }
    }
}
