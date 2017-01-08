using System.ComponentModel.DataAnnotations;

namespace sdvcWebapp.DataTransferObjects
{
    public class KeywordDto
    {
        [Required]
        [MaxLengthAttribute(100)]
        public string kw { get; set; }
    }
}