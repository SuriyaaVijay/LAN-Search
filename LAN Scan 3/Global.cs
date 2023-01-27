using System.IO;

namespace lanscan
{
    public static class Functions
    {
        public static void ErrorReport(string s)
        {
            try
            {
                FileStream fs = new FileStream("Error.log", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(s);
                sw.WriteLine("");
                sw.Close();
                fs.Close();
            }
            catch
            {
                return;
            }
        }
    }

    public static class Search
    {
        public static string keyword;
        public static string[] filters;
        public static long minsize=-1;
        public static long maxsize=-1;
    }

    public static class Default
    {
        public static string videoFilter = ".avi .mpg .mpeg .mov .flv .3gp .rm .rmvb .mp4 .0gm .mkv .mov .wmv .vob";
        public static string audioFilter = ".mp3 .wav .ogg .mid .rm .wma m4a";
        public static string imagesFilter = ".jpg .jpeg .bmp .gif .ico .tga .png";
        public static string codeFilter = ".c .cpp .h .java .class .jar .cs .csproj .vbproj";
        public static string softwareFilter = ".exe .msi .rpm .bin .deb .iso .nrg .zip .rar";
        public static string documentsFilter = ".pdf .doc .htm .html .mht .txt .ppt .xl .pps .tex .dvi";

        public static string serverip="Kartikeyan";

        public static int searchDepth=2;

        public static int threads=10;

        public static int pingTimeout=1000;
    }
   
    public static class Settings
    {
        public static string[] ipranges = new string[8] { "", "", "", "", "", "", "", "" };
        public static string[] individualips = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        public static string videoFilter;
        public static string audioFilter;
        public static string imagesFilter;
        public static string codeFilter;
        public static string softwareFilter;
        public static string documentsFilter;

        public static string serverip;

        public static int searchDepth;

        public static int threads;

        public static int pingTimeout;
    }
}