using MongoDB.Driver;
using System.Data;
using WebApp.Models;
using WebApp.Models.admin;

namespace WebApp.Services
{

    public class ProductService
    {
        private readonly IMongoCollection<Product> data;
        public ProductService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("Db"));
            IMongoDatabase database = client.GetDatabase("test");
            data = database.GetCollection<Product>("Product");
        }
        public List<Product> Get()
        {
            return data.Find(car => true).ToList();
        }

        public Product Get(string id)
        {
            return data.Find(car => car.Id == id).FirstOrDefault();
        }
        public Product Create(Product car)
        {
            data.InsertOne(car);
            return car;
        }

        public void Update(string id, Product carIn)
        {
            data.ReplaceOne(car => car.Id == id, carIn);
        }

        public void Remove(Product carIn)
        {
            data.DeleteOne(car => car.Id == carIn.Id);
        }

        public void Remove(string id)
        {
            data.DeleteOne(car => car.Id == id);
        }

    }
}
