

using Microsoft.AspNetCore.Builder;
using Microsoft.Graph.Models;

var builder= WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app= builder.Build();

var webSocketOptions= new WebSocketOptions
{
    KeepAliveInterval= TimeSpan.FromSeconds(120),
    //ReceiveBufferSize= 4 * 1024
};

app.UseWebSockets(webSocketOptions);

app.UseDefaultFiles();  
app.UseStaticFiles();

app.MapControllers();
app.Run();