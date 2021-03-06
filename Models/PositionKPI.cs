using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Solution.Models
{
    public class PositionKPI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SFPM_PositionKPIId { get; set; }
        public string PositionKPIName { get; set; }
        [ForeignKey("AlertType")]
        public int AlertTypeId { get; set; }
        public virtual AlertType AlertTypes { get; set; }
        public int LoadConditionId { get; set; }
        [ForeignKey("Rules")]
        public long RuleId { get; set; }
        public virtual Rules Rule { get; set; }
        public decimal RedLimit { get; set; }
        public decimal YellowLimit { get; set; }
        public bool RedEmailToCaptain { get; set; }
        public bool YellowEmailToCaptain { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Status Status { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
    }
}
