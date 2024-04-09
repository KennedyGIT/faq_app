using Microsoft.AspNetCore.Mvc;
using faq_app.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace faq_app.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly FaqDataContext _context;

        public HomeController(FaqDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("topic/{topicName}")]
        public IActionResult Index(string topicName)
        {
            var faqs = _context.Faqs.Where(f => f.Topic.TopicName.ToLower() == topicName.ToLower()).Include(f => f.Topic).Include(f => f.Category).ToList();
            return View("Index", faqs);
        }

        [HttpGet]
        [Route("category/{categoryName}")]
        public IActionResult IndexByCategory(string categoryName)
        {
            var faqs = _context.Faqs.Where(f => f.Category.CategoryName.ToLower() == categoryName.ToLower()).Include(f => f.Topic).Include(f => f.Category).ToList();
            return View("Index", faqs);
        }

        [HttpGet]
        [Route("topic/{topicName}/category/{categoryName}")]
        public IActionResult IndexByTopicAndCategory(string topicName, string categoryName)
        {
            var faqs = _context.Faqs.Where(f => f.Topic.TopicName.ToLower() == topicName.ToLower() &&
                                                 f.Category.CategoryName.ToLower() == categoryName.ToLower()).Include(f => f.Topic).Include(f => f.Category).ToList();
            return View("Index", faqs);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var faqs = _context.Faqs.Include(f => f.Topic).Include(f => f.Category).ToList();
            return View(faqs);
        }
    }
}
