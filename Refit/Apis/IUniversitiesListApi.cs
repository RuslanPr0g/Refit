using Microsoft.AspNetCore.Mvc;
using Refit;
using RefitProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefitProject.Apis
{
    public interface IUniversitiesListApi
    {
        [Get("/search")]
        Task<IEnumerable<University>> GetUniversities([FromQuery] string country);
    }
}
