using MongoDB.Bson;

namespace DataAccessLibrary.DataAccess
{
    public interface IMongoDBData
    {
        Task<List<string>> ConnectToDbTimeAsync();
        Task DeleteRecordAsync<T>(string table, ObjectId id);
        Task InsertRecordAsync<T>(string table, T record);
        Task<T> LoadRecordByIdAsync<T>(string table, ObjectId id);
        Task<List<T>> LoadRecordsAsync<T>(string table);
        Task UpsertRecordAsync<T>(string table, ObjectId id, T record);
    }
}