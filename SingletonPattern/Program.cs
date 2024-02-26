// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public sealed class NoThreadSafeSingleton
{
    private NoThreadSafeSingleton()
    {
    }

    private static NoThreadSafeSingleton instance = null;

    public static NoThreadSafeSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new NoThreadSafeSingleton();
            }

            return instance;
        }
    }
}

public sealed class ThreadSafeSingleton
{
    ThreadSafeSingleton()
    {
    }

    private static ThreadSafeSingleton instance = null;

    public static ThreadSafeSingleton Instance
    {
        get
        {
            lock (instance)
            {
                if (instance == null)
                {
                    instance = new ThreadSafeSingleton();
                }

                return instance;
            }
        }
    }
}