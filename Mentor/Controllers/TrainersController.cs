using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor.DAL;
using Mentor.Models;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Mentor.ViewModels;

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
        public async Task<IActionResult> load()
        {
            IEnumerable<TrainerVM> trainers = await _context.Trainers.Include(t => t.Category).OrderByDescending(t => t.Id).Take(6)
                .Select(x=> new TrainerVM
                {
                    Id=x.Id,
                    Name=x.Name,
                    SurName=x.SurName,
                    Image=x.Image,
                    Info=x.Info,
                    Facebook = x.Facebook,
                    Instagram=x.Instagram,
                    Twitter=x.Twitter,
                    Linkedin=x.Linkedin,
                    Category =new CategoryVM
                    {
                        Id=x.Category.Id,
                        Name=x.Category.Name
                    }


                }).ToListAsync();
            return Json(trainers);
        }
    }
}
