using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.AdminDtos
{
    public class AdminRegisterDto
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Password { get; init; }

        public string? District { get; init; }
        public string? City { get; init; }
        public string? ImageUrl { get; init; }


    }
}
