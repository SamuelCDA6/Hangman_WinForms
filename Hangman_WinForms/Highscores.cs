using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Hangman_WinForms
{
    enum Direction { ASC, DESC }
    enum Type { Date, Name, Score, Time }

    public partial class FormHighscores : Form
    {
        private static readonly string connectionString = @"*********************";
        private static readonly MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
        private static readonly MySqlDataAdapter adapter = new MySqlDataAdapter();

        private static readonly BindingSource bsDataGridView = new BindingSource();

        private static Type currentType = Type.Score;
        private static Direction currentDirection = Direction.DESC;
        private static int currentOffset = 0;

        public FormHighscores()
        {
            InitializeComponent();

            InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                DataTable dataTable = GetData("SELECT * FROM Hangman ORDER BY Score DESC LIMIT 10");

                dataGridView1.AutoGenerateColumns = true;

                bsDataGridView.DataSource = dataTable;
                dataGridView1.DataSource = bsDataGridView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateHighscoreDisplay(Type type, Direction direction, int offset)
        {
            DataTable dataTable = GetData($"SELECT * FROM Hangman ORDER BY {type} {direction} LIMIT {offset},10");

            bsDataGridView.DataSource = dataTable;
            dataGridView1.DataSource = bsDataGridView;

            if (dataTable.Rows.Count < 10)
            {
                btAfter.Enabled = false;
                btAfter.BackColor = Color.LightGray;
            }
            else if (!btAfter.Enabled)
            {
                btAfter.Enabled = true;
                btAfter.BackColor = Color.DarkGray;
            }

            if (currentOffset == 0)
            {
                btBefore.Enabled = false;
                btBefore.BackColor = Color.LightGray;
            }
            else if (!btBefore.Enabled)
            {
                btBefore.Enabled = true;
                btBefore.BackColor = Color.DarkGray;
            }
        }

        private static DataTable GetData(string sqlCommand)
        {
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand(sqlCommand, mySqlConnection);

                adapter.SelectCommand = command;

                table.Locale = System.Globalization.CultureInfo.InvariantCulture;

                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return table;
        }

        internal static int GetHighScore()
        {
            string sqlCommand = "SELECT Max(Score) FROM Hangman";
            MySqlCommand command = new MySqlCommand(sqlCommand, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        internal static void SaveScore(string name, int score, string time)
        {
            string sqlCommand = $"INSERT INTO Hangman (Date, Name, Score, Time) VALUES(SYSDATE(), \"{name}\", {score}, \"{time}\")";

            MySqlCommand command = new MySqlCommand(sqlCommand, mySqlConnection);

            try
            {
                mySqlConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void BtTime_Click(object sender, EventArgs e)
        {
            ChangeType(Type.Time, Direction.ASC);
        }

        private void BtScore_Click(object sender, EventArgs e)
        {
            ChangeType(Type.Score, Direction.DESC);
        }

        private void BtName_Click(object sender, EventArgs e)
        {
            ChangeType(Type.Name, Direction.ASC);

        }

        private void BtDate_Click(object sender, EventArgs e)
        {
            ChangeType(Type.Date, Direction.DESC);
        }

        private void ChangeType(Type type, Direction direction)
        {
            currentOffset = 0;

            if (currentType == type)
            {
                currentDirection = (currentDirection == Direction.ASC) ? Direction.DESC : Direction.ASC;
            }
            else
            {
                currentType = type;
                currentDirection = direction;
            }

            UpdateHighscoreDisplay(currentType, currentDirection, currentOffset);
        }

        private void BtBefore_Click(object sender, EventArgs e)
        {
            if (currentOffset != 0)
            {
                currentOffset -= 10;
                UpdateHighscoreDisplay(currentType, currentDirection, currentOffset);
            }
        }

        private void BtAfter_Click(object sender, EventArgs e)
        {
            currentOffset += 10;
            UpdateHighscoreDisplay(currentType, currentDirection, currentOffset);
        }

        private void BtReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
