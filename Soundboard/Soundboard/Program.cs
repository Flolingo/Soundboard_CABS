/*----------------------------------------------------------------------
 *						HTBLA-Leonding / Class: 1CHIF
 *-----------------------------------------------------------------------
 *						Florian Leitner   *.6.23
 *-----------------------------------------------------------------------
 * Description: can play sounds by clicking on it
 *-----------------------------------------------------------------------
*/

using System.Text;
using System.Media;
using System.Drawing;
//using System.Runtime.InteropServices;
//using Gma.System.MouseKeyHook;
//using System.Windows.Forms;

namespace Soundboard
{
    internal class Program
    {
        static string[] names = { "Samsung", "Griasti", "Furz", "Computer", "Amogus",
                                  "Alien",  "LaserShot", "Hupe", "Klingel", "Hund",
                                  "Alarm",  "Crash", "Smash", "Lachen", "BöseLache",
                                  "Schrei",  "Trommel", "Glocken", "Emotional", "GStyle",
                                  "Wow",  "Ahh", "Tot", "Geist", "Kind" };
        static string[] icons = { "\U0001f4f1", "\U0001f44b", "\U0001f4a9", "\U0001f9a0", "\U0001f60f",
                                  "\U0001f47d", "\U0001f52b", "\U0001f4ef", " \U0001f6ce", "\U0001f436",
                                  "\U0001f6a8", "\U0001f691", "\U0001f942", "\U0001f602", "\U0001f608",
                                  "\U0001f631", "\U0001f941", "\U0001f514", "\U0001f494", "\U0001f57a",
                                  "\U0001f929", "\U0001fa7b", "\U0001f635", "\U0001f47b", "\U0001f476" };

        static Sounds[] SOUNDS = FillArray();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.Unicode;
            PrintBoard();

            while (true)
            {
                string name = GetSound();

                if (name != "")
                {
                    PrintBoard();
                    SoundPlayer sound = new SoundPlayer(name + ".wav");
                    sound.Play();
                }

                Thread.Sleep(10);
            }
        }
        static Sounds[] FillArray()
        {
            Sounds[] sounds = new Sounds[25];

            for (int i = 0; i < 25; i++)
            {
                sounds[i] = new Sounds();
            }

            return sounds;
        }
        static void PrintBoard()
        {
            Console.Clear();
            PrintHeader();

            Console.WriteLine("\u250C\u2500\u2500\u2500\u252C\u2500\u2500\u2500\u252C\u2500\u2500\u2500\u252C\u2500\u2500\u2500\u252C\u2500\u2500\u2500\u2510");

            int counter = 0;

            for (int i = 0; i < 25; i++)
            {
                Point cords = new Point();

                if (i % 5 == 0 && i != 0)
                {
                    Console.Write("\u2502");
                    Console.WriteLine("\n" + "\u251C\u2500\u2500\u2500\u253C\u2500\u2500\u2500\u253C\u2500\u2500\u2500\u253C\u2500\u2500\u2500\u253C\u2500\u2500\u2500\u2524");
                }

                Console.Write("\u2502");
                //cords = GetPosition();
                //SOUNDS[i].SetMinX(cords.X);

                Console.Write(icons[i] + " ");
            //    cords = GetPosition();
            //    SOUNDS[i].SetMaxX(cords.X);
            }

            Console.Write("\u2502");
            Console.WriteLine("\n" + "\u2514\u2500\u2500\u2500\u2534\u2500\u2500\u2500\u2534\u2500\u2500\u2500\u2534\u2500\u2500\u2500\u2534\u2500\u2500\u2500\u2518");
        }
        static string GetSound()
        {
            int field = 0;
            bool notOK = true;

            while (notOK)
            {
                if (int.TryParse(Console.ReadLine(), out field))
                {
                    if (field >= 1 && field <= 25)
                        notOK = false;
                }
            }
 
           return names[field - 1];
        }
        static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Soundboard (Drücken Sie eine Zahl zwischen 1 und 25)\u2502");
            Console.WriteLine("\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Maus Steuerung
        //static string GetSound()
        //{
        //    int field = GetField();

        //    if (field == -1)
        //        return "";
        //    else
        //        return names[field];
        //}
        //static int GetField()
        //{
        //    int output = 0;

        //    while (true)
        //    {
        //        if (isLeftClick())
        //            if (IsValid(out output))
        //                break;
        //    }

        //    return output;
        //}
        //static bool IsValid(out int output)
        //{
        //    output = -1;
        //    Point pos = GetCursorPosition();

        //    for (int i = 0; i < SOUNDS.Length; i++)
        //    {
        //        if ((pos.X >= SOUNDS[i].GetMinX() && pos.X <= SOUNDS[i].GetMaxX()) &&
        //            (pos.X >= SOUNDS[i].GetMinY() && pos.X <= SOUNDS[i].GetMaxY()))
        //        {
        //            output = i; break;
        //        }
        //    }

        //    return true;
        //}

        //[DllImport("user32.dll")]
        //static extern bool GetCursorPos(out Point lpPoint);
        //static Point GetCursorPosition()
        //{
        //    Point lpPoint;
        //    GetCursorPos(out lpPoint);

        //    return lpPoint;
        //}

        //[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //static extern short GetAsyncKeyState(int keyCode);
        //static bool isLeftClick()
        //{
        //    const int VK_LBUTTON = 0x01;
        //    bool output = false;

        //    while (true)
        //    {
        //        short state = GetAsyncKeyState(VK_LBUTTON);
        //        bool isButtonDown = (state & 0x8000) != 0;

        //        if (isButtonDown)
        //        {
        //            output = true; break;
        //        }

        //        Thread.Sleep(10);
        //    }

        //    return output;

        //}\u2500
    }
}