using System;
using System.Threading.Tasks;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ProjetoAeroportos
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            await MainAsync(args);
        }

        private static async Task MainAsync(string[] args)
        {
            var connection = new ConnectionMongoDB();

            var point = new GeoJson2DGeographicCoordinates(-118.32528, 34.103212); 
            var location = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(point);

            var constructor = Builders<Airport>.Filter;
            var filter = constructor.NearSphere(x => x.loc, location, 100000);

            var airports = await connection.Airports.Find(filter).ToListAsync();
            foreach (var airport in airports)
            {
                Console.WriteLine(airport.ToJson<Airport>());
            }
            Console.WriteLine("");
        }
    }
}
