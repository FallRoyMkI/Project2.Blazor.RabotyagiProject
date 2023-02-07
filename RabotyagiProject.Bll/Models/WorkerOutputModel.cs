namespace RabotyagiProject.Bll.Models
{
    public class WorkerOutputModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public List<ServiceOutputModel> Service { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is WorkerOutputModel model &&
                   Name == model.Name &&
                   Phone == model.Phone &&
                   Mail == model.Mail &&
                   EqualityComparer<List<ServiceOutputModel>>.Default.Equals(Service, model.Service);
        }
    }
}