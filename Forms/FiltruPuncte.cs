using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class Filtru
    {

        //public static List<string> query = new List<string>();

        private int camera = 0;
        private int battery = 0;
        private int procesor = 0;
        private int retea = 0;
        private int pretMin = 0;
        private int pretMax = 0;
        private double screen_size = 0;
        private int ram = 0;
        private int storage = 0;
        private int sim = 0;
        public static List<string> test1 = new List<string>();
        public List<string> test2 = new List<string>();
        //and nuclei >= 6 and ram >= 6 and storage_capacity >= 128 and price >=4000 and ca' at line 1'
        //'>= 6 and ram >= 6 and storage_capacity >= 128 and price >=4000 and camera_qualit



        public (List<string>, List<string>) PickPhones()
        {
            List<string> query = new List<string>();
            List<string> query2 = new List<string>();
            if (PanelStateManager.buttonDivertisment)
            {
                procesor = 6;
                ram = 6;
                storage = 128;
                
                query.Add("nuclei >= 6 and ram >= 6 and storage_capacity >= 128");
                query2.Add("nuclei >= 6 and ram >= 4 and storage_capacity >= 128");

            }
            if(PanelStateManager.buttonMedia)
            {
                procesor = Math.Max(procesor, 6);
                ram = Math.Max(ram, 4);
                storage = Math.Max(storage, 64);
                query.Add($"nuclei >= {procesor} and ram >= {ram} and storage_capacity >= {storage}");
                query2.Add($"nuclei >= {procesor} and ram >= {ram} and storage_capacity >= {storage}");
            }
            if(PanelStateManager.buttonFotografie)
            {
                camera = Math.Max(camera, 30);
                storage = Math.Max(storage, 128);

                query.Add($"camera_quality >={camera} and storage_capacity >={storage}");
                query2.Add($"camera_quality >=12 and storage_capacity >={storage}");
            }
            if(PanelStateManager.buttonPremium)
            {
                pretMin = Math.Max(pretMin, 4000);
                query.Add($"price >={pretMin}");
                query2.Add($"price >={pretMin}");

            }
            if (PanelStateManager.buttonMediu)
            {
                pretMin = Math.Max(pretMin, 3000);
                query.Add($"price >={pretMin}");
                query2.Add($"price >={pretMin}");
                // query2.Add($"price >= 3000");
            }
            if (PanelStateManager.buttonEco)
            {
                pretMin = Math.Max(pretMin, 2000);
                query.Add($"price >={pretMin}");
                query2.Add($"price >={pretMin}");
                // query2.Add($"price >= 1800");
            }
            if(PanelStateManager.buttonCamera1)
            {
                camera = Math.Max(camera, 40);
                query.Add($"camera_quality  >= {camera}");
                query2.Add($"camera_quality  >= 12");
                //query2.Add("camera_quality >= 12");
            }
            if (PanelStateManager.buttonCamera2)
            {
                if (camera > 0)
                {
                    camera = Math.Min(camera, 30);
                }
                else
                {
                    camera = Math.Max(camera, 20);
                }
                query.Add($"camera_quality >= {camera}");
                query2.Add($"camera_quality >= 12");
                //query2.Add("camera_quality >= 12");
            }
            if (PanelStateManager.buttonCamera3)
            {
                camera = Math.Min(camera, 20);
                query.Add($"camera_quality >= {camera}");
                query2.Add($"camera_quality >= 12");
                // query2.Add("camera_quality >= 12");
            }
            if(PanelStateManager.buttonSim)
            {
                //sim = Math.Max(sim, 1);
                query.Add($"sim LIKE '%Dual SIM%'");
                query2.Add($"sim LIKE '%Dual SIM%'");
            }
            if(PanelStateManager.buttonRetea)
            {
                retea = Math.Max(retea, 5);
                query.Add($"retea >= {retea}");
                query2.Add($"retea >= {retea}");
            }
            if(PanelStateManager.buttonBattery)
            {
                battery = Math.Max(battery, 3700);
                query.Add($"battery_capacity >= {battery}");
                query2.Add($"battery_capacity >= 3100");
                //query2.Add("battery_capacity >= 3100");
            }


            return (query,query2);
        }
        

    }


   

}
