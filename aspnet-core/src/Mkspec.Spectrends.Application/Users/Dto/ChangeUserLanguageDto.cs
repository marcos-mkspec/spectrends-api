using System.ComponentModel.DataAnnotations;

namespace Mkspec.Spectrends.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}