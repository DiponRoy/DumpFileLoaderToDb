using System;
using System.Collections.Generic;

namespace DumpFileLoader
{
    public abstract class DumpFile
    {
        public abstract void Load();
        public abstract bool Validate(out IList<string> dumpFileValidationErrors);

        internal IDumpRowBatchIterator BatchIterator(uint batchSize)
        {
            throw new NotImplementedException();
        }
    }
}