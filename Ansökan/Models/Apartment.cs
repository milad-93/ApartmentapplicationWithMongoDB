﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ansökan.Models
{
 
    [BsonIgnoreExtraElements] // if not it crash it skips  to deserialize the ignored one
    public class Apartment
    {     
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [DisplayName("[POST-ID]")]
        public ObjectId _id { get; set; }

        [BsonIgnore]
        public string _idString
        {
            get
            {
                return _id.ToString();
            }
        }

        [Required]
        [DisplayName("Adress")]
        public string adress { get; set; }

        [Required]
        [DisplayName("Elevator")]
        public string elevator { get; set; }

        [Required]
        [DisplayName("Rooms")]
        public string nOfRooms { get; set; }
        [Required]
        [DisplayName("Balcony")]
        public string balcony { get; set; }
        [Required]
        [DisplayName("Squaremeter")]
        public string squareMeter { get; set; }
        [Required]
        [DisplayName("Floor")]
        public string floor { get; set; }

        // converting the id to a string in order to show it in the userinterface
        public static IMongoCollection<Apartment> apartmentCollection { get; set; }
    }
  


}