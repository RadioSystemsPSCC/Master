using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleFenceContract.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows;
using System.Data;
using InvisibleFenceContract.Services;

namespace InvisibleFenceContract.Viewmodels
{
    public class Safety2ViewModel : BindableBase
    {
        private string gPSPrice;
        private string boundaryPlusPrice;
        private string digitalTechnologyPrice;
        private string packageSelection;
        private string packagePrice;
        private string safetyTotal;

        public Safety2ViewModel()
        {
            loadOrder();
        }


        Order c_Order = new Order();

        /*public Order c_Order
        {
            get;
            set;
        }*/



        public string GPSPrice
        {

            get
            {
                return "$" + this.gPSPrice;
               
            }
            set
            {
                if (value != this.GPSPrice)

                {
                    this.gPSPrice = value;
                    OnPropertyChanged("GPSPrice");
                }
            }
        }

        public string BoundaryPlusPrice
        {
            get
            {


                return "$" + this.boundaryPlusPrice;
               
            }


            set
            {
                if (value != this.BoundaryPlusPrice)
                {
                    boundaryPlusPrice = value;
                    OnPropertyChanged("boundaryPlus");
                }
            }
        }

        public string DigitalTechnologyPrice
        {
            get
            {
               
                return "$" + digitalTechnologyPrice;
            }



            set
            {
                if (value != this.PackageSelection)
                {
                    digitalTechnologyPrice = value;
                    OnPropertyChanged("DigitalTechnologyPrice");
                }
            }
        }

        public string PackageSelection
        {
            get
            {
                return this.packageSelection;
            }
            set
            {
                if (value != this.PackageSelection)
                {
                    this.packageSelection = value;
                    OnPropertyChanged("PackageSelection");
                }
            }
        }

        public string PackagePrice
        {
            get
            {
                return "$" + this.packagePrice;
            }
            set
            {
                if (value != this.PackagePrice)
                {
                    this.packagePrice = value;
                    OnPropertyChanged("PackagePrice");
                }
            }
        }

        public string SafetyTotal
        {
            get
            {
                return "$" + packagePrice;
            }
            set
            {
                if (value != this.SafetyTotal)
                {
                    this.safetyTotal = value;
                    OnPropertyChanged("SafetyTotal");
                }
            }
        }

        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }


    }
}
