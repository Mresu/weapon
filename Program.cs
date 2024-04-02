


using ConsoleApp10;

Weopan weopan = new Weopan(15, 10, false);

while (true)
{
    Console.WriteLine("Seçiminiz (0 - İnformasiya, 1 - Ateş et, 2 - Qalan gülələrin sayı, 3 - Darağı yenidən doldur, 4 - Atış modunu dəyiş, 5 - Çıxış): ");
    string action = Console.ReadLine();

    switch (action)
    {
        case "0":
            Console.WriteLine("C- Atış modunu dəyişir.");
            break;
        case "1":
            weopan.Shoot();
            break;
        case "2":
            Console.WriteLine("Qalan gülələrin sayı: " + weopan.GetRemainBulletCount());
            break;
        case "3":
            weopan.Reload();
            break;
        case "4":
            weopan.ChangeFireMode();
            break;
        case "5":
            Console.WriteLine("Proqram dayandırılır.");
            return;
        default:
            Console.WriteLine("Düzgün seçim edin.");
            break;
    }
}
