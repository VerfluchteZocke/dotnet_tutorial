namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapGet("/", () => $"EnvironmentName: {app.Environment.EnvironmentName} \n" +
            $"ApplicationName: {app.Environment.ApplicationName} \n" +
            $"WebRootPath: {app.Environment.WebRootPath} \n" +
            $"ContentRootPath: {app.Environment.ContentRootPath}");

            app.Run();
        }
    }
}
