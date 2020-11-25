using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Utilidade
{
    public class Utilidade_validaCep
    {
        //variavel global da classe
        static public String CEP = "";
        static public String Cidade = "";
        static public String Estado = "";
        static public String Logadouro = "";
        static public String Bairro = "";


        //metodo para verificar cep no banco de dados
        public Boolean verificaCEP(String CEP)
        {
            bool flag = false; try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                ds.ReadXml(xml);
                Logadouro = ds.Tables[0].Rows[0]["logradouro"].ToString();
                Bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                Cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                Estado = ds.Tables[0].Rows[0]["uf"].ToString();
                CEP = CEP; flag = true;
            }
            catch (Exception)
            {
                CEP = "";
                Cidade = "";
                Estado = "";
                Bairro = "";
                Logadouro = "";

            }
            return flag;
        }
    }
}
