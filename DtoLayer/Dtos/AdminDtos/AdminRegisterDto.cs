using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.AdminDtos
{
    public class AdminRegisterDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? ImageUrl { get; set; }


    }
}
