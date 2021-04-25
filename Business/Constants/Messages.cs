using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductUnitAdded = "Added product unit";
        public static string ProductUnitNameInvalid = "Product unit name invalid";
        public static string ProductUnitsListed = "Product units listed";
        public static string MaintenanceTime = "The system is currently in maintenance.";
        public static string DeletedProductUnit = "";
        public static string UpdatedProductUnit = "";
        public static string ProductUnitNameAlreadyExist;

        public static string BrandAdded = "Added brand";
        public static string BrandsListed = "";
        public static string BrandDeleted = "";
        public static string UpdatedBrand = "";
        public static string CompanyDeleted = "";
        public static string CompanyLsited = "";

        public static string AuthorizationDenied = "You have no authority.";
        public static string UserRegistered = "";
        public static string UserNotFound = "";
        public static string AccessTokenCreated="";
        public static string UserAlreadyExists="";
        public static string SuccessfulLogin="";
        public static string PasswordError="";

        public static string DetetedDrawer="";
        public static string DrawerAdded="";
        public static string DrawerListed="";
        public static string DrawerUpdated="";

        public static string ExchangeRateAdded="";
        public static string ExchangeRateDeleted="";
        public static string ExchangeRateListed="";
        public static string ExchangeRateUpdated="";

        public static string AddedModel="";
        public static string DeletedModel="";
        public static string ListedModel="";
        public static string UpdatedModel="";

        public static string AddedProductAcceptance="";
        public static string DeletedProductAcceptance="";
        public static string ListedProductAcceptance="";
        public static string UpdatedProductAcceptance="";
        internal static string AddedProductOutput;
        internal static string DeletedProductOutput;
        internal static bool ListedProductOutput;
        internal static string UpdatedProductOutput;
    }
}
