namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var log = Singleton.Log.Instance;
            log.Save("Hello, World!");
        }
    }
}
