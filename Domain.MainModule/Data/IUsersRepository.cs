using System;
namespace Domain.MainModule.Data
{
    public interface IUsersRepository
    {
        Domain.MainModule.Entities.User GetUserBy(string username);
    }
}
