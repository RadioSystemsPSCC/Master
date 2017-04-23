using InvisibleFenceContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Viewmodels
{
    class Installation6ViewModel : BindableBase
    {
        private string outdoorInstallCost;
        private string outdoorXLoopPrice;
        private string outdoorXLoopQuantity;
        private string outdoorXLoopTotal;
        private string indoorXLoopPrice;
        private string indoorXLoopQuantity;
        private string indoorXLoopTotal;
        private string petDoorInstallPrice;
        private string petDoorInstallQuantity;
        private string petDoorInstallTotal;
        private string discount;
        private string singleTrainTotal;
        private string safetyTotal;
        private string protectionTotal;
        private string freedomTotal;
        private string addAPetTotal;
        private string solutionTotal;
        private string taxRate;
        private string tax;
        private string installTotal;
        private string total;
        private string deposit;
        private string balance;

        public Installation6ViewModel()
        {
            loadOrder();
        }

        public Order c_Order
        {
            get;
            set;
        }

        public string OutdoorInstallCost
        {
            get
            {
                return "$" + this.outdoorInstallCost;
            }
            set
            {
                if (value != this.OutdoorInstallCost)

                {
                    this.outdoorInstallCost = value;
                    OnPropertyChanged("OutdoorInstallCost");
                }
            }
        }

        public string OutdoorXLoopPrice
        {
            get
            {
                return "$" + this.outdoorXLoopPrice;
            }
            set
            {
                if (value != this.OutdoorXLoopPrice)

                {
                    this.outdoorXLoopPrice = value;
                    OnPropertyChanged("OutdoorXLoopPrice");
                }
            }
        }

        public string OutdoorXLoopQuantity
        {
            get
            {
                return this.outdoorXLoopQuantity.ToString();
            }
            set
            {
                if (value != this.OutdoorXLoopQuantity)

                {
                    this.outdoorXLoopQuantity = value;
                    OnPropertyChanged("OutdoorXLoopQuantity");
                }
            }
        }

        public string OutdoorXLoopTotal
        {
            get
            {
                return (Convert.ToDouble(this.outdoorXLoopPrice) * Convert.ToInt32(this.outdoorXLoopQuantity)).ToString();

            }
            set
            {
                if (value != this.OutdoorXLoopTotal)

                {
                    this.outdoorXLoopTotal = value;
                    OnPropertyChanged("OutdoorXLoopTotal");
                }
            }
        }

        public string IndoorXLoopPrice
        {
            get
            {
                return "$" + this.indoorXLoopPrice;
            }
            set
            {
                if (value != this.IndoorXLoopPrice)

                {
                    this.indoorXLoopPrice = value;
                    OnPropertyChanged("IndoorXLoopPrice");
                }
            }
        }

        public string IndoorXLoopQuantity
        {
            get
            {
                return this.indoorXLoopQuantity;
            }
            set
            {
                if (value != this.IndoorXLoopQuantity)

                {
                    this.indoorXLoopQuantity = value;
                    OnPropertyChanged("IndoorXLoopQuantity");
                }
            }
        }


        public string IndoorXLoopTotal
        {
            get
            {
                return (Convert.ToDouble(this.indoorXLoopPrice) * Convert.ToInt32(this.indoorXLoopQuantity)).ToString();
            }
            set
            {
                if (value != this.IndoorXLoopTotal)

                {
                    this.indoorXLoopTotal = value;
                    OnPropertyChanged("IndoorXLoopTotal");
                }
            }
        }

        public string PetDoorInstallPrice
        {
            get
            {
                return "$" + this.petDoorInstallPrice;
            }
            set
            {
                if (value != this.PetDoorInstallPrice)

                {
                    this.petDoorInstallPrice = value;
                    OnPropertyChanged("PetDoorInstallPrice");
                }
            }
        }

        public string PetDoorInstallQuantity
        {
            get
            {
                return this.petDoorInstallQuantity.ToString();
            }
            set
            {
                if (value != this.PetDoorInstallQuantity)

                {
                    this.petDoorInstallQuantity = value;
                    OnPropertyChanged("PetDoorInstallQuantity");
                }
            }
        }

        public string PetDoorInstallTotal
        {
            get
            {
                return (Convert.ToDouble(this.petDoorInstallPrice) * Convert.ToInt32(this.petDoorInstallQuantity)).ToString();
            }
            set
            {
                if (value != this.PetDoorInstallTotal)

                {
                    this.petDoorInstallTotal = value;
                    OnPropertyChanged("PetDoorInstallTotal");
                }
            }
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

        public string AddAPetTotal
        {
            get
            {
                return this.addAPetTotal;
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

        //Subtract discount from SolutionTotal
        public string SolutionTotal
        {
            get
            {
                return "$" + Convert.ToDouble(this.safetyTotal) + Convert.ToDouble(this.protectionTotal) + Convert.ToDouble(this.freedomTotal) + Convert.ToDouble(this.addAPetTotal) + Convert.ToDouble(this.outdoorXLoopTotal) + Convert.ToDouble(this.indoorXLoopTotal);
            }
            set
            {
                if (value != this.SolutionTotal)

                {
                    this.solutionTotal = value;
                    OnPropertyChanged("SolutionTotal");
                }
            }
        }


        public string TaxRate
        {
            get
            {
                return this.taxRate;
            }
            set
            {
                if (value != this.TaxRate)

                {
                    this.taxRate = value;
                    OnPropertyChanged("TaxRate");
                }
            }
        }

        public string Tax
        {
            get
            {
                return "$" + (Convert.ToDouble(solutionTotal) * Convert.ToDouble(taxRate));
            }
            set
            {
                if (value != this.Tax)

                {
                    this.tax = value;
                    OnPropertyChanged("Tax");
                }
            }
        }


        public string InstallTotal
        {
            get
            {

                return "$" + (Convert.ToDouble(outdoorInstallCost) - Convert.ToDouble(discount) + Convert.ToDouble(petDoorInstallTotal) + Convert.ToDouble(singleTrainTotal));
            }
            set
            {
                if (value != this.InstallTotal)

                {
                    this.installTotal = value;
                    OnPropertyChanged("InstallTotal");
                }
            }
        }

        public string Total
        {
            get
            {
                return "$" + (Convert.ToDouble(this.solutionTotal) + Convert.ToDouble(this.tax) + Convert.ToDouble(this.installTotal));
            }
            set
            {
                if (value != this.Total)

                {
                    this.total = value;
                    OnPropertyChanged("Total");
                }
            }
        }

        public string Deposit
        {
            get
            {
                return "$" + this.deposit;
            }
            set
            {
                if (value != this.Deposit)

                {
                    this.deposit = value;
                    OnPropertyChanged("Deposit");
                }
            }
        }

        public string Balance
        {
            get
            {
                return "$" + (Convert.ToDouble(this.total) - Convert.ToDouble(this.deposit));
            }
            set
            {
                if (value != this.Balance)

                {
                    this.balance = value;
                    OnPropertyChanged("Balance");
                }
            }
        }



        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}
