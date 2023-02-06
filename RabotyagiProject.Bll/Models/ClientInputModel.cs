namespace RabotyagiProject.Bll.Models
{
    public class ClientInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public List<OrderInputModel> Orders { get; set; }
    }
}
