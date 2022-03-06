namespace CapPasCap.UsesCase.Entities;

public class Challenge
{
    public int id { get; set; }

    public string text { get; set; }

    public string user { get; set; }

    public int likesNumber { get; set; }

    public Challenge(string text)
    {
        this.text = text;
    }

    public Challenge(string text, string user, int id)
    {
        this.id = id;
        this.text = text;
        this.user = user;
        this.likesNumber = 0;
    }

    public bool IsValid()
    {
        return string.IsNullOrEmpty(text) is false;
    }
}
