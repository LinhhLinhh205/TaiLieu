using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class TaiLieu
    {
        private string matailieu;
        private string tennhaxb;
        private int soph;

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Ma:{matailieu},Nha xuat ban:{tennhaxb},So phat hanh:{soph}");
        }
        
        public string Matailieu
        {
            get { return matailieu; }
            set { matailieu = value; }
        }
        public string Tennhaxb
        {
            get { return tennhaxb; }
            set { tennhaxb = value; }
        }
        public int Soph
        {
            get { return soph; }
            set { soph = value; }
        }
    }
    class Sach : TaiLieu
    {
        public string tentg;
        public int sotrang;

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ten:{tentg},So trang:{sotrang}");

        }
        
        public string Tentg
        {
            get { return tentg; }
            set { tentg = value; }
        }
        public int Sotrang
        {
            get { return sotrang; }
            set { sotrang = value; }
        }

    }
    class Bao : TaiLieu
    {
        public int ngayph;

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ngay phat hanh:{ngayph}");
        }
        
        public int Ngayph
        {
            get { return ngayph; }
            set { ngayph = value; }
        }
    }
    class TapChi : TaiLieu
    {
        public int sobph;
        public int thangph;
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"So phat hanh:{sobph},Thang phat hanh:{thangph}");
        }
        public int Sobph
        {
            get { return sobph; }
            set { sobph = value; }
        }
        public int Thangph
        {
            get { return thangph; }
            set { thangph = value; }
        }
    }
    class QLSach
    {
        private TaiLieu[] ds;
        private int n;

        public QLSach()
        {
            ds = new TaiLieu[100];
            n = 0;
        }
        public QLSach(int sophantu)
        {
            ds = new TaiLieu[sophantu];
            n = 0;
        }
        public void ThemTaiLieu(TaiLieu them)
        {
            if (n < ds.Length)
                ds[n++] = them;
            else Console.WriteLine("ds da day");
        }
        public void XoaTailieu(string matailieu)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    ds[j] = ds[j + 1];
                }
                ds[--n] = null;
                Console.WriteLine($"da xoa ai lieu ten {matailieu}");
                return;
            }
        }
        public void HienThiThongTinTaiLieu()
        {
            Console.WriteLine("                   ");
            Console.WriteLine("HIEN THI THONG TIN TAI LIEU");
            for (int i = 0; i < n; i++)
            {
                ds[i].HienThiThongTin();
            }
        }
        public void TimKiemTheoLoai<T>() where T : TaiLieu
        {
            for(int i = 0; i < n; i++)
            {
                if(ds[i] is T)
                {
                    ds[i].HienThiThongTin();
                }
            }
        }




        class Program
        {
            static void Main(string[] args)
            {
                QLSach quanly = new QLSach();
                int chon;
                do
                {
                    Console.WriteLine("QUAN LY SACH");
                    Console.WriteLine("1. Them tai lieu");
                    Console.WriteLine("2. Xoa tai lieu theo ma tai lieu");
                    Console.WriteLine("3. Hien thi thong tin ve tai lieu");
                    Console.WriteLine("4. Tim kiem theo loai");
                    Console.WriteLine("5. Thoat");
                    Console.WriteLine("---------------------------------");
                    Console.Write("Ban chon:");
                    Console.WriteLine("                                  ");
                    chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            ThemMoiTaiLieu(quanly);
                            break;
                        case 2:
                            XoaTaiLieu(quanly);
                            break;
                        case 3:
                            HienThiThongTinTaiLieu(quanly);
                            break;
                        case 4:
                            TimKiemTheoLoai(quanly);
                            break;

                        case 5:
                            Console.WriteLine("Da thoat chuong trinh");
                            break;
                    }
                } while (chon != 0);
            }
            static void QuanLySach(QLSach quanly)
            {
                int chon;
                do
                {
                    Console.WriteLine("QUAN LY SACH");
                    Console.WriteLine("1. Them tai lieu");
                    Console.WriteLine("2. Xoa tai lieu theo ma tai lieu");
                    Console.WriteLine("3. Hien thi thong tin ve tai lieu");
                    Console.WriteLine("4. Tim kiem theo loai");
                    Console.WriteLine("5. Thoat");
                    Console.WriteLine("----------------------------------");
                    Console.Write("Ban chon:");
                    chon = int.Parse(Console.ReadLine());
                    switch (chon)
                    {
                        case 1:
                            ThemMoiTaiLieu(quanly);
                            break;
                        case 2:
                            XoaTaiLieu(quanly);
                            break;
                        case 3:
                            HienThiThongTinTaiLieu(quanly);
                            break;
                        case 4:
                            TimKiemTheoLoai(quanly);
                            break;

                        case 5:
                            Console.WriteLine("Da thoat chuong trinh");
                            break;
                    }
                } while (chon != 0);
            }
            static void ThemMoiTaiLieu(QLSach quanlysach)
            {
                int loai;
                do
                {


                    Console.WriteLine("---THEM MOI TAI LIEU---");
                    Console.WriteLine("Nhap loai tai lieu");
                    Console.WriteLine("1. Sach");
                    Console.WriteLine("2. Tap chi");
                    Console.WriteLine("3. Bao");
                    Console.WriteLine("4. Quay lai");
                    Console.Write("Ban chon loai nao");
                    loai = int.Parse(Console.ReadLine());

                    switch (loai)
                    {
                        case 1:
                            ThemMoiSach(quanlysach);
                            break;
                        case 2:
                            ThemMoiTapChi(quanlysach);
                            break;
                        case 3:
                            ThemMoiBao(quanlysach);
                            break;
                        case 4:
                            QuanLySach(quanlysach);
                            break;
                        
                        default:
                            Console.WriteLine("Lua chon khong phu hop");
                            break;
                    }
                } while (loai != 0);
            }
            static void ThemMoiSach(QLSach quanlysach)
            {


                Console.Write("Nhap ma tai lieu:");
                string matailieu = Console.ReadLine();

                Console.Write("Nhap ten nha xuat ban:");
                string tennhaxuatban = Console.ReadLine();

                Console.Write("Nhap so phat hanh:");
                int sobanphathanh = int.Parse(Console.ReadLine());

                Console.Write("Nhap ten tac gia:");
                string tentg = Console.ReadLine();

                Console.Write("Nhap so trang:");
                int sotrang = int.Parse(Console.ReadLine());
                Sach sach = new Sach();
                sach.Matailieu = matailieu;
                sach.Tennhaxb = tennhaxuatban;
                sach.Soph = sobanphathanh;
                sach.Tentg = tentg;
                sach.Sotrang = sotrang;

                quanlysach.ThemTaiLieu(sach);
                Console.WriteLine("Them sach thanh cong");
            }
            static void ThemMoiTapChi(QLSach quanlysach)
            {
                Console.Write("Nhap ma tai lieu:");
                string matailieu = Console.ReadLine();

                Console.Write("Nhap ten nha xuat ban:");
                string tennhaxuatban = Console.ReadLine();

                Console.Write("Nhap so phat hanh:");
                int sobanphathanh = int.Parse(Console.ReadLine());

                Console.Write("Nhap so phat hanh:");
                int sophathanh = int.Parse(Console.ReadLine());

                Console.Write("Nhap thang phat hanh:");
                int thangphathanh = int.Parse(Console.ReadLine());
                TapChi tapchi = new TapChi();
                tapchi.Matailieu = matailieu;
                tapchi.Tennhaxb = tennhaxuatban;
                tapchi.Soph = sobanphathanh;
                tapchi.Thangph = thangphathanh;

                quanlysach.ThemTaiLieu(tapchi);
                Console.WriteLine("Them tap chi thanh cong");
            }
            static void ThemMoiBao(QLSach quanlysach)
            {
                Console.Write("Nhap ma tai lieu:");
                string matailieu = Console.ReadLine();

                Console.Write("Nhap ten nha xuat ban:");
                string tennhaxuatban = Console.ReadLine();

                Console.Write("Nhap so phat hanh:");
                int sobanphathanh = int.Parse(Console.ReadLine());

                Console.Write("Nhap ngay phat hanh:");
                int ngayphathanh = int.Parse(Console.ReadLine());
                Bao bao = new Bao();

                bao.Matailieu = matailieu;
                bao.Tennhaxb = tennhaxuatban;
                bao.Soph = sobanphathanh;
                bao.Ngayph = ngayphathanh;
                
                quanlysach.ThemTaiLieu(bao);
                Console.WriteLine("Them tap chi thanh cong");
            }
            static void XoaTaiLieu(QLSach quanlysach)
            {
                Console.WriteLine("---XOA TAI LIEU THEO MA TAI LIEU---");
                Console.Write("Nhap tai lieu can xoa:");
                string matailieu = Console.ReadLine();
                quanlysach.XoaTailieu(matailieu);
            }
            static void HienThiThongTinTaiLieu(QLSach quanlysach)
            {
                quanlysach.HienThiThongTinTaiLieu();
            }
            static void TimKiemTheoLoai(QLSach quanlysach)
            {
                int tim;
                Console.WriteLine("***Tim Kiem Theo Loai");
                Console.WriteLine("Nhap tai lieu can tim");
                Console.WriteLine("1. Sach");
                Console.WriteLine("2. Tap chi");
                Console.WriteLine("3. Bao");
                Console.Write("Ban chon loai nao:");
                tim = int.Parse(Console.ReadLine());
                switch (tim)
                {
                    case 1:
                        quanlysach.TimKiemTheoLoai<Sach>();
                        quanlysach.HienThiThongTinTaiLieu();
                        break;
                    case 2:
                        quanlysach.TimKiemTheoLoai<TapChi>();
                        quanlysach.HienThiThongTinTaiLieu();
                        break;
                    case 3:
                        quanlysach.TimKiemTheoLoai<Bao>();
                        quanlysach.HienThiThongTinTaiLieu();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong phu hop");
                        break;
                }
            }
        }
    }
}
