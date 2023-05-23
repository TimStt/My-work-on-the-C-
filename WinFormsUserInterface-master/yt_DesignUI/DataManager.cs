using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yt_DesignUI
{
    public static class DataManager
    {
        public static bool DataChanged { get; set; }

        public static void SetDataChanged()
        {
            DataChanged = true;
        }

        public static void ResetDataChanged()
        {
            DataChanged = false;
        }
    }
}
