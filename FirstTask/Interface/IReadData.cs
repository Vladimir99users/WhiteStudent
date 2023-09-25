public interface IReadData<T>
{
    public Task<T> GetData(string path);
}