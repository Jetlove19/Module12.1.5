namespace Module12._1._5
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                List<Users> listUsers = new()
        {
           new Users() { Name = "Павел", Login = Guid.NewGuid().ToString().Substring(1, 7), IsPremium = false },
           new Users() { Name = "Ольга", Login = Guid.NewGuid().ToString().Substring(1, 7), IsPremium = true },
           new Users() { Name = "Валентина", Login = Guid.NewGuid().ToString().Substring(1, 7), IsPremium = false },
        };
                foreach (var Premium in listUsers)
                {
                    if (!Premium.IsPremium)
                    {
                        Console.Write(Premium.Name + " ");
                        ADS.ShowAds();
                    }
                }
            }
        }
    }
}