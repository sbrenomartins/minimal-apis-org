namespace MinimalApiOrg.Extensions;

public static class BuilderExtensions
{
    public static void AddArchitectures(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();
        builder.Services.AddRazorComponents();
        builder.Services.AddServices();
    }

    public static void AddServices(this IServiceCollection services)
    {
        // Add Services
    }
}
