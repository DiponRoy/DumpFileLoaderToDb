namespace DumpFileLoader
{
    public interface IDumpRowBatchIterator
    {
        bool HasNextBatch { get; }

        IDumpRowBatch Next();
    }
}