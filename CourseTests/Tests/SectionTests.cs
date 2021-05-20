using Academy.Domain;
using CourseTests.CollectionFixture;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseTests.Tests
{
    [Collection("DB Collection")]
    public class SectionTests
    {
        public SectionTests(DatabaseFixture databaseFixture)
        {

        }
        [Fact]
        public void Constructor_ShouldConstructProperly()
        {
            //arrange
            const int id = 1;
            const string name = "item";
            var section = new Section(id, name);
            //act

            //assert
            section.Id.Should().Be(id);
            section.Name.Should().Be(name);
        }
    }
}
