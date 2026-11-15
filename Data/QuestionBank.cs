using BSIT_32E3_Elective_2_Assignment_1.Models;

namespace BSIT_32E3_Elective_2_Assignment_1.Data;

public static class QuestionBank
{
    public static IReadOnlyList<QuizQuestion> All { get; } = new List<QuizQuestion>
    {
        new()
        {
            Number = 1,
            Text = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
            Options = new()
            {
                ["A"] = "SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server",
                ["B"] = "SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON",
                ["C"] = "SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers",
                ["D"] = "SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server"
            },
            CorrectKey = "B",
            Explanation = "In MVC (SSR) the server runs Razor views and returns finished HTML. A Web API returns only data (usually JSON) and leaves the rendering to whichever client calls it."
        },
        new()
        {
            Number = 2,
            Text = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
            Options = new()
            {
                ["A"] = "ControllerBase supports Razor View rendering using View() and ViewData",
                ["B"] = "ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead",
                ["C"] = "Controller is obsolete in .NET 8 and cannot handle HTTP POST requests",
                ["D"] = "ControllerBase automatically creates SQLite database files on application startup"
            },
            CorrectKey = "B",
            Explanation = "Controller derives from ControllerBase and adds view support (View(), ViewData, TempData). An API has no views, so ControllerBase is the lighter choice."
        },
        new()
        {
            Number = 3,
            Text = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
            Options = new()
            {
                ["A"] = "[Route]",
                ["B"] = "[HttpGet]",
                ["C"] = "[ApiController]",
                ["D"] = "[FromQuery]"
            },
            CorrectKey = "C",
            Explanation = "[ApiController] enables automatic model-state validation, so an invalid payload returns 400 Bad Request before the action body runs."
        },
        new()
        {
            Number = 4,
            Text = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
            Options = new()
            {
                ["A"] = "200 OK",
                ["B"] = "201 Created",
                ["C"] = "204 No Content",
                ["D"] = "404 Not Found"
            },
            CorrectKey = "B",
            Explanation = "201 Created signals that a new resource now exists. In ASP.NET Core, CreatedAtAction() sets the Location header for you."
        },
        new()
        {
            Number = 5,
            Text = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
            Options = new()
            {
                ["A"] = "200 OK",
                ["B"] = "201 Created",
                ["C"] = "204 No Content",
                ["D"] = "400 Bad Request"
            },
            CorrectKey = "C",
            Explanation = "204 No Content means the request succeeded and there is nothing to send back. In ASP.NET Core, return NoContent()."
        },
        new()
        {
            Number = 6,
            Text = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
            Options = new()
            {
                ["A"] = "GET /api/getAllCourses",
                ["B"] = "GET /api/courses",
                ["C"] = "POST /api/createNewCourseRecord",
                ["D"] = "POST /api/deleteCourseById?id=5"
            },
            CorrectKey = "B",
            Explanation = "REST URIs name resources with plural nouns. The HTTP verb states the action, so verbs like get, create, and delete do not belong in the path."
        },
        new()
        {
            Number = 7,
            Text = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
            Options = new()
            {
                ["A"] = "It connects the controller directly to an Entity Framework database context",
                ["B"] = "It maps incoming URI request paths to the controller class using the class name token",
                ["C"] = "It encrypts all incoming JSON payloads",
                ["D"] = "It enables Cross-Origin Resource Sharing (CORS) for external React apps"
            },
            CorrectKey = "B",
            Explanation = "The [controller] token is replaced by the class name minus the \"Controller\" suffix, so CoursesController is reached at /api/courses."
        },
        new()
        {
            Number = 8,
            Text = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
            Options = new()
            {
                ["A"] = "POST",
                ["B"] = "PUT",
                ["C"] = "GET",
                ["D"] = "DELETE"
            },
            CorrectKey = "C",
            Explanation = "GET is safe (it changes nothing) and idempotent (repeating it gives the same result). PUT and DELETE are idempotent but not safe; POST is neither."
        }
    };
}
