using System;
using System.Collections.Generic;
using System.Text;
using KTDL;

namespace App
{
    public class XuLy
    {
        public string test(ModelInput ip)
        {
            ModelOutput ketqua = ConsumeModel.Predict(ip);
            return ketqua.Prediction.ToString();
        }
        public string phanLop(string pHinhDang, string pBeMat, string pMauSac, string pVetTham,
            string pMui,
            string pMang, string pKhoangCachMang, string pKichThuocMang, string pMauMang,
            string pHinhDangCuon, string pGocCuong, string pCuongTren, string pCuongDuoi, string pMauCuongTren, string pMauCuongDuoi,
            string pLoaiManChe, string pMauMangChe,
            string pSoVong, string pKieuVong, string pBaoTu,
            string pNoiXuatHien, string pMoiTruongSong)
        {
            var input = new ModelInput();
            //1
            //2
            input.Cap_shape = pHinhDang;
            //3
            input.Cap_surface = pBeMat;
            //4
            input.Cap_color = pMauSac;
            //5
            input.Bruises = pVetTham;
            //6
            input.Odor = pMui;
            //7
            input.Gill_attachment = pMang;
            //8
            input.Gill_spacing = pKhoangCachMang;
            //9
            input.Gill_size = pKichThuocMang;
            //10
            input.Gill_color = pMauMang;
            //11
            input.Stalk_shape = pHinhDangCuon;
            //12
            input.Stalk_root = pGocCuong;
            //13
            input.Stalk_color_above_ring = pCuongTren;
            //14
            input.Stalk_color_below_ring = pCuongDuoi;
            //15
            input.Stalk_surface_above_ring = pMauCuongTren;
            //16
            input.Stalk_surface_below_ring = pMauCuongDuoi;
            //17
            input.Veil_type = pLoaiManChe;
            //18
            input.Veil_color = pMauMangChe;
            //19
            input.Ring_number = pSoVong;
            //20
            input.Ring_type = pKieuVong;
            //21
            input.Spore_print_color = pBaoTu;
            //22
            input.Population = pNoiXuatHien;
            //23
            input.Habitat = pMoiTruongSong;



            ModelOutput ketqua = ConsumeModel.Predict(input);
            return ketqua.Prediction.ToString();
        }
        public int convertNhan(string s)
        {
            if (s == "p")
                return 0;
            else return 1;
        }
        //Chuyển dạng combobox
        //1
        public string traVeHinhDang(string input)
        {
            if (input == "Chuông")
            {
                input = "b";
            }
            else if (input == "Hình nón")
            {
                input = "c";
            }
            else if (input == "Lồi")
            {
                input = "x";
            }
            else if (input == "Phẳng")
            {
                input = "f";
            }
            else if (input == "Núm")
            {
                input = "k";
            }
            else if (input == "Trũng")
            {
                input = "s";
            }

            return input;
        }
        //2
        public string traVeBeMat(string input)
        {
            if (input == "Sợi")
            {
                input = "f";
            }
            else if (input == "Rãnh")
            {
                input = "g";
            }
            else if (input == "Vảy")
            {
                input = "y";
            }
            else if (input == "Mịn")
            {
                input = "s";
            }
            return input;
        }
        //3
        public string traVeMauSac(string input)
        {
            if (input == "Nâu")
            {
                input = "n";
            }
            if (input == "Da bò")
            {
                input = "b";
            }
            if (input == "Quế")
            {
                input = "c";
            }
            if (input == "Xám")
            {
                input = "g";
            }
            if (input == "Xanh Lá Cây")
            {
                input = "r";
            }
            if (input == "Hồng")
            {
                input = "p";
            }
            if (input == "Tím")
            {
                input = "u";
            }
            if (input == "Đỏ")
            {
                input = "e";
            }
            if (input == "Trắng")
            {
                input = "w";
            }
            if (input == "Vàng")
            {
                input = "y";
            }
            return input;
        }
        //4
        public string traVeVetTham(string input)
        {
            if (input == "Thâm")
            {
                input = "t";
            }
            if (input == "Không")
            {
                input = "f";
            }
            return input;
        }
        //5
        public string traVeMui(string input)
        {
            if (input == "Hạnh nhân")
            {
                input = "a";
            }
            if (input == "Hồi")
            {
                input = "l";
            }
            if (input == "Hóa chất")
            {
                input = "c";
            }
            if (input == "Tanh")
            {
                input = "y";
            }
            if (input == "Hôi")
            {
                input = "f";
            }
            if (input == "Mốc")
            {
                input = "m";
            }
            if (input == "Không")
            {
                input = "n";
            }
            if (input == "Hăng")
            {
                input = "p";
            }
            if (input == "Cay")
            {
                input = "s";
            }
            return input;
        }
        //6
        public string traVeMang(string input)
        {
            if (input == "Gắn kết")
            {
                input = "a";
            }
            if (input == "Giảm dần")
            {
                input = "d";
            }
            if (input == "Tự do")
            {
                input = "f";
            }
            if (input == "Khía")
            {
                input = "n";
            }
            return input;
        }
        //7
        public string traVeKhoangCachMang(string input)
        {
            if (input == "Gần")
            {
                input = "c";
            }
            if (input == "Đông đúc")
            {
                input = "w";
            }
            if (input == "Xa")
            {
                input = "d";
            }
            return input;
        }
        //8
        public string traVeKichThuocMang(string input)
        {
            if (input == "Rộng")
            {
                input = "b";
            }
            if (input == "Hẹp")
            {
                input = "n";
            }
            return input;
        }
        //9
        public string traVeMauMang(string input)
        {
            if (input == "Đen")
            {
                input = "k";
            }
            if (input == "Nâu")
            {
                input = "n";
            }
            if (input == "Da bò")
            {
                input = "b";
            }
            if (input == "SoCoLa")
            {
                input = "h";
            }

            if (input == "Xám")
            {
                input = "g";
            }

            if (input == "Xanh lá")
            {
                input = "r";
            }
            if (input == "Cam")
            {
                input = "o";
            }
            if (input == "Hồng")
            {
                input = "p";
            }
            if (input == "Tím")
            {
                input = "u";
            }
            if (input == "Đỏ")
            {
                input = "e";
            }
            if (input == "Trắng")
            {
                input = "w";
            }
            if (input == "Vàng")
            {
                input = "y";
            }
            return input;
        }
        //10
        public string traVeHinhDangCuon(string input)
        {
            if (input == "To")
            {
                input = "e";
            }
            if (input == "Nhỏ")
            {
                input = "t";
            }
            return input;
        }
        //11
        public string traVeGocCuon(string input)
        {

            if (input == "Củ")
            {
                input = "b";
            }

            if (input == "Chùy")
            {
                input = "c";
            }

            if (input == "Cốc")
            {
                input = "u";
            }

            if (input == "Bằng")
            {
                input = "e";
            }

            if (input == "Thân rễ")
            {
                input = "z";
            }

            if (input == "Gốc")
            {
                input = "r";
            }
            return input;
        }
        //12
        public string traVeCuon(string input)
        {

            if (input == "Sợi")
            {
                input = "f";
            }

            if (input == "Vảy")
            {
                input = "y";
            }

            if (input == "Mượt")
            {
                input = "k";
            }

            if (input == "Mịn")
            {
                input = "s";
            }
            return input;
        }
        //13
        public string traVeMauCuon(string input)
        {
            if (input == "Nâu")
            {
                input = "n";
            }
            if (input == "Da bò")
            {
                input = "b";
            }
            if (input == "Quế")
            {
                input = "c";
            }
            if (input == "Xám")
            {
                input = "g";
            }
            if (input == "Cam")
            {
                input = "o";
            }
            if (input == "Hồng")
            {
                input = "p";
            }
            if (input == "Đỏ")
            {
                input = "e";
            }
            if (input == "Trắng")
            {
                input = "w";
            }
            if (input == "Vàng")
            {
                input = "y";
            }
            return input;
        }
        //14
        public string traVeLoaiManChe(string input)
        {
            if (input == "Một phần")
            {
                input = "p";
            }
            if (input == "Phổ quát")
            {
                input = "u";
            }
            return input;
        }
        //15
        public string traVeMauManChe(string input)
        {
            if (input == "Nâu")
            {
                input = "n";
            }
            if (input == "Cam")
            {
                input = "o";
            }
            if (input == "Trắng")
            {
                input = "w";
            }
            if (input == "Vàng")
            {
                input = "y";
            }

            return input;
        }
        //16
        public string traVeSoVong(string input)
        {
            if (input == "Không")
            {
                input = "n";
            }
            if (input == "Một")
            {
                input = "o";
            }
            if (input == "Hai")
            {
                input = "t";
            }

            return input;
        }
        //17
        public string traVeKieuVong(string input)
        {
            if (input == "Dạng nhện")
            {
                input = "c";
            }
            if (input == "Vi Phân")
            {
                input = "e";
            }
            if (input == "Loe")
            {
                input = "f";
            }
            if (input == "Lớn")
            {
                input = "l";
            }
            if (input == "Không")
            {
                input = "n";
            }
            if (input == "Mặt dây")
            {
                input = "p";
            }
            if (input == "Vỏ bọc")
            {
                input = "s";
            }
            if (input == "Vùng")
            {
                input = "z";
            }
            return input;
        }
        //18
        public string traVeVeBaoTu(string input)
        {
            if (input == "Đen")
            {
                input = "k";
            }
            if (input == "Nâu")
            {
                input = "n";
            }
            if (input == "Da bò")
            {
                input = "b";
            }
            if (input == "SoCoLa")
            {
                input = "h";
            }
            if (input == "Xanh lá cây")
            {
                input = "r";
            }
            if (input == "Cam")
            {
                input = "o";
            }
            if (input == "Tím")
            {
                input = "u";
            }
            if (input == "Trắng")
            {
                input = "w";
            }
            if (input == "Vàng")
            {
                input = "y";
            }
            return input;
        }
        //19
        public string traVeNoiXuatHien(string input)
        {
            if (input == "Phong phú")
            {
                input = "a";
            }
            if (input == "Nhóm")
            {
                input = "c";
            }
            if (input == "Đông đúc")
            {
                input = "n";
            }
            if (input == "Rải rác")
            {
                input = "s";
            }
            if (input == "Riêng lẻ")
            {
                input = "v";
            }
            if (input == "Cô độc")
            {
                input = "y";
            }
            return input;
        }
        //20
        public string traVeMoiTruong(string input)
        {
            if (input == "Cỏ")
            {
                input = "g";
            }
            if (input == "Lá")
            {
                input = "l";
            }
            if (input == "Đồng cỏ")
            {
                input = "m";
            }
            if (input == "Thành thị")
            {
                input = "u";
            }
            if (input == "Rừng")
            {
                input = "d";
            }
            if (input == "Paths")
            {
                input = "p";
            }
            if (input == "Waste")
            {
                input = "w";
            }
            return input;
        }
        //Kiểm tra rỗng
        public bool kTraRong(string input)
        {
            if (input == string.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
