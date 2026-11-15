# BSIT_32E3_Elective_2_Assignment_1

ASP.NET Core MVC (.NET 8) app that shows the answer key for the SSR (MVC) vs Web API quiz.

## Run
```bash
dotnet run
```
Open the URL printed in the terminal (https://localhost:7032 by default).

## Structure
- `Models/`: `QuizQuestion`, `QuizViewModel`
- `Data/QuestionBank.cs`: the 8 questions, options, correct answers, explanations
- `Controllers/HomeController.cs`: builds the view model
- `Views/Home/Index.cshtml`: renders the questions and highlights correct answers

## Answers
1. B, 2. B, 3. C, 4. B, 5. C, 6. B, 7. B, 8. C
