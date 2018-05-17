namespace DumpFileLoader
{
    internal interface IDumpFileQueue<T> 
    {
        DumpFile Dequeue();
        bool HasFile { get; }
    }
}