using ConsoleApp1.Attributes;
using System.Reflection;

namespace ConsoleApp1.Extensions
{
    public class ModelState
    {
        public static bool IsValid<T>(T t)
        {
            foreach (var item in t.GetType().GetProperties())
            {
                ValidEmail email = (ValidEmail)item.GetCustomAttribute(typeof(ValidEmail), false);
                if (email != null)
                {
                    var methods = email.GetType().GetMethod("IsValid", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    bool result = (bool)methods.Invoke(email, new object[] { t });
                    if (!result) return false;
                }
                ValidPassword password = (ValidPassword)item.GetCustomAttribute(typeof(ValidPassword), false);
                if (password != null)
                {
                    var methods = password.GetType().GetMethod("IsValid", BindingFlags.Public | BindingFlags.Instance);
                    bool result = (bool)methods.Invoke(password, new object[] { t });
                    if (!result) return false;
                }
            }
            return true;
        }
    }
}
