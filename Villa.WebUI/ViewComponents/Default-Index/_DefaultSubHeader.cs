using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.SubHeaderDtos;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultSubHeader : ViewComponent
    {
        private readonly ISubHeaderService _subHeaderService;
        private readonly IMapper _mapper;

        public _DefaultSubHeader(ISubHeaderService subHeaderService, IMapper mapper)
        {
            _subHeaderService = subHeaderService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _subHeaderService.TGetListAsync();
            var subHeaderList = _mapper.Map<List<ResultSubHeaderDto>>(values);
            return View(subHeaderList);
        }
    }
}
