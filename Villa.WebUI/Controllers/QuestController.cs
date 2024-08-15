using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.QuestDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
    public class QuestController : Controller
    {
        private readonly IQuestService _questService;
        private readonly IMapper _mapper;

        public QuestController(IQuestService questService, IMapper mapper)
        {
            _questService = questService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _questService.TGetListAsync();
            var questList = _mapper.Map<List<ResultQuestDto>>(values);
            return View(questList);
        }

        public async Task<IActionResult> DeleteQuest(ObjectId id)
        {
            await _questService.TDeleteAsync(id);
            return RedirectToAction("index");
        }

        public IActionResult CreateQuest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuest(CreateQuestDto createQuestDto)
        {
            var newQuest = _mapper.Map<Quest>(createQuestDto);
            await _questService.TCreateAsync(newQuest);
            return RedirectToAction("index");
        }

        public async Task<IActionResult> UpdateQuest(ObjectId id)
        {
            var value = await _questService.TGetByIdAsync(id);
            var quest = _mapper.Map<UpdateQuestDto>(value);
            return View(quest);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateQuest(UpdateQuestDto updateQuestDto)
        {
            var quest = _mapper.Map<Quest>(updateQuestDto);
            await _questService.TUpdateAsync(quest);
            return RedirectToAction("index");
        }
    }
}
