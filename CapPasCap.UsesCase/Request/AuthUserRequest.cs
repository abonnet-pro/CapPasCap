namespace CapPasCap.UsesCase.Request;

public class AuthUserRequest
{
    public AuthUserRequest()
    {
    }

    public string login { get; set; }
    public string password { get; set; }
}