using Microsoft.AspNetCore.Mvc;
using Mission08_Team0301.Models;
using System.Diagnostics;

namespace Mission08_Team0301.Controllers
{
    public class HomeController : Controller
    {
        private IJobRepository _repo;

        public HomeController(IJobRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult JobForm()
        {
            var categories = _repo.Categories;
            ViewBag.Categories = categories;
            return View(new Job());
        }

        [HttpPost]
        public IActionResult JobForm(Job job)
        {
            if (ModelState.IsValid)
            {
                _repo.AddJob(job);
            }

            return RedirectToAction("Quadrants");
        }

        public IActionResult Quadrants()
        {
            var jobs = _repo.Jobs;

            return View(jobs);
        }



        [HttpPost]
        public IActionResult Complete(int id)
        {
            var job = _repo.Jobs
                .Single(x => x.JobId == id);

            _repo.CompleteJob(job);

            return RedirectToAction("Quadrants");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categories = _repo.Categories;
            ViewBag.Categories = categories;

            var job = _repo.Jobs
                .Single(x => x.JobId == id);

            return View("JobForm", job);
        }

        [HttpPost]
        public IActionResult Edit(Job job)
        {
            if (ModelState.IsValid)
            {
                _repo.EditJob(job);
            }

            return RedirectToAction("Quadrants");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var jobToDelete = _repo.Jobs
                .Single(x => x.JobId == id);

            return View(jobToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Job job)
        {
            _repo.DeleteJob(job);

            return RedirectToAction("Quadrants");
        }
    }
}
