namespace PhotoEditor
{
    public partial class MainForm : Form
    {
        //This is the variable that is going to be used for the photo root directory
        private string photoRootDirectory;
        private List<FileInfo> photoFiles;

        public MainForm()
        {
            InitializeComponent();

            //Part 1 - Due: Sept. 22
            //1. ListView on the main form shows all JPEG filenames in the user's Pictures directory.
            //   No photo is necessary, and no background thread is necessary to populate the list box

            //Need to get folder path - want to get pictures from the pictures folder
            photoRootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            PopulateImageList();

        }

        //Populate Image List()
        private void PopulateImageList()
        {
            photoFiles = new List<FileInfo>();

            //ListViewItem item1 = new ListViewItem("item1", 0);   // Text and image index
            //item1.SubItems.Add("1");   // Column 2
            //item1.SubItems.Add("2");   // Column 3
            //item1.SubItems.Add("3");   // Column 4

            //ListViewItem item2 = new ListViewItem("item2", 1);
            //item2.SubItems.Add("4");
            //item2.SubItems.Add("5");
            //item2.SubItems.Add("6");

            //ListViewItem item3 = new ListViewItem("item3", 2);
            //item3.SubItems.Add("7");
            //item3.SubItems.Add("8");
            //item3.SubItems.Add("9");

            //// Create columns (Width of -2 indicates auto-size)
            //mainFormListView.Columns.Add("Column 1", -2, HorizontalAlignment.Left);
            //mainFormListView.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            //mainFormListView.Columns.Add("Column 3", 40, HorizontalAlignment.Right);
            //mainFormListView.Columns.Add("Column 4", 40, HorizontalAlignment.Center);

            DirectoryInfo homeDir = new DirectoryInfo(photoRootDirectory);
            foreach (FileInfo file in homeDir.GetFiles("*.jpg"))
            {
                //photoFiles.Add(file);
                var temp = file.Name;
                mainFormListView.Items.Add(temp);
            }

            mainFormListView.Columns.Add("Column 1", -2, HorizontalAlignment.Left);
            mainFormListView.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            mainFormListView.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            mainFormListView.Columns.Add("Column 4", -2, HorizontalAlignment.Left);

            // Show default view - put in a list for now
            mainFormListView.View = View.List;

        }
    }
}