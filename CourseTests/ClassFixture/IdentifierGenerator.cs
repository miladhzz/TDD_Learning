using System;
using System.Collections.Generic;
using System.Text;

namespace CourseTests.ClassFixture
{
    public class IdentifierGenerator : IDisposable
    {
        public static Guid Guid { get; set; }
        public IdentifierGenerator()
        {
            Guid = Guid.NewGuid();
        }

        public void Dispose()
        {
            Guid = Guid.Empty;
        }
    }
}
