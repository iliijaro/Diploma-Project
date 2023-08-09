namespace DiplomaProject.BaseEntities;

public class BaseService
{
    protected ApiClient _apiClient;

    protected BaseService(ApiClient apiClient)
    {
        _apiClient = apiClient;
    }
}