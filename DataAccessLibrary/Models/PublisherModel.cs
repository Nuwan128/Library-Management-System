using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PublisherModel
    {
        [BsonId]
        public ObjectId Id { get; set; } = new ObjectId();
        public int YearOfPublication { get; set; }
        public string PublisherName { get; set; }
    }
}
