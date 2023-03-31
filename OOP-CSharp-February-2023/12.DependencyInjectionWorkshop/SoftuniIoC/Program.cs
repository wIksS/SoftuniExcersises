

using _12.DependencyInjectionWorkshop;
using _12.DependencyInjectionWorkshop.Contracts;
using ChessDependencyInversion.Renderers;
using SoftuniIoC;
using SoftuniIoC.Contracts;
using SoftuniIoC.Example;

SoftuniIoC.Contracts.IServiceProvider serviceProvider = ServiceConfigurator.ConfigureServices();

IPromotionService promotionService = serviceProvider.GetService<IPromotionService>();

promotionService.GetPromotion();