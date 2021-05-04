namespace Mediator_Pattern
{
    //Mediator
    class Form
    {
        public Button AddButton { get; set; }
        public TextBox NameTextBox { get; set; }
        public ListBox PeopleListBox { get; set; }

        public Form()
        {
            InitializeComponents();
            AddButton.Enabled = false;
        }

        private void InitializeComponents()
        {
            AddButton = new Button();
            NameTextBox = new TextBox();
            PeopleListBox = new ListBox();

            AddButton.Click += OnAddButtonClick;
            NameTextBox.TextChanged += OnNameTextBoxTextChanged;
        }

        public void OnAddButtonClick()
        {
            var name = NameTextBox.Text;
            PeopleListBox.Items.Add(name);
        }

        public void OnNameTextBoxTextChanged()
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                AddButton.Enabled = true;
            }
            else
            {
                AddButton.Enabled = false;
            }
        }
    }
}
