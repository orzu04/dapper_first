using Npgsql;
namespace Infrastructure;

public class DApperContext
{

  private  readonly string  _ConnectionString=
  "Host=localhost;Port=5432;Database=Dapper_db;User Id=postgres;Password=20082003;";
  

public NpgsqlConnection Connection()
{

return new NpgsqlConnection(_ConnectionString);

}

}
