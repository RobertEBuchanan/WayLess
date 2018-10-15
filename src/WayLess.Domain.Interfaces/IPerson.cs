namespace WayLess.Domain.Interfaces
{
    public interface IPerson
    {
        string UserId { get;  }
        string FirstName { get;  }
        string MiddleName { get; }
        string LastName { get; }
        string FullName();
    }
}