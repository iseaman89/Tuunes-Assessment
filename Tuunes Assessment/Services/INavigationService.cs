namespace Tuunes_Assessment.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync(string route, IDictionary<string, object> parameters = null);
        Task NavigateBackAsync();
    }
}