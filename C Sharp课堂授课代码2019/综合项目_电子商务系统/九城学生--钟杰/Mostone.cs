using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;

namespace mostone
{
    public class Mostone
    {
        public static User user = null;
        public static Dictionary<int, Goods> trolley = null;

        public static void Main(string[] args)
        {
            MController.Init();

            MViewer.MainView();

            MController.Stop();
        }
    }
}
