using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridController : ControllerBase
    {
        private IBottomGridRepository _bottomGridRepository;
        public BottomGridController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid([FromBody] CreateBottomGridDto createcategoryDto)
        {
            await _bottomGridRepository.CreateBottomGrid(createcategoryDto);
            return Ok("Veri kısmı başarılı bir şekilde eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            await _bottomGridRepository.DeleteBottomGrid(id);
            return Ok("Veri kısmı başarılı bir şekilde silindi");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBottomGrid(int id, UpdateBottomGridDto updateBottomGridDto)
        {
            updateBottomGridDto.BottomGridID = id;
            await _bottomGridRepository.UpdateBottomGrid(updateBottomGridDto);
            return Ok("Veri kısmı başarıyla güncellendi");
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var value = await _bottomGridRepository.GetBottomGrid(id);
            return Ok(value);
        }
    }
}
