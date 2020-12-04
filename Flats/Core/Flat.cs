using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats.Core
{
    public enum HallwayType
    {
        corridor = -1,
        terraced = 1
    }
    public enum HeatingType
    {
        central_heating = -1,
        individual_heating = 1
    }
    public enum AptManageType
    {
        management_in_trust = -1,
        self_management = 1
    }
    public enum TimeToPoint
    {
        min0_5 = 0,
        min5_10 = 1,
        min10_15 = 2,
        min15_20 = 3,
        no_point = 5
    }
    public class Flat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SalePrice { get; set; }
        public int AgeSold { get; set; } // YrSold-YrBuild
        public int Size { get; set; }
        public int Floor { get; set; }
        public HallwayType HallwayType { get; set; }
        public HeatingType HeatingType { get; set; }
        public AptManageType AptManageType { get; set; }
        public int N_ParkinglotGround { get; set; } 
        public int N_ParkinglotBasement { get; set; }
        public TimeToPoint TimeToBusStop { get; set; }
        public TimeToPoint TimeToSubway { get; set; }
        public int N_APT { get; set; }
        public int N_manager { get; set; }
        public int N_elevators { get; set; }
        public int N_PublicOffice { get; set; }
        public int N_Hospital { get; set; }
        public int N_Dpartmentstore { get; set; }
        public int N_Mall { get; set; }
        public int N_ETC { get; set; }
        public int N_Park { get; set; }
        public int N_FacilitiesInApt { get; set; }
        public int N_SchoolNearBy { get; set; }
    }
}
