using System.ComponentModel.DataAnnotations;

namespace Bicisim.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}