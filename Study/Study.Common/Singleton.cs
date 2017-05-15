namespace Study.Common
{
    public class Singleton
    {
        private static Singleton single = null;
        private static object locker = new object();
        private Singleton() { }

        public static Singleton Instance()
        {
            lock (locker)
            {
                if (single == null)
                {
                    lock (locker)
                    {
                        single = new Singleton();
                    }
                }
            }
            return single;
        }
    }
}
