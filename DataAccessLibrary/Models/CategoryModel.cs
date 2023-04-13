using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class CategoryModel
    {
        [BsonId] 
        public ObjectId Id { get; set; } = new ObjectId();
        public string Category { get; set; }
    }
}
