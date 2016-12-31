public class KeywordRepository : IKeywordRepository
{
    private IDbConnection _db;

    public List<Keyword> GetAll()
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
        return _db.Query<Keyword>("SELECT * FROM \"Keywords\"
                                    WHERE id = @id;");
        }
    }

    public Keyword Add(Keyword keyword)
    {
        using(_db = new MySqlConnection(mysqlConfig.Value.ConnectionString))
        {
            //TODO: Complete
        return _db.Query<Keyword>("INSERT INTO \"Keywords\" VALUES ");
        }
    }
}