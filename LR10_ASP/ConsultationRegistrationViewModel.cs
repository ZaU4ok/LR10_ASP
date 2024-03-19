using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LR10_ASP
{
    public class ConsultationRegistrationViewModel
    {
        [Required(ErrorMessage = "Поле Ім'я прізвище є обов'язковим")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Email є обов'язковим")]
        [EmailAddress(ErrorMessage = "Введіть коректну адресу Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Бажана дата консультації є обов'язковим")]
        [FutureDate(ErrorMessage = "Дата консультації повинна бути в майбутньому")]
        [NotWeekend(ErrorMessage = "Консультація не може проходити вихідними")]
        public DateTime ConsultationDate { get; set; }

        [Required(ErrorMessage = "Будь ласка, виберіть продукт")]
        [NotMonday(ErrorMessage = "Консультація щодо продукту «Основи» не може проходити по понеділках")]
        public string SelectedProduct { get; set; }

        public List<SelectListItem> Products { get; set; }

        public ConsultationRegistrationViewModel()
        {
            Products = new List<SelectListItem>
        {
            new SelectListItem { Value = "JavaScript", Text = "JavaScript" },
            new SelectListItem { Value = "C#", Text = "C#" },
            new SelectListItem { Value = "Java", Text = "Java" },
            new SelectListItem { Value = "Python", Text = "Python" },
            new SelectListItem { Value = "Основи", Text = "Основи" }
        };
        }
    }
}
