using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.ProductDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _productService.TGetListAsync();
            var productList = _mapper.Map<List<ResultProductDto>>(values);
            return View(productList);
        }

        public async Task<IActionResult> DeleteProduct(ObjectId id)
        {
            await _productService.TDeleteAsync(id);
            return RedirectToAction("index");
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            var newProduct = _mapper.Map<Product>(createProductDto);
            await _productService.TCreateAsync(newProduct);
            return RedirectToAction("index");
        }

        public async Task<IActionResult> UpdateProduct(ObjectId id)
        {
            var value = await _productService.TGetByIdAsync(id);
            var product = _mapper.Map<UpdateProductDto>(value);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Product>(updateProductDto);
            await _productService.TUpdateAsync(product);
            return RedirectToAction("index");
        }

        public async Task<IActionResult> ProductDetails(ObjectId id)
        {
            var value = await _productService.TGetByIdAsync(id);
            var product = _mapper.Map<ResultProductDto>(value);
            return View(product);
        }
    }
}
