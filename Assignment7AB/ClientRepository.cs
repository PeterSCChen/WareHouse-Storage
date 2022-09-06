using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment7AB
{
    class ClientRepository
    {
        private static string connString = @"Server=tcp:comp2614.database.windows.net,1433;
                                             Initial Catalog=comp2614;
                                             User ID=student;
                                             Password=iLOVEpho!;
                                             Encrypt=True;
                                             TrustServerCertificate=False;
                                             Connection Timeout=30;"; 

        public static ClientCollection GetClients
        {
            get
            {
                ClientCollection clients;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                                     FROM Client123456
                                     ORDER BY CompanyName";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Connection = conn;

                        conn.Open();

                        clients = new ClientCollection();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            string clientCode;
                            string companyName;
                            string address1;
                            string address2=null;
                            string city=null;
                            string province;
                            string postalCode=null;
                            decimal YTDsales=0m;
                            bool creditHold;
                            string notes=null;

                            while (reader.Read())
                            {
                                clientCode = reader["ClientCode"] as string;
                                companyName = reader["CompanyName"] as string;
                                address1 = reader["Address1"] as string;

                                if (!reader.IsDBNull(3))
                                {
                                    address2 = reader["Address2"] as string;
                                }

                                if (!reader.IsDBNull(4))
                                {
                                    city = reader["City"] as string;
                                }

                                province = reader["Province"] as string;

                                if (!reader.IsDBNull(6))
                                {
                                    postalCode = reader["PostalCode"] as string; ;
                                }


                                if (!reader.IsDBNull(7))
                                {
                                    YTDsales = (decimal)reader["YTDSales"];
                                }


                                creditHold = (bool)reader["CreditHold"];

                                if (!reader.IsDBNull(9))
                                {
                                    notes = reader["Notes"] as string;
                                }


                                clients.Add(new Client{ ClientCode = clientCode,
                                                        CompanyName = companyName,
                                                        Address1 = address1,
                                                        Address2 = address2,
                                                        City = city,
                                                        Province = province,
                                                        PostalCode = postalCode,
                                                        YTDSales = YTDsales,
                                                        CreditHold = creditHold,
                                                        Notes = notes});
                            }
                        }

                        return clients;
                    }
                }
            }
        }


    }

}
   