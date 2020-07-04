using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_TBA_Tools
{
    public partial class Form1 : Form
    {
        JArray root = new JArray();             //This will load the original json file
        string path;

        public List<string> items = new List<string>(); //List to store added items in the form
        public List<int> idArray = new List<int>(); // List to store map ids in the loaded Json file

        public bool isDuplicate = false;            //Bool value to check if the data added to the loaded json file is similar or not
        public Form1()
        {
            InitializeComponent();
            
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < idArray.Count; i++) // Checks for an existing id in the loaded Json as to avoid duplication
            {
                if (idArray[i] == mapId.Value)
                {
                    isDuplicate = true;
                }
            }
            if (roomName.Text == "" || description.Text == "")  // Checking for null values
            {
                MessageBox.Show("Enter all required fields : Room Name, Map ID, Directions, Descriptions");
            }
            else if (isDuplicate)   //Checking for duplication while adding data in loaded file
            {
                MessageBox.Show("The Given ID already exists");
                isDuplicate = false;
            }
            else if (enemyName.Text != "" && enemyHealth.Value == 0 && enemyDamage.Value == 0 && enemyWeapon.Text == "")    // Checking if user left null values after entering Enemy Name
            {
                MessageBox.Show("Enemy must have a Health, Damage and Weapon !");
            }
            else
            {
                idArray.Add(Convert.ToInt32(mapId.Value));  // Adding all ids of the loaded file in a list

                // Loading all values inserted in the form into a json object

                //Loading all direction values
                List<int> dir = new List<int>();
                dir.Add(Convert.ToInt32(northId.Value));
                dir.Add(Convert.ToInt32(westId.Value));
                dir.Add(Convert.ToInt32(eastId.Value));
                dir.Add(Convert.ToInt32(southId.Value));

                var direction = JsonConvert.SerializeObject(dir); // Loading direction list in a var to save it as an Json array 
                var array = root; //Loading the root Json object as var to store data in the end
                var intArray = JsonConvert.SerializeObject(items); // Loading item list in a var to save it as an Json array 

                var itemToAdd = new JObject();  //Creating a new var which is a JObject for ease of storing each data
                var enemies = new JObject();    //Creating a new var which is a JObject for ease of storing enemy data
                itemToAdd["id"] = Convert.ToInt32(mapId.Value);
                itemToAdd["name"] = roomName.Text;
                itemToAdd["accessible"] = accessible.Checked;
                itemToAdd["accessibleCondition"] = accessCondition.Text;
                itemToAdd["accessItem"] = accessItem.Text.ToLower();
                itemToAdd["nextLoc"] = JArray.Parse(direction);
                itemToAdd["description"] = description.Text;
                itemToAdd["items"] = JArray.Parse(intArray);
                enemies["name"] = enemyName.Text.ToLower();
                enemies["health"] = Convert.ToInt32(enemyHealth.Value);
                enemies["damage"] = Convert.ToInt32(enemyDamage.Value);
                enemies["weapon"] = enemyWeapon.Text.ToLower();
                itemToAdd["enemies"] = enemies;
                array.Add(itemToAdd);
                root = array;
                items.Clear();
                itemList.Items.Clear();
                statusLabel.Text = "Room " + roomName.Text + " has been added";
                statusStrip.Refresh();
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            items.Add(item.Text);               // Storing Items in the Item List
            itemList.Items.Add(item.Text);
            statusLabel.Text = "Item " + item.Text.ToLower() + " has been added";
            statusStrip.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                path = openFileDialog.FileName;         // Storing the path to load the selected JSON file
                root = JArray.Parse(File.ReadAllText(path));    // Retrieving entire JSON data in a JSON Array
                for (int i = 0; i < root.Count(); i++)
                {
                    loadRoom.Items.Add(root[i]["name"]);    // Storing All Room Names for displaying the loaded rooms in the file to the user
                }
                loadRoom.SelectedItem = loadRoom.Items[0];
                statusLabel.Text = path + " file has been loaded";
                statusStrip.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "File cannot be loaded");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Saving the inserted data into a new Json File
                saveFileDialog.ShowDialog();
                path = saveFileDialog.FileName;
                File.WriteAllText(path, JsonConvert.SerializeObject(root, Newtonsoft.Json.Formatting.Indented));
                statusLabel.Text = "Data has been saved to " + path;
                statusStrip.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " File Cannot be saved");
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (path == "") // Check if file path is null
            {
                MessageBox.Show("File Not Loaded");
            }
            else
            {
                if (loadRoom.SelectedItem.ToString() != "") //Check if the room the user wants to load has been left null in the provide dropdown
                {
                    var initialVar = File.ReadAllText(path);    // Loading the file in a "root" Json Array
                    root = JArray.Parse(initialVar);    

                    foreach (JObject obj in root.Children<JObject>())
                    {
                        idArray.Add(Convert.ToInt32(obj["id"]));    // Loading all the existing map ids so as to avoid id duplication while adding new rooms
                    }

                    JObject element = root.Children<JObject>().FirstOrDefault(o => Convert.ToString(o["name"]) == loadRoom.SelectedItem.ToString());    // Saving all names in a dropdown so user can select and view the data of a room

                    // Creating respective Json tokens for ease of data retrieve
                    JToken enemyData = element["enemies"];
                    JToken nextLoc = element["nextLoc"];
                    JToken itemArr = element["items"];

                    // Loading respective values
                    northId.Value = Convert.ToDecimal(nextLoc[0]);
                    westId.Value = Convert.ToDecimal(nextLoc[1]);
                    eastId.Value = Convert.ToDecimal(nextLoc[2]);
                    southId.Value = Convert.ToDecimal(nextLoc[3]);

                    for (int i = 0; i < itemArr.Count(); i++)
                    {
                        itemList.Items.Add(itemArr[i]);
                    }

                    roomName.Text = element["name"].ToString();
                    accessible.Checked = Convert.ToBoolean(element["accessible"]);
                    accessCondition.Text = element["accessibleCondition"].ToString();
                    accessItem.Text = element["accessItem"].ToString();
                    description.Text = element["description"].ToString();

                    enemyName.Text = enemyData["name"].ToString();
                    enemyWeapon.Text = enemyData["weapon"].ToString();
                    enemyHealth.Value = Convert.ToDecimal(enemyData["health"]);
                    enemyDamage.Value = Convert.ToDecimal(enemyData["damage"]);

                    statusLabel.Text = "Room " + loadRoom.SelectedItem + " has been loaded";
                    statusStrip.Refresh();
                }
                else
                {
                    MessageBox.Show("Select an appropriate 'Room' to Load");
                }
            }
        }
    }
}
