using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom exception derived from the base Exception class
public class MyCustomException : Exception
{
    public MyCustomException()
    {
    }

    public MyCustomException(string message)
        : base(message)
    {
    }

    public MyCustomException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
public class NotFoundException : Exception
{
    public NotFoundException()
    {

    }
    public NotFoundException(string message) : base(message)
    {

    }
    public NotFoundException(string message, Exception innerException) : base(message, innerException)
    {

    }


    public class UserRepositry
    {
        public User GetUserById(int id)
        {
            User user = null;
            if (user == null)
            {
                throw new NotFoundException($"User with ID {id} not found.");
            }
            return user;
        }
    }
}