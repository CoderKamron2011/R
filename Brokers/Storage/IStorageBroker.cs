using Register.Models;

namespace Register.Brokers.Storage
{
    internal interface IStorageBroker
    {
        void SignUp(string email, string pasword);
        bool LogIn(string email, string pasword);
        User[] GetAllUsers();
        User UserInfoUpdate(string email);
    }
}
