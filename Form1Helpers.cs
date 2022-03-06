using System.Runtime.InteropServices;

namespace Ferreteria_Garabito_Pichardo
{
    internal static class Form1Helpers
    {
        private const string V = "SendMessage";
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = V)]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
    }
}