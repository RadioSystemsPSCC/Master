using InvisibleFenceContract.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InvisibleFenceContract.Viewmodels
{
    class Solutions5ViewModel : BindableBase
    {
        private string safetyTotal;
        private string protectionTotal;
        private string freedomTotal;
        private string safetyWiredAddPrice;
        private string safetyWiredAddQuantity;
        private string safetyWiredAddTotal;
        private string gPSAddPrice;
        private string gPSAddQuantity;
        private string gPSAddTotal;
        private string singleTrainPrice;
        private string singleTrainQuantity;
        private string singleTrainTotal;
        private string couponCode;
        private string discount;
        private string solutionsPageTotal;
        private string addAPetTotal;



        public Solutions5ViewModel()
        {

            loadOrder();

        }

        public Order c_Order
        {
            get;
            set;
        }


        public string SafetyTotal
        {
            get
            {
                return this.safetyTotal;
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

        public string ProtectionTotal
        {
            get
            {
                return this.protectionTotal;
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


        public string FreedomTotal
        {
            get
            {
                return this.freedomTotal;
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

        public string SafetyWiredAddPrice
        {
            get
            {
                return "$" + this.safetyWiredAddPrice;
            }
            set
            {
                if (value != this.SafetyWiredAddPrice)


                {
                    this.safetyWiredAddPrice = value;
                    OnPropertyChanged("SafetyWiredAddPrice");
                }
            }
        }


        public string SafetyWiredAddQuantity
        {
            get
            {
                return this.safetyWiredAddQuantity.ToString();
            }
            set
            {
                if (value != this.SafetyWiredAddQuantity)


                {
                    this.safetyWiredAddQuantity = value;
                    OnPropertyChanged("SafetyWiredAddQuantity");
                }
            }
        }

        public string SafetyWiredAddTotal
        {
            get
            {
                return (Convert.ToDouble(this.safetyWiredAddPrice) * Convert.ToInt32(this.safetyWiredAddQuantity)).ToString();
            }
            set
            {
                if (value != this.SafetyWiredAddTotal)


                {
                    this.safetyWiredAddTotal = value;
                    OnPropertyChanged("SafetyWiredAddTotal");
                }
            }
        }


        public string GPSAddPrice
        {
            get
            {
                return "$" + this.gPSAddPrice;
            }
            set
            {
                if (value != this.GPSAddPrice)


                {
                    this.gPSAddPrice = value;
                    OnPropertyChanged("GPSAddPrice");
                }
            }
        }

        public string GPSAddQuantity
        {
            get
            {
                return this.gPSAddQuantity.ToString();
            }
            set
            {
                if (value != this.GPSAddQuantity)


                {
                    this.gPSAddQuantity = value;
                    OnPropertyChanged("GPSAddQuantity");
                }
            }
        }

        public string GPSAddTotal
        {
            get
            {
                return (Convert.ToDouble(this.gPSAddPrice) * Convert.ToInt32(this.gPSAddQuantity)).ToString();
            }
            set
            {
                if (value != this.GPSAddTotal)


                {
                    this.gPSAddTotal = value;
                    OnPropertyChanged("GPSAddTotal");
                }
            }
        }

        public string SingleTrainPrice
        {
            get
            {
                return "$" + this.singleTrainPrice;
            }
            set
            {
                if (value != this.SingleTrainPrice)
                {
                    this.singleTrainPrice = value;
                    OnPropertyChanged("SingleTrainPrice");
                }
            }
        }

        public string SingleTrainQuantity
        {
            get
            {
                return this.singleTrainQuantity;
            }
            set
            {
                if (value != this.SingleTrainQuantity)
                {
                    this.singleTrainQuantity = value;
                    OnPropertyChanged("SingleTrainQuantity");
                }
            }
        }

        public string SingleTrainTotal
        {
            get
            {
                return (Convert.ToDouble(this.singleTrainPrice) * Convert.ToInt32(this.singleTrainQuantity)).ToString();
            }
            set
            {
                if (value != this.SingleTrainTotal)
                {
                    this.singleTrainTotal = value;
                    OnPropertyChanged("SingleTrainTotal");

                }
            }
        }

        public string CouponCode
        {
            get
            {
                return this.couponCode;
            }
            set
            {
                if (value != this.CouponCode)

                {
                    this.couponCode = value;
                    OnPropertyChanged("CouponCode");
                }
            }
        }

        public string Discount
        {
            get
            {
                return "$" + this.discount;
            }
            set
            {
                if (value != this.discount)

                {
                    this.discount = value;
                    OnPropertyChanged("Discount");
                }
            }
        }
        //Does not include discount in total
        public string AddAPetTotal
        {
            get
            {
                return (Convert.ToDouble(safetyWiredAddTotal) + Convert.ToDouble(gPSAddTotal)).ToString();
            }
            set
            {
                if (value != this.AddAPetTotal)

                {
                    this.addAPetTotal = value;
                    OnPropertyChanged("AddAPetTotal");
                }
            }
        }




        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}


