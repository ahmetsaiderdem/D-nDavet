using System.ComponentModel.DataAnnotations;

namespace DüğünDavet.Models
{
    public class Cevap
    {
        [Required(ErrorMessage ="Lütfen Adınız alanını boş bırakmayınız")]
        public string Names { get; set; }
        [Required(ErrorMessage ="Lütfen Soyadınız alanını boş bırakmayınız")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Lütfen e-Mail alanını boş bırakmayınız")]
        [EmailAddress]
        public string eMail { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon alanını boş bırakmayınız")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Lütfen seçeneklerden birini seçiniz")]
        public bool? DuguneGelecekmi { get; set; }

    }
}
