using WebApp.Models;

namespace WebApp.Services;

public class SecurityService
{
    
    private UsersDAO _usersDao = new UsersDAO();

    public SecurityService()
    {
        
    }

    public bool IsValid(Users users)
    {
        return _usersDao.FindUserByNameAndPassword(users);
    }
}