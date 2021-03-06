﻿using CNBlackListSoamChecker.DbManager;
using System.Collections.Generic;

namespace CNBlackListSoamChecker
{
    internal static class Temp
    {
        internal static bool DisableAdminTools = true; // If you need use /ban , please change it to false.
        internal static bool DisableBanList = true; // If you need ban user, plese change it to true.
        private static DatabaseManager databaseManager = null;
        internal static List<SpamMessage> spamMessageList = null;
        internal static Dictionary<long, GroupCfg> groupConfig = new Dictionary<long, GroupCfg>() { };
        internal static Dictionary<int, BanUser> bannedUsers = new Dictionary<int, BanUser>() { };
        public static long AdminGroupID = 0; // If haven't, change it to 0
        public static long MainChannelID = 0; // If haven't, change it to 0
        public static long ReasonChannelID = 0; // If haven't, change it to 0
        public static string MainChannelName = null; // If haven't, change it to null
        public static string ReasonChannelName = null; // If haven't, change it to null

        internal static DatabaseManager GetDatabaseManager()
        {
            if (databaseManager == null)
            {
                databaseManager = new DatabaseManager();
            }
            return databaseManager;
        }
    }
}
