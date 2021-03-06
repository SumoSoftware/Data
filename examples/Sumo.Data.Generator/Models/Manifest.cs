﻿namespace Sumo.Data.Generator.Models
{
    public class Manifest
    {
        public int table_index { get; set; }
        public string table_name { get; set; }
        public string primary_key { get; set; }
        public int record_count { get; set; }
        public bool full_sync{ get; set; }
        public float sync_api { get; set; }
    }
}
