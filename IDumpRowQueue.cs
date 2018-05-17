namespace DumpFileLoader
{
    internal interface IDumpRowQueue<T> 
    {
        T Dequeue();
        bool HasRow { get; }
    }
}