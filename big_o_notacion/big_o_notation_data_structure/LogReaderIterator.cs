using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_o_notation_data_structure
{
    public class LogReaderIterator: IEnumerator<LogLine> {
    private int counter = 0;
    private int sizeLogLines;
    private int sizeUniqueIps;

        public LogLine Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public LogReaderIterator(int sizeLogLines, int sizeUniqueIps)
    {
        this.sizeLogLines = sizeLogLines;
        this.sizeUniqueIps = sizeUniqueIps;
    }

    public LogLine next()
    {
        if (this.MoveNext())
        {
            this.counter++;
            return new LogLine(this.counter % this.sizeUniqueIps);
        }
        throw new Exception();
    }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return this.counter < this.sizeLogLines;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
