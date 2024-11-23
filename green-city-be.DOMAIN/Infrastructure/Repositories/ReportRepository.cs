using green_city_be.DOMAIN.Core.Entities;
using green_city_be.DOMAIN.Core.Interfaces;
using green_city_be.DOMAIN.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_city_be.DOMAIN.Infrastructure.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly GreenCityDbContext _dbContext;

        public ReportRepository(GreenCityDbContext dbContext) { _dbContext = dbContext; }

        public async Task<IEnumerable<Report>> GetReports()
        {
            var reports = await _dbContext.Report.ToListAsync();
            return reports;
        }

        public async Task<Report> GetReportById(int id)
        {
            var report = await _dbContext.Report.Where(c => c.Id == id).FirstOrDefaultAsync();
            return report;
        }

        public async Task<int> AddReport(Report report)
        {
            await _dbContext.Report.AddAsync(report);

            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0 ? report.Id : -1;
        }

        public async Task<bool> UpdateReport(Report report)
        {
            _dbContext.Report.Update(report);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }



    }
}
