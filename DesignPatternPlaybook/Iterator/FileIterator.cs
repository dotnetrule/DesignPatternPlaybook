using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternPlaybook.Iterator
{
    public class FileIterator : IEnumerable<FileInfo>
    {
        private string _startingPath;
        private string _extension;
        private IEnumerator<string> _fileEnumerator;

        public FileIterator(string startingPath, string extension)
        {
            _startingPath = startingPath;
            _extension = extension;

        }

        public IEnumerator<FileInfo> GetEnumerator()
        {
            var files = Directory.EnumerateFiles(_startingPath, $"*.{_extension}", SearchOption.AllDirectories);

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
