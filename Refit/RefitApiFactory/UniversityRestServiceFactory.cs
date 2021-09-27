using Refit;
using RefitProject.Apis;

namespace RefitProject.RefitApiFactories
{
    public class UniversityRestServiceFactory : IUniversityRestServiceFactory
    {
        // Universities List - http://universities.hipolabs.com/search?country=United+States

        public IUniversitiesListApi GetRestService()
        {
            return RestService.For<IUniversitiesListApi>("http://universities.hipolabs.com");
        }
    }
}
