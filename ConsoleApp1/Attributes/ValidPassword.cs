using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Attributes
{
    public class ValidPassword : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            User user = value as User;
            int lower = 0;
            int number = 0;
            foreach (char enteredCharacters in user.Password)
            {
                if (char.IsLower(enteredCharacters))
                    lower++;
                else if (char.IsDigit(enteredCharacters))
                    number++;
            }
            if (char.IsUpper(user.Password[0]) && lower >= 1 && number >= 1 && user.Password.Length >= 8)
            {
                return true;
            }
            return false;
        }
    }
}
