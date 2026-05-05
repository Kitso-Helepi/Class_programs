namespace CRUD_ManagemenApp
{
    public partial class productsForm : Form
    {
        public productsForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string inputName = nameBox.Text;
            string inputID = idBox.Text;
            string inputPrice = priceBox.Text;

            if (string.IsNullOrEmpty(inputName) && string.IsNullOrEmpty(inputID) && string.IsNullOrEmpty(inputPrice))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            foreach (var item in displayBox.Items)
            {
                if (item.ToString().Contains($"Name: {inputName}|ID: {inputID}|Price: R{inputPrice}"))
                {
                    MessageBox.Show("The Product already exists");
                    return;
                }


            }
            displayBox.Items.Add($"Name: {inputName}|ID: {inputID}|Price: R{inputPrice}");
            nameBox.Clear();
            idBox.Clear();
            priceBox.Clear();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (displayBox.SelectedItems == null)
            {

                MessageBox.Show("Please select an item");
                return;
            }

            displayBox.Items.Remove(displayBox.SelectedItem);

        }
    }
}
