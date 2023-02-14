using System.Collections;
using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Models;

namespace RabotygiProject.Bll.Test.TestCaseSourse
{
    public class GetAllServicesTestSources : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            List<ServiceDto> receivedService = new List<ServiceDto>();
            List<ServiceOutputModel> expectedService = new List<ServiceOutputModel>();
            yield return new Object[] { receivedService, expectedService };

            receivedService = new List<ServiceDto>()
            {
            new ServiceDto()
                {
                Id = 1,
                Type = "Мытьё полов",
                Cost = 15,
                IsDeleted = false
                }
            };
            expectedService = new List<ServiceOutputModel>()
            {
            new ServiceOutputModel()
                {
                Id = 1,
                Type = "Мытьё полов",
                Cost = 15
                }
            };
            yield return new Object[] { receivedService, expectedService };

        }
    }
}
