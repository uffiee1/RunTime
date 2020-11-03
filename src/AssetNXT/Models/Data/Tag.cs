﻿using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AssetNXT.Models.Data
{
    public class Tag : ITag
    {
        public double AccelX { get; set; }

        public double AccelY { get; set; }

        public double AccelZ { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        public int DataFormat { get; set; }

        public int DefaultBackground { get; set; }

        public bool Favorite { get; set; }

        public double Humidity { get; set; }

        public double HumidityOffset { get; set; }

        [MaxLength(250)]
        public string Id { get; set; }

        public int MeasurementSequenceNumber { get; set; }

        public int MovementCounter { get; set; }

        public long Pressure { get; set; }

        public int Rssi { get; set; }

        public double Temperature { get; set; }

        public int txPower { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateAt { get; set; }

        public double Voltage { get; set; }
    }
}
