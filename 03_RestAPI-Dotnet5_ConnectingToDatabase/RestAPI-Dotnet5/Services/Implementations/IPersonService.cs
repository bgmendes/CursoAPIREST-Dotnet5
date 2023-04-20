using RestAPI_Dotnet5.Model;
using System.Collections.Generic;

namespace RestAPI_Dotnet5.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
