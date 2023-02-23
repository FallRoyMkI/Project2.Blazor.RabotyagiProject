using System.Collections;
using RabotyagiProject.Dal.Models;

    public class GetAllBusyTimeTimeTestCaseSourse : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            List<BusyTimeDto> busyTime = new List<BusyTimeDto>()
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
            yield return new Object[] { busyTime };


            yield return new Object[]
            {
            new List<BusyTimeDto>()
            };

            yield return new Object[]
            {
            new List<BusyTimeDto>()
            {
                new BusyTimeDto()
                {
                    Id = 2,
                    StartTime = new TimeSpan(12, 30, 0),
                    EndTime = new TimeSpan(13, 30, 0),
                    TimetableId = 100500,
                    IsDeleted = true
                }
            }
            };

        }
    }

