using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using Task_Management.Models;
using TMS.Areas.Identity.Data;

namespace TMS.Controllers
{
    public class ProjectController : Controller
    {
        private readonly TMSContext _context; // Replace TMSContext with your actual DbContext class
        private readonly ILogger<ProjectController> _logger; // Logger for error tracking

        // Constructor to inject the DbContext and ILogger
        public ProjectController(TMSContext context, ILogger<ProjectController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /Project/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Project/Create
        [HttpPost]
        public async Task<IActionResult> Create(Project model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Add the new project to the database
                    _context.Projects.Add(model);
                    await _context.SaveChangesAsync(); // Use async to avoid blocking the thread
                    return RedirectToAction("Index");  // Redirect to the Index action to list projects
                }
                catch (Exception ex)
                {
                    // Log the exception
                    _logger.LogError(ex, "An error occurred while saving the project.");
                    ModelState.AddModelError("", "An error occurred while saving the project.");
                }
            }
            else
            {
                // Log validation errors
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    _logger.LogWarning("Model validation error: {Error}", error.ErrorMessage);
                }
            }

            // If we got this far, something failed; redisplay the form
            return View(model);
        }

        // GET: /Project/Index
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                // Retrieve and display a list of projects
                var projects = _context.Projects.ToList(); // Fetch all projects from the database
                return View(projects); // Pass the list to the Index view
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError(ex, "An error occurred while retrieving the projects.");
                return View("Error"); // Show a generic error view if something goes wrong
            }
        }
    }
}
