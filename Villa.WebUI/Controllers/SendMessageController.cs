using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.MessageDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
    public class SendMessageController : Controller
    {
        private readonly IMessageService _messageservice;
        private readonly IMapper _mapper;

        public SendMessageController(IMessageService messageService, IMapper mapper)
        {
            _messageservice = messageService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
        {
            var newMessage = _mapper.Map<Message>(createMessageDto);
            await _messageservice.TCreateAsync(newMessage);
            return RedirectToAction("Index", "Default");
        }
    }
}
