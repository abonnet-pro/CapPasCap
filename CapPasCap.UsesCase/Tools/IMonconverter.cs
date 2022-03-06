namespace CapPasCap.UsesCase
{
    public interface IMonconverter<T, T2>
    {
        public T2 Convert(T user);
    }
}