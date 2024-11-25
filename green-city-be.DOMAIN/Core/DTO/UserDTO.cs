using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_city_be.DOMAIN.Core.DTO
{
    public class UserDTO
    {
    }

    public class UserAuthDTO
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class UserAddDTO
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Type { get; set; }
    }

    public class UserResponseAuthDTO
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Type { get; set; }
        public string? Token { get; set; }



    }
}
