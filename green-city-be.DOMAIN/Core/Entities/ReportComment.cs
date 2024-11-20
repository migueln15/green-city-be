using System;
using System.Collections.Generic;

namespace green_city_be.DOMAIN.Core.Entities;

public partial class ReportComment
{
    public int Id { get; set; }

    public int? ReportId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Report IdNavigation { get; set; } = null!;
}
