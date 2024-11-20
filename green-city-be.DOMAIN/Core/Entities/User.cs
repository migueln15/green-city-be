using System;
using System.Collections.Generic;

namespace green_city_be.DOMAIN.Core.Entities;

public partial class User
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public bool? IsActive { get; set; }

    public string? Type { get; set; }
}
