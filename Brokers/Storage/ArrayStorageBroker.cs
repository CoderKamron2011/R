using Register.Models;

namespace Register.Brokers.Storage
{
    public class ArrayStorageBroker : IStorageBroker
    {
        private User[] Users { get; set; } = new User[10];
        public ArrayStorageBroker() 
        {
            Users[0] = new User()
            {
                Name = "Kamron",
                Email = "kamron@gmail.com",
                Pasword = "sjjssjjs"
            };
            Users[1] = new User()
            {
                Name = "Afruz",
                Email = "afruz@gmail.com",
                Pasword = "Afruz2010"
            };
            Users[2] = new User()
            {
                Name = "Doston",
                Email = "doston01@gmail.com",
                Pasword = "dostonu01"
            };
        }

        public void SignUp(string email, string pasword)
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string email, string pasword)
        {
            throw new NotImplementedException();
        }

        public User[] GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User UserInformationUpdate(string email)
        {
            throw new NotImplementedException();
        }
    }
}