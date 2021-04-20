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
        public static string AccessTokenCreated;
        public static string UserAlreadyExists;
        public static string SuccessfulLogin;
        public static string PasswordError;
        internal static string DetetedDrawer;
        internal static string DrawerAdded;
        internal static bool DrawerListed;
        internal static string DrawerUpdated;
    }
}
