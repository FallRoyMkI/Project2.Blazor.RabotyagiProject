using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;

namespace RabotyagiProject.Bll
{
    public class WorkingDayManager
    {
        MapperX _mapperX = new MapperX();
        public IWorkingDayRepository WorkingDayRepository { get; set; }
        public WorkingDayManager(IWorkingDayRepository repository = null)
        {
            if (repository != null)
            {
                WorkingDayRepository = repository;
            }
            else
            {
                WorkingDayRepository = new WorkingDayRepository();
            }
        }

        public List<WorkingDayOutputModel> GetAllWorkingDays()
        {
            var workingDays = WorkingDayRepository.GetAllWorkingDays();
            var result = _mapperX.WorkingDayToListWorkingDayOutputModel(workingDays);
            return result;
        }
    }
}
