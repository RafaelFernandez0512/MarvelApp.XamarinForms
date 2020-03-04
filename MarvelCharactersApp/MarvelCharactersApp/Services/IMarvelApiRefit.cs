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
        [Get("/v1/public/characters?orderBy=-modified&limit=50&apikey=445556eb3e7671e571444d16f5c27178&hash=aa94487622d2f42736c0f89b617b7381&ts=1")]
        Task<Result> GetModifiedCharacter();
        [Get("/v1/public/characters/{id}/comics?limit=5&apikey=445556eb3e7671e571444d16f5c27178&hash=aa94487622d2f42736c0f89b617b7381&ts=1")]
        Task<ResultComics> GetComicCharacter(string id);

    }
}
