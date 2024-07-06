namespace MinimalApiOrg.Extensions;

public static class AppExtensions
{
    public static void UseArchitectures(this WebApplication app)
    {
        app.UseCors();
    }
}
