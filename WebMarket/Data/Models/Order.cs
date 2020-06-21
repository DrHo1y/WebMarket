using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { set; get; }
        [Display(Name = "Введите Имя")]
        public string Name { set; get; }
        [Display(Name = "Введите Фамилия")]
        public string Surname { set; get; }
        [Display(Name = "Введите Адрес")]
        public string Adress { set; get; }
        [Display(Name = "Введите Телефон")]
        public string Phone { set; get; }
        [Display(Name = "Введите Адресс электронной почты")]
        public string Email { set; get; }
        [BindNever]
        public DateTime OrderTime { set; get; }
        public virtual List<OrderDetail> OrderDetails { set; get; }
    }
}
