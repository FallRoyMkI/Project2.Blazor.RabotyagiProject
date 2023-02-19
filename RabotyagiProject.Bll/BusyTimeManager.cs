using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;

namespace RabotyagiProject.Bll
{
    public class BusyTimeManager
    {
        MapperX _mapperX = new MapperX();
        public IBusyTimeRepository BusyTimeRepository { get; set; }

        public List<BusyTimeOutputModel> GetAllBusyTime()
        {
            var allBusy = BusyTimeRepository.GetAllBusyTime();
            var result = _mapperX.MapBusyTimeDtoToListBusyTimeOutputModel(allBusy);
            return result;
        }

        public List<BusyTimeOutputModel> GetAllBusyTimeByTimetableId(int timetableId)
        {
            var allBusy = BusyTimeRepository.GetAllBusyTimeByTimetableId(timetableId);
            var result = _mapperX.MapBusyTimeDtoToListBusyTimeOutputModel(allBusy);
            return result;
        }
    }
}
