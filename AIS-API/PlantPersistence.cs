using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIS_API.Models;
using MySql.Data;
using System.Collections;

namespace AIS_API
{
    public class PlantPersistence
    {

        private MySql.Data.MySqlClient.MySqlConnection conn;

        public PlantPersistence()
        {
            string myconnectionString;

            //User name and password in plane text
            myconnectionString = "server=127.0.0.1;uid=root;pwd=root;database=AIS";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myconnectionString;
                conn.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
        }

        public ArrayList getplants()
        {
            ArrayList plantArray = new ArrayList();

            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

            //get all from table "tblplants"
            string sqlString = "SELECT * From tblplants";

            //Create DB connection
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();

            //if sql finds results run while
            while (mySQLReader.Read())
            {
                Plant p = new Plant();
                p.ID = mySQLReader.GetInt32(0);
                p.Name = mySQLReader.GetString(1);
                p.SoilMoistureMin = mySQLReader.GetInt32(2);
                p.SoilMoistureMax = mySQLReader.GetInt32(3);
                p.SoilMoistureNow = mySQLReader.GetInt32(4);
                p.Category = mySQLReader.GetString(5);
                p.SunlightMin = mySQLReader.GetInt32(6);
                p.SunlightMax = mySQLReader.GetInt32(7);
                p.SunlightNow = mySQLReader.GetInt32(8);
                p.ID_Type = mySQLReader.GetInt32(9);
                p.StartDate = mySQLReader.GetDateTime(10);
                p.Updated = mySQLReader.GetDateTime(11);
                plantArray.Add(p);
            }

            //return arrayList of my values
            return plantArray;

        }
        public bool deletePlant(long ID)
        {
            Plant p = new Plant();
            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

            string sqlString = "SELECT * From tblplants WHERE ID = " + ID.ToString();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();
            if (mySQLReader.Read())
            {
                mySQLReader.Close();
                sqlString = "DELETE From tblplants WHERE ID = " + ID.ToString();
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool updatePlant(long ID, Plant plantToSave)
        {
            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

            string sqlString = "SELECT * From tblplants WHERE ID = " + ID.ToString();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();
            if (mySQLReader.Read())
            {
                mySQLReader.Close();
                sqlString = "UPDATE tblplants SET Name='" + plantToSave.Name + "', SoilMoistureMin=" + plantToSave.SoilMoistureMin + ", SoilMoistureMax=" + plantToSave.SoilMoistureMax + ", SoilMoistureNow=" + plantToSave.SoilMoistureNow + ", Category='" + plantToSave.Category + "', SunlightMin=" + plantToSave.SunlightMin + ", SunlightMax=" + plantToSave.SunlightMax + ", SunlightNow=" + plantToSave.SunlightNow + ", ID_Type=" + plantToSave.ID_Type + ", StartDate='" + plantToSave.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "', Updated='" + plantToSave.Updated.ToString("yyyy-MM-dd HH:mm:ss") + "'WHERE ID = " + ID.ToString();
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }

        }


        public Plant getplant(long ID)
        {
            Plant p = new Plant();
            MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

            string sqlString = "SELECT * From tblplants WHERE ID = " + ID.ToString();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

            mySQLReader = cmd.ExecuteReader();
            if (mySQLReader.Read())
            {
                p.ID = mySQLReader.GetInt32(0);
                p.Name = mySQLReader.GetString(1);
                p.SoilMoistureMin = mySQLReader.GetInt32(2);
                p.SoilMoistureMax = mySQLReader.GetInt32(3);
                p.SoilMoistureNow = mySQLReader.GetInt32(4);
                p.Category = mySQLReader.GetString(5);
                p.SunlightMin = mySQLReader.GetInt32(6);
                p.SunlightMax = mySQLReader.GetInt32(7);
                p.SunlightNow = mySQLReader.GetInt32(8);
                p.ID_Type = mySQLReader.GetInt32(9);
                p.StartDate = mySQLReader.GetDateTime(10);
                p.Updated = mySQLReader.GetDateTime(11);

                return p;
            }
            else
            {
                return null;
            }

        }
        public long savePlant(Plant plantToSave)
        {

            string sqlString = "INSERT INTO tblplants(Name, SoilMoistureMin, SoilMoistureMax, SoilMoistureNow, Category, SunlightMin, SunlightMax, SunlightNow, ID_Type, StartDate, Updated) VALUES ('" + plantToSave.Name + "', " + plantToSave.SoilMoistureMin + ", " + plantToSave.SoilMoistureMax + ", " + plantToSave.SoilMoistureNow + ", '" + plantToSave.Category + "', " + plantToSave.SunlightMin + ", " + plantToSave.SunlightMax + ", " + plantToSave.SunlightNow + ", " + plantToSave.ID_Type + ", '" + plantToSave.StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + plantToSave.Updated.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;
            return id;
        }
    }
}