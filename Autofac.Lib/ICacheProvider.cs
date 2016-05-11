namespace Autofac.Lib
{
    public interface ICacheProvider
    {
        void Get(string key);

        void Set(string key, string value);

        string ShowName();
    }
}
