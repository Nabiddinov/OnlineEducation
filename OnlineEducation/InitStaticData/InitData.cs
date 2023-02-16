using OnlineEducation.Models;

namespace OnlineEducation.InitStaticData
{
    internal static class InitData
    {
        public static void InitCourses(ref List<CourseDetails> courses)
        {
            courses.Add(new CourseDetails() { Duration = 9, Id = Guid.NewGuid(), Name = "C#", Price = 345 });
            courses.Add(new CourseDetails() { Duration = 9, Id = Guid.NewGuid(), Name = "Java", Price = 340 });
            courses.Add(new CourseDetails() { Duration = 4, Id = Guid.NewGuid(), Name = "C++", Price = 155 });
        }
    }
}
