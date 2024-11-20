using System;
using System.Collections.Generic;

namespace green_city_be.DOMAIN.Core.Entities;

public partial class Report
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public int? Type { get; set; }

    public string? Location { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Status { get; set; }

    public virtual ReportComment? ReportComment { get; set; }
}
