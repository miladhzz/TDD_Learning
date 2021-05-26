using Academy.Infrustructure;
using CourseTests.Builders;
using FluentAssertions;
using System;
using Xunit;

namespace Academy.Infrustructe.Tests.Unit
{
    public class CourseRepositoryTests
    {
        private readonly CourseRepository _courseRepository;
        private readonly CourseTestBuilder _courseBuilder;
        public CourseRepositoryTests()
        {
            _courseRepository = new CourseRepository();
            _courseBuilder = new CourseTestBuilder();

        }

        [Fact]
        public void Sholud_AddNewToCourseList()
        {
            //arrang
            var course = _courseBuilder.Build();

            //act
            _courseRepository.Create(course);

            //assert
            _courseRepository.Courses.Should().Contain(course);
        }

        [Fact]
        public void Should_ListContainListOfCourses()
        {
            //act
            var courses = _courseRepository.GetAll();

            //assert
            courses.Should().HaveCountGreaterOrEqualTo(0);
        }

        [Fact]
        public void Should_ReturnCourseBtId()
        {
            //arrange
            const int id = 5;
            var newCourse = _courseBuilder.WithId(id).Build();
            _courseRepository.Create(newCourse);

            //act
            var actual = _courseRepository.GetBy(id);

            //assert
            actual.Should().Be(newCourse);
        }

        [Fact]
        public void Should_ReturnNull_WhenIdNotExist()
        {   
            //arrange
            const int id = 55;

            //act
            var actual = _courseRepository.GetBy(id);

            //assert
            actual.Should().BeNull();
        }

        [Fact]
        public void Should_DeleteCourseFromStore()
        {
            //arrange 
            const int id = 5;
            var course = _courseBuilder.WithId(id).Build();
            _courseRepository.Create(course);

            //act
            _courseRepository.Delete(id);


            //assert
            _courseRepository.Courses.Should().NotContain(course);
        }
    }
}
