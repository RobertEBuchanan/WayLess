using WayLess.Domain.Interfaces;

namespace Wayless.Domain
{
    public class Person : IPerson
    {
        public string UserId => throw new System.NotImplementedException();

        public string FirstName => throw new System.NotImplementedException();

        public string MiddleName => throw new System.NotImplementedException();

        public string LastName => throw new System.NotImplementedException();

        public string FullName()
        {
            throw new System.NotImplementedException();
        }
    }
}
