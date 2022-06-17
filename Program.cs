using System.Data;
using Microsoft.Data.SqlClient;
using ReSharperIssue;
using Microsoft.EntityFrameworkCore;

ApplicationDbContext context = new();
SqlParameter parm = new()
{
    ParameterName = "@Alpha",
    SqlDbType =  SqlDbType.Char,
    TypeName = "[dbo].VARCHAR",
    Size = 100,
    Direction = ParameterDirection.Input,
    Value = "Hello"

};

// https://docs.microsoft.com/en-us/ef/core/querying/raw-sql
List<Customer> result = await context.Customers!.FromSqlRaw("EXEC dbo.SearchCustomers @ALPHA", parm).ToListAsync();
Console.WriteLine(result.Capacity);
