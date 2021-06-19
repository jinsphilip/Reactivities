using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace API.Controllers
{
    public class ActivitiesController : BasicApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext dataContext)
        {
            _context = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivityById(Guid id)
        {

            return await _context.Activities.FindAsync(id);
        }

    }
}