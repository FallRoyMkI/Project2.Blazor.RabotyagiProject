namespace RabotyagiProject.Bll.Models
{
    public class WorkerOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public List<ServiceOutputModel> Service { get; set; }
    }
}