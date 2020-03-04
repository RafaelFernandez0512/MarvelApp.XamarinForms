using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelCharactersApp.Models
{
    public class Comic
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("digitalId")]
        public int DigitalId { get; set; }

        [JsonProperty("title")]
        public string Name { get; set; }
        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }


        [JsonProperty("returned")]
        public int Returned { get; set; }
        public string ImageCharacter { get => $"{Thumbnail.Path}/portrait_uncanny.{Thumbnail.Extension}"; }
    }
    public class DataComic
    {

        [JsonProperty("results")]
        public IList<Comic> Comics { get; set; }
    }

    public class ResultComics
    {
        [JsonProperty("data")]
        public DataComic Data { get; set; }
    }
}
