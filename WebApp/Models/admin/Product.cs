using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel;

namespace WebApp.Models.admin
{
    public class Product
    {
        //[Kode] ,[Nama] ,[Alamat] ,[Telp1] ,[Telp2] ,[Email]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [BsonElement("Address")]
        [DisplayName("Address")]
        public string Address { get; set; }
        [BsonElement("Phone")]
        [DisplayName("Phone")]
        public string Phone { get; set; }
        [BsonElement("Email")]
        [DisplayName("Email")]
        public string? Email { get; set; }
        [BsonElement("userid")]
        [DisplayName("user")]
        public string userid { get; set; }
    }
}
