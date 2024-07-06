namespace MinimalApiOrg.Endpoints;

public static class CategoryEndpoints
{
    public static void MapCategoryEndpoints(this WebApplication app)
    {
        app.MapGet("/category", () => "Hello World");
        app.MapPut("/category", () => "Hello World");
        app.MapPost("/category", () => "Hello World");
        app.MapDelete("/category", () => "Hello World");
    }
}
