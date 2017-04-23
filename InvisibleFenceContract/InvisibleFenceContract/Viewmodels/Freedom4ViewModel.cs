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

namespace InvisibleFenceContract.Viewmodels
{
    class Freedom4ViewModel : BindableBase
    {

        private string doormanPetDoorPrice;
        private string doormanPetDoorQuantity;
        private string doormanPetDoorTotal;
        private string shieldsCollarPrice;
        private string shieldsCollarQuantity2;
        private string shieldsCollarTotal;
        private string freedomTotal;

        public Freedom4ViewModel()
        {
            loadOrder();
        }

        public Order c_Order
        {
            get;
            set;
        }


        public string DoormanPetDoorPrice
        {
            get
            {
                return "$" + this.doormanPetDoorPrice;
            }
            set
            {
                if (value != this.DoormanPetDoorPrice)

                {
                    this.doormanPetDoorPrice = value;
                    OnPropertyChanged("DoormanPetDoorPrice");
                }
            }
        }


        public string DoormanPetDoorQuantity
        {
            get
            {
                return this.doormanPetDoorQuantity.ToString();
            }
            set
            {
                if (value != this.DoormanPetDoorQuantity)

                {
                    this.doormanPetDoorQuantity = value;
                    OnPropertyChanged("DoormanPetDoorQuantity");
                }
            }
        }

        public string DoormanPetDoorTotal
        {
            get
            {
                return (Convert.ToDouble(this.doormanPetDoorPrice) * Convert.ToInt32(this.doormanPetDoorQuantity)).ToString();
            }
            set
            {
                if (value != this.DoormanPetDoorTotal)

                {
                    this.doormanPetDoorTotal = value;
                    OnPropertyChanged("DoormanPetDoorTotal");
                }
            }
        }


        public string ShieldsCollarPrice
        {
            get
            {
                return "$" + this.shieldsCollarPrice;
            }
            set
            {
                if (value != this.ShieldsCollarPrice)

                {
                    this.shieldsCollarPrice = value;
                    OnPropertyChanged("ShieldsCollarPrice");
                }
            }
        }

        public string ShieldsCollarQuantity2
        {
            get
            {
                return this.shieldsCollarQuantity2;
            }
            set
            {
                if (value != this.ShieldsCollarQuantity2)

                {
                    this.shieldsCollarQuantity2 = value;
                    OnPropertyChanged("ShieldsCollarQuantity2");
                }
            }
        }

        public string ShieldsCollarTotal
        {
            get
            {
                return (Convert.ToDouble(this.shieldsCollarTotal) + (Convert.ToDouble(this.shieldsCollarPrice) * Convert.ToInt32(this.shieldsCollarQuantity2))).ToString();
            }
            set
            {
                if (value != this.ShieldsCollarTotal)
                {
                    this.shieldsCollarTotal = value;
                    OnPropertyChanged("ShieldsCollarTotal");
                }
            }
        }

        public string FreedomTotal
        {
            get
            {
                return (Convert.ToDouble(this.doormanPetDoorTotal) + (Convert.ToDouble(this.shieldsCollarTotal))).ToString();
            }
            set
            {
                if (value != this.FreedomTotal)
                {
                    this.freedomTotal = value;
                    OnPropertyChanged("FreedomTotal");
                }
            }
        }

        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}
