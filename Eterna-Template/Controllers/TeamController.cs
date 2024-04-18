using Eterna_Template.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna_Template.Controllers
{
    public class TeamController : Controller
    {
        private List<TeamMember> GetTeamMembers()
        {
            var teamMembers = new List<TeamMember>
            {
                new TeamMember { Id = 1, Name = "John Doe", Position = "Developer", Description = "Lorem ipsum dolor sit amet" },
                new TeamMember { Id = 2, Name = "Jane Doe", Position = "Designer", Description = "Consectetur adipiscing elit" },
                new TeamMember { Id = 3, Name = "Juan Alvarez", Position = "Project Manager", Description = "Lorem ipsum dacia nose" }
            };

            return teamMembers;
        }

        public IActionResult Index()
        {
            var teamMembers = GetTeamMembers();
            return View(teamMembers);
        }
    }
}
