using Leilao.API.Contracts;
using Leilao.API.Entities;

namespace Leilao.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly APILeilaoDbContext _dbcontext;

    public UserRepository(APILeilaoDbContext dbcontext) => _dbcontext = dbcontext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbcontext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbcontext.Users.First(user => user.Email.Equals(email));
}
