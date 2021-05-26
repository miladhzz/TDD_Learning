using CourseTests.Builders;
using FluentAssertions;
using System;
using Xunit;

namespace Academy.Infrustructe.Tests.Unit
{
    public class CourseRepositoryTests
    {
        [Fact]
        public void Course_SholudAddNewToCourseList()
        {
            //arrang
            var courseBuilder = new CourseTestBuilder();
            var course = courseBuilder.Build();
            var respository = new CourseRepository();

            //act
            respository.Create(course);

            //assert
            respository.Courses.Should().Contain(course);
        }
    }
}
