using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentElevator
{
        
    public partial class Form1 : Form
    {
        //boolean values to check if the lift is moving up or down
        bool lift_going_down = false;
        bool lift_going_up = false;

        public Form1()
        {
            InitializeComponent();//windows forms auto-generated code to initialise the resources/buttons, etc
            open_doors_down();//starting the program by opening the doors at ground floor
        }

        private void control_up_Click(object sender, EventArgs e)//up button in the control panel
        {
            goingup();//start the timer to make the lift go up
        }

        private void control_down_Click(object sender, EventArgs e)//down button in control panel
        {
            goingdown();//start the timer to make the lift go down
        }

        private void request_up_Click(object sender, EventArgs e)//up button on the elevator panel
        {
            goingup();//start the timer that makes the lift go up
        }

        private void request_down_Click(object sender, EventArgs e)//down button on the elevator panel
        {
            goingdown();//start the timer that makes the lift go down
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();//close the application
        }

        private void timer1_Tick(object sender, EventArgs e)//make lift go down
        {
            if (pictureBox1.Location.Y <= 298)//checking if the elevator picture is at a certain location before moving it
            {
                pictureBox1.Top += 2;//move the elevator picture down by two pixels everytime the loop runs
                floor_display_label.Top += 2;//move the label at the same time
            }
            else//if the elevator is already down
            {
                timer1.Enabled = false;//stop the timer
                open_doors_down();//start the door opening animation
                display_floor0.Image = Properties.Resources.green;//change the floor 0 display images to green
                control_floor0.Image = Properties.Resources.green;//to show that's where the lift is

                display_floor1.Image = Properties.Resources.red;//change the floor 1 displays to red
                control_floor1.Image = Properties.Resources.red;

                floor_display_label.Text = "Floor 0";//change the label text as well
                pictureBox2.Image = Properties.Resources.fg1;//change the image in the control panel to show G (for ground floor)
            }
        }

        private void timer2_Tick(object sender, EventArgs e)//make lift go up
        {
            if (pictureBox1.Location.Y <= 470 && pictureBox1.Location.Y > 15)/*this time we are checking if the picture box is anywhere between these two variables
                                                                               *because it doesn't work with just one.
                                                                               * It needs two coordinates so it knows when to stop moving the lift up 
                                                                               * */
            {
                timer4.Enabled = true;//if it meets those conditions it starts the down doors closing animation
                pictureBox1.Top -= 2;//and moves the lift picture box up by two pixels
                floor_display_label.Top -= 2;//same with the label
            }
            else//if the elevator is already up
            {
                timer2.Enabled = false;//stop the timer
                open_doors_up();//start the door opening animation
                display_floor1.Image = Properties.Resources.green;//change all the images accordingly
                control_floor1.Image = Properties.Resources.green;

                display_floor0.Image = Properties.Resources.red;
                control_floor0.Image = Properties.Resources.red;
                floor_display_label.Text = "Floor 1";//as well as the label
                pictureBox2.Image = Properties.Resources.f11;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)//animate doors opening at ground floor
        {
            if (pictureBox4.Location.X >= 1 && pictureBox5.Location.X<=panel1.Width)//this time we are usig the X coordinate to check if the doors are in a certain position
            {                                                                       //I am using panel1.width because i couldn't find an integer that worked the way I wanted
                                                                                    //and because this way the doors can stop once they reach a certain point
                pictureBox4.Left -= 2;//move both picture boxes to the left and right respectively
                pictureBox5.Left += 2;
            }
            else
            {
                timer3.Enabled = false;//if the conditions aren't met, the timer stops
            }
        }

        private void timer4_Tick(object sender, EventArgs e)//doors closing at ground floor
        {
            if(pictureBox4.Location.X <= 55 && pictureBox5.Location.X >= 1)//for closing the doors it's a bit different, I don't need to use panel.width anymore
            {                                                               //the doors stop moving once the left door reaches X=56
                pictureBox4.Left += 2;//move the doors by two pixels
                pictureBox5.Left -= 2;
            }
            else//if the conditions aren't met
            {
                timer4.Enabled = false;//stop the timer
                if (lift_going_up == true)//this value changes to true when any of the up buttons are pressed
                {
                    timer2.Enabled = true;//and this code makes it actually move up in this case
                    lift_going_up = false;//then set the variable back to false to prevent infinite loops
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)//open doors at the first floor
        {
            /*
             * Timer 5 and timer 6 do exactly the same thing as 3 and 4, except for the doors at first floor
             * */
            if (pictureBox7.Location.X >= 1 && pictureBox6.Location.X <= panel1.Width)
            {
                pictureBox7.Left -= 2;
                pictureBox6.Left += 2;
            }
            else
            {
                timer5.Enabled = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)//close doors at first floor
        {
            //same code as timer 4, except different variables 
            //because obviously the picture boxes are at different locations
            if (pictureBox7.Location.X <= 55 && pictureBox6.Location.X >= 1)
            {
                pictureBox7.Left += 2;
                pictureBox6.Left -= 2;
            }
            else
            {
                timer6.Enabled=false;
                if (lift_going_down == true)//same style of nested if statement,
                                            //except now we're checking if the lift is going down
                {
                    timer1.Enabled = true;
                    lift_going_down = false;
                }
            }
        }
        /*
         * The next 4 methods are controlling all the doors opening and closing animations
         * The close animation ones get called by two different methods
         * which are previously called on a button press
         * 
         */
        private void open_doors_down()//in order to open the doors at ground floor
        {
            timer3.Enabled = true;//we need to start the timer which controls the animation
            add_Data("Ground Floor - Doors Opening");//this line adds information in the database using the add_Data method
        }
        //the rest of these methods to the same thing, except they start different timers according to the action performed
        private void close_doors_down()
        {
            timer4.Enabled = true;
            add_Data("Ground Floor - Doors Closing");
        }

        private void open_doors_up()
        {
            timer5.Enabled = true;
            add_Data("First Floor - Doors Opening");
        }

        private void close_doors_up()
        {
            timer6.Enabled = true;
            add_Data("First Floor - Doors Closing");
        }

        private void goingup()//this method gets called by the up buttons to move the lift to the first floor
        {
            close_doors_down();//it closes the doors at ground floor
            lift_going_up = true;//changes the going_up variable to true, so that the timer can start
            add_Data("This lift is going up");//and adds data into the logs
        }

        private void goingdown()//same thing with this method, execept it's for going down
        {
            close_doors_up();//closes the doors at first floor
            lift_going_down = true;//starts a different timer
            add_Data("This lift is going down");
            
        }

        private bool filled;//variable needed by the list box to fetch items from the database
        public DataSet ds = new DataSet();//creates a new instance of the DataSet object

        private void btn_log_Click(object sender, EventArgs e)//events for the log button press
        {
            try//try/catch block for easier error handling
            {
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=logs.accdb;";//create the connection string to the database
                string dbcommand = "SELECT * FROM actions;";//SQL command to get items from the database
                OleDbConnection conn = new OleDbConnection(dbconnection);//creating new objects for connection, command and data adapter respectively
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

                conn.Open();//opens the connection to the Access database

                while (filled == false)//if the list box is not populated with all the elements in the database
                {
                    adapter.Fill(ds);//it fetches the data and stores it in the adapter
                    filled = true;//and the variable changes to true, so the loop stops
                }
                conn.Close();//closing the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displays an error message in case the connection fails
            }

            listBox1.Items.Clear();//clear the items in the listbox
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                //adds the items from the adapter in the list box
                listBox1.Items.Add(row["Date"] + "\t" + row["Time"] + "\t\t" + row["Action"]);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)//clear logs button
        {
            listBox1.Items.Clear();//this just erases everything from the listbox
        }

        private void add_Data(string action)//the method for adding information into the database according to specific events
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = logs.accdb;";//connection string again
            string dbcommand = "INSERT INTO [actions] ([Date],[Time],[Action]) VALUES (@date, @time, @action)";//SQL insert command
            string date = DateTime.Now.ToShortDateString();//initialising the date and time string variables
            string time = DateTime.Now.ToLongTimeString();//these get converted to date and time respectively and automatically added to the database when an action is added

            listBox1.Items.Add(date + "\t" + time + "\t\t" + action);//shows the items in the listBox

            OleDbConnection conn_db = new OleDbConnection(dbconnection);//creating new objects for database connection, SQL command, and data adapter
            OleDbCommand comm_insert = new OleDbCommand(dbcommand, conn_db);
            OleDbDataAdapter adapter_insert = new OleDbDataAdapter(comm_insert);
            //executes the command and adds items to the database
            comm_insert.Parameters.AddWithValue("@date", date);
            comm_insert.Parameters.AddWithValue("@time", time);
            comm_insert.Parameters.AddWithValue("@action", action);

            conn_db.Open();//connection is opened

            comm_insert.ExecuteNonQuery();//execute the query

            conn_db.Close();//and close the connection
        }
        /*
         * The next few methods are empty, because while making the GUI I accidentally double clicked the items in the design form
         * and if I try to delete them I get an error
         * I would have to go through the Windows Forms auto-generated code to modify the entries
         * in order to be able to delete them, but that might cause other issues 
         * so I decided just to keep them
         * 
         */
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void floor_display_label_Click(object sender, EventArgs e)
        {

        }

    }
}
