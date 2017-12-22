using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Model
{
    public class Natif : AbstractDefinition
    {
        private List<Entities.BagageDefinition> listeBagage = new List<Entities.BagageDefinition>();
        public Natif()
        {
            listeBagage.Clear();
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24387299, Compagnie = "AA", Ligne = 0063, LigneAlpha = ' ', JourExploitation = 2, Itineraire = "MIA", ClasseBagage = 'Y', CodeIata = "015730437700", Continuation = false, Rush = false });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24389425, Compagnie = "LH", Ligne = 1027, LigneAlpha = ' ', JourExploitation = 3, Itineraire = "FRA", ClasseBagage = 'M', CodeIata = "522050540600", Continuation = false, Rush = false });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24404502, Compagnie = "EY", Ligne = 0032, LigneAlpha = ' ', JourExploitation = 2, Itineraire = "AUH", ClasseBagage = 'Y', CodeIata = "005718412300", Continuation = false, Rush = false });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24405559, Compagnie = "AA", Ligne = 0041, LigneAlpha = ' ', JourExploitation = 2, Itineraire = "ORD", ClasseBagage = 'Y', CodeIata = "015735229100", Continuation = true, Rush = false });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24494127, Compagnie = "PS", Ligne = 0128, LigneAlpha = ' ', JourExploitation = 6, Itineraire = "KBP", ClasseBagage = 'S', CodeIata = "800608207900", Continuation = false, Rush = false });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24453184, Compagnie = "UA", Ligne = 056, LigneAlpha = ' ', JourExploitation = 4, Itineraire = "EWR", ClasseBagage = 'J', CodeIata = "401640989800", Continuation = false, Rush = true });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24453244, Compagnie = "SV", Ligne = 0126, LigneAlpha = ' ', JourExploitation = 4, Itineraire = "JED", ClasseBagage = 'Y', CodeIata = "006585786000", Continuation = false, Rush = false });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24446743, Compagnie = "UU", Ligne = 0974, LigneAlpha = ' ', JourExploitation = 3, Itineraire = "RUN", ClasseBagage = 'Y', CodeIata = "007410201500", Continuation = false, Rush = false });
            listeBagage.Add(new Entities.BagageDefinition { IdBagage = 24446755, Compagnie = "UU", Ligne = 0974, LigneAlpha = ' ', JourExploitation = 3, Itineraire = "RUN", ClasseBagage = 'Y', CodeIata = "007410201500", Continuation = false, Rush = false });
        }

        public override Entities.BagageDefinition GetBagage(string codeIata)
        {
            var bag = listeBagage.Where(b => b.CodeIata == codeIata).ToList();

            if (bag.Count == 1)
                return bag[0];
            //todo gérer ici le cas d'une correspondance multiple qui retourne une exception avec l'ensemble des bagages trouvés
            return null;
        }

        public override Entities.BagageDefinition GetBagage(int idBagage)
        {
            var bag = listeBagage.Where(b => b.IdBagage == idBagage).ToList();

            if (bag.Count == 1)
                return bag[0];
            return null;
        }

        public override int CreateBagage(Entities.BagageDefinition bagage)
        {
            var maxId = listeBagage.Max(b => b.IdBagage);
            bagage.IdBagage = ++maxId;
            this.listeBagage.Add(bagage);
            return maxId;
        }

        public override Entities.RoutageBagage GetInfoRoutage(int idBagage)
        {
            return new Entities.RoutageBagage() { LocalisationEjection = 4516, NomEjection = "EJ13", StatutEjection = "TPS", 
                LocalisationSureteN1 = 4385, NomSureteN1 = "PIM EST", 
                LocalisationSureteN3 = 13284, NomSureteN3 = "CX1" };
        }
    }
}
