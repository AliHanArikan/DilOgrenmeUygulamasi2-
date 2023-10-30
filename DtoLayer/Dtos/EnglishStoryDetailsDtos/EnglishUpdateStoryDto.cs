using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.EnglishStoryDetailsDtos
{
    public class EnglishUpdateStoryDto
    {
        public string EnglishStoryName { get; set; }

        public string? EnglishStoryImageUrl { get; set; }
        public string EnglishStoryDescription { get; set; }
    }
}
