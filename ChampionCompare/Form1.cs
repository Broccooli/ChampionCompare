using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace ChampionCompare
{
    public partial class MainForm : Form
    {
        ChampionTable ct;
        string[] xAxisLabels = {"HP",
                                "HP/Lvl",
                                "HP5",
                                "HP5/Lvl",
                                "MP",
                                "MP/Lvl",
                                "MP5",
                                "MP5/Lvl",
                                "AD",
                                "AD/Lvl",
                                "AS",
                                "AS/Lvl",
                                "AR",
                                "AR/Lvl",
                                "MR",
                                "MR/Lvl",
                                "MS",
                                "Range",};


        public MainForm()
        {            
            InitializeComponent();
            InitializeNecessities();           
        }

        public void InitializeNecessities()
        {
            DataMiner miner = new DataMiner();
            ct = ChampionTable.Init(miner.ReturnTable);
            InitializeDropDowns();
            // ct.testTable();
        }

        private void InitializeDropDowns()
        {
            ChampionTable t = ChampionTable.ChampTable;

            for (int ii = 0; ii < t.table.Rows.Count; ii++)
            {
                ComboBoxChampItem cbci = t.GetBoxItemForIndex(ii);
                champOneDropdown.Items.Add(cbci);
                champTwoDropdown.Items.Add(cbci);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DataChart.Series.Clear();
            bool twoPicked = false;
            ComboBoxChampItem champ1 = null;
            ComboBoxChampItem champ2 = null;

            while (!twoPicked)
            {
                if (champOneDropdown.SelectedItem != null && champTwoDropdown.SelectedItem != null)
                {
                    champ1 = (champOneDropdown.SelectedItem as ComboBoxChampItem);
                    champ2 = (champTwoDropdown.SelectedItem as ComboBoxChampItem);

                    DataChart.Series.Add(champ1.ToString());
                    DataChart.Series.Add(champ2.ToString());

                    DataChart.Series[champ1.ToString()].IsValueShownAsLabel = true;
                    DataChart.Series[champ2.ToString()].IsValueShownAsLabel = true;

                    twoPicked = true;
                }
                else
                {
                    MessageBox.Show("Please choose two champions");
                }
            }

            for (int ii = 0; ii < champ1.Stats.Length - 1; ii++)
            {
                DataChart.Series[champ1.ToString()].Points.AddXY(xAxisLabels[ii], champ1.Stats[ii]);
                DataChart.Series[champ2.ToString()].Points.AddXY(xAxisLabels[ii], champ2.Stats[ii]);
            }

        }
    }
}
