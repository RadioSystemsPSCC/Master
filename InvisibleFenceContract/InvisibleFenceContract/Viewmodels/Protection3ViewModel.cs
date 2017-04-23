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
    class Protection3ViewModel : BindableBase
    {
        private string outdoorShieldPrice1;
        private string outdoorShieldPrice2;
        private string outdoorShieldQuantity;
        private string outdoorShieldTotal;
        private string indoorShieldPrice1;
        private string indoorShieldPrice2;
        private string indoorShieldQuantity;
        private string indoorShieldTotal;
        private string microShieldPrice1;
        private string microShieldPrice2;
        private string microShieldQuantity;
        private string microShieldTotal;
        private string shieldsCollarPrice;
        private string shieldsCollarQuantity;
        private string shieldsCollarTotal;
        private string microLitePrice;
        private string microLiteQuantity;
        private string microLiteTotal;
        private string protectionTotal;



        public Protection3ViewModel()
        {
            loadOrder();

        }



        public Order c_Order
        {
            get;
            set;
        }



        public string OutdoorShieldPrice1
        {
            get
            {
                return "$" + this.outdoorShieldPrice1;
            }
            set
            {
                if (value != this.OutdoorShieldPrice1)

                {
                    this.outdoorShieldPrice1 = value;
                    OnPropertyChanged("OutdoorShieldPrice1");
                }
            }
        }

        public string OutdoorShieldPrice2
        {
            get
            {
                return "$" + this.outdoorShieldPrice2;
            }
            set
            {
                if (value != this.OutdoorShieldPrice2)
                {
                    this.outdoorShieldPrice2 = value;
                    OnPropertyChanged("OutdoorShieldPrice2");
                }
            }
        }

        public string OutdoorShieldQuantity
        {
            get
            {
                return this.outdoorShieldQuantity.ToString();
            }
            set
            {
                if (value != this.OutdoorShieldQuantity)


                {
                    this.outdoorShieldQuantity = value;
                    OnPropertyChanged("OutdoorShieldQuantity");
                }
            }
        }



        public string OutdoorShieldTotal
        {
            get
            {
                return "$" + (((Convert.ToInt32(outdoorShieldQuantity) / 2) * Convert.ToDouble(outdoorShieldPrice2)) + ((Convert.ToInt32(outdoorShieldQuantity) % 2) * Convert.ToDouble(outdoorShieldPrice1))).ToString();
            }
            set
            {
                if (value != this.OutdoorShieldTotal)


                {
                    this.outdoorShieldTotal = value;
                    OnPropertyChanged("OutdoorShieldTotal");
                }
            }
        }

        public string IndoorShieldPrice1
        {
            get
            {
                return "$" + this.indoorShieldPrice1;
            }
            set
            {
                if (value != this.IndoorShieldPrice1)


                {
                    this.indoorShieldPrice1 = value;
                    OnPropertyChanged("IndoorShieldPrice1");
                }
            }
        }


        public string IndoorShieldPrice2
        {
            get
            {
                return "$" + this.indoorShieldPrice2;
            }
            set
            {
                if (value != this.IndoorShieldPrice2)


                {
                    this.indoorShieldPrice2 = value;
                    OnPropertyChanged("IndoorShieldPrice2");
                }
            }
        }

        public string IndoorShieldQuantity
        {
            get
            {
                return this.indoorShieldQuantity.ToString();
            }
            set
            {
                if (value != this.IndoorShieldQuantity)


                {
                    this.indoorShieldQuantity = value;
                    OnPropertyChanged("IndoorShieldQuantity");
                }
            }
        }

        public string IndoorShieldTotal
        {
            get
            {
                return "$" + (((Convert.ToInt32(indoorShieldQuantity) / 2) * Convert.ToDouble(indoorShieldPrice2)) + ((Convert.ToInt32(indoorShieldQuantity) % 2) * Convert.ToDouble(indoorShieldPrice1))).ToString();
            }
            set
            {
                if (value != this.IndoorShieldTotal)


                {
                    this.indoorShieldTotal = value;
                    OnPropertyChanged("IndoorShieldTotal");
                }
            }
        }

        public string MicroShieldPrice1
        {
            get
            {
                return "$" + this.microShieldPrice1;
            }
            set
            {
                if (value != this.MicroShieldPrice1)


                {
                    this.microShieldPrice1 = value;
                    OnPropertyChanged("MicroShieldPrice1");
                }
            }
        }


        public string MicroShieldPrice2
        {
            get
            {
                return "$" + this.microShieldPrice2;
            }
            set
            {
                if (value != this.MicroShieldPrice2)


                {
                    this.microShieldPrice2 = value;
                    OnPropertyChanged("MicroShieldPrice2");
                }
            }
        }

        public string MicroShieldQuantity
        {
            get
            {
                return this.microShieldQuantity.ToString();
            }
            set
            {
                if (value != this.MicroShieldQuantity)


                {
                    this.microShieldQuantity = value;
                    OnPropertyChanged("MicroShieldQuantity");
                }
            }
        }

        public string MicroShieldTotal
        {
            get
            {
                return "$" + (((Convert.ToInt32(microShieldQuantity) / 2) * Convert.ToDouble(microShieldPrice2)) + ((Convert.ToInt32(microShieldQuantity) % 2) * Convert.ToDouble(microShieldPrice1))).ToString();
            }
            set
            {
                if (value != this.MicroShieldTotal)


                {
                    this.microShieldTotal = value;
                    OnPropertyChanged("MicroShieldTotal");
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

        public string ShieldsCollarQuantity
        {
            get
            {
                return this.shieldsCollarQuantity.ToString();
            }
            set
            {
                if (value != this.ShieldsCollarQuantity)


                {
                    this.shieldsCollarQuantity = value;
                    OnPropertyChanged("ShieldsCollarQuantity");
                }
            }
        }

        public string ShieldsCollarTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(shieldsCollarPrice) * Convert.ToInt32(shieldsCollarQuantity));
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


        public string MicroLitePrice
        {
            get
            {
                return "$" + this.microLitePrice;
            }
            set
            {
                if (value != this.MicroLitePrice)


                {
                    this.microLitePrice = value;
                    OnPropertyChanged("MicroLitePrice");
                }
            }
        }

        public string MicroLiteQuantity
        {
            get
            {
                return this.microLiteQuantity;
            }
            set
            {
                if (value != this.MicroLiteQuantity)

                {
                    this.microLiteQuantity = value;
                    OnPropertyChanged("MicroLiteQuantity");
                }
            }
        }

        public string MicroLiteTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(microLitePrice) * Convert.ToInt32(microLiteQuantity));
            }
            set
            {
                if (value != this.MicroLiteTotal)


                {
                    this.microLiteTotal = value;
                    OnPropertyChanged("MicroLiteTotal");
                }
            }
        }

        public string ProtectionTotal
        {
            get
            {
                return (Convert.ToDouble(outdoorShieldTotal) + Convert.ToDouble(indoorShieldTotal) + Convert.ToDouble(microShieldTotal) + Convert.ToDouble(shieldsCollarTotal) + Convert.ToDouble(microLiteTotal)).ToString();
            }
            set
            {
                if (value != this.ProtectionTotal)
                {
                    this.protectionTotal = value;
                    OnPropertyChanged("ProtectionTotal");
                }
            }
        }

        public void loadOrder()
        {
            c_Order = Utility.Order;
        }



    }
}
