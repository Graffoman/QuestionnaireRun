using Services.Abstractions;
using Services.Repositories.Abstractions;
using WebApi.Settings;
using Infrastructure.DataAcess;
using Infrastructure.Repositories.Implementations;
using Services.Implementations;
using Domain.Entities.Classes;
using Infrastructure.DataAcces;

namespace WebApi
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationSettings = configuration.Get<ApplicationSettings>();
            services.AddSingleton(applicationSettings)
                    .AddSingleton((IConfigurationRoot)configuration)
                    .InstallMongoDB()
                    .InstallServices()
                    .InstallRepositories();
            return services;
        }

        private static IServiceCollection InstallMongoDB(this IServiceCollection serviceCollection)
        {
            MongoDBClassMap.RegisterClassMaps();
            serviceCollection
                .AddSingleton<MongoDB<QuestionnaireRun>>()
                .AddSingleton<MongoDB<QuestionnaireSubmit>>();
                //.AddSingleton<MongoDB<UserGroup>>();
            return serviceCollection;
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionnaireRunService, QuestionnaireRunService>()
                .AddTransient<IQuestionnaireSubmitService, QuestionnaireSubmitService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IUserGroupService, UserGroupService>();
            return serviceCollection;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IQuestionnaireRunRepository, QuestionnaireRunRepository>()
                .AddTransient<IQuestionnaireSubmitRepository, QuestionnaireSubmitRepository>()
                .AddTransient<IUserRepository, UserRepository>()
                .AddTransient<IUserGroupRepository, UserGroupRepository>();
            return serviceCollection;
        }
    }
}
