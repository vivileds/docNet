using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Pim.Entities;

namespace Server.ServiceBagage
{
    public class ServiceBagage : IServiceBagage
    {

        public static int nbInstanceCreate = 0;
        public static int nbAppelTotal = 0;
        public int nbAppelInstance = 0;

        public ServiceBagage()
        {
            nbInstanceCreate++;
        }
        
        public int CreateBagage(BagageDefinition bag)
        {
            return MyAirport.Pim.Model.Factory.Model.CreateBagage(bag);
        }

        public BagageDefinition GetBagageByCodeIata(string codeItata)
        {
            nbAppelTotal++;
            this.nbAppelInstance++;
            return MyAirport.Pim.Model.Factory.Model.GetBagage(codeItata);
        }

        public BagageDefinition GetBagageById(int idBagage)
        {
            return MyAirport.Pim.Model.Factory.Model.GetBagage(idBagage);
        }

        public RoutageBagage GetInfoRoutage(int idBagage)
        {
            return MyAirport.Pim.Model.Factory.Model.GetInfoRoutage(idBagage);
        }
    }
}
