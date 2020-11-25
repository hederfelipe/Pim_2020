using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2020.Utilidade
{
    public class Utilidade_DadosConexao
    {
        public static string Server = @".\SQLEXPRESS";
        public static string Database = @"pim_2020";
        public static string usuario = @"hederfelipe";
        public static string senha = @"816633";

        public static string StringConexao
        {
            get
            {
                return @"Data Source =" + Server + ";Initial Catalog=" + Database + ";User ID=" + usuario + ";Password=" + senha;

            }
        }
    }
}
