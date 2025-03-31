namespace SmartPhoneOO.Models
{
    public class Sansung : Smartphone
    {
        public Sansung(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        private string? Model { get; set; }
        private string? IMEI { get; set; }
        private int Memory { get; set; }


        public override void DownloadApp(string app)
        {
            Console.WriteLine($"Downloading app {app}");
        }

        public override void DownloadConfirm()
        {

            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memory: {Memory}");

        }

    }
}