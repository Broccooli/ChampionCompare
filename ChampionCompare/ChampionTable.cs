using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HtmlAgilityPack;
using System.Diagnostics;

namespace ChampionCompare
{
    class ChampionTable
    {
        static ChampionTable instance;
        static Boolean initialized = false;
        public DataTable table;

        private ChampionTable(DataTable table)
        {
            this.table = table;
            table.TableName = "Champions";
        }

        // Private constructor, ChampionTable follows a Singelton pattern
        public static ChampionTable Init(DataTable t)
        {
            if (instance == null && !initialized)
            {
                instance = new ChampionTable(t);
                initialized = true;
                return instance;
            }
            else
            {
                return instance;
            }

        }

        // Return instance of this Singleton
        public static ChampionTable ChampTable
        {
            get
            {
                if (!initialized)
                {
                    Console.WriteLine("Please initialize ChampionTable first using ChampionTable.Init(DataTable). You have recieved a null value");
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }

        // Returns the name of the champion at the given index
        private string getName(int index)
        {
            DataRow row = table.Rows[index];
            string unformatted = (string)row[0];
            int ampIndex = unformatted.IndexOf('&');
            string formatted = unformatted.Substring(0, ampIndex).Trim();

            return formatted;
        }

        private double[] getStats(int index)
        {
            double[] retArray = new double[table.Columns.Count - 1];
            double temp;

            for (int ii = 0; ii < table.Columns.Count - 1; ii++)
            {
                DataRow row = table.Rows[index];
                string unformatted = (string)row[ii + 1];
                //int backSlashIndex = unformatted.IndexOf('n') - 1;
                //string formattedString = unformatted.Substring(0, backSlashIndex).Trim();
                if (unformatted.Contains('%'))
                {
                    string newUnformatted = unformatted.Replace('%', ' ').Trim();
                    temp = Convert.ToDouble(newUnformatted);
                    temp %= 100;
                }
                else
                {
                    if (index == 110 && ii == 10) {
                        Debug.Print("here we are");
                    }
                    temp = Convert.ToDouble(unformatted);
                }
                retArray[ii] = temp;
            }

            return retArray;
        }

        public ComboBoxChampItem GetBoxItemForIndex(int index)
        {
            return new ComboBoxChampItem(getName(index), getStats(index));
        }
    }
}
