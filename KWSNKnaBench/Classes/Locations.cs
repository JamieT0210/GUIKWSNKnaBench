using Microsoft.Win32;
using System;
using System.IO;

namespace KWSNKnaBench.Classes
{
    class Locations
    {
        public static string location(string locType)
        {
            if (string.IsNullOrEmpty(locType))
            {
                throw new ArgumentNullException(locType);
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                key = key.OpenSubKey("Jamie", true);
                key = key.OpenSubKey("KWSNKnaBench", true);
                if (key != null)
                {
                    Object o = key.GetValue(locType);
                    if (o != null)
                    {
                        string tempLoc = (o.ToString());
                        tempLoc = tempLoc.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                        string finalLoc = tempLoc;

                        return Convert.ToString(finalLoc);
                    }
                    else
                    {
                        string finalLoc = null;
                        return Convert.ToString(finalLoc);
                    }
                }
                else
                {
                    string finalLoc = null;
                    return Convert.ToString(finalLoc);
                }
            }
        }
        public static string boinclocation(string locType)
        {
            if (string.IsNullOrEmpty(locType))
            {
                throw new ArgumentNullException(locType);
            }
            else
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("Software", true);
                key = key.OpenSubKey("Space Sciences Laboratory, U.C. Berkeley", true);
                key = key.OpenSubKey("BOINC Setup", true);
                if (key != null)
                {
                    Object o = key.GetValue(locType);
                    if (o != null)
                    {
                        string tempLoc = (o.ToString());
                        string finalLoc = tempLoc;

                        return Convert.ToString(finalLoc);
                    }
                    else
                    {
                        string finalLoc = null;
                        return Convert.ToString(finalLoc);
                    }
                }
                else
                {
                    string finalLoc = null;
                    return Convert.ToString(finalLoc);
                }
            }
        }
    }
}
