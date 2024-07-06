namespace MinimalApiOrg.Endpoints;

public static class EndpointsExtensions
{
    public static void UseEndpoints(this WebApplication app)
    {
        app.MapCategoryEndpoints();
    }
}
