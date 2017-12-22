using MyAirport.Pim.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Model
{
    public class Sql : AbstractDefinition
    {
        string strCnx = ConfigurationManager.ConnectionStrings["MyAirport.Pim.Settings.DbConnect"].ConnectionString;

        string commandGetBagageIata =
            "SELECT b.ID_BAGAGE, b.CODE_IATA, b.COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, b.CONTINUATION, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' FROM BAGAGE b " +
            "left outer join BAGAGE_A_POUR_PARTICULARITE app on app.ID_BAGAGE = b.ID_BAGAGE and app.ID_PARTICULARITE = 15 " + // 15 : RUSH
                "where b.CODE_IATA = @code " +
                "order by ID_BAGAGE desc";

        string commandGetBagageId =
            "SELECT b.ID_BAGAGE, b.CODE_IATA, b.COMPAGNIE, b.LIGNE, b.DATE_CREATION, b.ESCALE, b.CLASSE, b.CONTINUATION, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' FROM BAGAGE b " +
            "left outer join BAGAGE_A_POUR_PARTICULARITE app on app.ID_BAGAGE = b.ID_BAGAGE and app.ID_PARTICULARITE = 15 " + // 15 : RUSH
                "where b.ID_BAGAGE = @id " +
                "order by ID_BAGAGE desc";




  /*      string commandCreateBagage =
            "insert into BAGAGE(COMPAGNIE, LIGNE, JOUR_EXPLOITATION, ESCALE, CLASSE, CODE_IATA," +
            " CONTINUATION) values(@compagnie, @ligne, @jour_exploitation, @escale, @classe, @code_iata, @continuation)";

//        string CommandANePasFaire =
//            "select * from bagage b where b.CodeIata = " + codeIata + "order by b.id_bagage";
*/
        public override BagageDefinition GetBagage(int idBagage)
        {
            BagageDefinition bagRes = null;
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(this.commandGetBagageId, cnx);
                cmd.Parameters.AddWithValue("@id", idBagage);
                cnx.Open();

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    // Au moins un bagage à été trouvé
                    if (sdr.Read())
                    #region cache
                    {
                        bagRes = new BagageDefinition();
                        bagRes.IdBagage = sdr.GetInt32(sdr.GetOrdinal("ID_BAGAGE"));
                        bagRes.Compagnie = sdr["Compagnie"].ToString();
                        bagRes.Ligne = Convert.ToInt32(sdr["ligne"]);
                        bagRes.JourExploitation = sdr.GetInt16(sdr.GetOrdinal("Jour_Exploitation")); //Attention le type demander doit correspondre au type SQL Getint32 léve une exception
                        bagRes.Itineraire = sdr.GetString(sdr.GetOrdinal("Escale"));
                        bagRes.ClasseBagage = sdr["classe"] is DBNull ? 'Y' : Convert.ToChar(sdr["classe"]);
                        bagRes.CodeIata = sdr.GetString(sdr.GetOrdinal("Code_Iata"));
                        bagRes.Continuation = sdr[sdr.GetOrdinal("continuation")].ToString() == "Y" ? true : false; //et pas 'N' ? false : true; car sinon on considére le passager en continuation par defaut
                        bagRes.Rush = sdr.GetBoolean(sdr.GetOrdinal("Rush"));
                    }
                    if (sdr.Read())
                    {
                        //TODO remplacer par une exception personnaliser
                        throw new ApplicationException("Trop de résultats retournés");
                    }
                    #endregion
                    return bagRes;
                }
            }
        }


        /// <summary>
        /// Retourne le bagage correspondant au code iata saisi, 
        /// si aucun resultat trouvé bag vaut null, 
        /// si plusieur résultats trouvés une exception est levée
        /// </summary>
        /// <param name="codeIata"></param>
        /// <returns></returns>
        public override BagageDefinition GetBagage(string codeIata)
        {
            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(commandGetBagageIata, cnx);
                cmd.Parameters.AddWithValue("@code", codeIata);
                cnx.Open();
             
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {         
                    BagageDefinition bag = null;
                    // Au moins un bagage à été trouvé
                    if (sdr.Read())
                    #region cache
                    {
                        bag = new BagageDefinition();
                        bag.IdBagage = sdr.GetInt32(0);//Attention ici à l'ordre des colonnes retrounées par la requête
                        bag.Compagnie = sdr["Compagnie"].ToString();
                        bag.Ligne = Convert.ToInt32(sdr["ligne"]);
                        bag.JourExploitation = sdr.GetInt16(sdr.GetOrdinal("Jour_Exploitation")); //Attention le type demander doit correspondre au type SQL Getint32 léve une exception
                        bag.Itineraire = sdr.GetString(sdr.GetOrdinal("Escale"));
                        bag.ClasseBagage = sdr["classe"] is DBNull ? 'Y' : Convert.ToChar(sdr["classe"]);
                        bag.CodeIata = sdr.GetString(sdr.GetOrdinal("Code_Iata"));
                        bag.Continuation = sdr[sdr.GetOrdinal("continuation")].ToString() == "Y" ? true : false; //et pas 'N' ? false : true; car sinon on considére le passager en continuation par defaut
                        bag.Rush = sdr.GetBoolean(sdr.GetOrdinal("Rush"));
                    }
                    if (sdr.Read())
                    {
                        //TODO remplacer par une exception personnaliser
                        throw new ApplicationException("Trop de résultats retournés");
                    }
                    #endregion
                    return bag;
                }
            }
        }
        public override int CreateBagage(Entities.BagageDefinition bag)
        {
            throw new NotImplementedException();

            /* using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(commandCreateBagage, cnx);
                cmd.Parameters.AddWithValue("@compagnie", bag.Compagnie);
                cmd.Parameters.AddWithValue("@ligne", bag.Ligne);
                cmd.Parameters.AddWithValue("@jour_exploitation", bag.JourExploitation);
                cmd.Parameters.AddWithValue("@escale", bag.Itineraire);
                cmd.Parameters.AddWithValue("@classe", bag.ClasseBagage);
                cmd.Parameters.AddWithValue("@code_iata", bag.CodeIata);
                cmd.Parameters.AddWithValue("@continuation", bag.Continuation);

                cnx.Open();
                using (int sdr = cmd.ExecuteNonQuery())
                {
                    return sdr;
                }
            } */
        }

    }
}
