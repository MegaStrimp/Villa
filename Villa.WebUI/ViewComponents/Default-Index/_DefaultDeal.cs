using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.DealDtos;

namespace Villa.WebUI.ViewComponents.Default_Index
{
    public class _DefaultDeal : ViewComponent
    {
        private readonly IDealService _bannerService;
        private readonly IMapper _mapper;

        public _DefaultDeal(IDealService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.TGetListAsync();
            var bannerList = _mapper.Map<List<ResultDealDto>>(values);
            return View(bannerList);
        }
    }
}
