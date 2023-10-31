using Project.Storage;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Hotels nevskyy = new Hotels("Невский 44", 1, 
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7394616/ra_nevsky_44_/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2");
            Hotels tambovskay = new Hotels("Тамбовская 11", 2, 
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7394597/otel_ra_tambovskaia_11/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2");
            Hotels rybinskay = new Hotels("Рыбинская 7", 3, 
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid6813550/ra_na_ryibinskoj_7/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2");
            CompSet mHotel = new CompSet("М-Отель", 1, 
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7842297/motel/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2");
            CompSet esplanada = new CompSet("Еспланада", 2 , 
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7935103/hotel_esplanada/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2");
            CompSet bristol = new CompSet("Бристоль", 3, 
                "https://ostrovok.ru/hotel/russia/st._petersburg/mid7747316/bristol_hotel_2/?q=2042&dates=01.12.2023-31.12.2023&guests=2&sid=236da8e1-1636-4b69-a1df-9450c9e4e6c2");

            

           ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}