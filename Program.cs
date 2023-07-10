

using static NotFoundException;

// Example usage of the custom exception
public class Program
{
    public static void Main()
    {
        try
        {
            // Throw the custom exception
            throw new MyCustomException("This is a custom exception.");
        }
        catch (MyCustomException ex)
        {
            // Handle the custom exception
            Console.WriteLine("Custom exception caught: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        try
        {
            UserRepositry userRepositry = new UserRepositry();
            User user = userRepositry.GetUserById(19189);
        }
        catch(NotFoundException ex)
        {
            Console.WriteLine("User not found: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
