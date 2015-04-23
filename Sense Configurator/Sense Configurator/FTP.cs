using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sense_Configurator
{
    class FTP
    {
        public static void DownloadFile(string FTPAddress, string Dir, string UN, string PW, string Filename)
        {
            Chilkat.Ftp2 ftp = new Chilkat.Ftp2();

            bool success;

            //  Any string unlocks the component for the 1st 30-days.
            success = ftp.UnlockComponent("RCKVGHFTP_hK0TOpsv6An5");
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            ftp.Hostname = FTPAddress;
            ftp.Username = UN;
            ftp.Password = PW;
            ftp.Passive = false;
            //  The default data transfer mode is "Active" as opposed to "Passive".

            //  Connect and login to the FTP server.
            success = ftp.Connect();
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            //  Change to the remote directory where the file is located.
            //  This step is only necessary if the file is not in the root directory
            //  for the FTP account.
            success = ftp.ChangeRemoteDir(Dir);
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            //  Download a file.
            string localFilename = Filename;
            string remoteFilename = Filename;

            success = ftp.GetFile(remoteFilename, localFilename);
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            ftp.Disconnect();

            Console.WriteLine("File Downloaded!");
        }


        public static void DownloadDirectory(string FTPAddress, string Dir, string UN, string PW)
        {
            Chilkat.Ftp2 ftp = new Chilkat.Ftp2();

            bool success;

            //  Any string unlocks the component for the 1st 30-days.
            success = ftp.UnlockComponent("RCKVGHFTP_hK0TOpsv6An5");
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            ftp.Hostname = FTPAddress;
            ftp.Username = UN;
            ftp.Password = PW;
            ftp.Passive = false;
            ftp.KeepSessionLog = true;

            //  Connect and login to the FTP server.
            success = ftp.Connect();
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            //  Set the current remote directory to the root of
            //  the tree to be downloaded.
            success = ftp.ChangeRemoteDir("/" + Dir);
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            //  Recursively download all non-existant and newer files.
            int mode = 2;
            string localDir = Path.GetDirectoryName(Application.ExecutablePath);
            success = ftp.SyncLocalTree(localDir + "/" + GV.UpdateAvailable, mode);
            if (success != true)
            {
                Console.WriteLine(ftp.LastErrorText);
                return;
            }

            ftp.Disconnect();

            //  Display the session log.
            Console.WriteLine(ftp.SessionLog);
        }
    }
}
