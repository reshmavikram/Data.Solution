using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Solution.Models
{
    public class SevereWaveThresholdUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SFPM_SevereWaveThresholdUnitId { get; set; }
        public string SevereWaveThresholdUnitName { get; set; }
    }
}
