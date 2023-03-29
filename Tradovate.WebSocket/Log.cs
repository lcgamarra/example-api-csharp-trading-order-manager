using System;
using System.Diagnostics;
using System.Net.Mime;
using System.Windows;

namespace Tradovate
{
    public static class Log
    {
        static bool Enabled = true;
        static private Stopwatch stopwatch = new Stopwatch();
        public static Action<object> LogAction { get; set; }
        static public void Write(object message)
        {
            LogAction(message);
        }
    }
}