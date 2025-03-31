namespace SmartPhoneOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone() { }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;

        }


        public string? Number { get; set; }
        private string? Model { get; set; }
        private string? IMEI { get; set; }
        private int Memory { get; set; }


        public  void Call()
        {
            Console.WriteLine("Calling...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Receiving Call");
        }


        public abstract void DownloadApp(string app);
        public abstract void DownloadConfirm();
    }
}