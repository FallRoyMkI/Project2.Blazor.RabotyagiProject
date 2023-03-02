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

    public class GetServiceByIdTestSources : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int id = 1;
            ServiceDto receivedService = new ServiceDto();
            ServiceOutputModel expectedService = new ServiceOutputModel();
            yield return new Object[] { id, receivedService, expectedService };

            id = 1;
            receivedService = new ServiceDto()
            {
                Id = 1,
                Type = "Мытьё полов",
                Cost = 15,
                IsDeleted = false
            };

            expectedService = new ServiceOutputModel()
            {
                Id = 1,
                Type = "Мытьё полов",
                Cost = 15,
            };

            yield return new Object[] { id, receivedService, expectedService };

            id = 2;
            receivedService = new ServiceDto()
            {
                Id = 2,
                Type = "Хотьба по потолоку",
                Cost = 1999,
                IsDeleted = false
            };

            expectedService = new ServiceOutputModel()
            {
                Id = 2,
                Type = "Хотьба по потолоку",
                Cost = 1999,
            };

            yield return new Object[] { id, receivedService, expectedService };
        }
    }

}
