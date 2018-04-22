using System;
using System.Collections;
using System.Collections.Generic;

namespace big_o_notation_data_structure
{
    public class LogReaderIterator : IEnumerator<LogLine>
    {
        private int counter = 0;
        private int sizeLogLines;
        private int sizeUniqueIps;
        private LogLine _current;

        public LogReaderIterator(int sizeLogLines, int sizeUniqueIps)
        {
            this.sizeLogLines = sizeLogLines;
            this.sizeUniqueIps = sizeUniqueIps;
        }

        public LogLine Current => _current;

        object IEnumerator.Current => Current;

        public bool hasNext()
        {
            return this.counter < this.sizeLogLines;
        }

        public bool MoveNext()
        {
            if (this.hasNext()) {
                this.counter++;
                _current = new LogLine(this.counter % this.sizeUniqueIps);
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _current = null;

        }
    }
}
