using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Weopan
    {
        private bool fireMode;

        public byte CapacityBullet { get; set; }
        public byte CurrentBullet { get; set; }
        public bool FireMode { get; set; }
        public Weopan(byte capacityBullet, byte currentBullet, bool fireMode)
        {
            this.CapacityBullet = capacityBullet;
            this.CurrentBullet = currentBullet;
            this.FireMode = fireMode;
        }
        public void Shoot()
        {

            if (FireMode = true)
            {
                Console.WriteLine("avtomatik");
            }
            else
            {
                Console.WriteLine("tekli");
            }


        }
        public int GetRemainBulletCount()
        {
           return CapacityBullet - CurrentBullet;
            Console.WriteLine(11);

        }
        public void Reload()
        {
            CurrentBullet = CapacityBullet;
            Console.WriteLine("daragi doldur");
        }
        public void ChangeFireMode()
        {
            fireMode = !fireMode;
            if (fireMode)
            {
                Console.WriteLine("Atış modu: Avtomatik");
            }
            else
            {
                Console.WriteLine("Atış modu: Təkli");
            }
        }
    }
}
