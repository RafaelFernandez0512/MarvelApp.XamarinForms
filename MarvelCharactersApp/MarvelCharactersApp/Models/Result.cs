using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelCharactersApp.Models
{
    public class Result
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data {

        [JsonProperty("results")]
        public IList<Character> Characters { get; set; }
    }
}
