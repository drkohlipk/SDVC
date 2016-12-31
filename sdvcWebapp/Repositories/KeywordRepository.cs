public class KeywordRepository : IKeywordRepository
{
    private IDbConnection _db;

    public List<User> GetAll()
    {
        using(_db = new MySqlConnection(mysqlConfig.Value.ConnectionString))
        {
            return _db.Query<Keyword>("SELECT * FROM \"Keywords\";");
        }
    }
}