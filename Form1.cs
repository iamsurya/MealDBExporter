using MealDBExporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealDBExporter
{
    public partial class MealDBExporter : Form
    {

        /* Variables */

        String CurrentFileName;    /* Path of file picked */
        String ParentDirectoryPath; /* Parent Directory to Browse */
        String CurrentDirectoryPath;    /* Current Directory we're at */
        String [] dirs;         /* List of Directories Returned */
        UInt16 CurrentDirectoryIndex = 0; /* Current Index of Directory in List */
        UInt16 CurrentMealIndex = 0;    /* Current Meal being shown */

        StreamReader Input;
        List<Meal> Meals;

        /// <summary>
        /// Constructor
        /// </summary>
        public MealDBExporter()
        {
            InitializeComponent();
        }

        private void MealDBExporter_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "D:\\ShimmerData\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                    CurrentFileName = openFileDialog1.FileName;
                    tbFileName.Text = CurrentFileName;
                    CurrentDirectoryPath = generateCurrentDirectoryPath(CurrentFileName);
                    tbCurrentDirectory.Text = getCurrentDirectoryName();
                    ParentDirectoryPath = generateParentDirectoryPath(CurrentFileName);
                    tbParentPath.Text = ParentDirectoryPath;
                    CurrentDirectoryIndex = 0;

                    /* Find all directories in parent */
                    dirs = Directory.GetDirectories(ParentDirectoryPath);


                    /* Get the current directory Index */
                    while (CurrentDirectoryPath.Equals(dirs[CurrentDirectoryIndex]) != true)
                        CurrentDirectoryIndex++;

                    /* Load the file and update the UI */
                    LoadCurrentFile();
               
            }

            btnWriteNext.Enabled = true;
        }

        private void LoadCurrentFile()
        {
            /* Update the Current File TextBox */
            tbFileName.Text = generateCurrentEventsFileName();

            /* Load all the meals in the current file */
            Meals = LoadMeals(generateCurrentEventsFileName());
            CurrentMealIndex = 0;

            /* Show the first Meal in the app */
            UpdateUI(Meals, CurrentMealIndex);
        }

        /// <summary>
        /// Self made String Compare tool
        /// </summary>
        /// <param name="source"></param>
        /// <param name="toCheck"></param>
        /// <param name="comp"></param>
        /// <returns></returns>
        public static bool Contains(String source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }

        private void UpdateUI(List <Meal> MealList, UInt16 CurrentMealIndex)
        {
            tbInMealNumber.Text = MealList[CurrentMealIndex].MealNumber.ToString();
            tbOutMealNumber.Text = tbInMealNumber.Text;

            tbInStartTime.Text = MealList[CurrentMealIndex].StartTime;
            tbOutStartTime.Text = tbInStartTime.Text;

            TimeSpan FiveOClock = new TimeSpan(5, 0, 0);
            TimeSpan InputTS;
            TimeSpan.TryParse(tbInStartTime.Text, out InputTS);

            if (TimeSpan.Compare(InputTS, FiveOClock) >= 0)
            {
                tbOutStartTime.ForeColor = Color.Black;
            }
            else
            {
                tbOutStartTime.ForeColor = Color.Red;
                InputTS = InputTS.Add(new TimeSpan(24, 0, 0));
                tbOutStartTime.Text = ((int) Math.Floor(InputTS.TotalHours)).ToString()+":"+InputTS.Minutes.ToString("00")+":"+InputTS.Seconds.ToString("00");
            }


            tbInEndTime.Text = MealList[CurrentMealIndex].EndTime;
            tbOutEndTime.Text = tbInEndTime.Text;

            TimeSpan.TryParse(tbInEndTime.Text, out InputTS);

            if (TimeSpan.Compare(InputTS, FiveOClock) >= 0)
            {
                tbOutEndTime.ForeColor = Color.Black;
            }
            else
            {
                tbOutEndTime.ForeColor = Color.Red;
                InputTS = InputTS.Add(new TimeSpan(24, 0, 0));
                tbOutEndTime.Text = ((int)Math.Floor(InputTS.TotalHours)).ToString() + ":" + InputTS.Minutes.ToString("00") + ":" + InputTS.Seconds.ToString("00");
            }

            tbInLocation.Text = MealList[CurrentMealIndex].Location;
            tbOutLocation.Text = tbInLocation.Text;

            tbInMealName.Text = MealList[CurrentMealIndex].MealName;
            tbOutMealName.Text = tbInMealName.Text;

            if (Contains(tbInMealName.Text,"Snack", StringComparison.OrdinalIgnoreCase))
            {
                tbOutMealName.Text = "Snack";
            }
            if (Contains(tbInMealName.Text, "Breakfast", StringComparison.OrdinalIgnoreCase))
            {
                tbOutMealName.Text = "Breakfast";
            }
            if (Contains(tbInMealName.Text, "Dinner", StringComparison.OrdinalIgnoreCase))
            {
                tbOutMealName.Text = "Dinner";
            }
            if (Contains(tbInMealName.Text, "Lunch", StringComparison.OrdinalIgnoreCase))
            {
                tbOutMealName.Text = "Lunch";
            }

            tbInCompany.Text = MealList[CurrentMealIndex].InCompany;
            tbOutCompany.Text = tbInCompany.Text;

            if (tbInCompany.Text.Equals("InCompany")) tbOutCompany.Text = "Group";

            tbInActivity.Text = MealList[CurrentMealIndex].Activity;
            tbOutActivity.Text = tbInActivity.Text;

            if (Contains(tbInActivity.Text, "Eating", StringComparison.OrdinalIgnoreCase))
            {
                tbOutActivity.Text = "Eating";
            }
            else if (Contains(tbInActivity.Text, "No", StringComparison.OrdinalIgnoreCase))
            {
                tbOutActivity.Text = "Eating";
            }
            else if (tbInActivity.Text.Equals("")) tbOutActivity.Text = "Eating";
            else
                tbOutActivity.Text = "Mixed";

            tbInDescription.Text = MealList[CurrentMealIndex].Description;
        }

        /// <summary>
        /// Creates a CurrentDirectoryPath given a child file path.
        /// </summary>
        /// <param name="CurrentFilePath">The path of a file in the directory</param>
        /// <returns>Full Path of Directory file exists in</returns>
        private String generateCurrentDirectoryPath(String CurrentFilePath)
        {
            return new DirectoryInfo(CurrentFilePath).Parent.FullName;
        }


        /// <summary>
        /// Creates Parent Directory from CurrentFilePath
        /// </summary>
        /// <param name="CurrentFilePath">Path of Child\Child.txt</param>
        /// <returns></returns>
        private String generateParentDirectoryPath(String CurrentFilePath)
        {
            return new DirectoryInfo(CurrentFilePath).Parent.Parent.FullName + "\\";
        }

        /// <summary>
        /// Creates CurrentFileName from CurrentDirectoryPath
        /// </summary>
        /// <returns>CurrentFileName</returns>
        private String generateCurrentFileName()
        {
            return CurrentDirectoryPath + "\\" + getCurrentDirectoryName() + ".txt";
        }

        /// <summary>
        /// Creates a Directory Name from Directory Path
        /// </summary>
        /// <returns></returns>
        private String getCurrentDirectoryName()
        {
            return new DirectoryInfo(CurrentDirectoryPath).Name;
        }

        /// <summary>
        /// Creates the events file name from the CurrentDirectoryPath
        /// </summary>
        /// <returns></returns>
        private String generateCurrentEventsFileName()
        {
            return CurrentDirectoryPath + "\\" + getCurrentDirectoryName() + "-events.txt";
        }

        /// <summary>
        /// Loads all Meals from a Given events file
        /// </summary>
        /// <param name="FilePath">Path to events file</param>
        /// <returns>List of Meals</returns>
        private List<Meal> LoadMeals(String FilePath)
        {
            List<Meal> MealsList = new List<Meal>();
            String Line;
            String[] Fields;
            String[] delimiters = new String[] { "\t", "\t|\t", "|" };
            Input = new StreamReader(FilePath);
            UInt16 CurrentMealNumber = 0;

            /* Read the first Line *Start Time */
            while ((Line = Input.ReadLine()) != null)
            {
                Fields = Line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                /* Add this to Meal List if not Start or End */
                if (Fields.Length>3)
                {
                    CurrentMealNumber++;
                    if(Fields.Length == 9) MealsList.Add(new Meal(CurrentMealNumber, Fields[0].Trim(), Fields[1].Trim(), Fields[2].Trim(), Fields[3].Trim(), Fields[4].Trim(), Fields[5].Trim(), Fields[6].Trim(), Fields[7].Trim(), Fields[8].Trim()));
                    if (Fields.Length == 8) MealsList.Add(new Meal(CurrentMealNumber, Fields[0].Trim(), Fields[1].Trim(), Fields[2].Trim(), Fields[3].Trim(), Fields[4].Trim(), Fields[5].Trim(), Fields[6].Trim(), Fields[7].Trim(), ""));
                }
            }

            return MealsList;
        }

        /// <summary>
        /// Code for the Write/Next Button
        /// </summary>
        private void btnWriteNext_Click(object sender, EventArgs e)
        {
            /* Write Meal Data to File */
            StreamWriter LineWriter = new StreamWriter(tbOpFilePath.Text,true);

            /* Write the meal to the output file */
            LineWriter.WriteLine(getCurrentDirectoryName() + "\t" + tbOutMealNumber.Text + "\t" + tbOutStartTime.Text + "\t" + tbOutEndTime.Text + "\t" + tbOutLocation.Text + "\t" + tbOutMealName.Text + "\t" + tbOutCompany.Text + "\t" + tbOutActivity.Text);

            LineWriter.Close();

            /* Increment Meal and Update UI */
            CurrentMealIndex++;

            if(CurrentMealIndex < Meals.Count)
                UpdateUI(Meals, CurrentMealIndex);
            /* Otherwise we're moving on to the next meal */
            else
            {
                /* Increment the Current Directory Index */
                CurrentDirectoryIndex++;

                if (CurrentDirectoryIndex < dirs.Length)
                {
                    CurrentDirectoryPath = dirs[CurrentDirectoryIndex];
                    tbCurrentDirectory.Text = getCurrentDirectoryName();
                    LoadCurrentFile();
                }
                else
                {
                    MessageBox.Show("Finished reading entire folder");
                    btnWriteNext.Enabled = false;
                }
                
            }
            
        }



    }

    /// <summary>
    /// Stores a single Meal and all its information
    /// </summary>
    public class Meal
    {
        /// <summary>
        /// MealNumber for this participant.
        /// </summary>
        public int MealNumber;
        /// <summary>
        /// Name of Meal
        /// </summary>
        public String MealName;
        /// <summary>
        /// Start Time of Meal
        /// </summary>
        public String StartTime;
        /// <summary>
        /// End Time of Meal
        /// </summary>
        public String EndTime;
        /// <summary>
        /// Location of Meal
        /// </summary>
        public String Location;
        /// <summary>
        /// Seconds
        /// </summary>
        public String Seconds;
        /// <summary>
        /// InCompany
        /// </summary>
        public String InCompany;
        /// <summary>
        /// CompanyEating
        /// </summary>
        public String CompanyEating;
        /// <summary>
        /// Description
        /// </summary>
        public String Description;
        /// <summary>
        /// Activity
        /// </summary>
        public String Activity;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="MealNumber"></param>
        /// <param name="MealName"></param>
        /// <param name="StartTime"></param>
        /// <param name="EndTime"></param>
        /// <param name="Location"></param>
        /// <param name="Seconds"></param>
        /// <param name="InCompany"></param>
        /// <param name="CompanyEating"></param>
        /// <param name="Description"></param>
        /// <param name="Activity"></param>
        public Meal(int MealNumber, String MealName, String StartTime, String EndTime, String Location, String Seconds, String InCompany, String CompanyEating, String Description, String Activity)
        {
            this.MealNumber = MealNumber;
            this.MealName = MealName;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Location = Location;
            this.Seconds = Seconds;
            this.InCompany = InCompany;
            this.CompanyEating = CompanyEating;
            this.Description = Description;
            this.Activity = Activity;
        }
    }

}
