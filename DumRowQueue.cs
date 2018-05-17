using System.Collections.Generic;

namespace DumpFileLoader
{
    public class DumRowQueue<DumpRow<T>> : Queue<T>, IDumpRowQueue<T>
    {
        public bool HasRow => throw new System.NotImplementedException();
    }
}