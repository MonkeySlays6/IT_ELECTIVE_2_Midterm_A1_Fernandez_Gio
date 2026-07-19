using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Name"] = "Gio N. Fernandez";
        ViewData["ProTitle"] = "IT Undergraduate";
        ViewData["Introduction"] = "Hi, I'm Gio Fernandez, a BSIT student at Lyceum of Alabang with a passion for technology and continuous learning. As an aspiring IT professional, I love sharpening my strategic thinking through chess and video games while working toward a bright, balanced future in the tech industry.";

        return View();
    }

    public IActionResult About()
    {
        ViewData["Biography1"] = "Hello! My name is Gio Fernandez, and I am currently a student at Lyceum of Alabang. I am pursuing a Bachelor of Science in Information Technology (BSIT), a choice driven by my fascination with technology and how it shapes our daily lives. Throughout my educational journey, I have been dedicated to building a solid foundation in tech concepts, and this course is providing me with the practical skills and knowledge needed to thrive in the digital age. Looking ahead, my ultimate career goal is to become a highly skilled IT professional, capable of tackling complex technological challenges.";
        ViewData["Biography2"] = "I am naturally curious, and one of my biggest interests is simply learning new things—whether that means picking up a new programming language or exploring how different systems work. When I am not studying, I love to unwind by playing chess and video games, both of which keep my strategic thinking sharp. Ultimately, my future plan is to secure a great job in the tech industry where I can grow professionally, while also making sure I take the time to truly enjoy life.";
        ViewData["Course"] = "Course: Bachelor of Science in Information Technology";
        ViewData["School"] = "School: Lyceum of Alabang";
        ViewData["S.Y."] = "Year: 3rd Year";
        ViewData["CareerGoal1"] = "Become an IT Professional.";
        ViewData["CareerGoal2"] = "Enjoy life.";
        ViewData["Interest1"] = "Cooking";
        ViewData["Interest2"] = "Gaming";
        ViewData["Interest3"] = "Reading";
        return View();
    }

    public IActionResult Skills()
    {
        ViewData["Language1"] = "C#";
        ViewData["Language2"] = "Java";
        ViewData["Language3"] = "Python";
        ViewData["WebTech1"] = "HTML";
        ViewData["WebTech2"] = "CSS"; 
        ViewData["WebTech3"] = "Bootstrap"; 
        ViewData["WebTech4"] = "ASP.NET Core MVC";
        ViewData["Database"] = "Microsoft Access";
        ViewData["DevTool1"] = "Visual Studio";
        ViewData["DevTool2"] = "NetBeans";
        ViewData["DevTool3"] = "PyCharm";
        ViewData["DevTool4"] = "Git";
        ViewData["DevTool5"] = "Github";
        return View();
    }

    public IActionResult Projects()
    {
        ViewData["Project1"] = "IT_ELECTIVE_2_Midterm_A1_Fernandez_Gio";
        ViewData["Description1"] = "A project about creating a portfolio website.";
        ViewData["Technology1"] = "ASP.NET Core MVC, Bootstrap, Visual Studio";
        ViewData["Project2"] = "BSIT_31E1_PRELIM_Q1_Fernandez_Gio";
        ViewData["Description2"] = "A quiz for debugging and fixing the code.";
        ViewData["Technology2"] = "C#, Visual Studio";
        ViewData["Project3"] = "BSIT31E1_PRELIM_H2_FERNANDEZ_GIO";
        ViewData["Description3"] = "A program about the file ingestion engine that reads in different formats.";
        ViewData["Technology3"] = "C#, Visual Studio";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Email"] = "gionfernandez060606@gmail.com";
        ViewData["Phone"] = "09XX-XXX-XXXX";
        ViewData["GitHub"] = "github.com/MonkeySlays6";
        ViewData["LinkedIn"] = "linkedin.com";
        ViewData["Facebook"] = "facebook.com/MonkeySlays.4081";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}