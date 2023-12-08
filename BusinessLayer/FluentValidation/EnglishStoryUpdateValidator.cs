using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class EnglishStoryUpdateValidator : AbstractValidator<EnglishStoryDetails>
    {
        public EnglishStoryUpdateValidator()
        {
            RuleFor(x => x.EnglishStoryDetailsName).NotEmpty();
            RuleFor(x => x.EnglishStoryDetailsContent).NotEmpty();
            RuleFor(x => x.EnglishStoryImageUrl).NotEmpty();
            RuleFor(x => x.EnglishStoryDetailsContent).MinimumLength(500).WithMessage("Lütfen Kısa Bir Hikaye Girmeyiniz... ");
            
        }
    }
}
