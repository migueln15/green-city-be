using green_city_be.DOMAIN.Core.DTO;
using green_city_be.DOMAIN.Core.Entities;
using green_city_be.DOMAIN.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_city_be.DOMAIN.Core.Services
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }
        public async Task<IEnumerable<ReportDTO>> GetReports()
        {
            var reports = await _reportRepository.GetReports();
            var reportsDTO = new List<ReportDTO>();

            foreach (var report in reports)
            {
                var reportDTO = new ReportDTO();
                reportDTO.Id = report.Id;
                reportDTO.Title = report.Title;
                reportDTO.Detail = report.Detail;
                reportDTO.Type = report.Type;
                reportDTO.Location = report.Location;
                reportDTO.Status = report.Status;

                reportsDTO.Add(reportDTO);
            }
            return reportsDTO;
        }

        public async Task<ReportDTO> GetReportById(int id)
        {
            var report = await _reportRepository.GetReportById(id);
            var reportDTO = new ReportDTO();

            reportDTO.Id = report.Id;
            reportDTO.Title = report.Title;
            reportDTO.Detail = report.Detail;
            reportDTO.Type = report.Type;
            reportDTO.Location = report.Location;
            reportDTO.Status = report.Status;

            return reportDTO;
        }

        public async Task<int> AddReport(ReportAddDTO reportAddDTO)
        {
            var report = new Report();
            report.UserId = reportAddDTO.UserId;
            report.Title = reportAddDTO.Title;
            report.Detail = reportAddDTO.Detail;
            report.Type = reportAddDTO.Type;
            report.Location = reportAddDTO.Location;
            report.Status = "P";

            return await _reportRepository.AddReport(report);
        }

        public async Task<bool> UpdateStatusReport(ReportStatusDTO reportStatusDTO)
        {
            var report = await _reportRepository.GetReportById(reportStatusDTO.Id);
            if (report == null) return false;

            report.Status = reportStatusDTO.Status;

            return await _reportRepository.UpdateReport(report);

        }
    }
}
