using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Eterna_Template.Models;
using Eterna_Template.ViewModels;

namespace Eterna_Template.Controllers;

public class HomeController : Controller
{
    List<Feature> Features = new List<Feature>();
    List<Service> Services = new List<Service>();
    public HomeController()
    {
        Services = new List<Service>()
        {
             new Service
             {
                 Id=1,
                 Name="Service 1",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=2,
                 Name="Service 2",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=3,
                 Name="Service 3",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=4,
                 Name="Service 4",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=5,
                 Name="Service 5",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
             new Service
             {
                 Id=6,
                 Name="Service 6",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"

             },
        };
        Features = new List<Feature>()
           {
             new Feature
             {
                 Id=1,
                 Name="Feature 1",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"

             },
             new Feature
             {
                 Id=2,
                 Name="Feature 2",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"

             },
             new Feature
             {
                 Id=3,
                 Name="Feature 3",
                 Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"

             },
        };
        
}
    public IActionResult Index()
    {
        HomeViewModel hv = new HomeViewModel();
        hv.Services = Services;
        hv.Features = Features;
       return View(hv);
    }
}
