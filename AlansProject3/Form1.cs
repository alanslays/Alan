namespace AlansProject3
{
    public partial class Form1 : Form
    {

        Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "d�bowe drzwi z mosi�n� klamk�");
            diningRoom = new Room("Jadalnia", "kryszta�owy �yrandol");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztu�ce", "rozsuwane drzwi");

            frontYard = new OutsideWithDoor("Podw�rko przed domem", false, "d�bowe drzwi z mosi�zn� klamk�");
            backYard = new OutsideWithDoor("Podw�rko za domem", true, "rozsuwane drzwi");
            garden = new Outside("Ogr�d", false);

            diningRoom.Exists = new Location[] { livingRoom, kitchen };
            livingRoom.Exists = new Location[] { diningRoom };
            kitchen.Exists = new Location[] { diningRoom };
            frontYard.Exists = new Location[] { backYard, garden };
            backYard.Exists = new Location[] { frontYard, garden };
            garden.Exists = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        public void MoveToANewLocation(Location newLocation)
        {
            currentLocation = new Location;

            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndec]);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
