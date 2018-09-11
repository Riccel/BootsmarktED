﻿namespace BootsLogik.Boot
{
    public class Werkzeug
    {
        public static int CreateID()
        {
            // 16 Byte Schlüssel
            System.Guid ID = System.Guid.NewGuid();
            string strgUID = ID.ToString();
            byte[] bUID = ID.ToByteArray();

            // die ersten 8 Bytes werden verwendet
            int lUID = 0;
            lUID = lUID | (int)bUID[0];
            int shift = 8;
            for (int i = 1; i < 8; i++)
            {
                lUID = lUID | (int)bUID[i] << shift;
                shift = shift + 8;
            }

            return lUID;
        } 


        public static double ParseDouble(string s, double defaultValue)
        {
            double value;
            s = s.Replace(".", "");
            if (!double.TryParse(s, out value))
            {
                value = defaultValue;
            }
            return value;
        }

        public static int ParseInt(string s, int defaultValue)
        {
            int value;
            s = s.Replace(".", "");
            if (!int.TryParse(s, out value))
            {
                value = defaultValue;
            }
            return value;
        }

        
        // Liegeplatz darf nicht Null oder leer sein
        public static string LiegeplatzTest(string s)
        {

            if (string.IsNullOrWhiteSpace(s))
            {
                throw new System.Exception("(\"{0}\") ist entweder Null oder leer!");
                //return "is null or empty";
            }
            else
                return string.Format("(\"{0}\") ist entweder Null oder leer!", s);
        }



    }

    }

