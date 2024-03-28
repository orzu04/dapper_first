
using Dapper;
using DoMain.Models;

using Npgsql;
namespace Infrastructure.Servises;

public class CourseServise : ICourseServise
{


      private readonly string _connectionString =
        "Server=localhost;Port=5432;Database=Dapper_db;User Id=postgres;Password=20082003";
    public string AddCourse(Course course)
    {
       
         using (var connection=new NpgsqlConnection(_connectionString))
        {
            var sql = $"INSERT INTO Course (Course_name,Course_price)" +
                      $"values('{course.Course_name}','{course.Price}' )";
            var result = connection.Execute(sql);
            if (result > 0) return "Successfully added course";
             return "Failed to add course";
        }

    }

    public bool Delete(int id)
    {
         using (var connection=new NpgsqlConnection(_connectionString))
        {
            var sql = $"delete  from Course as c where c.id={@id}";
            var result = connection.Execute(sql);
            if(result>0) return true;
            return false;
        }
    }

    public Course GetById(int id)
    {
        
    using (var connection=new NpgsqlConnection(_connectionString))
        {
            var sql = $"Select * from Course where id={@id} ";
            var result = connection.QueryFirstOrDefault<Course>(sql);
            return result;
        }

    }

    public List<Course> GetCourses()
    {
    
       using (var connection=new NpgsqlConnection(_connectionString))
        {
            var sql = "Select * from Course ";
            var result = connection.Query<Course>(sql);
            return result.ToList();
        }

    }

    public string Ubdete(Course course)
    {
        throw new NotImplementedException();
    }

}
