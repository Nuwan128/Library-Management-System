﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

using MongoDB.Bson;
using MongoDB.Driver;



namespace DataAccessLibrary.DataAccess
{
    public class MongoDBDataAccess : IMongoDBData
    {
        private IMongoDatabase _db;

        public MongoDBDataAccess(IConfiguration config)
        {
            var connectionString = config.GetConnectionString("MongoDb");
            var client = new MongoClient(connectionString);
            _db = client.GetDatabase("LibraryManagementSystemDB");
        }
        public async Task InsertRecordAsync<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);
            await collection.InsertOneAsync(record);
        }
        public async Task<List<T>> LoadRecordsAsync<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);
            var cursor = await collection.FindAsync(new BsonDocument());
            return await cursor.ToListAsync();
        }
        public async Task<T> LoadRecordByIdAsync<T>(string table, ObjectId id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);

            var cursor = await collection.FindAsync(filter);
            return await cursor.FirstOrDefaultAsync();
        }
        public async Task UpsertRecordAsync<T>(string table, ObjectId id, T record)
        {
            var collection = _db.GetCollection<T>(table);
            var result = await collection.ReplaceOneAsync(
                new BsonDocument("_id", id),
                record,
                new UpdateOptions { IsUpsert = true });
        }
        public async Task DeleteRecordAsync<T>(string table, ObjectId id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);

            await collection.DeleteOneAsync(filter);
        }
        public async Task<List<string>> ConnectToDbTimeAsync()
        {
            return await Task.Run(() =>
            {
                return _db.Client.ListDatabaseNames().ToList();
            });
        }
        public async Task<List<T>> SearchAsync<T>(string table,string fieldName, string query)
        {
                
                var collection = _db.GetCollection<T>(table);
                var filter = Builders<T>.Filter.Regex(fieldName, new BsonRegularExpression($"^{query}"));
                var result = await collection.FindAsync(filter);
                return await result.ToListAsync();

        }

        public async Task<T> SearchOneAsync<T>(string table, string fieldName, string query)
        {

            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Regex(fieldName, new BsonRegularExpression($"{query}"));
            var result = await collection.FindAsync(filter);
            return await result.FirstOrDefaultAsync();

        }

    }
}
