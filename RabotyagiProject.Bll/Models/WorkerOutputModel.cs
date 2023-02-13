namespace RabotyagiProject.Bll.Models
{
    public class WorkerOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public List<ServiceOutputModel> Service { get; set; } = new List<ServiceOutputModel>();

        public override bool Equals(object? obj)
        {
            return obj is WorkerOutputModel model &&
                   Id == model.Id && 
                   Name == model.Name &&
                   Phone == model.Phone &&
                   Mail == model.Mail &&
                   Service.SequenceEqual(model.Service);
        }
    }
}