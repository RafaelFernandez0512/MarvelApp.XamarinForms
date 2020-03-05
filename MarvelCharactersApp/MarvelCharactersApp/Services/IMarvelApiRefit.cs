using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MarvelCharactersApp.Models;

namespace MarvelCharactersApp.Services
{   
    public interface IMarvelApiRefit
    {
        [Get("/v1/public/characters?orderBy=-modified&limit=50&ts=1&apikey={apikey}&hash={hash}")]
        Task<Result> GetModifiedCharacter(string apikey, string hash);
        [Get("/v1/public/characters/{id}/comics?limit=5&apikey={apikey}&hash={hash}&ts={ts}")]
        Task<ResultComics> GetComicCharacter(string id,string apikey,string hash,string ts);

    }
}
