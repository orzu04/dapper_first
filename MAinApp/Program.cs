



using DoMain.Models;
using Infrastructure.Servises;

var servise = new CourseServise();
var course = new Course(){
 Course_name ="Js",
 Price= 1500
};






var resalt = servise.GetCourses();

servise.AddCourse(course);

servise.Delete(1);

//foreach (var item in servise.GetCourses())
//{
 //System.Console.WriteLine(item);   
//}
