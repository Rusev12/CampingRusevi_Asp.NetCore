﻿using System.IO;

namespace CampingRusevi.Data.Models
{
    public class ImageInputModel
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public Stream Content { get; set; }
    }
}
