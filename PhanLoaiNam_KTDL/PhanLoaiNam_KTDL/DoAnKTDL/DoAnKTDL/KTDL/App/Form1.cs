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
using KTDL;
using FileHelpers;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XuLy dt = new XuLy();
        List<string> kqTest;
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPathTest.Text = ofd.FileName;
            }
            
        }

        

        private void btnTest_Click(object sender, EventArgs e)
        {
            string[] line = System.IO.File.ReadAllLines(@""+txtPathTest.Text+"");
            var dsMushroomTest = new List<ModelInput>();
            for(int i = 1; i < line.Length; i ++)
            {
                ModelInput mushroom = new ModelInput();
                string[] row = line[i].Split(",");
                mushroom.Cap_shape = row[0];
                mushroom.Cap_surface = row[1];
                mushroom.Cap_color = row[2];
                mushroom.Bruises = row[3];
                mushroom.Odor = row[4];
                mushroom.Gill_attachment = row[5];
                mushroom.Gill_spacing = row[6];
                mushroom.Gill_size = row[7];
                mushroom.Gill_color = row[8];
                mushroom.Stalk_shape = row[9];
                mushroom.Stalk_root = row[10];
                mushroom.Stalk_surface_above_ring = row[11];
                mushroom.Stalk_surface_below_ring = row[12];
                mushroom.Stalk_color_above_ring = row[13];
                mushroom.Stalk_color_below_ring = row[14];
                mushroom.Veil_type = row[15];
                mushroom.Veil_color = row[16];
                mushroom.Ring_number = row[17];
                mushroom.Ring_type = row[18];
                mushroom.Spore_print_color = row[19];
                mushroom.Population = row[20];
                mushroom.Habitat = row[21];
                dsMushroomTest.Add(mushroom);
            }
            kqTest = new List<string>();
            for (int i = 0; i < dsMushroomTest.Count; i++)
            {
                //textBox1.Text = textBox1.Text+ dt.phanLop(dsMushroomTest[i].Cap_shape, dsMushroomTest[i].Cap_surface, dsMushroomTest[i].Cap_color, dsMushroomTest[i].Bruises,
                //    dsMushroomTest[i].Odor, dsMushroomTest[i].Gill_attachment, dsMushroomTest[i].Gill_spacing, dsMushroomTest[i].Gill_size, dsMushroomTest[i].Gill_color,
                //    dsMushroomTest[i].Stalk_shape, dsMushroomTest[i].Stalk_root, dsMushroomTest[i].Stalk_surface_above_ring, dsMushroomTest[i].Stalk_surface_below_ring,
                //    dsMushroomTest[i].Stalk_color_above_ring, dsMushroomTest[i].Stalk_color_below_ring, dsMushroomTest[i].Veil_type, dsMushroomTest[i].Veil_color, 
                //    dsMushroomTest[i].Ring_number, dsMushroomTest[i].Ring_type, dsMushroomTest[i].Spore_print_color, dsMushroomTest[i].Population, dsMushroomTest[i].Habitat);
                //kqTest.Add(dt.test(dsMushroomTest[i]));
                textBox1.Text = textBox1.Text + "\n" + dt.test(dsMushroomTest[i]);
            }
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] line1 = System.IO.File.ReadAllLines(@"" + txtPathTest.Text + "");
            string[] line = System.IO.File.ReadAllLines(@"" +txtPathResult.Text + "");
            var dsKQTest = new List<string>();
            var dsKQ = new List<string>();
            for (int i = 1; i < line.Length; i++)
            {
                string s = line[i];
                dsKQ.Add(s);
            }
            for (int j = 1; j < line1.Length; j++)
            {
                string s = line1[j];
                dsKQTest.Add(s);
            }
            int count = 0;
            for (int i = 0; i < dsKQ.Count; i++)
            {
                if (dt.convertNhan(dsKQTest[i]) == dt.convertNhan(dsKQ[i]))
                {
                    count++;
                }    
            }
            textBox1.Text ="Số mẫu khớp: "+count.ToString()+"     Tỉ lệ chính xác:"+ (count* 100 / dsKQ.Count).ToString()+"%";
            
        }

        private void btnBrowseResult_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPathResult.Text = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dt.kTraRong(cbbHinhDang1.Text) || dt.kTraRong(cbbBeMat1.Text) || dt.kTraRong(cbbMauSac1.Text) || dt.kTraRong(cbbVetTham1.Text) || dt.kTraRong(cbbMui1.Text)
               || dt.kTraRong(cbbMang1.Text) || dt.kTraRong(cbbKhoangCachMang1.Text) || dt.kTraRong(cbbKichThuocMang1.Text) || dt.kTraRong(cbbMauMang1.Text) ||
               dt.kTraRong(cbbHinhDang1.Text) || dt.kTraRong(cbbGocCuon1.Text) || dt.kTraRong(cbbCuongTren1.Text) || dt.kTraRong(cbbMauCuongDuoi1.Text) ||
               dt.kTraRong(cbbMauCuonTren1.Text) || dt.kTraRong(cbbMauCuongDuoi1.Text) || dt.kTraRong(cbbLoaiMangChe1.Text) || dt.kTraRong(cbbMauMangChe1.Text) ||
               dt.kTraRong(cbbSoVong1.Text) || dt.kTraRong(cbbKieuVong1.Text) || dt.kTraRong(cbbBaoTu1.Text) || dt.kTraRong(cbbNoiXuatHien1.Text) || dt.kTraRong(cbbMoiTruongSong1.Text))
            {
                MessageBox.Show("Vui lòng chọn thuộc tính!");
            }
            else
            {
                //Nắp
                string hinhNap = dt.traVeHinhDang(cbbHinhDang1.SelectedItem.ToString());
                string beMatNap = dt.traVeBeMat(cbbBeMat1.SelectedItem.ToString());
                string mauNap = dt.traVeMauSac(cbbMauSac1.SelectedItem.ToString());
                string vetThem = dt.traVeVetTham(cbbVetTham1.SelectedItem.ToString());
                string mui = dt.traVeMui(cbbMui1.SelectedItem.ToString());
                //Mang
                string mang = dt.traVeMang(cbbMang1.SelectedItem.ToString());
                string kcMang = dt.traVeKhoangCachMang(cbbKhoangCachMang1.SelectedItem.ToString());
                string ktMang = dt.traVeKichThuocMang(cbbKichThuocMang1.SelectedItem.ToString());
                string mauMang = dt.traVeMauMang(cbbMauMang1.SelectedItem.ToString());
                //Cuống
                string hdCuong = dt.traVeHinhDangCuon(cbbHinhDangCuon1.SelectedItem.ToString());
                string gocCuong = dt.traVeGocCuon(cbbGocCuon1.SelectedItem.ToString());
                string cuongTren = dt.traVeCuon(cbbCuongTren1.SelectedItem.ToString());
                string cuongDuoi = dt.traVeCuon(cbbCuonDuoi1.SelectedItem.ToString());
                string mauCuongTren = dt.traVeMauCuon(cbbMauCuonTren1.SelectedItem.ToString());
                string mauCuongDuoi = dt.traVeMauCuon(cbbMauCuongDuoi1.SelectedItem.ToString());
                //Màng che
                string loaiMangChe = dt.traVeLoaiManChe(cbbLoaiMangChe1.SelectedItem.ToString());
                string mauMangChe = dt.traVeMauManChe(cbbMauMangChe1.SelectedItem.ToString());
                //Vòng nấm
                string soVong = dt.traVeSoVong(cbbSoVong1.SelectedItem.ToString());
                string kieuVong = dt.traVeKieuVong(cbbKieuVong1.SelectedItem.ToString());
                string baoTu = dt.traVeVeBaoTu(cbbBaoTu1.SelectedItem.ToString());
                //Môi trường
                string noiXuatHien = dt.traVeNoiXuatHien(cbbNoiXuatHien1.SelectedItem.ToString());
                string moiTruong = dt.traVeMoiTruong(cbbMoiTruongSong1.SelectedItem.ToString());
                //Kết quả để đưa predic

                string kq = dt.phanLop(hinhNap, beMatNap, mauNap, vetThem, mui
                        , mang, kcMang, ktMang, mauMang
                        , hdCuong, gocCuong, cuongTren, cuongDuoi, mauCuongTren, mauCuongDuoi
                        , loaiMangChe, mauMangChe
                        , soVong, kieuVong, baoTu,
                        noiXuatHien, moiTruong);
                //Kiểm tra kết quả
                if (kq == "p")
                {
                    MessageBox.Show("Những thuộc tính trên cho thấy loại nấm này không ăn được! " + "(" + kq + ")");
                }
                else if (kq == "e")
                {
                    MessageBox.Show("Những thuộc tính trên cho thấy loại nấm này ăn được! " + "(" + kq + ")");
                }
                else
                {
                    MessageBox.Show("Không thể xác định được");
                }
            }
        }
    }
}
