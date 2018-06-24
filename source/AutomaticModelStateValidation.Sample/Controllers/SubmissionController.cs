using System;
using Microsoft.AspNetCore.Mvc;

using AutomaticModelStateValidation.Sample.Models;

namespace AutomaticModelStateValidation.Controllers
{
    [Route("/")]
    public class SubmissionController : Controller
    {
        [HttpGet("")]
        public ActionResult NewSubmission()
        {
            // Load data for the blank form
            return View(new NewSubmissionViewModel()
            {
                Name = "" // Prefill
            });
        }

        [HttpPost("")]
        [AutoValidateModel(nameof(NewSubmission))]
        public RedirectToActionResult PostForm(SaveSubmissionViewModel model)
        {
            // Save submission to database
            return RedirectToAction(nameof(ViewSubmission), new { Id = 1 });
        }

        [HttpGet("{id}")]
        public ActionResult ViewSubmission(int id)
        {
            // Load submission from database
            return View(new ViewSubmissionViewModel()
            {
                Id = id
            });
        }
    }
}
