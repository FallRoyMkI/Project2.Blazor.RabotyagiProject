using System.Collections;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;

public class GetAllBusyTimeTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        List<BusyTimeDto> dtoBusyTime = new List<BusyTimeDto>();
        List<BusyTimeOutputModel> modelBusyTime = new List<BusyTimeOutputModel>();
        dtoBusyTime = new List<BusyTimeDto>()
            {
                new BusyTimeDto()
                {
                    Id = 1,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                }
            };

        modelBusyTime = new List<BusyTimeOutputModel>()
            {
                new BusyTimeOutputModel()
                {
                    Id = 1,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                }
            };
        yield return new Object[] { dtoBusyTime, modelBusyTime };


        yield return new Object[]
        {
            dtoBusyTime = new List<BusyTimeDto>(),
            modelBusyTime = new List<BusyTimeOutputModel>()
        };

        dtoBusyTime = new List<BusyTimeDto>()
                {
                    new BusyTimeDto()
                    {
                        Id = 1,
                        StartTime = new TimeSpan(12, 30, 0),
                        EndTime = new TimeSpan( 13, 30, 0),
                        TimetableId = 1,
                        IsDeleted = false
                    },
                    new BusyTimeDto()
                    {
                        Id = 2,
                        StartTime = new TimeSpan(11, 40, 1),
                        EndTime = new TimeSpan( 11, 50, 1),
                        TimetableId = 4,
                        IsDeleted = false
                    }
                };

        modelBusyTime = new List<BusyTimeOutputModel>()
                {
                    new BusyTimeOutputModel()
                    {
                        Id = 1,
                        StartTime = new TimeSpan(12, 30, 0),
                        EndTime = new TimeSpan( 13, 30, 0),
                        TimetableId = 1,
                        IsDeleted = false
                    },
                    new BusyTimeOutputModel()
                    {
                        Id = 2,
                        StartTime = new TimeSpan(11, 40, 1),
                        EndTime = new TimeSpan( 11, 50, 1),
                        TimetableId = 4,
                        IsDeleted = false
                    }
                };
        yield return new Object[] { dtoBusyTime, modelBusyTime };

    }
}
public class GetAllBusyTimeByTimetableIdTestCaseSourse : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator()
    {
        int tableId = 1;
        List<BusyTimeDto> dtoBusyTime = new List<BusyTimeDto>();
        List<BusyTimeOutputModel> modelBusyTime = new List<BusyTimeOutputModel>();
        dtoBusyTime = new List<BusyTimeDto>()
            {
                new BusyTimeDto()
                {
                    Id = 5,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                },
            };

        modelBusyTime = new List<BusyTimeOutputModel>()
            {
                new BusyTimeOutputModel()
                {
                    Id = 5,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                }
            };
        yield return new Object[] { dtoBusyTime, modelBusyTime, tableId };

        dtoBusyTime = new List<BusyTimeDto>();
        modelBusyTime = new List<BusyTimeOutputModel>();
        yield return new Object[] { dtoBusyTime, modelBusyTime, tableId };

        dtoBusyTime = new List<BusyTimeDto>()
            {
                new BusyTimeDto()
                {
                    Id = 5,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                },
                new BusyTimeDto()
                {
                    Id = 6,
                    StartTime = new TimeSpan(10, 30, 0),
                    EndTime = new TimeSpan( 11, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                },
            };

        modelBusyTime = new List<BusyTimeOutputModel>()
            {
                new BusyTimeOutputModel()
                {
                    Id = 5,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan( 13, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                },
                new BusyTimeOutputModel()
                {
                    Id = 6,
                    StartTime = new TimeSpan(10, 30, 0),
                    EndTime = new TimeSpan( 11, 30, 0),
                    TimetableId = 1,
                    IsDeleted = false
                },
            };
        yield return new Object[] { dtoBusyTime, modelBusyTime, tableId };

    }
}
