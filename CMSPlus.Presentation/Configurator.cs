using CMSPlus.Domain.Persistence;
using CMSPlus.Presentation.Validations.Topic;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace CMSPlus.Presentation;

public static class Configurator
{
    public static void AddPresentation(this IServiceCollection services)
    {
        services.AddRazorPages().AddRazorRuntimeCompilation();
        services.AddScoped<TopicValidatorHelpers>();
        services.AddValidatorsFromAssembly(typeof(Program).Assembly);
        services.AddControllersWithViews();
        services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>();
        services.AddDatabaseDeveloperPageExceptionFilter();
    }

    public static void AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Program).Assembly);
    }
}
