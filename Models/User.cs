namespace morning_challenge.Models
{
    class User
    {
        public string UserName { get; set; }
        private string Password { get; set; }

        public bool ValidatePassword(string input)
        {
            return input == Password;
        }
        public User(string name, string pass)
        {
            UserName = name;
            Password = pass;
        }
    }
}