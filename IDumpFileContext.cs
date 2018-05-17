using System.Collections.Generic;

namespace DumpFileLoader
{
    internal interface IDumpContext
    {
        void Load();
        IDumpFileQueue<DumpFile> FileQueue();
        void LogFileErrors(IList<string> dumpFileValidationErrors);
        void Archive(DumpFile dumpFile);
        void MoveToDraft(DumpFile dumpFile);
    }
}