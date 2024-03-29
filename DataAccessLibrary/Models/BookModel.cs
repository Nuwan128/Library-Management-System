﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    

    public class BookModel
    {
        [BsonId] 
        public ObjectId Id { get; set; } = new ObjectId();
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Edition { get; set; }
        public int Count { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId CategoryId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId AuthorId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId PublisherId { get; set; }
    }
}
