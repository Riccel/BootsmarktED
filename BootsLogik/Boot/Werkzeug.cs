namespace BootsLogik.Boot
{
    public class Werkzeug
    {
        public static int CreateID()
        {
            
            System.Guid ID = System.Guid.NewGuid();
            string strgUID = ID.ToString();
            byte[] bUID = ID.ToByteArray();

            
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


    }

    }

