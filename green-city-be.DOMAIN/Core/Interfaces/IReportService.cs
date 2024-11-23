using green_city_be.DOMAIN.Core.DTO;

namespace green_city_be.DOMAIN.Core.Interfaces
{
    public interface IReportService
    {
        Task<int> AddReport(ReportAddDTO reportAddDTO);
        Task<ReportDTO> GetReportById(int id);
        Task<IEnumerable<ReportDTO>> GetReports();
        Task<bool> UpdateStatusReport(ReportStatusDTO reportStatusDTO);
    }
}