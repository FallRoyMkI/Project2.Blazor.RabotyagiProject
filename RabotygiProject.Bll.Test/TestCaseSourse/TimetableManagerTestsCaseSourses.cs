using System.Collections;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;

namespace RabotygiProject.Bll.Test.TestCaseSourse
{

    public class GetAllTimetableTestCaseSourse : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            List<TimetableDto> dtoTimetable = new List<TimetableDto>();
            List<TimetableOutputModel> timetableModel = new List<TimetableOutputModel>();
            dtoTimetable = new List<TimetableDto>()
            {
                new TimetableDto
                {
                Id = 1,
                WorkerId = 4,
                WorkingDayId = 15,
                IsDeleted = false
                },
                new TimetableDto
                {
                Id = 6,
                WorkerId = 2,
                WorkingDayId = 22,
                IsDeleted = false
                }
            };
            timetableModel = new List<TimetableOutputModel>()
            {
                new TimetableOutputModel
                {
                Id = 1,
                WorkerId = 4,
                WorkingDayId = 15,
                IsDeleted = false
                },
                new TimetableOutputModel
                {
                Id = 6,
                WorkerId = 2,
                WorkingDayId = 22,
                IsDeleted = false
                },
            };
            yield return new Object[] { dtoTimetable, timetableModel };
            yield return new Object[]
            {
            dtoTimetable = new List<TimetableDto>(),
            timetableModel = new List<TimetableOutputModel>()
            };
        }
    };

    public class GetAllTimetableByWorkerIdTestCaseSourse : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            int workerId = 2;
            List<TimetableDto> dtoTimetable = new List<TimetableDto>();
            List<TimetableOutputModel> timetableModel = new List<TimetableOutputModel>();
            dtoTimetable = new List<TimetableDto>()
            {
                new TimetableDto
                {
                Id = 1,
                WorkerId = 4,
                WorkingDayId = 15,
                IsDeleted = false
                },
                new TimetableDto
                {
                Id = 6,
                WorkerId = 2,
                WorkingDayId = 22,
                IsDeleted = false
                }
            };
            timetableModel = new List<TimetableOutputModel>()
            {
                new TimetableOutputModel
                {
                Id = 1,
                WorkerId = 4,
                WorkingDayId = 15,
                IsDeleted = false
                },
                new TimetableOutputModel
                {
                Id = 6,
                WorkerId = 2,
                WorkingDayId = 22,
                IsDeleted = false
                },
            };
            yield return new Object[] { dtoTimetable, timetableModel, workerId };
        }
    }
}

public class UpdateTimetableByIdTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        TimetableDto dtoTimetable = new TimetableDto()
        {
            Id = 1,
            WorkerId = 4,
            WorkingDayId = 15,
            IsDeleted = false
        };
        TimetableInputModel timetableModel = new TimetableInputModel()
        {
            Id = 1,
            WorkerId = 4,
            WorkingDayId = 15,
            IsDeleted = false
        };

        yield return new Object[] { dtoTimetable, timetableModel };
    }
}

public class AddNewTimetableTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {

        int workerId = 4;
        int workingDayId = 15;
        TimetableDto dtoTimetable = new TimetableDto()
        {
            Id = 1,
            WorkerId = 4,
            WorkingDayId = 15,
            IsDeleted = false
        };
        yield return new Object[] {dtoTimetable, workerId, workingDayId };
    }
}

