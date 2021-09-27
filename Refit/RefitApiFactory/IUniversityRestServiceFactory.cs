using RefitProject.Apis;

namespace RefitProject.RefitApiFactories
{
    public interface IUniversityRestServiceFactory
    {
        IUniversitiesListApi GetRestService();
    }
}