using System;
using System.Windows.Forms;

namespace KWSNKnaBench.Classes
{
    class createFiles
    {
        public static bool createCMDFiles(string fileType)
        {
            if (string.IsNullOrEmpty(fileType))
            {
                throw new ArgumentNullException(fileType);
            }
            else
            {
                string benchLoc = KWSNKnaBench.Classes.Locations.location("Path");
                string boincInstall = KWSNKnaBench.Classes.Locations.boinclocation("INSTALLDIR");
                string boincData = KWSNKnaBench.Classes.Locations.boinclocation("DATADIR");
                if (fileType == "SuspendCPU")
                {
                    try
                    {
                        System.IO.File.Delete(benchLoc + @"\Knabench\Suspend.cmd");
                        System.IO.File.Delete(benchLoc + @"\Knabench\Resume.cmd");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_run_mode never 172800");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Resume.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_run_mode never 1");

                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else if (fileType == "SuspendGPU")
                {
                    try
                    {
                        System.IO.File.Delete(benchLoc + @"\Knabench\Suspend.cmd");
                        System.IO.File.Delete(benchLoc + @"\Knabench\Resume2.cmd");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_gpu_mode never 172800");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Resume2.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_gpu_mode never 1");

                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else if (fileType == "SuspendAll")
                {
                    try
                    {
                        System.IO.File.Delete(benchLoc + @"\Knabench\Suspend.cmd");
                        System.IO.File.Delete(benchLoc + @"\Knabench\Suspend2.cmd");
                        System.IO.File.Delete(benchLoc + @"\Knabench\Resume2.cmd");
                        System.IO.File.Delete(benchLoc + @"\Knabench\Resume.cmd");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_gpu_mode never 172800");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Suspend2.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_run_mode never 172800");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Resume2.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_gpu_mode never 1");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\Resume.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --set_run_mode never 1");

                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else if (fileType == "prefsOverride")
                {
                    try
                    {
                        System.IO.File.Delete(benchLoc + @"\Knabench\prefsOverride.cmd");
                        System.IO.File.WriteAllText(benchLoc + @"\Knabench\prefsOverride.cmd", @"""" + boincInstall + "boinccmd" + @"""" + " --read_global_prefs_override");

                        return true;
                    }
                    catch (Exception)
                    {
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
