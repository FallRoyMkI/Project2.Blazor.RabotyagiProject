namespace RabotyagiProject.Bll.Models
{
    public class ServiceOutputModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? Cost { get; set; }
        public bool? IsDeleted { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ServiceOutputModel model &&
                   Id == model.Id &&
                   Type == model.Type &&
                   Cost == model.Cost &&
                   IsDeleted == model.IsDeleted;
        }
    }
}
