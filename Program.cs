namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 5
                };
                app.UseDeveloperExceptionPage(developerExceptionPageOptions);
            }

            app.Run(async (context) =>
            {
                int Number1 = 10, Number2 = 0;
                int Result = Number1 / Number2;
                await context.Response.WriteAsync("Request Handled and Response Generated");
            });
            //This will Run the Application
            app.Run();
        }
    }
}
