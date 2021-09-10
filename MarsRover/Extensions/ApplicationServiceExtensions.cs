using System;
using Application.Repository.Interfaces;
using Application.Repository.Move;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IMoveRover, MoveRover>();
            services.AddSingleton<HandleMovement, StartMoving>();

            return services;
        }

    }
}