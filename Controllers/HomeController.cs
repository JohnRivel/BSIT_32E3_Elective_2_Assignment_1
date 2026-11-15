using BSIT_32E3_Elective_2_Assignment_1.Data;
using BSIT_32E3_Elective_2_Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT_32E3_Elective_2_Assignment_1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new QuizViewModel
        {
            Title = "Assignment 1",
            Subtitle = "BSIT 32E3 Elective 2, Assignment 1",
            Questions = QuestionBank.All
        };

        return View(model);
    }

    public IActionResult Error() => View();
}
