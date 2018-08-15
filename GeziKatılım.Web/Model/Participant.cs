using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeziKatılım.Web.Model
{
    public class Participant
    {

        [Required(ErrorMessage = "İsminizi giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email giriniz.")]
        [EmailAddress(ErrorMessage = "Lütfen mail adresinizi düzgün giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon giriniz.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Kursa katılıp katılmayacağınızı bilmemiz gerekiyor.")]
        public bool? WillAttend { get; set; }

    }
}