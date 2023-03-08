namespace DemoUser
{
    public class User
    {

        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        public User(string userEmail)
        {
            m_email = userEmail;
        }
        private string m_email;
    }
}
