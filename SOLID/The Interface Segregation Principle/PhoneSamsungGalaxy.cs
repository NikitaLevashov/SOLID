using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.The_Interface_Segregation_Principle
{
    class PhoneSamsungGalaxy : ICall, IPhotoVideo, IInternet, IMessage       
    {
        public void Call()
        {
            
        }

        public void Internet()
        {
           
        }

        public void MakeMessage()
        {
            
        }

        public void MakePhotoVideo()
        {
           
        }
    }
}
