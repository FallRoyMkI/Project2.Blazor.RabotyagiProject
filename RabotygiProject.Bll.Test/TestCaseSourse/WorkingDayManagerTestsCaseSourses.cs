using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;
using System.Collections;

namespace RabotygiProject.Bll.Test.TestCaseSourse
{
    //List<WorkingDayDto> dtoWorkingDay= new List<WorkingDayDto>();
    //List<WorkingDayOutputModel> workingDayOutputModels = new List<WorkingDayOutputModel>();

    public class GetAllWorkingDaysTestCaseSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            List<WorkingDayDto> dtoWorkingDay = new List<WorkingDayDto>();
            List<WorkingDayOutputModel> workingDayOutputModels = new List<WorkingDayOutputModel>();
            yield return new Object[] { dtoWorkingDay, workingDayOutputModels };

            dtoWorkingDay = new List<WorkingDayDto>()
            {
            new WorkingDayDto()
                {
                Id = 1,
                Date = DateTime.Parse("10.10.2023")
                },
                new WorkingDayDto()
                {
                Id = 5,
                Date = DateTime.Parse("19.10.2023")
                }
            };
            workingDayOutputModels = new List<WorkingDayOutputModel>()
            {
            new WorkingDayOutputModel()
                {
                Id = 1,
                Date = DateTime.Parse("10.10.2023")
                },
            new WorkingDayOutputModel()
               {
                Id = 5,
                Date = DateTime.Parse("19.10.2023")
                }
            };
            yield return new Object[] { dtoWorkingDay, workingDayOutputModels };

        }
    }

    public class GetWorkingDayByIdTestCaseSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int id = 1;
            WorkingDayDto dtoWorkingDay = new WorkingDayDto();
            WorkingDayOutputModel workingDayOutputModels = new WorkingDayOutputModel();
            yield return new Object[] { id, dtoWorkingDay, workingDayOutputModels };

            id = 1;
            dtoWorkingDay = new WorkingDayDto()
            {
                Id = 1,
                Date = DateTime.Parse("10.10.2023")
            };

            workingDayOutputModels = new WorkingDayOutputModel()
            {
                Id = 1,
                Date = DateTime.Parse("10.10.2023")
            };

            yield return new Object[] { id, dtoWorkingDay, workingDayOutputModels };

            id = 2;
            dtoWorkingDay = new WorkingDayDto()
            {
                Id = 2,
                Date = DateTime.Parse("5.10.2023")
            };

            workingDayOutputModels = new WorkingDayOutputModel()
            {
                Id = 2,
                Date = DateTime.Parse("5.10.2023")
            };

            yield return new Object[] { id, dtoWorkingDay, workingDayOutputModels };
        }
    }
}

    //List<WorkingDayDto> dtoWorkingDay= new List<WorkingDayDto>();
    //List<WorkingDayOutputModel> workingDayOutputModels = new List<WorkingDayOutputModel>();

public class UpdateWorkingDayByIdTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        int id = 1;
        WorkingDayDto dtoWorkingDay = new WorkingDayDto()
        {
            Id = 1,
            Date = DateTime.Parse("10.10.2023")
        };
        WorkingDayInputModel workingDayInputModels = new WorkingDayInputModel()
        {
            Id = 1,
            Date = DateTime.Parse("10.10.2023")
        };
        yield return new Object[] {id, dtoWorkingDay, workingDayInputModels };
    }
}

public class AddNewWorkingDayTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        DateTime date = DateTime.Parse("10.10.2023");
        WorkingDayDto dtoWorkingDay = new WorkingDayDto()
        {
            Id = 1,
            Date = date
        };
        WorkingDayInputModel workingDayInputModels = new WorkingDayInputModel()
        {
            Id = 1,
            Date = date
        };

        yield return new Object[] { dtoWorkingDay, workingDayInputModels, date };
    }
}


