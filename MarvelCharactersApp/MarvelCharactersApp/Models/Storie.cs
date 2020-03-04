using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelCharactersApp.Models
{
    public class Storie
    {
        [JsonProperty("available")]
        public int Available { get; set; }
        [JsonProperty("returned")]
        public int Returned { get; set; }
    }
}
