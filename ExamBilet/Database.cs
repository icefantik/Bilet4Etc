using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBilet
{
    class Database
    {
        private SqlConnection sqlConnection = new SqlConnection("data source = 10.10.14.40; initial catalog = Bilet4; persist security info=True;user id = p1_18_12; password=Abcd1234;MultipleActiveResultSets=True;App=EntityFramework");
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
        public static DataTable RunQuery(string query)
        {
            Database database = new Database();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(query, database.getConnection());
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public static List<SumPlanDate> GetListSumPlan()
        {
            DataTable dataTable = RunQuery("SELECT * FROM SumOnPlanDate");
            List<SumPlanDate> sumPlan = new List<SumPlanDate>();
            SumPlanDate sumPlanDate;
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                sumPlanDate = new SumPlanDate();
                sumPlanDate.sum = int.Parse(dataTable.Rows[i][0].ToString());
                sumPlanDate.date = dataTable.Rows[i][1].ToString();
                sumPlan.Add(sumPlanDate);
            }
            return sumPlan;
        }
        public static List<OrderFurnt> GetListOrderFurnt()
        {
            DataTable dataTable = RunQuery("select * from OutstandOrders");
            List<OrderFurnt> orders = new List<OrderFurnt>();
            OrderFurnt orderFurnt;
            for (int i = 0; i < dataTable.Rows.Count; ++i)
            {
                orderFurnt = new OrderFurnt();
                orderFurnt.id = int.Parse(dataTable.Rows[i][0].ToString());
                orderFurnt.DeliveryDetal = dataTable.Rows[i][1].ToString();
                orderFurnt.Specification = dataTable.Rows[i][2].ToString();
                orderFurnt.TypeFurniture = dataTable.Rows[i][3].ToString();
                orderFurnt.FurnityreName = dataTable.Rows[i][4].ToString();
                orderFurnt.Price = int.Parse(dataTable.Rows[i][5].ToString());
                orderFurnt.DeliveryDate = dataTable.Rows[i][6].ToString();
                orders.Add(orderFurnt);
            }
            return orders;
        }
    }
}
