using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using HtmlAgilityPack;
using System.Data;

namespace ChampionCompare
{
    class DataMiner
    {
        HtmlDocument mainPage;
        DataTable returnTable;

        public DataMiner()
        {
            string htmlCode = "";
            string url = "http://leagueoflegends.wikia.com/wiki/Base_champion_statistics";

            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(url);
            }

            mainPage = new HtmlDocument();
            mainPage.LoadHtml(htmlCode);

            var headers = mainPage.DocumentNode.SelectNodes("//tr/th");
            returnTable = new DataTable();
            foreach (HtmlNode header in headers)
                returnTable.Columns.Add(header.InnerText); // create columns from th
            // select rows with td elements 
            foreach (var row in mainPage.DocumentNode.SelectNodes("//tr[td]"))
                returnTable.Rows.Add(row.SelectNodes("td").Select(td => td.InnerText).ToArray());
        }

        public DataTable ReturnTable
        {
            get { return returnTable; }
        }
    }
}
