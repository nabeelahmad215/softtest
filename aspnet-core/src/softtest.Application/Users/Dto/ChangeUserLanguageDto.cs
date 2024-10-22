using System.ComponentModel.DataAnnotations;

namespace softtest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}