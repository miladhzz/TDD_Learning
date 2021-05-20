using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTests.CollectionFixture
{
    public class DatabaseFixture : IDisposable
    {
        public Guid Guid { get; set; }
        public DatabaseFixture()
        {
            Guid = Guid.NewGuid();
        }
        public void Dispose()
        {
            Guid = Guid.Empty;
        }
    }
}
