using System.Data;
using Dapper;

namespace RawLibrary.Data;

public class BookRepository(IDbConnection connection)
{
   private readonly IDbConnection _connection = connection;
   
}