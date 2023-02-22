using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;

namespace RabotyagiProject.Bll
{
    public class TimetableManager
    {
        MapperX _mapperX = new MapperX();
        public ITimetableRepository TimetableRepository { get; set; }
        public TimetableManager(ITimetableRepository repository = null)
        {
            if (repository != null)
            {
                TimetableRepository = repository;
            }
            else
            {
                TimetableRepository = new TimetableRepository();
            }
        }

        public List<TimetableOutputModel> GetAllTimetable()
        {
            var timetable = TimetableRepository.GetAllTimetable();
            var result = _mapperX.MapTimetableDtoToListTimetableOutputModel(timetable);
            return result;

        }

        public List<TimetableOutputModel> GetAllTimetableByWorkerId(int workerId)
        {
            var timetables = TimetableRepository.GetAllTimetableByWorkerId(workerId);
            var result = _mapperX.MapTimetableDtoToListTimetableOutputModelById(timetables);
            return result;
        }
    }
}
