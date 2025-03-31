using SmartPhoneOO.Models;


while (true)
{

    Console.Clear();
    Console.WriteLine("------------------------------------");
    Console.WriteLine("Choose your smartphone model: ");
    Console.WriteLine("1 - Iphone \n2 - Sansung \n3 - Motorola \n4 - Xiami");
    Console.WriteLine("------------------------------------");
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (choice)
    {
        case 1:
            {
                Smartphone tellIphone = new Iphone("44268636", "Apple iPhone 16 Pro Max", "44261111", 256);
                tellIphone.DownloadConfirm();

                Console.WriteLine("------------------------------------");
                tellIphone.Call();
                tellIphone.ReceiveCall();
                tellIphone.DownloadApp("Whatsapp");
                Console.ReadKey();
            }
            break;
        case 2:
            {
                Smartphone tellSung = new Sansung("17639922", "Galaxy S24 FE 5G", "17632222", 256);
                tellSung.DownloadConfirm();

                Console.WriteLine("------------------------------------");
                tellSung.Call();
                tellSung.ReceiveCall();
                tellSung.DownloadApp("Notion");
                Console.ReadKey();
            }
            break;
        case 3:
            {
                Smartphone tellMoto = new Motorola("77462992", "Motorola Moto g35 5G", "77463333", 256);
                tellMoto.DownloadConfirm();

                Console.WriteLine("------------------------------------");
                tellMoto.Call();
                tellMoto.ReceiveCall();
                tellMoto.DownloadApp("Orkut");
                Console.ReadKey();
            }
            break;
        case 4:
            {
                Smartphone tellXiomi = new Xiaomi("55624990", "Xiaomi POCO X6 Pro 5G", "55624444", 512);
                tellXiomi.DownloadConfirm();

                Console.WriteLine("------------------------------------");
                tellXiomi.Call();
                tellXiomi.ReceiveCall();
                tellXiomi.DownloadApp("Aliexpress");
                Console.ReadKey();
            }
            break;
        default:
            {
                Console.WriteLine("You selected the wrong model, press any key to return to your choice:");
                Console.ReadKey();
            }
            break;
    }

}



