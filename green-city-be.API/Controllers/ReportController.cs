using green_city_be.DOMAIN.Core.DTO;
using green_city_be.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace green_city_be.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("GetReports")]
        public async Task<IActionResult> GetReports()
        {
            var reports = await _reportService.GetReports();
            return Ok(reports);
        }

        [HttpGet("GetReportById/{id}")]
        public async Task<IActionResult> GetReportById(int id)
        {
            return Ok(await _reportService.GetReportById(id));
        }

        [HttpPost("AddReport")]
        public async Task<IActionResult> AddReport([FromBody] ReportAddDTO reportAddDTO)
        {
            int id =  await _reportService.AddReport(reportAddDTO);
            return Ok(id);
        }

        [HttpPut("UpdateStatusReport")]
        public async Task<IActionResult> UpdateStatusReport([FromBody] ReportStatusDTO reportStatusDTO)
        {
            var result = await _reportService.UpdateStatusReport(reportStatusDTO);
            if (!result) return BadRequest();
            return Ok(result);
        }
    }
}
