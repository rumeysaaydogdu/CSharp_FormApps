using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBaglantiUygulamasi
{
    class KisiErisimKatmani
    {
        public DataTable GetAll()
        {
            SqlConnection baglanti = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=course; integrated security=true");
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand sorgu = new SqlCommand("Select * from Ogrenciler", baglanti);
            SqlDataReader okuyucu = sorgu.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(okuyucu);
            okuyucu.Close();
            baglanti.Close();

            return dataTable;
        }
    }
}
