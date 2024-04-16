internal class Program
{
    private static void Main(string[] args)
    {
        Add();
    }

    static void Add()
    {
        Console.WriteLine($"Truong cua ban la: {SinhVien.School}");
        SinhVien sv = new SinhVien();
        Console.WriteLine($"Lop cua ban la: {sv.myClass}");
    }
}
class SinhVien
{
    public string myClass = "CNTT";
    public static string School = "fpt";

}