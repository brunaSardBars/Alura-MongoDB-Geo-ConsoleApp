using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAeroportos
{
    class ConnectionMongoDB
    {
        public const string CONNECTION_STRING = "mongodb://127.0.0.1:27017";
        public const string DATABASE = "geo";
        public const string COLLECTION = "airports";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static ConnectionMongoDB()
        {
            _client = new MongoClient(CONNECTION_STRING);
            _database = _client.GetDatabase(DATABASE);
        }

        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoCollection<Airport> Airports
        {
            get { return _database.GetCollection<Airport>(COLLECTION); }
        }

    }
}
