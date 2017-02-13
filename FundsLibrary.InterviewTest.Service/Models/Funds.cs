using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FundsLibrary.InterviewTest.Service.Models
{
    public class Factsheets
    {
        public DateTime? ProfessionalClassAccurateDate { get; set; }
        public string ProfessionalClass { get; set; }
        public DateTime? PrivateClassAccurateDate { get; set; }
        public string PrivateClass { get; set; }
        public DateTime? ProfessionalUnitAccurateDate { get; set; }
        public string ProfessionalUnit { get; set; }
        public DateTime? PrivateUnitAccurateDate { get; set; }
        public string PrivateUnit { get; set; }
        public string PostSale { get; set; }
        public DateTime? PostSaleAccurateDate { get; set; }
        public string LatestPrivate { get; set; }
        public DateTime? LatestPrivateAccurateDate { get; set; }
        public string LatestProfessional { get; set; }
        public DateTime? LatestProfessionalAccurateDate { get; set; }
    }

    public class ReportsAndAccounts
    {
        public DateTime? AnnualReportAccurateDate { get; set; }
        public string AnnualReport { get; set; }
        public DateTime? InterimReportAccurateDate { get; set; }
        public string InterimReport { get; set; }
        public string LatestReport { get; set; }
        public DateTime? LatestReportAccurateDate { get; set; }
    }

    public class Documents
    {
        public Factsheets Factsheets { get; set; }
        public List<object> AlternativeLanguageFactsheets { get; set; }
        public object Kiids { get; set; }
        public List<object> AlternativeLanguageKiids { get; set; }
        public object PriipKids { get; set; }
        public List<object> AlternativeLanguagePriipKids { get; set; }
        public object Prospectus { get; set; }
        public List<object> AlternativeLanguageProspectus { get; set; }
        public ReportsAndAccounts ReportsAndAccounts { get; set; }
        public List<object> AlternativeLanguageReportsAndAccounts { get; set; }
        public string LatestPointOfSaleDocument { get; set; }
        public DateTime? LatestPointOfSaleAccurateDate { get; set; }
    }

    public class Charges
    {
        public decimal? AmcPercentage { get; set; }
        public decimal? AdditionalExpenses { get; set; }
        public string AnnualChargeType { get; set; }
        public decimal? AnnualChargePercentage { get; set; }
        public DateTime? AnnualChargeCalculationDate { get; set; }
        public decimal? AnnualFundPercentage { get; set; }
        public string Exit { get; set; }
        public decimal? Initial { get; set; }
        public string Performance { get; set; }
        public DateTime? TerEffectiveDate { get; set; }
        public bool? TerPerformanceIncluded { get; set; }
        public bool? TerEstimated { get; set; }
        public decimal? TerCalculated { get; set; }
        public DateTime? OcfCalculationDate { get; set; }
        public bool? OcfEstimated { get; set; }
        public decimal? OcfCalculated { get; set; }
        public decimal? Administration { get; set; }
        public string EarlyApplicationBenefits { get; set; }
        public string ExistingInvestorBenefits { get; set; }
        public decimal? InitialCommission { get; set; }
        public bool? CashRebateAvailable { get; set; }
        public decimal? TrailCommission { get; set; }
    }

    public class Essentials
    {
        public string BenchmarkDescription { get; set; }
        public bool? ClassCleanValue { get; set; }
        public string IaSector { get; set; }
        public string AbiSector { get; set; }
        public string Objectives { get; set; }
        public string InvestmentPolicy { get; set; }
        public string FundDomicile { get; set; }
        public string FundType { get; set; }
        public bool? IsaQualifying { get; set; }
        public bool? SippQualifying { get; set; }
        public bool? CashIsaQualifying { get; set; }
        public string ValuationFrequency { get; set; }
        public string ValuationPoint { get; set; }
        public string AicSector { get; set; }
        public bool? AicMember { get; set; }
        public string AicAssetType { get; set; }
        public decimal? PortfolioAssetTypePercentage { get; set; }
        public string CompanyIndex { get; set; }
        public DateTime? DealingDate { get; set; }
        public bool? ShareBuybackPolicy { get; set; }
        public string ShareBuybackPolicyDescription { get; set; }
        public int? MinimumInvestment { get; set; }
        public int? MaximumInvestment { get; set; }
        public bool? TopUpOffer { get; set; }
        public int? AmountRaising { get; set; }
        public string SubscriptionLinkedToOtherVct { get; set; }
        public bool? OverAllotmentFacility { get; set; }
        public int? OverAllotmentAmount { get; set; }
        public string ShareAllotmentFrequency { get; set; }
        public bool? SubscriptionOpen { get; set; }
        public DateTime? SubscriptionOpenDate { get; set; }
        public object SubscriptionCloseForTaxYear { get; set; }
        public DateTime? SubscriptionCloseDate { get; set; }
        public DateTime? FinalDateForReceiptOfApplications { get; set; }
        public DateTime? ApplicationsAcceptDate { get; set; }
        public bool? SubscriptionExtension { get; set; }
        public DateTime? SubscriptionExtensionCloseDate { get; set; }
        public string StockListingCurrency { get; set; }
        public string StockListingCurrencyCode { get; set; }
        public DateTime? AnnualReportingDate { get; set; }
        public DateTime? InterimReportingDate { get; set; }
        public string FundCommentary { get; set; }
        public string InvestmentProcess { get; set; }
        public int? BenchmarkReplication { get; set; }
        public string ReplicationMethod { get; set; }
        public string LegalStructure { get; set; }
        public string RebalancingStructure { get; set; }
        public string CollateralStructure { get; set; }
        public string ExchangeProductType { get; set; }
        public decimal? MaximumLendPercentage { get; set; }
        public DateTime? MaximumLendPercentageAccurateDate { get; set; }
        public decimal? AverageLoanAmount { get; set; }
        public DateTime? AverageLoanAmountAccurateDate { get; set; }
        public decimal? FundReturn { get; set; }
        public string LendingRevenueSplit { get; set; }
        public string ReportingStatus { get; set; }
    }

    public class Attributes
    {
        public bool? MultiManager { get; set; }
        public bool? IndexTracker { get; set; }
        public bool? Property { get; set; }
        public bool? Commodity { get; set; }
        public bool? ProtectedAbsoluteReturn { get; set; }
        public bool? Bric { get; set; }
        public bool? Bond { get; set; }
        public decimal? Leverage { get; set; }
        public bool? Cash { get; set; }
        public bool? SingleAssetClass { get; set; }
        public bool? HigherVolatility { get; set; }
        public bool? InternallyManaged { get; set; }
        public bool? WithProfits { get; set; }
        public string AssetType { get; set; }
        public string ManagementStyle { get; set; }
        public bool? GlobalBond { get; set; }
        public bool? CorporateBonds { get; set; }
        public bool? Equities { get; set; }
        public bool? Gilts { get; set; }
        public bool? GuaranteedFunds { get; set; }
        public bool? MixedAsset { get; set; }
        public bool? SpecialistOther { get; set; }
        public bool? LifeStyle { get; set; }
        public string VctType { get; set; }
        public bool? Hedged { get; set; }
        public string CurrentlyStockLending { get; set; }
        public string PermittedStockLending { get; set; }
        public bool? IsPriip { get; set; }
    }

    public class EtfAttributes
    {
        public string ProductConstructionMethod { get; set; }
        public bool? StockLendingAbility { get; set; }
        public string LegalStructure { get; set; }
        public string IndexRebalancingFrequency { get; set; }
        public string Leverage { get; set; }
    }

    public class LaunchDetails
    {
        public DateTime? ClassLaunchDate { get; set; }
        public DateTime? FundLaunchDate { get; set; }
        public decimal? FundLaunchPrice { get; set; }
        public string FundLaunchCurrency { get; set; }
        public string FundLaunchCurrencyCode { get; set; }
        public string UnitLaunchCurrency { get; set; }
        public string UnitLaunchCurrencyCode { get; set; }
        public DateTime? UnitLaunchDate { get; set; }
        public decimal? UnitLaunchPrice { get; set; }
        public string PriceCurrency { get; set; }
        public string PriceCurrencyCode { get; set; }
        public decimal? EstimatedOrdinaryShareLaunchNav { get; set; }
        public int? AmountRaised { get; set; }
        public DateTime? AmountRaisedAsAtDate { get; set; }
        public int? MaximumNumberOfOrdinarySharesOffered { get; set; }
        public int? MaximumNumberOfOrdinarySharesInIssue { get; set; }
    }

    public class Identification
    {
        public Guid InternalFundCode { get; set; }
        public string ClassName { get; set; }
        public string ClassType { get; set; }
        public string ClassMinimalName { get; set; }
        public string BaseCurrency { get; set; }
        public string BaseCurrencyCode { get; set; }
        public string BloombergCode { get; set; }
        public string UnitType { get; set; }
        public string InternalCode { get; set; }
        public string IsinCode { get; set; }
        public string MexCode { get; set; }
        public string ReutersCode { get; set; }
        public string SedolCode { get; set; }
        public string Citicode { get; set; }
        public string NameAbbreviated { get; set; }
        public string Name { get; set; }
        public string NamePreferred { get; set; }
        public string UnitName { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string LocalMarketCode { get; set; }
        public string SectorName { get; set; }
        public string FullName { get; set; }
        public string ProductId { get; set; }
    }

    public class Team
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public int? PositionWithinTeam { get; set; }
        public DateTime? StartDate { get; set; }
        public string Role { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
    }

    public class Management
    {
        public List<Team> Team { get; set; }
        public string AdministratorId { get; set; }
        public string AuthorisedCorporateDirector { get; set; }
        public string CustodianId { get; set; }
        public string RegistrarId { get; set; }
        public string TrusteeDepositoryId { get; set; }
        public string ActivelyManaged { get; set; }
        public Guid InternalGroupCode { get; set; }
        public string AbbreviatedGroupName { get; set; }
        public string GroupDealingTelNumber { get; set; }
        public string GroupEnquiriesEmail { get; set; }
        public string GroupFaxNumber { get; set; }
        public string GroupAddress { get; set; }
        public string GroupHomepage { get; set; }
        public string GroupTelNumber { get; set; }
        public bool? GroupEtf { get; set; }
        public string GroupLongName { get; set; }
        public string GroupMenuName { get; set; }
        public string GroupShortName { get; set; }
        public string GroupType { get; set; }
        public string GroupLogo { get; set; }
        public int? FcaAcdReference { get; set; }
        public string ContractConfirmationContact { get; set; }
        public string PriceFileContact { get; set; }
        public string IssuingCompany { get; set; }
    }

    public class Regulatory
    {
        public object EusdEffectiveDate { get; set; }
        public string EusdStatus { get; set; }
        public bool? FcaRecognised { get; set; }
        public string DerivativesAllowed { get; set; }
        public string RegulatoryStatus { get; set; }
    }

    public class Risks
    {
        public bool? ChargesToCapital { get; set; }
        public bool? ConcentratedPortfolio { get; set; }
        public bool? DepositorySolvency { get; set; }
        public bool? DerivativeExposure { get; set; }
        public bool? DirectProperty { get; set; }
        public bool? EmergingMarkets { get; set; }
        public bool? EthicalRestrictions { get; set; }
        public bool? ExchangeRate { get; set; }
        public bool? GearedInvestments { get; set; }
        public bool? HighYieldBonds { get; set; }
        public bool? HighRisk { get; set; }
        public bool? IncomeErodingGrowth { get; set; }
        public bool? Inflation { get; set; }
        public bool? LongTermInvestments { get; set; }
        public bool? BondIssuerSolvency { get; set; }
        public bool? Liquidity { get; set; }
        public bool? NewFundCharges { get; set; }
        public bool? Offshore { get; set; }
        public bool? PerformanceCharges { get; set; }
        public bool? ReturnsAreNotGuaranteed { get; set; }
        public bool? SectorSpecific { get; set; }
        public bool? SmallerCompanies { get; set; }
        public bool? TaxationTaxRelief { get; set; }
        public bool? UmbrellaLiabilities { get; set; }
        public bool? ValueOfInvestments { get; set; }
    }

    public class Srri
    {
        public int? ValidatedSrri { get; set; }
    }

    public class KiidExtraction
    {
        public object Kiids { get; set; }
        public Srri Srri { get; set; }
    }

    public class Dealing
    {
        public int? ClassMinimumRegularSavings { get; set; }
        public bool? ClassRegularSavingsAvailable { get; set; }
        public bool? ClassWrappedRegularSavingsGroup { get; set; }
        public bool? ClassUnwrappedRegularSavingsGroup { get; set; }
        public bool? ClassWrappedRegularSavingsPlatform { get; set; }
        public bool? ClassUnwrappedRegularSavingsPlatform { get; set; }
        public int? ClassMinimumWithdrawal { get; set; }
        public int? ClassMinimumHolding { get; set; }
        public bool? MinimumWaived { get; set; }
        public bool? EmxDealing { get; set; }
        public bool? SwiftDealing { get; set; }
        public bool? FaxDealing { get; set; }
        public bool? PhoneDealing { get; set; }
        public string ApplicationFormRequired { get; set; }
        public decimal? LowAssumedGrowthRate { get; set; }
        public decimal? DeductionEffectLowGrowthRate { get; set; }
        public decimal? HighAssumedGrowthRate { get; set; }
        public decimal? DeductionEffectHighGrowthRate { get; set; }
        public bool? HasHigherGrowthRate { get; set; }
        public bool? AdvanceRedemptionNotice { get; set; }
        public string UnitRedemptionOrder { get; set; }
        public string ValuationFrequency { get; set; }
        public string ValuationDay { get; set; }
        public string ValuationLocalTime { get; set; }
        public string ValuationCutOffTime { get; set; }
        public string ValuationTimeZone { get; set; }
    }

    public class StaticData
    {
        public Charges Charges { get; set; }
        public object EffectOfDeductions { get; set; }
        public Essentials Essentials { get; set; }
        public Attributes Attributes { get; set; }
        public EtfAttributes EtfAttributes { get; set; }
        public LaunchDetails LaunchDetails { get; set; }
        public Identification Identification { get; set; }
        public Management Management { get; set; }
        public Regulatory Regulatory { get; set; }
        public Risks Risks { get; set; }
        public KiidExtraction KiidExtraction { get; set; }
        public Dealing Dealing { get; set; }
    }

    public class Value
    {
        public Guid Id { get; set; }
        public Documents Documents { get; set; }
        public object PortfolioData { get; set; }
        public object RatingsData { get; set; }
        public StaticData StaticData { get; set; }
        public object IncomeData { get; set; }
        public object PerformanceData { get; set; }
        public string Type { get; set; }
    }

    public class Funds
    {
        public List<Value> value { get; set; }
    }
}