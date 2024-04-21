namespace lap_lich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            show_matrix();
        }

        public void show_matrix()
        {
            Button old_bt = new Button()
            {
                Width = 95,
                Height = 59,
                Location = new Point(0, 0)
            };
             

            for (int i = 0; i < 5; i++)
            {
                p_matrix.Controls.Add(old_bt);
                for (int j = 0; j < 6; j++)
                {
                    Button new_bt = new Button()
                    {
                        Width = 95,
                        Height = 59,
                        Location = new Point(old_bt.Location.X + 95 + 6, old_bt.Location.Y)
                    };

                    p_matrix.Controls.Add(new_bt);
                    old_bt = new_bt;
                }

                old_bt = new Button()
                {
                    Width = 95,
                    Height = 59,
                    Location = new Point(0, old_bt.Location.Y + 59 + 6)
                };
                
            }
        }
    }
}
