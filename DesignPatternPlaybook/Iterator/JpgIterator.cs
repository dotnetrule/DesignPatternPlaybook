using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternPlaybook.Iterator
{
    public class JpgIterator : IEnumerable<FileInfo>
    {
        private string _startingPath;

        private IEnumerator<string> _fileEnumerator;

        public JpgIterator(string startingPath)
        {
            _startingPath = startingPath;
            
        }

        public IEnumerator<FileInfo> GetEnumerator()
        {
            var files = Directory.EnumerateFiles(_startingPath, "*.jpg", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                yield return new FileInfo(file);
            }
            
        }

        public bool MoveNext()
        {
            return _fileEnumerator.MoveNext();
        }

        public void Reset()
        {
            _fileEnumerator.Reset();
        }

        public FileInfo Current
        {
            get { return new FileInfo(_fileEnumerator.Current); }
        }

        public void Dispose()
        {
            _fileEnumerator.Dispose();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
