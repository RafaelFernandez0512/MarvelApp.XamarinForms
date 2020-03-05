using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MarvelCharactersApp.Models;

namespace MarvelCharactersApp.Services
{
    public class MarvelApi: IMarvelApiHttps
    {
        const string ApiUrlHttp = "https://gateway.marvel.com:443/v1/public/characters?limit=100";
        public async Task<Result> GetAllCharacter()
        {
            HttpClient client = new HttpClient();
            var characters = await client.GetStringAsync($"{ApiUrlHttp}&apikey={ApiConfig.ApiKeyMarvel}&hash={ApiConfig.HashKeyMarvel}&ts=1");
            return JsonConvert.DeserializeObject<Result>(characters);
        }

        public async Task<Result> GetModifiedCharacter()
        {
            var getRequest = RestService.For<IMarvelApiRefit>($"{ApiConfig.UrlMarvel}");
            var characters = await getRequest.GetModifiedCharacter(ApiConfig.ApiKeyMarvel, ApiConfig.HashKeyMarvel);
            return characters;

        }
       public async Task<ResultComics> GetComicCharacter(string id)
        {
            var getRequest = RestService.For<IMarvelApiRefit>(ApiConfig.UrlMarvel);
            var characters = await getRequest.GetComicCharacter(id,ApiConfig.ApiKeyMarvel, ApiConfig.HashKeyMarvel, ApiConfig.TSKeyMarvel);
            return characters;

        }

    }
}
