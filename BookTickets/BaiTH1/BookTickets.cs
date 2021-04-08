using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiTH1.Properties;

namespace BaiTH1
{
    public partial class BookTickets : Form
    {
        public BookTickets()
        {
            InitializeComponent();
        }

        // khởi tạo kiểu phim
        struct movie
        {
            public string name { get; set; }
            public string staus { get; set; }
            public List<showTimeFilm> showTimes { get; set; }
        }

        // khởi tạo thời gian và địa điểm chiếu
        struct showTimeFilm
        {
            public string time { get; set; }
            public List<bool> seats_1 { get; set; }
            public List<bool> seats_2 { get; set; }
            public List<bool> seats_3 { get; set; }
        }

        // tạo thời gian và địa điểm chiếu
        showTimeFilm createShowTime(string time = "", int theater = -1,List<int> booked = null )
        {
            showTimeFilm newST = new showTimeFilm();
            newST.time = time;

            if(theater == 1)
            {
                newST.seats_1 = new List<bool>();
                for (int i = 0; i < 37; i++)// đổi số ghế tùy theo sơ đồ 
                {
                    if(booked == null)
                        newST.seats_1.Add(false);
                    else
                    {
                        if (booked.Contains(i))
                            newST.seats_1.Add(true);
                        else
                            newST.seats_1.Add(false);
                    }  
                }
            }
            else if (theater == 2)
            {
                newST.seats_2 = new List<bool>();
                for (int i = 0; i < 37; i++) // đổi số ghế tùy theo sơ đồ 
                {
                    if (booked == null)
                        newST.seats_2.Add(false);
                    else
                    {
                        if (booked.Contains(i))
                            newST.seats_2.Add(true);
                        else
                            newST.seats_2.Add(false);
                    }
                }
            }
            else if (theater == 3)
            {
                newST.seats_3 = new List<bool>();
                for (int i = 0; i < 37; i++)// đổi số ghế tùy theo sơ đồ 
                {
                    if (booked == null)
                        newST.seats_3.Add(false);
                    else
                    {
                        if (booked.Contains(i))
                            newST.seats_3.Add(true);
                        else
                            newST.seats_3.Add(false);
                    }
                }
            }
            
            return newST;
        }

        // khởi tạo database ban đầu
        void createDatabase()
        {
            movie newFilm = new movie();
            newFilm.name = "bố già";
            newFilm.staus = "Đang chiếu";
            newFilm.showTimes = new List<showTimeFilm>();

            //
            List<int> booked = new List<int> { 1, 8, 10, 11, 23, 6 };
            showTimeFilm newST = createShowTime("07:00",1,booked);
            newFilm.showTimes.Add(newST);

            booked = new List<int> { 3, 4, 20,21,22};
            newST = createShowTime("07:00", 3, booked);
            newFilm.showTimes.Add(newST);

            newST = createShowTime("09:00", 3);
            newFilm.showTimes.Add(newST);

            newST = createShowTime("17:00", 1);
            newFilm.showTimes.Add(newST);

            newST = createShowTime("17:00", 2);
            newFilm.showTimes.Add(newST);

            // add to list
            moviesList.Add(newFilm);
            imageListMovies.Images.Add(Resources.Bố_già);
        }

        // khởi tạo biến
        List<movie> moviesList = new List<movie>();
        ImageList imageListMovies = new ImageList();
        int selectedItem = -1;
        List<Button> lstBtn = new List<Button>();
        List<Label> lstLb = new List<Label>();
        int selectedSeat = -1;
        bool firstTime = true;
        Size defautSize;
        bool booking = false;
        // hàm cập nhật giá trị đang được chọn ở listview
        void getItem()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                selectedItem = listView1.SelectedItems[0].Index;
            }
        }

        // hàm show trên listview
        void showListView()
        {
            listView1.Clear();
            for (int i = 0; i < moviesList.Count(); i++)
            {
                listView1.Items.Add(moviesList[i].staus, i);
                imageListMovies.ImageSize = new Size(128, 128);
                listView1.LargeImageList = imageListMovies;
                listView1.View = View.LargeIcon;
            }
        }

        // tạo hàm chọn ghế
        void chooseSeat(object sender, EventArgs e)
        {
            var button = (Button)sender;
            selectedSeat = button.Name[button.Name.Length - 1] - 49;

            if(button.BackColor == Color.YellowGreen)
            {
                button.BackColor = Color.Transparent;
            }
            else
            {
                button.BackColor = Color.YellowGreen;
                textBox_soghe.Text = lstLb[selectedSeat].Text;
            }     
        }
        

        // tìm ID phim
        int findIDFilm(string name)
        {
            for (int i = 0; i < moviesList.Count; i++)
            {
                if(name == moviesList[i].name)
                {
                    return i;
                }
            }
            return -1;
        }

        // show infor to combobox of name film
        void showNameFilm(ComboBox cbb)
        {
            cbb.DataSource = null;
            List<string> nameFilms = new List<string>();
            foreach (movie film in moviesList)
            {
                if (nameFilms.Contains(film.name) == false)
                    nameFilms.Add(film.name);
            }
            cbb.DataSource = nameFilms;
            cbb.Text = "";
        }

        // hàm show thông tin thời gian hiện có 
        void showTimes(ComboBox cbb,bool booking = false, string name = "")
        {
            List<string> times = new List<string>();
            foreach (movie film in moviesList)
            {
                foreach (showTimeFilm st in film.showTimes)
                {

                    if (times.Contains(st.time) == false)
                        times.Add(st.time);
                }
            }
            cbb.DataSource = null;
            cbb.DataSource = times;
            cbb.Text = "";
        }

        // hàm show sơ đồ 
        void showMaps(ComboBox cbbTimes, ComboBox cbbTheater)
        {
            if (cbbTimes.Text != "" && cbbTheater.Text != "")
            {
                panel_seatsMap.Visible = true; // bật panel

                foreach (movie film in moviesList)
                {
                    foreach (showTimeFilm st in film.showTimes)
                    {
                        if (st.time == cbbTimes.Text)
                        {
                            if (st.seats_1 != null && cbbTheater.Text == "1")
                            {
                                for (int i = 0; i < 37; i++)
                                {
                                    if (st.seats_1[i])
                                    {
                                        lstBtn[i].BackColor = Color.Transparent;
                                        lstBtn[i].BackgroundImage = Resources.whitechair;
                                        lstLb[i].BackColor = Color.Red;
                                    }
                                }
                            }
                            else if (st.seats_2 != null && cbbTheater.Text == "2")
                            {
                                for (int i = 0; i < 37; i++)
                                {
                                    if (st.seats_2[i])
                                    {
                                        lstBtn[i].BackColor = Color.Transparent;
                                        lstBtn[i].BackgroundImage = Resources.whitechair;
                                        lstLb[i].BackColor = Color.Red;
                                    }
                                }
                            }
                            else if (st.seats_3 != null && cbbTheater.Text == "3")
                            {
                                for (int i = 0; i < 37; i++)
                                {
                                    if (st.seats_3[i])
                                    {
                                        lstBtn[i].BackColor = Color.Transparent;
                                        lstBtn[i].BackgroundImage = Resources.whitechair;
                                        lstLb[i].BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin tra cứu!!!");
            }
        }

        // clear seats
        void clearSeats()
        {
            for(int i =0; i < 37; i++)
            {
                if(lstLb[i].BackColor == Color.Red || lstBtn[i].BackColor == Color.YellowGreen)
                {
                    lstBtn[i].BackColor = Color.Transparent;
                    lstBtn[i].BackgroundImage = Resources.blackchair;
                    lstLb[i].BackColor = Color.Transparent;
                }
            }
        }
        private void button_phim_cong_Click(object sender, EventArgs e)
        {
            // kiểm tra có tồn tại đủ thông tin chưa 
            if(textBox_danhmuc_phim.Text != "" && comboBox_tinhtrang.Text != "")
            {
                // lấy đường dẫn ảnh thông qua opendialog
                string imagePath = "";
                OpenFileDialog chooseImage = new OpenFileDialog();
                chooseImage.Title = "Chọn hình đại diện của phim";
                chooseImage.InitialDirectory = @"C:/";
                chooseImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                try
                {
                    if (chooseImage.ShowDialog() == DialogResult.OK)
                    {
                        imagePath = chooseImage.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn ảnh đại diện cho phim");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thực thi!!!");
                }
                
                // thêm phim vào database
                movie newFilm = new movie();
                newFilm.name = textBox_danhmuc_phim.Text;
                newFilm.staus = comboBox_tinhtrang.Text;
                newFilm.showTimes = new List<showTimeFilm>();

                moviesList.Add(newFilm);
                imageListMovies.Images.Add(Image.FromFile(imagePath));

                // show phim
                showListView();

                // setting defaut textbox
                comboBox_tinhtrang.Text = "";
                textBox_danhmuc_phim.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của phim!!!");
            }
        }
        

        private void comboBox_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_phim.Text != "")
            {
                selectedItem = findIDFilm(comboBox_phim.Text);
                List<string> times = new List<string>();
                foreach(showTimeFilm st in moviesList[selectedItem].showTimes)
                {
                    if (times.Contains(st.time) == false)
                        times.Add(st.time);
                }
                comboBox_suat.DataSource = times;
                comboBox_suat.Text = "";
            }
                
        }
       
        private void button_datve_Click(object sender, EventArgs e)
        {

            //if (comboBox_phim.Text != "")
            //{
            //    int iDFilm = findIDFilm(comboBox_phim.Text);
            //    if(iDFilm != -1)
            //    {

            //    }
            //}

            // đổi màu ghế và đặt ghế
            lstBtn[selectedSeat].BackColor = Color.Transparent;
            lstBtn[selectedSeat].BackgroundImage = Resources.whitechair;
            lstLb[selectedSeat].BackColor = Color.Red;
            //... đổi database
            //moviesList[iDFilm].seats[selectedSeat] = true;
            // set defaut-seat
            selectedSeat = -1;


        }

        private void comboBox_rap_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearSeats();
            if (comboBox_rap.Text != "" && comboBox_suat.Text != "")
            {
                showMaps(comboBox_suat, comboBox_rap);
            }
        }

        private void button_huyve_Click(object sender, EventArgs e)
        {
            

            // đổi màu ghế 
            lstBtn[selectedSeat].BackColor = Color.Transparent;
            lstBtn[selectedSeat].BackgroundImage = Resources.blackchair;
            lstLb[selectedSeat].BackColor = Color.Transparent;
            //... đổi database
            selectedSeat = -1;
        }

        private void button_phim_tru_Click(object sender, EventArgs e)
        {
            // kiểm tra có item nào được chọn chưa 
            if (selectedItem != -1)
            {
                // xóa phim
                moviesList.RemoveAt(selectedItem);
                imageListMovies.Images.RemoveAt(selectedItem);
                selectedItem = -1;
            }

            showListView();
            textBox_danhmuc_phim.Text = "";
            comboBox_tinhtrang.Text = "";
        }

        private void groupBox_datve_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox_phim_Enter(object sender, EventArgs e)
        {
            showListView();
            panel_seatsMap.Visible = false;
            comboBox_phim.Text = "";
            comboBox_rap.Text = "";
            comboBox_rap.Text = "";
            textBox_soghe.Text = "";
        }

        
        private void BookTickets_Load(object sender, EventArgs e)
        {
            button_datve.FlatAppearance.BorderSize = 0;
            button_huyve.FlatAppearance.BorderSize = 0;

            // tạo list button
            lstBtn= new List<Button> { button_1, button_2, button_3, button_4, button_5, button_6, button_7, button_8, button_9, button_10, button_11, button_12, button_13, button_14, button_15, button_16, button_17, button_18, button_19, button_20, button_21, button_22, button_23, button_24, button_25, button_26, button_27, button_28, button_29, button_30, button_31, button_32, button_33, button_34, button_35, button_36, button_37 };
            foreach(Button bt in lstBtn)
            {
                bt.FlatAppearance.BorderSize = 0;
            }

            // tạo list label
            lstLb = new List<Label> { label_1, label_2, label_3, label_4, label_5, label_6, label_7, label_8, label_9, label_10, label_11, label_12, label_13, label_14, label_15, label_16, label_17, label_18, label_19, label_20, label_21, label_22, label_23, label_24, label_25, label_26, label_27, label_28, label_29, label_30, label_31, label_32, label_33, label_34, label_35, label_36, label_37 };

            // thêm data vào trước
            createDatabase();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getItem();
        }

        private void comboBox_phim_Click(object sender, EventArgs e)
        {
            showNameFilm(comboBox_phim);
            showTimes(comboBox_suat);
        }

        private void comboBox_danhmuc_phim_Click(object sender, EventArgs e)
        {
            showNameFilm(comboBox_danhmuc_phim);
        }

        private void comboBox_danhmuc_phim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_xemGhe_Click(object sender, EventArgs e)
        {
            showMaps(comboBox_soDo_suat, comboBox_soDo_rap);

          
            //// bật tắt panel seats_map
            //if(panel_seatsMap.Visible == false)
            //{
            //    panel_seatsMap.Visible = true;
            //}
            //else
            //{
            //    // hủy chọn nếu có chọn ghế
            //    foreach(Button bt in lstBtn)
            //    {
            //        if (bt.BackColor == Color.YellowGreen)
            //            bt.BackColor = Color.Transparent;
            //    }
            //    panel_seatsMap.Visible = false;
            //}
        }

        private void panel_seatsMap_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            chooseSeat(sender, e);
        }

        private void button_2_Click(object sender, EventArgs e)
        {

        }

        private void BookTickets_SizeChanged(object sender, EventArgs e)
        {
            if (firstTime)
            {
                defautSize.Width = this.Width;
                defautSize.Height = this.Height;
                firstTime = false;
            }
            else
            {
                this.Width = defautSize.Width;
                this.Height = defautSize.Height;    
            }
        }

        private void textBox_danhmuc_phim_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox_soDo_suat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_soDo_suat_Click(object sender, EventArgs e)
        {
            List<string> times = new List<string>();
            foreach (movie film in moviesList)
            {
                foreach (showTimeFilm st in film.showTimes)
                {
                    if (times.Contains(st.time) == false)
                        times.Add(st.time);
                }
            }
            comboBox_soDo_suat.DataSource = null;
            comboBox_soDo_suat.DataSource = times;
        }

        private void comboBox_soDo_rap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_soDo_rap_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox_times_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_suat_Click(object sender, EventArgs e)
        {
        }

        private void comboBox_rap_Click(object sender, EventArgs e)
        {
            comboBox_rap.DataSource = null;
            List<int> theaters = new List<int>();
            foreach (movie film in moviesList)
            {
                foreach (showTimeFilm st in film.showTimes)
                {
                    if (st.time == comboBox_suat.Text)
                    {
                        if (st.seats_1 != null)
                            if (theaters.Contains(1) == false)
                                theaters.Add(1);
                        if (st.seats_2 != null)
                            if (theaters.Contains(2) == false)
                                theaters.Add(2);
                        if (st.seats_3 != null)
                            if (theaters.Contains(3) == false)
                                theaters.Add(3);
                    }
                }
            }
            comboBox_rap.DataSource = theaters;
            
        }

        private void comboBox_suat_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_rap.Text = "";
            comboBox_rap.DataSource = null;
        }
    }
}
