using System.Data.Entity;
using TaskStar.Dt98DbContext.DT98UserDbContext.Model;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext
{
    public class Dt98UserEF6DbContext : DbContext
    {
        #region Public Constructors

        public static string ConnectionString { get; set; } = "data source=.\\SQL2014;Initial Catalog=DT98User;user id=sa;password=E77lingen;Integrated Security=False;";

        public Dt98UserEF6DbContext() : base(ConnectionString) { }
        public Dt98UserEF6DbContext(string connectionString) : base(connectionString) => ConnectionString = connectionString;

        #endregion Public Constructors

        #region Public Properties

        public DbSet<ArticleGroups> ArticleGroups { get; set; }

        public DbSet<ArticleKitSet> ArticleKitSet { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<BlackListLocal0001S> BlackListLocal0001S { get; set; }

        public DbSet<ArticlesUbGroups> ArticlesUbGroups { get; set; }

        public DbSet<AlternativePrices> AlternativePrices { get; set; }

        public DbSet<BlackList001> BlackList001 { get; set; }

        public DbSet<BlackList002> BlackList002 { get; set; }

        public DbSet<JournalJobs> JournalJobs { get; set; }

        public DbSet<CardDlyTotal001> CardDlyTotal001 { get; set; }

        public DbSet<CardDlyTotal002> CardDlyTotal002 { get; set; }

        public DbSet<CardDlyTotal003> CardDlyTotal003 { get; set; }

        public DbSet<VmaCurrent> VmaCurrent { get; set; }

        public DbSet<CardDlyTotal004> CardDlyTotal004 { get; set; }

        public DbSet<CardDlyTotal023> CardDlyTotal023 { get; set; }

        public DbSet<Vma_History> Vma_History { get; set; }

        public DbSet<CardDlyTotal025> CardDlyTotal025 { get; set; }

        public DbSet<CardDlyTotal026> CardDlyTotal026 { get; set; }

        public DbSet<VmaTankContents> VmaTankContents { get; set; }

        public DbSet<TankNetz> TankNetz { get; set; }

        public DbSet<CardDlyTotal029> CardDlyTotal029 { get; set; }

        public DbSet<CardDlyTotal045> CardDlyTotal045 { get; set; }

        public DbSet<CardDlyTotal046> CardDlyTotal046 { get; set; }

        public DbSet<CardDlyTotal050> CardDlyTotal050 { get; set; }

        public DbSet<CardDlyTotal051> CardDlyTotal051 { get; set; }

        public DbSet<CardDlyTotal158> CardDlyTotal158 { get; set; }

        public DbSet<CardDlyTotal171> CardDlyTotal171 { get; set; }

        public DbSet<CardTrxCount001> CardTrxCount001 { get; set; }

        public DbSet<CardTrxCount002> CardTrxCount002 { get; set; }

        public DbSet<DevClass> DevClass { get; set; }

        public DbSet<VmaRecordsTank> VmaRecordsTank { get; set; }

        public DbSet<DevConfig> DevConfig { get; set; }

        public DbSet<DevSetting> DevSetting { get; set; }

        public DbSet<CardData> CardData { get; set; }

        public DbSet<DevType> DevType { get; set; }

        public DbSet<DevValType> DevValType { get; set; }

        public DbSet<EanCodes> EanCodes { get; set; }

        public DbSet<FuelSales> FuelSales { get; set; }

        public DbSet<IssuerLists> IssuerLists { get; set; }

        public DbSet<WeatWettbewerber> WeatWettbewerber { get; set; }

        public DbSet<JournalBookings> JournalBookings { get; set; }

        public DbSet<JournalCurrency> JournalCurrency { get; set; }

        public DbSet<VmaFuelSales> VmaFuelSales { get; set; }

        public DbSet<JournalHeader> JournalHeader { get; set; }

        public DbSet<ObjectStates> ObjectStates { get; set; }

        public DbSet<VmaHostStates> VmaHostStates { get; set; }

        public DbSet<OpTotalData> OpTotalData { get; set; }

        public DbSet<OpTotalFiles> OpTotalFiles { get; set; }

        public DbSet<TrxHistory> TrxHistory { get; set; }

        public DbSet<OpTotalGenerations> OpTotalGenerations { get; set; }

        public DbSet<Receipts> Receipts { get; set; }

        public DbSet<RedList001> RedList001 { get; set; }

        public DbSet<TankTransactions> TankTransactions { get; set; }

        public DbSet<VmaRecords> VmaRecords { get; set; }

        public DbSet<RedList002> RedList002 { get; set; }

        public DbSet<RedList003> RedList003 { get; set; }

        public DbSet<RedList004> RedList004 { get; set; }

        public DbSet<RedList023> RedList023 { get; set; }

        public DbSet<RedList025> RedList025 { get; set; }

        public DbSet<ScaledDiscount> ScaledDiscount { get; set; }

        public DbSet<RedList026> RedList026 { get; set; }

        public DbSet<RedList029> RedList029 { get; set; }

        public DbSet<SammelRecords> SammelRecords { get; set; }

        public DbSet<DatacomOnlineCards> DatacomOnlineCards { get; set; }

        public DbSet<RedList045> RedList045 { get; set; }

        public DbSet<DatacomOnlineHosts> DatacomOnlineHosts { get; set; }

        public DbSet<RedList046> RedList046 { get; set; }

        public DbSet<RedList050> RedList050 { get; set; }

        public DbSet<RedList051> RedList051 { get; set; }

        public DbSet<WeatWettbewerbsDaten> WeatWettbewerbsDaten { get; set; }

        public DbSet<RedList158> RedList158 { get; set; }

        public DbSet<RedList171> RedList171 { get; set; }

        public DbSet<SalesBookings> SalesBookings { get; set; }

        public DbSet<SalesHeader> SalesHeader { get; set; }

        public DbSet<Schedule> Schedule { get; set; }

        public DbSet<VmaHistoryOld> VmaHistoryOld { get; set; }

        public DbSet<SqlPolicy> SqlPolicy { get; set; }

        public DbSet<VmaHistoryTankOld> VmaHistoryTankOld { get; set; }

        public DbSet<Taxes> Taxes { get; set; }

        public DbSet<VmaHistory> VmaHistory { get; set; }

        public DbSet<TaInfo> TaInfo { get; set; }

        public DbSet<TrxData> TrxData { get; set; }

        public DbSet<TrxFiles> TrxFiles { get; set; }

        public DbSet<TrxGenerations> TrxGenerations { get; set; }

        public DbSet<Version> Version { get; set; }

        public DbSet<persFuelIngPoints> persFuelIngPoints { get; set; }

        public DbSet<VmaHistoryTank> VmaHistoryTank { get; set; }

        public DbSet<persNozzles> persNozzles { get; set; }

        public DbSet<BlackListTypes> BlackListTypes { get; set; }

        public DbSet<CardBaseTypes> CardBaseTypes { get; set; }

        public DbSet<Mts> Mts { get; set; }

        public DbSet<CardDlyTotalTypes> CardDlyTotalTypes { get; set; }

        public DbSet<CardTrxCountTypes> CardTrxCountTypes { get; set; }

        public DbSet<CardTypeMapping> CardTypeMapping { get; set; }

        public DbSet<CardTypes> CardTypes { get; set; }

        public DbSet<FuelIngPointTypes> FuelIngPointTypes { get; set; }

        public DbSet<GreyListTypes> GreyListTypes { get; set; }

        public DbSet<HostTypes> HostTypes { get; set; }

        public DbSet<ArticleStock> ArticleStock { get; set; }

        public DbSet<EniError> EniError { get; set; }

        public DbSet<IssuerListTypes> IssuerListTypes { get; set; }

        public DbSet<NormUnits> NormUnits { get; set; }

        public DbSet<NozzleTypes> NozzleTypes { get; set; }

        public DbSet<ObjectTypes> ObjectTypes { get; set; }

        public DbSet<PaymentTypes> PaymentTypes { get; set; }

        public DbSet<PosDataXmlPdfExportOrders> PosDataXmlPdfExportOrders { get; set; }

        public DbSet<PumpTypes> PumpTypes { get; set; }

        public DbSet<RedListTypes> RedListTypes { get; set; }

        public DbSet<TankTypes> TankTypes { get; set; }

        public DbSet<TerminalComponentTypes> TerminalComponentTypes { get; set; }

        public DbSet<TerminalTypes> TerminalTypes { get; set; }

        public DbSet<TrxFileTypes> TrxFileTypes { get; set; }

        public DbSet<Units> Units { get; set; }

        public DbSet<BlackLists> BlackLists { get; set; }

        public DbSet<CardDataCom> CardDataCom { get; set; }

        public DbSet<CardDlyTotals> CardDlyTotals { get; set; }

        public DbSet<CardFields> CardFields { get; set; }

        public DbSet<CardFieldValues> CardFieldValues { get; set; }

        public DbSet<CardFiles> CardFiles { get; set; }

        public DbSet<CardHandling> CardHandling { get; set; }

        public DbSet<CardProducts> CardProducts { get; set; }

        public DbSet<CodeVouchers> CodeVouchers { get; set; }

        public DbSet<CardProfiles> CardProfiles { get; set; }

        public DbSet<Cards> Cards { get; set; }

        public DbSet<ReceiptsToPrint> ReceiptsToPrint { get; set; }

        public DbSet<CardTracks> CardTracks { get; set; }

        public DbSet<CardTrxCounts> CardTrxCounts { get; set; }

        public DbSet<FuelIngPoints> FuelIngPoints { get; set; }

        public DbSet<GlobalValues> GlobalValues { get; set; }

        public DbSet<GreyLists> GreyLists { get; set; }

        public DbSet<Hosts> Hosts { get; set; }

        public DbSet<sptIssuerLists> sptIssuerLists { get; set; }

        public DbSet<Nozzles> Nozzles { get; set; }

        public DbSet<OpTotalBaseMatrix> OpTotalBaseMatrix { get; set; }

        public DbSet<OpTotalPaymentMap> OpTotalPaymentMap { get; set; }

        public DbSet<OpTotalProductMap> OpTotalProductMap { get; set; }

        public DbSet<VmaTempFuelings> VmaTempFuelings { get; set; }

        public DbSet<ProductCodeGroups> ProductCodeGroups { get; set; }

        public DbSet<ProductCodeMaps> ProductCodeMaps { get; set; }

        public DbSet<ProductCodeTaxMap> ProductCodeTaxMap { get; set; }

        public DbSet<Pumps> Pumps { get; set; }

        public DbSet<RedLists> RedLists { get; set; }

        public DbSet<TankS> TankS { get; set; }

        public DbSet<TerminalComponents> TerminalComponents { get; set; }

        public DbSet<Terminals> Terminals { get; set; }

        public DbSet<TerminalSettings> TerminalSettings { get; set; }

        public DbSet<TerminationCodes> TerminationCodes { get; set; }

        public DbSet<TotalHandler> TotalHandler { get; set; }

        public DbSet<sptTrxFiles> sptTrxFiles { get; set; }

        #endregion Public Properties
    }
}
