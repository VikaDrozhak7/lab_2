public sealed class Authenticator
{
    private static Authenticator _instance = null;
    private static readonly object padlock = new object();

    Authenticator()
    {
    }

    public static Authenticator Instance
    {
        get
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
                return _instance;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Authenticator authenticator1 = Authenticator.Instance;
        Authenticator authenticator2 = Authenticator.Instance;

        if (authenticator1 == authenticator2)
        {
            Console.WriteLine("Authenticator is singleton");
        }
        else
        {
            Console.WriteLine("Authenticator is not singleton");
        }
    }
}
