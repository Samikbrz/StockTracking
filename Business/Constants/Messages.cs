using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductUnitAdded = "Ürün birimi eklendi";
        public static string ProductUnitNameInvalid = "Ürün adı geçersiz";
        public static string ProductUnitsListed = "Ürün birimleri listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string DeletedProductUnit = "Ürün birimi silindi";
        public static string UpdatedProductUnit = "Ürün birimi güncellendi";
        public static string ProductUnitNameAlreadyExist="Bu ürün  birimi zaten mevcut";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandDeleted = "Marka silindi";
        public static string UpdatedBrand = "Marka güncellendi";
        public static string BrandAlreadyExist = "Bu marka zaten mevcut!";

        public static string DeletedCompany = "Firma silindi";
        public static string ListedCompany = "Firmalar listelendi";
        public static string UpdatedCompany = "Firma güncellendi";
        public static string AddedCompany = "Firma eklendi";

        public static string AuthorizationDenied = "Bu işlemi yapmak için yetkiniz yok!";
        public static string UserRegistered = "Kayıt işlemi yapıldı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string AccessTokenCreated="";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut";
        public static string SuccessfulLogin="Giriş Yapıldı";
        public static string PasswordError="Şifre hatalı!";

        public static string DeletedDrawer="Çekmece silindi";
        public static string DrawerAdded="Çekmece eklendi";
        public static string DrawerListed="Çekmece listelendi";
        public static string DrawerUpdated="Çekmece güncellendi";

        public static string ExchangeRateAdded="";
        public static string ExchangeRateDeleted="";
        public static string ExchangeRateListed="Para birimleri listelendi";
        public static string ExchangeRateUpdated="";

        public static string AddedModel="Model eklendi";
        public static string DeletedModel="Model silindi";
        public static string ListedModel="Modeller listelendi";
        public static string UpdatedModel="Model güncellendi";

        public static string AddedProductAcceptance="Ürün kabulü oluşturuldu.";
        public static string DeletedProductAcceptance= "Ürün kabulü silindi.";
        public static string ListedProductAcceptance= "Ürün kabulleri listelendi.";
        public static string UpdatedProductAcceptance= "Ürün kabulü güncellendi.";

        public static string AddedProductOutput="Ürün çıkışı eklendi";
        public static string DeletedProductOutput= "Ürün çıkışı silindi";
        public static string ListedProductOutput= "Ürün çıkışları listelendi";
        public static string UpdatedProductOutput= "Ürün çıkışı güncellendi";

        public static string AddedProposal="Teklif oluşturuldu";
        public static string DeletedProposal="Teklif silindi";
        public static string ListedProposal="Teklifler listelendi";
        public static string UpdatedProposal="Teklif güncellendi";

        public static string AddedShelf="Raf eklendi";
        public static string DeletedShelf = "Raf silindi";
        public static string UpdatedShelf = "Raf güncellendi";
        public static string ListedShelves = "Raflar listelendi";

        public static string UpdatedStock="Stok güncellendi";
        public static string ListedStock="Stoklar listelendi";
        public static string DeletedStock="Stok silindi";
        public static string AddedStock="Stok eklendi";

        public static string AddedStockKind="Stok türü eklendi";
        public static string DeletedStockKind = "Stok türü silindi";
        public static string ListedStockKind = "Stok türleri listelendi";
        public static string UpdatedStockKind = "Stok türü güncellendi";

        public static string AddedStockStore="Depo stok dağılımı eklendi";
        public static string DeletedStockStore = "Depo stok dağılımı silindi";
        public static string ListedStockStores = "Depo stok dağılımları listelendi";
        public static string UpdatedStockStore = "Depo stok dağılımı güncellendi";

        public static string AddedStore="Depo eklendi";
        public static string DeletedStore="Depo Silindi";
        public static string ListedStore="Depolar listelendi";
        public static string UpdatedStore="Depo güncellendi";

        public static string AddedStoreTransfer="Ürün transferi oluşturuldu";
        public static string DeletedStoreTransfer="Ürün transferi silindi";
        public static string ListedStoreTransfer= "Ürün transferleri listelendi";
        public static string UpdatedStoreTransfer="Ürün transferi güncellendi";

        public static string ListedUserOperationClaims;
        public static string UpdatedUserOperationClaims;
        public static string DeletedUserOperationClaims;
    }
}
