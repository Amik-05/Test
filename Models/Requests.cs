namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requests
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime? Date { get; set; }

        public string Equipment { get; set; }

        public string Type { get; set; }

        public string Descrip { get; set; }

        public string Client { get; set; }

        public string Status { get; set; }
    }
}
