namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            WebApplicationOptions webApplicationOptions = new WebApplicationOptions
            {
                WebRootPath = "MyWebRoot",
                Args = args, 
                EnvironmentName = "Production",
            };
            var builder = WebApplication.CreateBuilder(webApplicationOptions);
            var app = builder.Build();

            app.MapGet("/", () => $"EnvironmentName: {app.Environment.EnvironmentName} \n" +
            $"ApplicationName: {app.Environment.ApplicationName} \n" +
            $"WebRootPath: {app.Environment.WebRootPath} \n" +
            $"ContentRootPath: {app.Environment.ContentRootPath}");

            app.Run();
        }
    }
}
