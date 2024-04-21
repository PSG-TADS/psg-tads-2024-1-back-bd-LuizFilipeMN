using locadoraVeiculos;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LocacaoDb>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Locadora de Veículos API", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Locadora de Veículos API V1");
    c.RoutePrefix = string.Empty;
});

app.MapGet("/veiculos", async (LocacaoDb db) => await db.Veiculo.ToListAsync());
app.MapPost(
    "/veiculos",
    async (LocacaoDb db, Veiculo veiculo) =>
    {
        db.Veiculo.Add(veiculo);
        await db.SaveChangesAsync();
        return Results.Created($"/veiculos/{veiculo.VeiculoId}", veiculo);
    }
);
app.MapPut(
    "/veiculos/{id}",
    async (LocacaoDb db, int id, Veiculo inputVeiculo) =>
    {
        var veiculo = await db.Veiculo.FindAsync(id);
        if (veiculo is null)
            return Results.NotFound();

        veiculo.Modelo = inputVeiculo.Modelo;
        veiculo.Marca = inputVeiculo.Marca;

        await db.SaveChangesAsync();

        return Results.NoContent();
    }
);
app.MapDelete(
    "/veiculos/{id}",
    async (LocacaoDb db, int id) =>
    {
        var veiculo = await db.Veiculo.FindAsync(id);
        if (veiculo is null)
            return Results.NotFound();

        db.Veiculo.Remove(veiculo);
        await db.SaveChangesAsync();
        return Results.Ok(veiculo);
    }
);

app.MapGet("/clientes", async (LocacaoDb db) => await db.Cliente.ToListAsync());
app.MapPost(
    "/clientes",
    async (LocacaoDb db, Cliente cliente) =>
    {
        db.Cliente.Add(cliente);
        await db.SaveChangesAsync();
        return Results.Created($"/clientes/{cliente.ClienteId}", cliente);
    }
);
app.MapPut(
    "/clientes/{id}",
    async (LocacaoDb db, int id, Cliente inputCliente) =>
    {
        var cliente = await db.Cliente.FindAsync(id);
        if (cliente is null)
            return Results.NotFound();

        cliente.Nome = inputCliente.Nome;
        cliente.Sobrenome = inputCliente.Sobrenome;

        await db.SaveChangesAsync();

        return Results.NoContent();
    }
);
app.MapDelete(
    "/clientes/{id}",
    async (LocacaoDb db, int id) =>
    {
        var cliente = await db.Cliente.FindAsync(id);
        if (cliente is null)
            return Results.NotFound();

        db.Cliente.Remove(cliente);
        await db.SaveChangesAsync();
        return Results.Ok(cliente);
    }
);

app.MapGet("/reservas", async (LocacaoDb db) => await db.Reserva.ToListAsync());
app.MapPost(
    "/reservas",
    async (LocacaoDb db, Reserva reserva) =>
    {
        db.Reserva.Add(reserva);
        await db.SaveChangesAsync();
        return Results.Created($"/reservas/{reserva.ReservaId}", reserva);
    }
);
app.MapPut(
    "/reservas/{id}",
    async (LocacaoDb db, int id, Reserva inputReserva) =>
    {
        var reserva = await db.Reserva.FindAsync(id);
        if (reserva is null)
            return Results.NotFound();

        reserva.DataInicio = inputReserva.DataInicio;
        reserva.DataFim = inputReserva.DataFim;
        reserva.VeiculoId = inputReserva.VeiculoId;
        reserva.ClienteId = inputReserva.ClienteId;

        await db.SaveChangesAsync();

        return Results.NoContent();
    }
);
app.MapDelete(
    "/reservas/{id}",
    async (LocacaoDb db, int id) =>
    {
        var reserva = await db.Reserva.FindAsync(id);
        if (reserva is null)
            return Results.NotFound();

        db.Reserva.Remove(reserva);
        await db.SaveChangesAsync();
        return Results.Ok(reserva);
    }
);

app.Run();