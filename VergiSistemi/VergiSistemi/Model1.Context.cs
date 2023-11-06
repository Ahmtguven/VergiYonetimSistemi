﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VergiSistemi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VergiSistemiEntities1 : DbContext
    {
        public VergiSistemiEntities1()
            : base("name=VergiSistemiEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bakanlıklar> Bakanlıklar { get; set; }
        public virtual DbSet<Sikayet> Sikayets { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Vatanda> Vatandas { get; set; }
        public virtual DbSet<Vergiler> Vergilers { get; set; }
    
        public virtual int BAdd(string bakanlıkName, string daireBaskanlık, Nullable<decimal> ciro, string merkez)
        {
            var bakanlıkNameParameter = bakanlıkName != null ?
                new ObjectParameter("bakanlıkName", bakanlıkName) :
                new ObjectParameter("bakanlıkName", typeof(string));
    
            var daireBaskanlıkParameter = daireBaskanlık != null ?
                new ObjectParameter("DaireBaskanlık", daireBaskanlık) :
                new ObjectParameter("DaireBaskanlık", typeof(string));
    
            var ciroParameter = ciro.HasValue ?
                new ObjectParameter("Ciro", ciro) :
                new ObjectParameter("Ciro", typeof(decimal));
    
            var merkezParameter = merkez != null ?
                new ObjectParameter("Merkez", merkez) :
                new ObjectParameter("Merkez", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BAdd", bakanlıkNameParameter, daireBaskanlıkParameter, ciroParameter, merkezParameter);
        }
    
        public virtual int BDell(Nullable<int> bakanlıkId)
        {
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("BakanlıkId", bakanlıkId) :
                new ObjectParameter("BakanlıkId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BDell", bakanlıkIdParameter);
        }
    
        public virtual ObjectResult<BList_Result> BList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BList_Result>("BList");
        }
    
        public virtual int BUpdate(Nullable<int> bakanlıkId, string bakanlıkName, string daireBaskanlık, Nullable<decimal> ciro, string merkez)
        {
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("BakanlıkId", bakanlıkId) :
                new ObjectParameter("BakanlıkId", typeof(int));
    
            var bakanlıkNameParameter = bakanlıkName != null ?
                new ObjectParameter("bakanlıkName", bakanlıkName) :
                new ObjectParameter("bakanlıkName", typeof(string));
    
            var daireBaskanlıkParameter = daireBaskanlık != null ?
                new ObjectParameter("DaireBaskanlık", daireBaskanlık) :
                new ObjectParameter("DaireBaskanlık", typeof(string));
    
            var ciroParameter = ciro.HasValue ?
                new ObjectParameter("Ciro", ciro) :
                new ObjectParameter("Ciro", typeof(decimal));
    
            var merkezParameter = merkez != null ?
                new ObjectParameter("Merkez", merkez) :
                new ObjectParameter("Merkez", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BUpdate", bakanlıkIdParameter, bakanlıkNameParameter, daireBaskanlıkParameter, ciroParameter, merkezParameter);
        }
    
        public virtual ObjectResult<SorguBak_Result> SorguBak()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SorguBak_Result>("SorguBak");
        }
    
        public virtual ObjectResult<SorguMeslek_Result> SorguMeslek()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SorguMeslek_Result>("SorguMeslek");
        }
    
        public virtual ObjectResult<SorguVat_Result> SorguVat()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SorguVat_Result>("SorguVat");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int VAdd(string tC, string meslek, string adres, string telefon, string mail)
        {
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var meslekParameter = meslek != null ?
                new ObjectParameter("Meslek", meslek) :
                new ObjectParameter("Meslek", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VAdd", tCParameter, meslekParameter, adresParameter, telefonParameter, mailParameter);
        }
    
        public virtual int VDell(Nullable<int> kisiNo)
        {
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("KisiNo", kisiNo) :
                new ObjectParameter("KisiNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VDell", kisiNoParameter);
        }
    
        public virtual int VerAdd(string vergiName, string tipi, Nullable<decimal> tutar, Nullable<int> faiz)
        {
            var vergiNameParameter = vergiName != null ?
                new ObjectParameter("vergiName", vergiName) :
                new ObjectParameter("vergiName", typeof(string));
    
            var tipiParameter = tipi != null ?
                new ObjectParameter("Tipi", tipi) :
                new ObjectParameter("Tipi", typeof(string));
    
            var tutarParameter = tutar.HasValue ?
                new ObjectParameter("Tutar", tutar) :
                new ObjectParameter("Tutar", typeof(decimal));
    
            var faizParameter = faiz.HasValue ?
                new ObjectParameter("Faiz", faiz) :
                new ObjectParameter("Faiz", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VerAdd", vergiNameParameter, tipiParameter, tutarParameter, faizParameter);
        }
    
        public virtual int VerDell(Nullable<int> vergiId)
        {
            var vergiIdParameter = vergiId.HasValue ?
                new ObjectParameter("VergiId", vergiId) :
                new ObjectParameter("VergiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VerDell", vergiIdParameter);
        }
    
        public virtual ObjectResult<VerList_Result> VerList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerList_Result>("VerList");
        }
    
        public virtual int VerUpdate(Nullable<int> vergiId, string vergiName, string tipi, Nullable<decimal> tutar, Nullable<int> faiz)
        {
            var vergiIdParameter = vergiId.HasValue ?
                new ObjectParameter("VergiId", vergiId) :
                new ObjectParameter("VergiId", typeof(int));
    
            var vergiNameParameter = vergiName != null ?
                new ObjectParameter("vergiName", vergiName) :
                new ObjectParameter("vergiName", typeof(string));
    
            var tipiParameter = tipi != null ?
                new ObjectParameter("Tipi", tipi) :
                new ObjectParameter("Tipi", typeof(string));
    
            var tutarParameter = tutar.HasValue ?
                new ObjectParameter("Tutar", tutar) :
                new ObjectParameter("Tutar", typeof(decimal));
    
            var faizParameter = faiz.HasValue ?
                new ObjectParameter("Faiz", faiz) :
                new ObjectParameter("Faiz", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VerUpdate", vergiIdParameter, vergiNameParameter, tipiParameter, tutarParameter, faizParameter);
        }
    
        public virtual ObjectResult<VList_Result> VList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VList_Result>("VList");
        }
    
        public virtual ObjectResult<VListFiltreleme_Result> VListFiltreleme()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VListFiltreleme_Result>("VListFiltreleme");
        }
    
        public virtual int VUpdate(Nullable<int> kisiNo, string tC, string meslek, string adres, string telefon, string mail)
        {
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("KisiNo", kisiNo) :
                new ObjectParameter("KisiNo", typeof(int));
    
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var meslekParameter = meslek != null ?
                new ObjectParameter("Meslek", meslek) :
                new ObjectParameter("Meslek", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VUpdate", kisiNoParameter, tCParameter, meslekParameter, adresParameter, telefonParameter, mailParameter);
        }
    
        public virtual int SikayetAdd(Nullable<int> bakanlıkId, string tC, string metin, string bakanlıkName, Nullable<System.DateTime> tarih)
        {
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("BakanlıkId", bakanlıkId) :
                new ObjectParameter("BakanlıkId", typeof(int));
    
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var metinParameter = metin != null ?
                new ObjectParameter("Metin", metin) :
                new ObjectParameter("Metin", typeof(string));
    
            var bakanlıkNameParameter = bakanlıkName != null ?
                new ObjectParameter("BakanlıkName", bakanlıkName) :
                new ObjectParameter("BakanlıkName", typeof(string));
    
            var tarihParameter = tarih.HasValue ?
                new ObjectParameter("Tarih", tarih) :
                new ObjectParameter("Tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SikayetAdd", bakanlıkIdParameter, tCParameter, metinParameter, bakanlıkNameParameter, tarihParameter);
        }
    
        public virtual int SikayetDel(Nullable<int> sikayetId)
        {
            var sikayetIdParameter = sikayetId.HasValue ?
                new ObjectParameter("SikayetId", sikayetId) :
                new ObjectParameter("SikayetId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SikayetDel", sikayetIdParameter);
        }
    
        public virtual ObjectResult<SikayetList_Result> SikayetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SikayetList_Result>("SikayetList");
        }
    
        public virtual int SikayetUp(Nullable<int> sikayetId, Nullable<int> bakanlıkId, string tC, string metin, string bakanlıkName, Nullable<System.DateTime> tarih)
        {
            var sikayetIdParameter = sikayetId.HasValue ?
                new ObjectParameter("SikayetId", sikayetId) :
                new ObjectParameter("SikayetId", typeof(int));
    
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("BakanlıkId", bakanlıkId) :
                new ObjectParameter("BakanlıkId", typeof(int));
    
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var metinParameter = metin != null ?
                new ObjectParameter("Metin", metin) :
                new ObjectParameter("Metin", typeof(string));
    
            var bakanlıkNameParameter = bakanlıkName != null ?
                new ObjectParameter("BakanlıkName", bakanlıkName) :
                new ObjectParameter("BakanlıkName", typeof(string));
    
            var tarihParameter = tarih.HasValue ?
                new ObjectParameter("Tarih", tarih) :
                new ObjectParameter("Tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SikayetUp", sikayetIdParameter, bakanlıkIdParameter, tCParameter, metinParameter, bakanlıkNameParameter, tarihParameter);
        }
    
        public virtual ObjectResult<VatList_Result> VatList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VatList_Result>("VatList");
        }
    
        public virtual ObjectResult<Getir_Result> Getir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Getir_Result>("Getir");
        }
    
        public virtual ObjectResult<Filtreleme1_Result> Filtreleme1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filtreleme1_Result>("Filtreleme1");
        }
    
        public virtual ObjectResult<BakanlıkFiltre_Result> BakanlıkFiltre()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BakanlıkFiltre_Result>("BakanlıkFiltre");
        }
    
        public virtual ObjectResult<KisiVergiList_Result> KisiVergiList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KisiVergiList_Result>("KisiVergiList");
        }
    
        public virtual ObjectResult<VerToplama_Result> VerToplama()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VerToplama_Result>("VerToplama");
        }
    
        public virtual int BakanlıkDell(Nullable<int> bakanlıkId)
        {
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("bakanlıkId", bakanlıkId) :
                new ObjectParameter("bakanlıkId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BakanlıkDell", bakanlıkIdParameter);
        }
    
        public virtual int BakanlıklAdd(string bakanlıkName, string daireBaskanlık, Nullable<decimal> ciro, string merkez, string passwords)
        {
            var bakanlıkNameParameter = bakanlıkName != null ?
                new ObjectParameter("bakanlıkName", bakanlıkName) :
                new ObjectParameter("bakanlıkName", typeof(string));
    
            var daireBaskanlıkParameter = daireBaskanlık != null ?
                new ObjectParameter("DaireBaskanlık", daireBaskanlık) :
                new ObjectParameter("DaireBaskanlık", typeof(string));
    
            var ciroParameter = ciro.HasValue ?
                new ObjectParameter("Ciro", ciro) :
                new ObjectParameter("Ciro", typeof(decimal));
    
            var merkezParameter = merkez != null ?
                new ObjectParameter("Merkez", merkez) :
                new ObjectParameter("Merkez", typeof(string));
    
            var passwordsParameter = passwords != null ?
                new ObjectParameter("Passwords", passwords) :
                new ObjectParameter("Passwords", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BakanlıklAdd", bakanlıkNameParameter, daireBaskanlıkParameter, ciroParameter, merkezParameter, passwordsParameter);
        }
    
        public virtual ObjectResult<BakanlıkList_Result> BakanlıkList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BakanlıkList_Result>("BakanlıkList");
        }
    
        public virtual int BakanlıkUpdate(Nullable<int> bakanlıkId, string bakanlıkName, string daireBaskanlık, Nullable<decimal> ciro, string merkez, string passwords)
        {
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("bakanlıkId", bakanlıkId) :
                new ObjectParameter("bakanlıkId", typeof(int));
    
            var bakanlıkNameParameter = bakanlıkName != null ?
                new ObjectParameter("bakanlıkName", bakanlıkName) :
                new ObjectParameter("bakanlıkName", typeof(string));
    
            var daireBaskanlıkParameter = daireBaskanlık != null ?
                new ObjectParameter("DaireBaskanlık", daireBaskanlık) :
                new ObjectParameter("DaireBaskanlık", typeof(string));
    
            var ciroParameter = ciro.HasValue ?
                new ObjectParameter("Ciro", ciro) :
                new ObjectParameter("Ciro", typeof(decimal));
    
            var merkezParameter = merkez != null ?
                new ObjectParameter("Merkez", merkez) :
                new ObjectParameter("Merkez", typeof(string));
    
            var passwordsParameter = passwords != null ?
                new ObjectParameter("Passwords", passwords) :
                new ObjectParameter("Passwords", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BakanlıkUpdate", bakanlıkIdParameter, bakanlıkNameParameter, daireBaskanlıkParameter, ciroParameter, merkezParameter, passwordsParameter);
        }
    
        public virtual int SikayetDell(Nullable<int> sikayetId)
        {
            var sikayetIdParameter = sikayetId.HasValue ?
                new ObjectParameter("SikayetId", sikayetId) :
                new ObjectParameter("SikayetId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SikayetDell", sikayetIdParameter);
        }
    
        public virtual int SikayetUpdate(Nullable<int> sikayetId, Nullable<int> bakanlıkId, string tC, string metin, string bakanlıkName, Nullable<System.DateTime> tarih)
        {
            var sikayetIdParameter = sikayetId.HasValue ?
                new ObjectParameter("SikayetId", sikayetId) :
                new ObjectParameter("SikayetId", typeof(int));
    
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("BakanlıkId", bakanlıkId) :
                new ObjectParameter("BakanlıkId", typeof(int));
    
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var metinParameter = metin != null ?
                new ObjectParameter("Metin", metin) :
                new ObjectParameter("Metin", typeof(string));
    
            var bakanlıkNameParameter = bakanlıkName != null ?
                new ObjectParameter("BakanlıkName", bakanlıkName) :
                new ObjectParameter("BakanlıkName", typeof(string));
    
            var tarihParameter = tarih.HasValue ?
                new ObjectParameter("Tarih", tarih) :
                new ObjectParameter("Tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SikayetUpdate", sikayetIdParameter, bakanlıkIdParameter, tCParameter, metinParameter, bakanlıkNameParameter, tarihParameter);
        }
    
        public virtual int VatandasAdd(string tC, string meslek, string adres, string telefon, string mail, string sifre)
        {
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var meslekParameter = meslek != null ?
                new ObjectParameter("Meslek", meslek) :
                new ObjectParameter("Meslek", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("Sifre", sifre) :
                new ObjectParameter("Sifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VatandasAdd", tCParameter, meslekParameter, adresParameter, telefonParameter, mailParameter, sifreParameter);
        }
    
        public virtual int VatandasDell(Nullable<int> kisiNo)
        {
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("KisiNo", kisiNo) :
                new ObjectParameter("KisiNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VatandasDell", kisiNoParameter);
        }
    
        public virtual ObjectResult<VatandasList_Result> VatandasList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VatandasList_Result>("VatandasList");
        }
    
        public virtual int VatandasUpdate(Nullable<int> kisiNo, string tC, string meslek, string adres, string telefon, string mail, string sifre)
        {
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("KisiNo", kisiNo) :
                new ObjectParameter("KisiNo", typeof(int));
    
            var tCParameter = tC != null ?
                new ObjectParameter("TC", tC) :
                new ObjectParameter("TC", typeof(string));
    
            var meslekParameter = meslek != null ?
                new ObjectParameter("Meslek", meslek) :
                new ObjectParameter("Meslek", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var sifreParameter = sifre != null ?
                new ObjectParameter("Sifre", sifre) :
                new ObjectParameter("Sifre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VatandasUpdate", kisiNoParameter, tCParameter, meslekParameter, adresParameter, telefonParameter, mailParameter, sifreParameter);
        }
    
        public virtual int VergiAdd(string vergiName, string tipi, Nullable<decimal> tutar, Nullable<int> faiz, Nullable<int> kisiNo, Nullable<int> bakanlıkId)
        {
            var vergiNameParameter = vergiName != null ?
                new ObjectParameter("vergiName", vergiName) :
                new ObjectParameter("vergiName", typeof(string));
    
            var tipiParameter = tipi != null ?
                new ObjectParameter("Tipi", tipi) :
                new ObjectParameter("Tipi", typeof(string));
    
            var tutarParameter = tutar.HasValue ?
                new ObjectParameter("Tutar", tutar) :
                new ObjectParameter("Tutar", typeof(decimal));
    
            var faizParameter = faiz.HasValue ?
                new ObjectParameter("Faiz", faiz) :
                new ObjectParameter("Faiz", typeof(int));
    
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("KisiNo", kisiNo) :
                new ObjectParameter("KisiNo", typeof(int));
    
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("BakanlıkId", bakanlıkId) :
                new ObjectParameter("BakanlıkId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VergiAdd", vergiNameParameter, tipiParameter, tutarParameter, faizParameter, kisiNoParameter, bakanlıkIdParameter);
        }
    
        public virtual int VergiDell(Nullable<int> vergiId)
        {
            var vergiIdParameter = vergiId.HasValue ?
                new ObjectParameter("vergiId", vergiId) :
                new ObjectParameter("vergiId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VergiDell", vergiIdParameter);
        }
    
        public virtual ObjectResult<VergiList_Result> VergiList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VergiList_Result>("VergiList");
        }
    
        public virtual int VergiUpdate(Nullable<int> vergiId, string vergiName, string tipi, Nullable<decimal> tutar, Nullable<int> faiz, Nullable<int> kisiNo, Nullable<int> bakanlıkId)
        {
            var vergiIdParameter = vergiId.HasValue ?
                new ObjectParameter("VergiId", vergiId) :
                new ObjectParameter("VergiId", typeof(int));
    
            var vergiNameParameter = vergiName != null ?
                new ObjectParameter("vergiName", vergiName) :
                new ObjectParameter("vergiName", typeof(string));
    
            var tipiParameter = tipi != null ?
                new ObjectParameter("Tipi", tipi) :
                new ObjectParameter("Tipi", typeof(string));
    
            var tutarParameter = tutar.HasValue ?
                new ObjectParameter("Tutar", tutar) :
                new ObjectParameter("Tutar", typeof(decimal));
    
            var faizParameter = faiz.HasValue ?
                new ObjectParameter("Faiz", faiz) :
                new ObjectParameter("Faiz", typeof(int));
    
            var kisiNoParameter = kisiNo.HasValue ?
                new ObjectParameter("KisiNo", kisiNo) :
                new ObjectParameter("KisiNo", typeof(int));
    
            var bakanlıkIdParameter = bakanlıkId.HasValue ?
                new ObjectParameter("BakanlıkId", bakanlıkId) :
                new ObjectParameter("BakanlıkId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VergiUpdate", vergiIdParameter, vergiNameParameter, tipiParameter, tutarParameter, faizParameter, kisiNoParameter, bakanlıkIdParameter);
        }
    
        public virtual ObjectResult<BakanlıkFiltreleme_Result> BakanlıkFiltreleme()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BakanlıkFiltreleme_Result>("BakanlıkFiltreleme");
        }
    
        public virtual ObjectResult<KisiVergiListesi_Result> KisiVergiListesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KisiVergiListesi_Result>("KisiVergiListesi");
        }
    
        public virtual ObjectResult<kişiFiltreleme_Result> kişiFiltreleme()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<kişiFiltreleme_Result>("kişiFiltreleme");
        }
    
        public virtual ObjectResult<BakanlıkAdınaGore_Result> BakanlıkAdınaGore()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BakanlıkAdınaGore_Result>("BakanlıkAdınaGore");
        }
    
        public virtual ObjectResult<VergiAdıFiltre_Result> VergiAdıFiltre()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VergiAdıFiltre_Result>("VergiAdıFiltre");
        }
    
        public virtual ObjectResult<MAG_Result> MAG()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MAG_Result>("MAG");
        }
    }
}