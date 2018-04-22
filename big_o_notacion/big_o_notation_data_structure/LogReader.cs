using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace big_o_notation_data_structure
{

    public class LogReader: IEnumerable<LogLine> {
    private  int sizeLogLines;
    private  int sizeUniqueIps;
    private ICollection<String> uniqueIps;
 
        public LogReader(int sizeLogLines, int sizeUniqueIps, CollectionType collectionType)
    {
        this.sizeLogLines = sizeLogLines;
        this.sizeUniqueIps = sizeUniqueIps;
        this.uniqueIps = CollectionFactory.getCollection(collectionType);
    }

    public int readAllLogs()
    {
        int sizeLogLines = 0;
        foreach (LogLine line in this)
        {
            String ip = line.getIP();
            sizeLogLines++;
        }
        return sizeLogLines;
    }

    public int getSizeUniqueIps()
    {

        foreach (LogLine logLine in this)
        {
            String ip = logLine.getIP();
            if (!this.uniqueIps.Contains(ip))
            {
                this.uniqueIps.Add(ip);
            }
        }
        return this.uniqueIps.Count();
    }

        public IEnumerator<LogLine> GetEnumerator()
        {
            return new LogReaderIterator(this.sizeLogLines, this.sizeUniqueIps);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LogReaderIterator(this.sizeLogLines, this.sizeUniqueIps);
        }
    }

}
