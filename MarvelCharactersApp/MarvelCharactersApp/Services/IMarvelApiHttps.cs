using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MarvelCharactersApp.Models;

namespace MarvelCharactersApp.Services
{
    public interface IMarvelApiHttps
    {
        Task<Result> GetAllCharacter();
    }
}
