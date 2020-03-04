using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelCharactersApp.Models
{
   public class Serie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }


        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
        public string ImageCharacter { get => $"{Thumbnail.Path}/portrait_uncanny.{Thumbnail.Extension}"; }

    }
    public class ResultSerie
    {
        [JsonProperty("data")]
        public DataSerie Data { get; set; }
    }

    public class DataSerie
    {

        [JsonProperty("results")]
        public IList<Serie> Series { get; set; }
    }
}
