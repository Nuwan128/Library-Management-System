﻿using MongoDB.Bson;

namespace DataAccessLibrary.DataAccess
{
    public interface IMongoDBData
    {
        Task<List<string>> ConnectToDbTimeAsync();
        Task DeleteRecordAsync<T>(string table, ObjectId id);
        Task InsertRecordAsync<T>(string table, T record);
        Task<T> LoadRecordByIdAsync<T>(string table, ObjectId id);
        Task<List<T>> LoadRecordsAsync<T>(string table);
        Task<List<T>> SearchAsync<T>(string table, string columnName, string query);
        Task<T> SearchOneAsync<T>(string table, string fieldName, string query);
        Task UpsertRecordAsync<T>(string table, ObjectId id, T record);
    }
}