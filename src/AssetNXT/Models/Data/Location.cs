﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AssetNXT.Models.Data
{
    public class Location
    {
        [BsonElement]
        public double Accuracy { get; set; }

        [BsonElement]
        public double Latitude { get; set; }

        [BsonElement]
        public double Longitude { get; set; }
    }
}
