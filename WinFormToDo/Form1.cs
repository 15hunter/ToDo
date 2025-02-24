using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormToDo
{
    public partial class txtAdd : Form
    {

        private List<Todo> TaskList { get; set; }
        public txtAdd()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        private void SubmitForm(object sender, EventArgs e) {

            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Description is empty, please provide a description.");
                return;
            }
            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Missing a due date.");
                return;
            }
            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formatted, please resubmit.");
                return;
            }
            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description needs to be created.");
                return;
            }


            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            TaskList.Add(myTodo);

            UpdateListBox();

            ClearForm();
           

        }

       

        public void UpdateListBox()
        {
            lbTaskList.Items.Clear();

            var list = TaskList
                .Where(t => t.IsDone == false)
                .OrderBy(t => t.DueDate)
                .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                lbTaskList.Items.Add(list[i].ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form cleared");
           
        }

        private void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDate.Clear();
        }

        private void lbTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbTaskList.SelectedIndex;
            string selectedItem = (string)lbTaskList.SelectedItem;

            if (selectedIndex == -1)
            {
                return;
            }

            if (selectedItem == null)
            {
                MessageBox.Show("No item selected at the index");
                return;
            }

            //int id = Int32.Parse(selectedItem.Split(" - ")[0]);

            //var todo = TaskList.Find(t => t.Id == id);

            //if (todo != null) 
            //{ 
               // todo.IsDone = !todo.IsDone;

               // UpdateListBox();
            //}
            

            

        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SubmitForm(sender, e);
            }
        }
    }
}
