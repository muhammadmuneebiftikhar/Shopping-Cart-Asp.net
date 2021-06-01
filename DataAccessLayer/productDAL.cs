using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using System.Data;

namespace DataAccessLayer
{
    public class productDAL
    {
        Dbcon db = new Dbcon();
        public DataTable GellAllProductsDAL()
        {
            string qry = "Select * from products";
            return db.Search(qry);
        }
        public DataTable SearchProductsDAL(product p)
        {
            string qry = $"Select * from products where Id ={p.Id}";
            return db.Search(qry);
        }

        public bool InsertProduct(product p )
        {
            string qry = $"Insert into products (Name, Image, Price, Description) VALUES ('"+ p.Name +"', '"+ p.Image +"', '"+ p.Price +"', '"+ p.Description +"')";
            return db.UDI(qry);
        }

    }
}
