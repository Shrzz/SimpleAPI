using Microsoft.AspNetCore.Mvc;
using Simple_API.Models;
using Simple_API.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IFilmService, FilmService>();

var app = builder.Build();



app.MapPost("/create", 
    (Film film, IFilmService service) =>
    {
        var result = service.Create(film);
        return Results.Ok(result);
    });

app.MapGet("/get", (int id, IFilmService service) =>
{
    var result = service.Get(id);

    if (result is null) return Results.NotFound("Film not found");

    return Results.Ok(result);
});

app.MapGet("/list", (IFilmService service) =>
{
    var result = service.GetAll();

    return Results.Ok(result);
});

app.MapPut("/update", (Film film, IFilmService service) =>
{
    var newFilm = service.Update(film);

    if (newFilm is null)
    {
        return Results.NotFound("Film not found");
    }

    return Results.Ok(newFilm);
});

app.MapDelete("/delete", (int id, IFilmService service) => 
{
    var result = service.Delete(id);

    if (!result) return Results.BadRequest("Somenthing went wrong");

    return Results.Ok(result);
});

app.Run();
