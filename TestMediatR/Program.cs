using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TestMediatR;

var services = new ServiceCollection();
services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

var serviceProvider = services.BuildServiceProvider();
var mediator = serviceProvider.GetService<IMediator>();

var response = await mediator!.Send(new Ping { Message = "Ping!" });
Console.WriteLine(response.Response);