using System;
using System.Collections.Generic;
using System.Text;

namespace lanscan
{
    class IP
    {
        private byte[] bytes = new byte[4];

        public IP()
        {
            for(int i=0;i<4;i++)
                bytes[i]=0;
        }

        public IP(string s)
        {
            string[] array = s.Split(new char[] { '.' });
            for (int i = 0; i < 4; i++)
                bytes[i] = Byte.Parse(array[i]);
        }

        public static IP operator ++ (IP ip)
        {           
            for (int i = 0; i < 4; i++)
            {
                if (ip.bytes[3 - i] == 255)
                {
                    if (i == 3)
                    {
                        for (int j = 0; j < 4; j++)
                            ip.bytes[j] = 0;
                        break;
                    }
                    continue;
                }
                ip.bytes[3 - i]++;
                break;
            }

            return ip;
        }

        public static bool operator <=(IP ip1, IP ip2)
        {            
            for (int i = 0; i < 4; i++)
            {
                if (ip1.bytes[i] < ip2.bytes[i])
                    return true;
                if (ip1.bytes[i] > ip2.bytes[i])
                    return false;
            }
            return true;
        }

        public static bool operator >=(IP ip1, IP ip2)
        {
            for (int i = 0; i < 4; i++)
            {
                if (ip1.bytes[i] > ip2.bytes[i])
                    return true;
                if (ip1.bytes[i] < ip2.bytes[i])
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                s += bytes[i].ToString();
                if (i == 3)
                    break;
                s += ".";
            }
            return s;
        }
    }
}
