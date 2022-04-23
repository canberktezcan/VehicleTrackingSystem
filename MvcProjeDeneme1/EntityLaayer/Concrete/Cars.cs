using CsvHelper.Configuration.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLaayer.Concrete
{
    public class Cars
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]


        public ObjectId object_id { get; set; }

        //[BsonElement("dateTime")]
      
        public DateTime dateTime { get; set; }

        //[BsonElement("lat")]
        public string lat { get; set; }

        //[BsonElement("lng")]
        public string lng { get; set; }

        //[BsonElement("id")]
        public string id { get; set; }


        public string CustomerUsername { get; set; }// burda ilişkiyi alıyorum
        public virtual Customer Customer { get; set; }

    }
}
