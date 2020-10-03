<Query Kind="Statements">
  <Namespace>Microsoft.Extensions.Hosting</Namespace>
  <Namespace>Microsoft.AspNetCore.Hosting</Namespace>
  <Namespace>Microsoft.AspNetCore.Builder</Namespace>
  <IncludeAspNet>true</IncludeAspNet>
</Query>

Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webBuilder =>
{
	webBuilder.Configure(app =>
	{
		app.UseRouting();
		
		app.UseEndpoints(endpoints =>
		{
			endpoints.MapGet("/", async context =>
			{
				Console.WriteLine(new {a = "a"});
				await context.Response.BodyWriter.WriteAsync(Encoding.UTF8.GetBytes("Hello, world!"));
			});
		});
	});
}).Build().Run();