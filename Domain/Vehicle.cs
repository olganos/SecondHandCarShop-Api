﻿namespace Domain
{

    public class Vehicle
    {
        public int _id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year_model { get; set; }
        public float price { get; set; }
        public bool licensed { get; set; }
        public string date_added { get; set; }
    }

}