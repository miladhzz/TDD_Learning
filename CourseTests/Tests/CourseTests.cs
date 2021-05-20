using Academy.Domain;
using Academy.Domain.Exceptions;
using CourseTests.Builders;
using FluentAssertions;
using System;
using Xunit;
using CourseTests.ClassFixture;
using CourseTests.CollectionFixture;

namespace CourseTests.Tests
{
    [Collection("DB Collection")]
    public class CourseTests : IClassFixture<IdentifierGenerator>
    {
        private readonly CourseTestBuilder _course;

        public CourseTests(DatabaseFixture databaseFixture)
        {
            _course = new CourseTestBuilder();
        }

        [Fact]
        public void Consttructor_ShouldConstructProperly()
        {
            const string name = "milad";
            const double price = 1000;

            var course = _course.WithPrice(price)
                .WithName(name)
                .Build();

            course.Id.Should().Be(0);
            course.Name.Should().Be("milad");
            course.Price.Should().Be(1000);
            course.Sections.Should().BeEmpty();
        }

        [Fact]
        public void Constructor_ShouldRaiseException_WhenNameIsEmpty()
        {
            var guid = IdentifierGenerator.Guid;
            const string name = "";

            Action course = () => _course.WithName(name).Build();

            course.Should().ThrowExactly<CourseNameIsEmptyException>();
        }

        [Fact]
        public void Constructor_ShouldRaiseException_WhenPriceIsLowerThanZero()
        {
            var guid = IdentifierGenerator.Guid;

            const double price = -1;

            Action course = () => _course.WithPrice(price).Build();

            course.Should().ThrowExactly<CoursePriceIsNegativeException>();
        }

        [Fact]
        public void AddSection_SectionShouldNotEmptyList()
        {
            //arrange
            var course = _course.Build();
            var section = new Section(1, "item");            

            //act
            course.AddSection(section);

            //assert
            course.Sections.Should().ContainEquivalentOf(section);
        }

        //public void Dispose()
        //{

        //}
    }
}
