using green_city_be.DOMAIN.Core.Entities;

namespace green_city_be.DOMAIN.Core.Interfaces
{
    public interface IReportRepository
    {
        Task<int> AddReport(Report report);
        Task<Report> GetReportById(int id);
        Task<IEnumerable<Report>> GetReports();
        Task<bool> UpdateReport(Report report);
    }
}