using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class UserModel
    {
        [BsonId]
        public ObjectId Id { get; set; } = new ObjectId();
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public byte[] ProfilePicture { get; set; }
      
    }
}
