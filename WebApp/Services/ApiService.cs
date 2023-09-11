using MongoDB.Driver;
using System.Data;
using WebApp.Models;
using WebApp.Models.admin;

namespace WebApp.Services
{

    public class ApiService
    {
        private readonly IMongoCollection<ApplicationUser> datauser;
        private readonly IMongoCollection<ApplicationRole> datarole;
        public ApiService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("Db"));
            IMongoDatabase database = client.GetDatabase("test");
            datauser = database.GetCollection<ApplicationUser>("Users");
            datarole = database.GetCollection<ApplicationRole>("Roles");
        }

        public List<ApplicationUser> GetUsers(Guid id)
        {
            return datauser.Find(car => car.Id == id).ToList();
        }
        public ApplicationUser GetUserByEmail(string semail)
        {
            return datauser.Find(car => car.Email == semail).SingleOrDefault();
        }
        public List<ApplicationUser> GetUsers()
        {
            return datauser.Find(car => true).ToList();
        }

        public List<ApplicationRole> GetRoles()
        {
            return datarole.Find(car => true).ToList();
        }
        public ApplicationRole CreateRole(ApplicationRole car)
        {
            datarole.InsertOne(car);
            return car;
        }
    }
}
