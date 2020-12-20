using System.ComponentModel.DataAnnotations;

namespace RAdminstration.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}