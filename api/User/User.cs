namespace User;

public class User : IUser
{
    public Guid? Game()
    {
        return Guid.Parse("60d165f6-be3e-4d33-8fa4-71c97fed5e46");
    }

    public string UserName()
    {
        return "Savpek";
    }
}