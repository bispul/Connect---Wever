using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;


namespace Connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //connectStorageQuery();
            string txtDeviceName = "myFirstDevice";
            retreiveAllData(txtDeviceName);
            deviceName.Text = txtDeviceName;
        }

        private void cloudStorageConnectInsert()
        {
            string accountName = "wever";
            string accountKey = "YOUR_ACCOUNT_KEY";
            try
            {
                StorageCredentials creds = new StorageCredentials(accountName, accountKey);
                CloudStorageAccount account = new CloudStorageAccount(creds, useHttps: true);

                CloudTableClient client = account.CreateCloudTableClient();

                CloudTable table = client.GetTableReference("sportingproducts");
                table.CreateIfNotExists();

                Console.WriteLine(table.Uri.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Done... press a key to end.");
            Console.ReadKey();
        }

        string accountName = "wever";
        string accountKey = "I2Np9cx1OOYSURfOCHF06tz00YPNiib0Clv6i5I3tLtXqz7561YOe5SoKgErCeIhwo4TR+9E6br9IzP6/vFq6A==";

        private void connectStorageQuery()
        {
            
            try
            {
                StorageCredentials creds = new StorageCredentials(accountName, accountKey);
                CloudStorageAccount account = new CloudStorageAccount(creds, useHttps: true);

                CloudTableClient client = account.CreateCloudTableClient();
                CloudTable table = client.GetTableReference("pumpControl");

                TableOperation retrieveOperation = TableOperation.Retrieve<WeverEntityClass>("myFirstDevice", "2016-03-27T13:27:59.1475848+00:00");

                TableResult query = table.Execute(retrieveOperation);

                if (query.Result != null)
                {
                    Console.WriteLine("Pump Control: {0}", ((WeverEntityClass)query.Result).pumpControl);
                }
                else
                {
                    Console.WriteLine("The Pump Control was not found.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        

        private void retreiveAllData(string partitionId)
        {
            // Retrieve the storage account from the accountName and accountKey
            StorageCredentials creds = new StorageCredentials(accountName, accountKey);
            CloudStorageAccount account = new CloudStorageAccount(creds, useHttps: true);

            CloudTableClient client = account.CreateCloudTableClient();
            CloudTable table = client.GetTableReference("pumpControl");

            // Construct the query operation for all customer entities where PartitionKey=parameter".
            TableQuery<WeverEntityClass> query = new TableQuery<WeverEntityClass>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionId));

            string lastWaterlevel = "";
            string lastPumpControl = "";
            string lastTime = "";   

          
            // Print the fields for each customer.
            foreach (WeverEntityClass entity in table.ExecuteQuery(query))
            {
                lastPumpControl = entity.pumpControl;
                lastWaterlevel = entity.waterlevel;
                //lastTime = entity.RowKey;

                Console.WriteLine("{0}, {1}\t{2}\t{3}\t{4}", entity.PartitionKey, entity.RowKey,
                    entity.time, entity.pumpControl, entity.waterlevel);
            }
            if (waterPumpStatus.Text != null || waterLevel.Text != "")
            {
                waterPumpStatus.Text = lastPumpControl;
            }
            else waterPumpStatus.Text = "Error Retrieving Data";
            if (waterLevel.Text != null || waterLevel.Text != "")
                waterLevel.Text = lastWaterlevel;
            else waterLevel.Text =
                    "Error Retrieving Data";
            Console.WriteLine();
            Console.WriteLine(partitionId+"  "+
                    lastTime+"  "+lastPumpControl+"  "+lastWaterlevel);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void waterLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
