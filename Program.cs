using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpFileLoader
{
    class Program
    {
        public void Read()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\example_File.csv"));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                String[] values = line.Split(',');

                for (int i = 0; i < values.Length; i++)
                {
                }
            }
        }
        static void Main(string[] args)
        {
            Stuent stuent = new Stuent();

            IDumpContext dumpFileContext = new DumpContext();
            dumpFileContext.Load();
            for (IDumpFileQueue<DumpFile> fileQueue = dumpFileContext.FileQueue(); fileQueue.HasFile;)
            {
                DumpFile dumpFile = fileQueue.Dequeue();
                dumpFile.Load();
                IList<string> dumpFileValidationErrors;
                if (!dumpFile.Validate(out dumpFileValidationErrors))
                {
                    dumpFileContext.LogFileErrors(dumpFileValidationErrors);
                    dumpFileContext.Draft(dumpFile);
                }

                uint batchSize = 100;
                for (IDumpRowBatchIterator rowBatchIterator = dumpFile.BatchIterator(batchSize); rowBatchIterator.HasNextBatch;)
                {
                    IDumpRowBatch rowBatch = rowBatchIterator.Next();
                    for (DumRowQueue<Stuent> rowQueue = rowBatch.RowQueue(); rowQueue.HasRow;)
                    {
                        DumpRow<Stuent> row = rowQueue.Dequeue();
                        Stuent entity = row.Entity();

                        try
                        {
                            SaveToDb(entity);
                        }
                        catch (Exception ex)
                        {

                            dumpFileContext.Draft(dumpFile, row.(line));
                        }
                    }
                }

                dumpFileContext.Archive(dumpFile);
            }
        }

        private static void SaveToDb(Stuent student)
        {
            throw new NotImplementedException();
        }
    }
}
