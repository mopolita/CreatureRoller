using System.Xml.Linq;

namespace CreatureRoller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    public static class Dice
    {
        public static int Roll(int nb, int faces, int mod = 0)
        {
            Random random = new Random();
            int total = mod;
            for (int i = 0; i < nb; i++)
            {
                total += random.Next(1, faces + 1);
            }
            return total;
        }    
    }
}