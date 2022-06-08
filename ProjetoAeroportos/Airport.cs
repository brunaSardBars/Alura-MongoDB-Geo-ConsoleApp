using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAeroportos
{
    public class Airport
    {

        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        public GeoJsonPoint<GeoJson2DGeographicCoordinates> loc { get; set; }

        public string name { get; set; }
        public string type { get; set; }
        public string code { get; set; }

    }
   
}
