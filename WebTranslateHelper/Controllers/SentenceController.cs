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
                NativeSentence = viewModel.NativeSentence
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

        private int GetRandomNumber(List<Sentence> sentences)
        {
            Random random = new();
            int num = random.Next(sentences.Count);
            return num;
        }

        [HttpGet]
        public async Task<IActionResult> StartTraining()
        {
            var sentences = await dbContext.Sentences.ToListAsync();
            int randomSentenceIndex = GetRandomNumber(sentences);

            return View(sentences[randomSentenceIndex]);
        }

        [HttpPost]
        public async Task<IActionResult> StartTraining(string Id, string foreignSentence)
        {
            var sentences = await dbContext.Sentences.ToListAsync();
            var sentence = sentences[GetRandomNumber(sentences)].ForeignSentence;
            if (Id == foreignSentence)
            {
                return Content("Right");
            }
            else
            {
                return Content("Incorrect");
            }
        }
    }
}
