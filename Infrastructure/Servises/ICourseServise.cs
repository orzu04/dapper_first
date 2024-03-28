using DoMain.Models;

namespace Infrastructure.Servises;

public interface ICourseServise
{

  List<Course> GetCourses();
  Course GetById(int id);
  string AddCourse(Course course);
  string Ubdete(Course course);
  bool Delete(int id);
   

}
