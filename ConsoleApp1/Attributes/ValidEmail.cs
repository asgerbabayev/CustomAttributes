using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Attributes
{
    public class ValidEmail : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            User user = value as User;
            Regex regex = new Regex("^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$");
            return regex.IsMatch(user.Email);
        }
    }
}
