using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Handlers.Command;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Handlers.Queries;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Command;
using StudentHousingAccomodation.Application.Features.RoleHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Commands;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Handlers.Queries;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Commands;
using StudentHousingAccomodation.Application.Features.UserHandlersRequest.Requests.Queries;
using StudentHousingAccomodation.Data.Data;
using StudentHousingAccomodation.Domain.Dtos.UserDtos;
using StudentHousingAccomodation.Domain.Records;
using StudentHousingAccomodation.Infrastructure.Repositories.Contracts;
using StudentHousingAccomodation.Infrastructure.Repositories.Implementations;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Safely retrieve the connection string and handle potential null values
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("The connection string 'DefaultConnection' is not configured.");
}
builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(connectionString));

// Bind JwtSection from configuration
var jwtSection = builder.Configuration.GetSection("JwtSection").Get<JwtSection>();
if (jwtSection == null)
{
    throw new ArgumentNullException(nameof(builder.Configuration), "JwtSection configuration is missing.");
}

// Corrected line to fix CS1503
builder.Services.Configure<JwtSection>(options =>
{
    options.Key = jwtSection.Key;
    options.Issuer = jwtSection.Issuer;
    options.Audience = jwtSection.Audience;
});

builder.Services.AddLogging();
builder.Services.AddMemoryCache();

// Configure JWT authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSection.Issuer,
        ValidAudience = jwtSection.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSection.Key!))
    };
});

///

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(de => de.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
// Register repositories
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<IUserAccountRepository, UserAccountRepository>();
builder.Services.AddTransient<IUserRolesRepository, UserRolesRepository>();
builder.Services.AddTransient<IPropertyImageRepository, PropertyImageRepository>();
builder.Services.AddTransient<IPropertyInformationRepository, PropertyInformationRepository>();
builder.Services.AddTransient<IRoomInformationRepository, RoomInformationRepository>();
builder.Services.AddTransient<ILandLordInformationRepository, LandLordInformationRepository>();
builder.Services.AddTransient<IPropertyAmentiesInformationRepository, PropertyAmentiesInformationRepository>();
builder.Services.AddTransient<IPropertyRatingRepository, PropertyRatingRepository>();
builder.Services.AddTransient<IStudentInformationRepository, StudentInformationRepository>();
builder.Services.AddTransient<IStudentInterestsRepository, StudentInterestsRepository>();

// Register other services and handlers
builder.Services.AddTransient<IRequestHandler<GetAllRolesNameRequest, List<string>>, GetAllRolesNameHandler>();
builder.Services.AddTransient<IRequestHandler<CreateNewRoleRequest, GeneralResponse>, CreateNewRoleHandler>();
//
// Register handlers
builder.Services.AddTransient<IRequestHandler<CreateUserRequest, GeneralResponse>, CreateUserHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllUserRequest, List<GetUserDto>>, GetAllUserHandler>();
builder.Services.AddTransient<IRequestHandler<GetUserRequest, GetUserDto>, GetUserHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateUserRequest, GeneralResponse>, UpdateUserHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteUserRequest, GeneralResponse>, DeleteUserHandler>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()// Replace with your Blazor WASM URL
        .AllowAnyMethod()
        .AllowAnyHeader());
});

// Pass the required 'Configuration' argument.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins");
app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();