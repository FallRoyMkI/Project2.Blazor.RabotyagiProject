﻿namespace RabotyagiProject.Bll.Models
{
    public class ClientOutputModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public List<OrderOutputModel> Orders { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ClientOutputModel model &&
                   Name == model.Name &&
                   Phone == model.Phone &&
                   Mail == model.Mail &&
                   EqualityComparer<List<OrderOutputModel>>.Default.Equals(Orders, model.Orders);
        }
    }
}
