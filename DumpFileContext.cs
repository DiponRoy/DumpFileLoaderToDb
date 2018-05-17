using System.Collections.Generic;

namespace DumpFileLoader
{
    internal class DumpContext : IDumpContext
    {
        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public IDumpFileQueue<DumpFile> FileQueue()
        {
            IDumpFileQueue<DumpFile> queue = new DumpFileQueue();
            return queue;
        }

        public void LogFileErrors(IList<string> dumpFileValidationErrors)
        {
            throw new System.NotImplementedException();
        }

        public void Archive(DumpFile dumpFile)
        {
            throw new System.NotImplementedException();
        }

        public void Draft(DumpFile dumpFile)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class DumpFileQueue : Queue<DumpFile>, IDumpFileQueue<DumpFile>
    {
        public bool HasFile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public DumpFile Dequeue()
        {
            throw new System.NotImplementedException();
        }
    }
}