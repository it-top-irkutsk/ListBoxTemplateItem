using System;

namespace ListBoxTemplateItem
{
    public class User
    {
        public string Login { get; init; }
        public string Password { get; init; }

        public User(string login, string password)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public User() { }
    }
}