//==================================================================================================
//  FILE        :
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System.Data.Entity;
using System.Linq;
using TaskStar.Dt98DbContext.Dt98UserDbContext.Model;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext
{
    public class Dt98UserEF6DbContext : DbContext
    {
        #region Public Constructors

        public Dt98UserEF6DbContext() : base(ConnectionString)
        {
        }

        public Dt98UserEF6DbContext(string connectionString) : base(connectionString) => ConnectionString = connectionString;

        #endregion Public Constructors

        #region Public Properties

        public static string ConnectionString { get; set; } = "data source=.\\SQL2014;Initial Catalog=DT98User;user id=sa;password=E77lingen;Integrated Security=False;";
        public DbSet<ArticleGroups> ArticleGroups { get; set; }

        public DbSet<ArticleKITSet> ArticleKITSet { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<BlackListLocal0001S> BlackListLocal0001S { get; set; }

        public DbSet<ArticlesUBGroups> ArticlesUBGroups { get; set; }

        public DbSet<AlternativePrices> AlternativePrices { get; set; }

        public DbSet<BlackList_001> BlackList_001 { get; set; }

        public DbSet<BlackList_002> BlackList_002 { get; set; }

        public DbSet<JournalJobs> JournalJobs { get; set; }

        public DbSet<CardDLYTotal_001> CardDLYTotal_001 { get; set; }

        public DbSet<CardDLYTotal_002> CardDLYTotal_002 { get; set; }

        public DbSet<CardDLYTotal_003> CardDLYTotal_003 { get; set; }

        public DbSet<VMacurrent> VMacurrent { get; set; }

        public DbSet<CardDLYTotal_004> CardDLYTotal_004 { get; set; }

        public DbSet<CardDLYTotal_023> CardDLYTotal_023 { get; set; }

        public DbSet<VMA_History> VMA_History { get; set; }

        public DbSet<CardDLYTotal_025> CardDLYTotal_025 { get; set; }

        public DbSet<CardDLYTotal_026> CardDLYTotal_026 { get; set; }

        public DbSet<VMATankContents> VMATankContents { get; set; }

        public DbSet<TankNetz> TankNetz { get; set; }

        public DbSet<CardDLYTotal_029> CardDLYTotal_029 { get; set; }

        public DbSet<CardDLYTotal_045> CardDLYTotal_045 { get; set; }

        public DbSet<CardDLYTotal_046> CardDLYTotal_046 { get; set; }

        public DbSet<CardDLYTotal_050> CardDLYTotal_050 { get; set; }

        public DbSet<CardDLYTotal_051> CardDLYTotal_051 { get; set; }

        public DbSet<CardDLYTotal_158> CardDLYTotal_158 { get; set; }

        public DbSet<CardDLYTotal_171> CardDLYTotal_171 { get; set; }

        public DbSet<CardTRXCount_001> CardTRXCount_001 { get; set; }

        public DbSet<CardTRXCount_002> CardTRXCount_002 { get; set; }

        public DbSet<DevClass> DevClass { get; set; }

        public DbSet<VMARecordsTank> VMARecordsTank { get; set; }

        public DbSet<DevConfig> DevConfig { get; set; }

        public DbSet<DevSetting> DevSetting { get; set; }

        public DbSet<CardData> CardData { get; set; }

        public DbSet<DevType> DevType { get; set; }

        public DbSet<DevValType> DevValType { get; set; }

        public DbSet<EanCodes> EanCodes { get; set; }

        public DbSet<FuelSales> FuelSales { get; set; }

        public DbSet<ISSUERListS> ISSUERListS { get; set; }

        public DbSet<WEATWettbewerber> WEATWettbewerber { get; set; }

        public DbSet<JournalBookingS> JournalBookingS { get; set; }

        public DbSet<JournalCurrency> JournalCurrency { get; set; }

        public DbSet<VMAFuelSales> VMAFuelSales { get; set; }

        public DbSet<JournalHeader> JournalHeader { get; set; }

        public DbSet<ObjectStateS> ObjectStateS { get; set; }

        public DbSet<VMAHostStates> VMAHostStates { get; set; }

        public DbSet<OPTotalData> OPTotalData { get; set; }

        public DbSet<OPTotalFiles> OPTotalFiles { get; set; }

        public DbSet<TRXHistory> TRXHistory { get; set; }

        public DbSet<OPTotalGenerationS> OPTotalGenerationS { get; set; }

        public DbSet<ReceiptS> ReceiptS { get; set; }

        public DbSet<RedList_001> RedList_001 { get; set; }

        public DbSet<TankTransactions> TankTransactions { get; set; }

        public DbSet<VMARecords> VMARecords { get; set; }

        public DbSet<RedList_002> RedList_002 { get; set; }

        public DbSet<RedList_003> RedList_003 { get; set; }

        public DbSet<RedList_004> RedList_004 { get; set; }

        public DbSet<RedList_023> RedList_023 { get; set; }

        public DbSet<RedList_025> RedList_025 { get; set; }

        public DbSet<ScaledDiscount> ScaledDiscount { get; set; }

        public DbSet<RedList_026> RedList_026 { get; set; }

        public DbSet<RedList_029> RedList_029 { get; set; }

        public DbSet<SammelRecords> SammelRecords { get; set; }

        public DbSet<DatacomOnlineCards> DatacomOnlineCards { get; set; }

        public DbSet<RedList_045> RedList_045 { get; set; }

        public DbSet<DatacomOnlineHosts> DatacomOnlineHosts { get; set; }

        public DbSet<RedList_046> RedList_046 { get; set; }

        public DbSet<RedList_050> RedList_050 { get; set; }

        public DbSet<RedList_051> RedList_051 { get; set; }

        public DbSet<WEATWettbewerbsDaten> WEATWettbewerbsDaten { get; set; }

        public DbSet<RedList_158> RedList_158 { get; set; }

        public DbSet<RedList_171> RedList_171 { get; set; }

        public DbSet<SalesBookingS> SalesBookingS { get; set; }

        public DbSet<SalesHeader> SalesHeader { get; set; }

        public DbSet<Schedule> Schedule { get; set; }

        public DbSet<VMAHistoryOLD> VMAHistoryOLD { get; set; }

        public DbSet<SqlPolicy> SqlPolicy { get; set; }

        public DbSet<VMAHistoryTankOLD> VMAHistoryTankOLD { get; set; }

        public DbSet<Taxes> Taxes { get; set; }

        public DbSet<VMAHistory> VMAHistory { get; set; }

        public DbSet<TAInfo> TAInfo { get; set; }

        public DbSet<TRXData> TRXData { get; set; }

        public DbSet<TRXFiles> TRXFiles { get; set; }

        public DbSet<TRXGenerationS> TRXGenerationS { get; set; }

        public DbSet<Version> Version { get; set; }

        public DbSet<persFuelINGPointS> persFuelINGPointS { get; set; }

        public DbSet<VMAHistoryTank> VMAHistoryTank { get; set; }

        public DbSet<persNozzles> persNozzles { get; set; }

        public DbSet<BlackListTypes> BlackListTypeS { get; set; }

        public DbSet<CardBaseTypes> CardBaseTypeS { get; set; }

        public DbSet<Mts> Mts { get; set; }

        public DbSet<CardDLYTotalTypeS> CardDLYTotalTypeS { get; set; }

        public DbSet<CardTRXCountTypeS> CardTRXCountTypeS { get; set; }

        public DbSet<CardTypeMapPING> CardTypeMapPING { get; set; }

        public DbSet<CardTypeS> CardTypeS { get; set; }

        public DbSet<FuelINGPointTypeS> FuelINGPointTypeS { get; set; }

        public DbSet<GreyListTypeS> GreyListTypeS { get; set; }

        public DbSet<HostTypeS> HostTypeS { get; set; }

        public DbSet<ArticleStock> ArticleStock { get; set; }

        public DbSet<ENIError> ENIError { get; set; }

        public DbSet<ISSUERListTypeS> ISSUERListTypeS { get; set; }

        public DbSet<NormUnitS> NormUnitS { get; set; }

        public DbSet<NozzleTypeS> NozzleTypeS { get; set; }

        public DbSet<ObjectTypeS> ObjectTypeS { get; set; }

        public DbSet<PaymentTypeS> PaymentTypeS { get; set; }

        public DbSet<PosDataXmlPdfExportOrders> PosDataXmlPdfExportOrders { get; set; }

        public DbSet<PumpTypeS> PumpTypeS { get; set; }

        public DbSet<RedListTypeS> RedListTypeS { get; set; }

        public DbSet<TankTypeS> TankTypeS { get; set; }

        public DbSet<TerminalComponentTypeS> TerminalComponentTypeS { get; set; }

        public DbSet<TerminalTypeS> TerminalTypeS { get; set; }

        public DbSet<TRXFileTypeS> TRXFileTypeS { get; set; }

        public DbSet<UnitS> UnitS { get; set; }

        public DbSet<BlackListS> BlackListS { get; set; }

        public DbSet<CardDataCom> CardDataCom { get; set; }

        public DbSet<CardDLYTotalS> CardDLYTotalS { get; set; }

        public DbSet<CardFieldS> CardFieldS { get; set; }

        public DbSet<CardFieldValues> CardFieldValues { get; set; }

        public DbSet<CardFiles> CardFiles { get; set; }

        public DbSet<CardHandling> CardHandling { get; set; }

        public DbSet<CardProductS> CardProductS { get; set; }

        public DbSet<CodeVouchers> CodeVouchers { get; set; }

        public DbSet<CardProfileS> CardProfileS { get; set; }

        public DbSet<CardS> CardS { get; set; }

        public DbSet<ReceiptsToPrint> ReceiptsToPrint { get; set; }

        public DbSet<CardTracks> CardTracks { get; set; }

        public DbSet<CardTRXCountS> CardTRXCountS { get; set; }

        public DbSet<FuelINGPointS> FuelINGPointS { get; set; }

        public DbSet<GlobalValues> GlobalValues { get; set; }

        public DbSet<GreyListS> GreyListS { get; set; }

        public DbSet<Hosts> Hosts { get; set; }

        public DbSet<_sptISSUERLISTS> _sptISSUERLISTS { get; set; }

        public DbSet<Nozzles> Nozzles { get; set; }

        public DbSet<OPTotalBaseMatrix> OPTotalBaseMatrix { get; set; }

        public DbSet<OPTotalPaymentMap> OPTotalPaymentMap { get; set; }

        public DbSet<OPTotalProductMap> OPTotalProductMap { get; set; }

        public DbSet<VMATempFuelings> VMATempFuelings { get; set; }

        public DbSet<ProductCodeGroups> ProductCodeGroups { get; set; }

        public DbSet<ProductCodeMaps> ProductCodeMaps { get; set; }

        public DbSet<ProductCodeTAXMap> ProductCodeTAXMap { get; set; }

        public DbSet<Pumps> Pumps { get; set; }

        public DbSet<RedListS> RedListS { get; set; }

        public DbSet<TankS> TankS { get; set; }

        public DbSet<TerminalComponents> TerminalComponents { get; set; }

        public DbSet<TerminalS> TerminalS { get; set; }

        public DbSet<TerminalSettings> TerminalSettings { get; set; }

        public DbSet<TerminationCodes> TerminationCodes { get; set; }

        public DbSet<TotalHandler> TotalHandler { get; set; }

        public DbSet<_sptTRXFILES> _sptTRXFILES { get; set; }

        #endregion Public Properties
    }
}