using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_ADM.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public bool AccessLevel { get; set; }

        [Required(ErrorMessage = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string UserName { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy-}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birthday")]
        public string Birthday { get; set; }

        //[RegularExpression("[0-9]")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email")]
        [Display(Name = "Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        //[RegularExpression("[0-9]")]
        [Display(Name = "Indentification")]
        public string Indentification { get; set; }

        //[RegularExpression("[0-9]")]
        [Display(Name = "Fiscal Number")]
        public string FiscalNumber { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        //[RegularExpression("[0-7]")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        public IList<Order> Order { get; set; }


        public User()
        {
        }

        public User(int userId, string username, string email, bool accesslevel)
        {
            UserId = userId;
            UserName = username;
            Email = email;
            AccessLevel = accesslevel;
        }

        public User(int userId, string username, string birthday, string phonenumber, string email, string address, string postalcode, string indentification, string fiscalnumber)
        {
            UserId = userId;
            UserName = username;
            Birthday = birthday;
            PhoneNumber = phonenumber;
            Email = email;
            Address = address;
            PostalCode = postalcode;
            Indentification = indentification;
            FiscalNumber = fiscalnumber;
        }
    }
}
