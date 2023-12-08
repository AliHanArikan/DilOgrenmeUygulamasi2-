using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class EnglishStoryValidator : AbstractValidator<EnglishStory>
    {
        public EnglishStoryValidator()
        {
            RuleFor(x => x.EnglishStoryName).NotEmpty();
            RuleFor(x => x.EnglishStoryDescription).NotEmpty();
            RuleFor(x => x.EnglishStoryImageUrl).NotEmpty();
            RuleFor(x => x.EnglishStoryDescription).MinimumLength(500).WithMessage("Lütfen Kısa Bir Hikaye Girmeyiniz... ");

        }
    }
}
