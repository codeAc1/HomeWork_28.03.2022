using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor.DAL;
using Mentor.Models;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace Mentor.Controllers
{
    public class TrainersController : Controller
    {
        private readonly MentorDbContext _context;

        public TrainersController(MentorDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Trainer> trainers = await _context.Trainers.Include(t=>t.Category).OrderByDescending(t=>t.Id).Take(6).ToListAsync();
            return View(trainers);
        }
    }
}
