using System;
using Application.Repository.Interfaces;
using Application.Repository.Move;
using MarsRover.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace MarsRover
{
    class Program
    {

        
        static void Main(string[] args)
        {


            var maxPoints = Console.ReadLine().Split(' ');
            var currentLocation = Console.ReadLine().Split(' ');
            var movement = Console.ReadLine();

            var services = new ServiceCollection();
            ApplicationServiceExtensions.AddApplicationServices(services);
            var _serviceProvider = services.BuildServiceProvider(true);
            var _moveRover = new MoveRover();
            var _handleMovement = new StartMoving();
            // var _moveRover = _serviceProvider.GetService<IMoveRover>();
            // var _handleMovement = _serviceProvider.GetService<HandleMovement>();


            var coordinates = _moveRover.Move(maxPoints, currentLocation, movement, _handleMovement);

            if (coordinates != null)
                Console.WriteLine(coordinates.X + " " + coordinates.Y + " " + coordinates.directions);
            else
                Console.WriteLine("Bad Request");
        }
    }
}