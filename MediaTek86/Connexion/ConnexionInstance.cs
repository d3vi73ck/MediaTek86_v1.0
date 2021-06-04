﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek86.Connexion
{
    public class ConnexionInstance
    {
        private static ConnexionInstance instance = null;

        private readonly MySqlConnection connexion;

        private MySqlDataReader reader;

        private ConnexionInstance(string stringConnect)
        {
            try
            {
                connexion = new MySqlConnection(stringConnect);
                connexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// Static method to return the unique instance of the connexion to the database
        /// </summary>
        /// <param name="stringConnect">connexion string to the database</param>
        /// <returns>instance of the connexion to the data base</returns>
        public static ConnexionInstance GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new ConnexionInstance(stringConnect);
            }
            return instance;
        }

        /// <summary>
        /// Method to execute all request except select
        /// </summary>
        /// <param name="stringQuery">query stored in a string</param>
        /// <param name="parameters">parameter of the request</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(stringQuery, connexion);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Method to execute a request select
        /// </summary>
        /// <param name="stringQuery">query stored in a string</param>
        /// <param name="parameters">parameter of the request</param>
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(stringQuery, connexion);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Check if the cursor can read another tuple
        /// </summary>
        /// <returns>true if the cursor can read another tuple in Field</returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Create the field containing all the tuples corresponding to the request
        /// </summary>
        /// <param name="nameField">field (string) passed into parameter</param>
        /// <returns>Returns the field containing all the tuples or null</returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Close the cursor once the field is empty
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }
    }
}
