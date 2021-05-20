using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseTests.CollectionFixture
{
    [CollectionDefinition("DB Collection")]
    public class DatabaseFixtureDifintion : ICollectionFixture<DatabaseFixture>
    {
    }
}
