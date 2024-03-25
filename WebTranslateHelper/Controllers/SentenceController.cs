using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTranslateHelper.Data;
using WebTranslateHelper.Models;
using WebTranslateHelper.Models.Entities;

namespace WebTranslateHelper.Controllers
{
    public class SentenceController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public SentenceController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult AddSentence()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSentence(AddSentenceWithModel viewModel)
        {
            var sentence = new Sentence
            {
                ForeignSentence = viewModel.ForeignSentence,
                NativeSentece = viewModel.NativeSentence
            };

            await dbContext.Sentences.AddAsync(sentence);
            await dbContext.SaveChangesAsync();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var sentences = await dbContext.Sentences.ToListAsync();
            return View(sentences);
        }
    }
}
