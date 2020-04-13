using System.ComponentModel.DataAnnotations;

namespace Mkspec.SpectrendsApi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}