using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap ma nhan vien");
        string manhanvien=Console.ReadLine();
        Console.WriteLine("Nhap ho ten");
        string hoten=Console.ReadLine();
        Console.WriteLine("Nhap tuoi");
        int tuoi=int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap gioi tinh");
        string gioitinh = Console.ReadLine();
        Console.WriteLine("Nhap chieu cao");
        double chieucao = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap can nang");
        float cannang = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so ngay cong");
        int songaycong = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap luong 1 ngay");
        double luong1ngay = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so nam kinh nghiem");
        int sonamkinhnghiem = int.Parse(Console.ReadLine());
        Console.WriteLine("Dang lam viec");
        bool danglamviec = bool.Parse(Console.ReadLine());
        Console.WriteLine("Nhap xep loai");
        char xeploai = char.Parse(Console.ReadLine());
        decimal tongluong = (decimal)(songaycong * luong1ngay);
        Console.WriteLine("=========== HỒ SƠ NHÂN VIÊN ==========="
            + "\n" + "Mã nhân viên: " + manhanvien +
            "\n" + "Họ tên: " + hoten + "\n" + "Tuoi: " + tuoi +
            "\n" + "Giới tính: " + gioitinh +
            "\n" + "Chiều cao: " + chieucao +" m"+
            "\n" + "Cân nặng: " + cannang +" kg"+
            "\n" + "Tổng lương: " + tongluong +" VND"+
            "\n" + "Số ngày công: " + songaycong +
            "\n" + "Lương 1 ngày: " + luong1ngay +
            "\n" + "Kinh nghiệm: " + sonamkinhnghiem +" nam"+
            "\n" + "Đang làm việc: " + danglamviec +
            "\n" + "Xếp loại: " + xeploai);
    }
}