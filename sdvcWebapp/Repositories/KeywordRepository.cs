using System;
using System.Collections.Generic;
using sdvcWebapp.Models;
using Dapper;
using MySql.Data.MySqlClient;

public class KeywordRepository : IKeywordRepository
{
    private System.Data.IDbConnection _db;

    public IEnumerable<Keyword> GetAll()
    {
        using(_db = new MySqlConnection(mysqlConfig.Value.ConnectionString))
        {
            return _db.Query<Keyword>("SELECT * FROM \"Keywords\";");
        }
    }

    public Keyword FindById(int id)
    {
        using(_db = new MySqlConnection(mysqlConfig.Value.ConnectionString))
        {
        return _db.QuerySingleOrDefault("SELECT * FROM \"Keywords\" WHERE id = @id;", new {id});
        }
    }
//TODO: Fix This
    public Keyword Add(Keyword keyword)
    {
        using(_db = new MySqlConnection(mysqlConfig.Value.ConnectionString))
        {
            //TODO: Complete
            string query = "INSERT INTO Keywords (text) VALUES @Text"
        return _db.Query<Keyword>(query,new {keyword = keyword});
        }
    }

    public Keyword FindByText()
    {
        throw new NotImplementedException();
    }

    List<Keyword> IBaseRepository<Keyword>.GetAll()
    {
        throw new NotImplementedException();
    }

    Keyword IBaseRepository<Keyword>.FindById(int id)
    {
        throw new NotImplementedException();
    }

    public Keyword Add(Keyword entity)
    {
        throw new NotImplementedException();
    }

    public Keyword Update(Keyword entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveById(int id)
    {
        throw new NotImplementedException();
    }
}