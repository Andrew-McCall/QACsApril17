using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProject.DUKW
{
    public class AmphibiousVehicle : ILandVehicle, IWaterVehicle, IAirVehicle
    {

        public string Brake() // Use this one AmphibiousVehicle and ILandVehicle
        {
            return "Screech!";
        }

        string IWaterVehicle.Brake() // Cast to IWaterVehicle, then it will use this
        {
            return "Splash!";
        }

        string IAirVehicle.Brake() // Use this one AmphibiousVehicle and ILandVehicle
        {
            return "Woosh!";
        }

    }
}
