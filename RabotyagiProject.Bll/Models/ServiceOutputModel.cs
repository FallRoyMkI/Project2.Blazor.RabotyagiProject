namespace RabotyagiProject.Bll.Models
{
    public class ServiceOutputModel
    {
        public string Type { get; set; }
        public int? Cost { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ServiceOutputModel model &&
                   Type == model.Type &&
                   Cost == model.Cost;
        }
    }
}
