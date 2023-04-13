﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ReaderModel
    {
        [BsonId]
        public ObjectId Id { get; set; } = new ObjectId();
        public string UserName { get; set; }
        public string Address { get; set; }
        public List<string> PhoneNumbers { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }


    }
}
