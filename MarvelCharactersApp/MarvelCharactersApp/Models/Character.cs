using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelCharactersApp.Models
{
    public class Character
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }
        [JsonProperty("comics")]
        public Comic Comics { get; set; }

        [JsonProperty("stories")]
        public Storie Stories { get; set; }
        public string ImageCharacter { get => $"{Thumbnail.Path}/portrait_uncanny.{Thumbnail.Extension}"; }
    }
}
