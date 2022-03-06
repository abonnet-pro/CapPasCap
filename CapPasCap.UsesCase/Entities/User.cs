namespace CapPasCap.UsesCase.Entities;

public class User
{
    public string login { get; set; }
    public string password { get; set; }

    public User(string login, string password)
    {
        this.login = login;
        this.password = password;
    }

    public bool IsValid()
    {
        return string.IsNullOrEmpty(login) is false
                && string.IsNullOrEmpty(password) is false;
    }
}
