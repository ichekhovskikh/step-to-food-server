﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StepToFoodServer.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        [JsonIgnore]
        public ICollection<ProductFood> ProductFoods { get; set; }

        [NotMapped]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludedInSearch { get; set; }
    }
}
