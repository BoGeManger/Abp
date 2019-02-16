using System.ComponentModel.DataAnnotations;

namespace Abp.BG.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}