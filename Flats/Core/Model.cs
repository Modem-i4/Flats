using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats.Core
{
    public class Model
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Constant { get; set; }
        public double AgeSold { get; set; }
        public double Size { get; set; }
        public double Floor { get; set; }
        public double HallwayType { get; set; }
        public double HeatingType { get; set; }
        public double AptManageType { get; set; }
        public double N_ParkinglotGround { get; set; }
        public double N_ParkinglotBasement { get; set; }
        public double TimeToBusStop { get; set; }
        public double TimeToSubway { get; set; }
        public double N_APT { get; set; }
        public double N_manager { get; set; }
        public double N_elevators { get; set; }
        public double N_PublicOffice { get; set; }
        public double N_Hospital { get; set; }
        public double N_Dpartmentstore { get; set; }
        public double N_Mall { get; set; }
        public double N_ETC { get; set; }
        public double N_Park { get; set; }
        public double N_FacilitiesInApt { get; set; }
        public double N_SchoolNearBy { get; set; }


        public double ResidualStandardError { get; set; }
        public double RSquared { get; set; }
        public double AdjustedRSquared { get; set; }
        public double FStatistic { get; set; }
        public double CorrespondingPValue { get; set; }


        public double LogLikehood { get; set; }
        public double ChiSquared { get; set; }
        public double KernelLogLikehood { get; set; }
        public double Akaike { get; set; }
        public double CorrectedAIC { get; set; }
        public double Bayesian { get; set; }

        public Model()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
