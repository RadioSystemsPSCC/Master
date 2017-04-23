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
        private string safetyTotal;
        private string freedomTotal;
        private string protectionTotal;
        private string addAPetTotal;
        private string discount;
        private string singleTrainTotal;



        public string OutdoorInstallCost
        {
            get
            {
                return "$" + this.OutdoorInstallCost;
            }
            set
            {
                if (value != this.OutdoorInstallCost)

                {
                    this.OutdoorInstallCost = value;
                    OnPropertyChanged("OutdoorInstallCost");
                }
            }
        }

        public string OutdoorXLoopPrice
        {
            get
            {
                return "$" + this.OutdoorXLoopPrice;
            }
            set
            {
                if (value != this.OutdoorXLoopPrice)

                {
                    this.OutdoorXLoopPrice = value;
                    OnPropertyChanged("OutdoorXLoopPrice");
                }
            }
        }

        public string OutdoorXLoopQuantity
        {
            get
            {
                return this.OutdoorXLoopQuantity.ToString();
            }
            set
            {
                if (value != this.OutdoorXLoopQuantity)

                {
                    this.OutdoorXLoopQuantity = value;
                    OnPropertyChanged("OutdoorXLoopQuantity");
                }
            }
        }

        public string OutdoorXLoopTotal
        {
            get
            {
                return (Convert.ToDouble(this.OutdoorXLoopPrice) * Convert.ToInt32(this.OutdoorXLoopQuantity)).ToString();

            }
            set
            {
                if (value != this.OutdoorXLoopTotal)

                {
                    this.OutdoorXLoopTotal = value;
                    OnPropertyChanged("OutdoorXLoopTotal");
                }
            }
        }

        public string IndoorXLoopPrice
        {
            get
            {
                return "$" + this.IndoorXLoopPrice;
            }
            set
            {
                if (value != this.IndoorXLoopPrice)

                {
                    this.IndoorXLoopPrice = value;
                    OnPropertyChanged("IndoorXLoopPrice");
                }
            }
        }

        public string IndoorXLoopQuantity
        {
            get
            {
                return this.IndoorXLoopQuantity;
            }
            set
            {
                if (value != this.IndoorXLoopQuantity)

                {
                    this.IndoorXLoopQuantity = value;
                    OnPropertyChanged("IndoorXLoopQuantity");
                }
            }
        }


        public string IndoorXLoopTotal
        {
            get
            {
                return (Convert.ToDouble(this.IndoorXLoopPrice) * Convert.ToInt32(this.IndoorXLoopQuantity)).ToString();
            }
            set
            {
                if (value != this.IndoorXLoopTotal)

                {
                    this.IndoorXLoopTotal = value;
                    OnPropertyChanged("IndoorXLoopTotal");
                }
            }
        }

        public string PetDoorInstallPrice
        {
            get
            {
                return "$" + this.PetDoorInstallPrice;
            }
            set
            {
                if (value != this.PetDoorInstallPrice)

                {
                    this.PetDoorInstallPrice = value;
                    OnPropertyChanged("PetDoorInstallPrice");
                }
            }
        }

        public string PetDoorInstallQuantity
        {
            get
            {
                return this.PetDoorInstallQuantity.ToString();
            }
            set
            {
                if (value != this.PetDoorInstallQuantity)

                {
                    this.PetDoorInstallQuantity = value;
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
                    this.SolutionTotal = value;
                    OnPropertyChanged("SolutionTotal");
                }
            }
        }


        public string TaxRate
        {
            get
            {
                return this.TaxRate;
            }
            set
            {
                if (value != this.TaxRate)

                {
                    this.TaxRate = value;
                    OnPropertyChanged("TaxRate");
                }
            }
        }

        public string Tax
        {
            get
            {
                return this.Tax;
            }
            set
            {
                if (value != this.Tax)

                {
                    this.Tax = value;
                    OnPropertyChanged("Tax");
                }
            }
        }

        
        public string InstallTotal
        {
            get
            {
                //this formula needs to be checked to make sure it is correct. I changed it slightly on 04/22 to fix an error it was throwing -D.O.
                return "$" + (Convert.ToDouble(outdoorInstallCost) - Convert.ToDouble(discount)) + Convert.ToDouble(petDoorInstallTotal) + Convert.ToDouble(singleTrainTotal);
            }
            set
            {
                if (value != this.InstallTotal)

                {
                    this.InstallTotal = value;
                    OnPropertyChanged("InstallTotal");
                }
            }
        }

        public string Total
        {
            get
            {
                return this.Total;
            }
            set
            {
                if (value != this.Total)

                {
                    this.Total = value;
                    OnPropertyChanged("Total");
                }
            }
        }

        public string Deposit
        {
            get
            {
                return this.Deposit;
            }
            set
            {
                if (value != this.Deposit)

                {
                    this.Deposit = value;
                    OnPropertyChanged("Deposit");
                }
            }
        }

        public string Balance
        {
            get
            {
                return this.Balance;
            }
            set
            {
                if (value != this.Balance)

                {
                    this.Balance = value;
                    OnPropertyChanged("Balance");
                }
            }
        }

        public Installation6ViewModel()
        {
            loadOrder();
        }

        public Order c_Order
        {
            get;
            set;
        }

        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}
