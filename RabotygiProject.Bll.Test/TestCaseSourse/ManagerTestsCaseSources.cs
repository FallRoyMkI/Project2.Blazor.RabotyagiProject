using System.Collections;
using RabotyagiProject.Dal.Models;

namespace RabotygiProject.Bll.Test.TestCaseSourse
{
    public class GetAllBusyTimeTimeTestCaseSourse : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            List<BusyTimeDto> busyTime = new List<BusyTimeDto>()
            {
                new BusyTimeDto()
                {
                    Id = 1,
                    StartTime = new DateTime(2023, 2, 9, 12, 30, 0),
                    EndTime = new DateTime(2023, 2, 9, 13, 30, 0),
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
                    StartTime = new DateTime(2023, 2, 9, 12, 30, 0),
                    EndTime = new DateTime(2023, 2, 9, 13, 30, 0),
                    TimetableId = 100500,
                    IsDeleted = true
                }
            }
            };

        }
    }
}
