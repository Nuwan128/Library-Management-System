using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Entities;

namespace DataAccessLibrary.Models
{
    
    public class IssueBookModel
    {
        [BsonId]
        public ObjectId Id { get; set; } = new ObjectId();
        public string ISBN { get; set; }
        public int ReaderNo { get; set; }
        public DateTime ReserveDate { get; set; }
        public DateTime DueDate { get; set; }



    }
}
