﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Auth;
using Grpc.Core;
using HOLMS.Types.Booking.RPC;
using HOLMS.Types.CRM.RPC;
using HOLMS.Types.Folio;
using HOLMS.Types.Folio.RPC;
using HOLMS.Types.IAM;
using HOLMS.Types.IAM.RPC;
using HOLMS.Types.Money.RPC;
using HOLMS.Types.Operations.RPC;
using HOLMS.Types.Primitive;
using HOLMS.Types.Reporting.RPC;
using HOLMS.Types.Supply.RPC;
using HOLMS.Types.TenancyConfig.RPC;
using Microsoft.Extensions.Logging;

namespace HOLMS.Platform.Client {
    public class ApplicationClient : IDisposable, IApplicationClient {
        private const int SecondsToMilliseconds = 1000;
        private const int MinutesToSeconds = 60;
        private const int AutoRefreshMinsBeforeExpiry = 5;

        private readonly IApplicationClientConfig _sp;
        private readonly string _clientId;

        private Channel _authenticatedChannel;
        private Timer _refreshTimer;

        public ILogger Logger { get; protected set; }

        #region Booking
        public BookingPricingSvc.BookingPricingSvcClient BkPricingSvc { get; protected set; }
        public CancellationPolicySvc.CancellationPolicySvcClient CancellationPolicySvc { get; protected set; }
        public CancellationReasonSvc.CancellationReasonSvcClient CancellationReasonSvc { get; protected set; }
        public CheckInService.CheckInServiceClient CheckInSvc { get; protected set; }
        public CheckoutSvc.CheckoutSvcClient CheckOutSvc { get; protected set; }
        public GroupBookingSvc.GroupBookingSvcClient GroupBookingSvc { get; protected set; }
        public GroupBookingSearchSvc.GroupBookingSearchSvcClient GroupBookingSearchSvc { get; protected set; }
        public GuaranteeAuthorizerService.GuaranteeAuthorizerServiceClient GuaranteeAuthorizerService { get; protected set; }
        public IncidentalItemReservationSvc.IncidentalItemReservationSvcClient IncidentalResSvc { get; protected set; }
        public LodgingBookingSvc.LodgingBookingSvcClient LodgingBookingSvc { get; protected set; }
        public OpenLodgingReservationSvc.OpenLodgingReservationSvcClient OpenLodgingReservationSvc { get; protected set; }
        public OTAChannelProviderSvc.OTAChannelProviderSvcClient OTAChannelProviderSvc { get; protected set; }
        public ReservationCancellationSvc.ReservationCancellationSvcClient ResCancellationSvc { get; protected set; }
        public ReservationNoteSvc.ReservationNoteSvcClient ReservationNoteSvc { get; protected set; }
        public ReservationSearchSvc.ReservationSearchSvcClient ReservationSearchSvc { get; protected set; }
        public ReservationTagsSvc.ReservationTagsSvcClient ReservationTagsSvc { get; protected set; }
        public RestrictionSvc.RestrictionSvcClient RestrictionSvc { get; protected set; }
        public TravelAgentSvc.TravelAgentSvcClient TravelAgentSvc { get; protected set; }
        public TurnAwayReasonSvc.TurnAwayReasonSvcClient TurnAwayReasonSvc { get; protected set; }
        public OTASyncSvc.OTASyncSvcClient OTASyncSvc { get; protected set; }
        #endregion

        #region CRM
        public CorrespondenceSvc.CorrespondenceSvcClient CorrespondenceSvc { get; protected set; }
        public GroupSvc.GroupSvcClient GroupSvc { get; protected set; }
        public GuestHistorySvc.GuestHistorySvcClient GuestHistorySvc { get; protected set; }
        public GuestSvc.GuestSvcClient GuestSvc { get; protected set; }
        #endregion

        #region Folio
        public FolioAuthCleanupSvc.FolioAuthCleanupSvcClient FolioAuthCleanupSvc { get; protected set; }
        public GroupBookingFolioSvc.GroupBookingFolioSvcClient GroupBookingFolioSvc { get; protected set; }
        public MasterFolioSvc.MasterFolioSvcClient MasterFolioSvc { get; protected set; }
        public ReservationFolioSvc.ReservationFolioSvcClient ReservationFolioSvc { get; protected set; }
        public ReservationGuaranteeSvc.ReservationGuaranteeSvcClient ResGuaranteeSvc { get; protected set; }
        public TaxAssessmentSvc.TaxAssessmentSvcClient TaxAssessmentSvc { get; protected set; }
        public TaxFeeSvc.TaxFeeSvcClient TaxFeeSvc { get; protected set; }
        #endregion

        #region IAM
        public ClientInstanceSvc.ClientInstanceSvcClient ClientInstancesSvc { get; protected set; }
        public DepartmentSvc.DepartmentSvcClient DepartmentsSvc { get; protected set; }
        public StaffSvc.StaffSvcClient StaffSvc { get; protected set; }
        public TenancySvc.TenancySvcClient TenancySvc { get; protected set; }
        #endregion

        #region Money
        public AccountAssignmentsSvc.AccountAssignmentsSvcClient AccountAssignmentSvc { get; protected set; }
        public AccountSvc.AccountSvcClient AccountSvc { get; protected set; }
        public AccountingTxnSvc.AccountingTxnSvcClient AccountingTxnSvc { get; protected set; }
        public CardMerchantSvc.CardMerchantSvcClient CardMerchantSvc { get; protected set; }
        public CardProcessingSvc.CardProcessingSvcClient CardProcessingSvc { get; protected set; }
        public CardTerminalSvc.CardTerminalSvcClient CardTerminalSvc { get; protected set; }
        #endregion
        
        #region Operations
        public AttractionCategorySvc.AttractionCategorySvcClient AttractionCategorySvc { get; protected set; }
        public CalendarMsgSvc.CalendarMsgSvcClient CalendarMsgSvc { get; protected set; }
        public GuestFolioTemplateSvc.GuestFolioTemplateSvcClient GuestFolioTmplSvc { get; protected set; }
        public HKDirtyTrackingSvc.HKDirtyTrackingSvcClient HKDirtyTrackingSvc { get; protected set; }
        public HousekeepingManagementSvc.HousekeepingManagementSvcClient HousekeepingManagementSvc { get; protected set; }
        public HousekeepingTimeSvc.HousekeepingTimeSvcClient HousekeepingTimeSvc { get; protected set; }
        public NoteRequestSvc.NoteRequestSvcClient NoteRequestSvc { get; protected set; }
        public OutOfOrderRecordSvc.OutOfOrderRecordSvcClient OutOfOrderRecordSvc { get; protected set; }
        public PBXSvc.PBXSvcClient PBXSvc { get; protected set; }
        public RoomClaimsSvc.RoomClaimsSvcClient RoomClaimsSvc { get; protected set; }
        public RoomSvc.RoomSvcClient RoomSvc { get; protected set; }
        public StaffMsgSvc.StaffMsgSvcClient StaffMsgSvc { get; protected set; }
        #endregion

        #region Supply
        public HoldsSvc.HoldsSvcClient HoldsSvc { get; protected set; }
        public IncidentalItemSvc.IncidentalItemSvcClient IncidentalItemSvc { get; protected set; }
        public IncidentalSupplySvc.IncidentalSupplySvcClient IncidentalSupplySvc { get; protected set; }
        public PricingSvc.PricingSvcClient PricingSvc { get; protected set; }
        public RateScheduleSvc.RateScheduleSvcClient RateScheduleSvc { get; protected set; }
        public RoomTypeSvc.RoomTypeSvcClient RoomTypeSvc { get; protected set; }
        public SupplyHistorySnapshotSvc.SupplyHistorySnapshotSvcClient SupplyHistorySnapshotSvc { get; protected set; }
        public SupplySnapshotSvc.SupplySnapshotSvcClient SupplySnapshotSvc { get; protected set; }
        public OtaBaseSupplySvc.OtaBaseSupplySvcClient OtaBaseSupplySvc { get; protected set; }
        public PricingOverrideSvc.PricingOverrideSvcClient PricingOverrideSvc { get; protected set; }
        #endregion

        #region Tenancy Config
        public ChannelManagerConfigurationSvc.ChannelManagerConfigurationSvcClient ChannelManagerConfigurationSvc { get; protected set; }
        public ChimeSvc.ChimeSvcClient ChimeSvcClient { get; protected set; }
        public ForeignPropertyConfigurationSvc.ForeignPropertyConfigurationSvcClient ForeignPropertyConfigurationSvc { get; protected set; }
        public GroupBookingMethodSvc.GroupBookingMethodSvcClient GroupBookingMethodSvc { get; protected set; }
        public HkPhoneCodeSvc.HkPhoneCodeSvcClient HkPhoneCodeSvc { get; protected set; }
        public KCEConfigSvc.KCEConfigSvcClient KCEConfigSvc { get; protected set; }
        public IIFExportConfigSvc.IIFExportConfigSvcClient IIFExportConfigSvc { get; protected set; }
        public PhoneCodeSvc.PhoneCodeSvcClient PhoneCodeSvc { get; protected set; }
        public PropertySvc.PropertySvcClient PropertySvc { get; protected set; }
        public ReservationDefaultsSvc.ReservationDefaultsSvcClient ReservationDefaultsSvc { get; protected set; }
        public ReservationSourceSvc.ReservationSourceSvcClient ReservationSourceSvc { get; protected set; }
        public ReservationStatusColorsSvc.ReservationStatusColorsSvcClient ReservationStatusColorsSvc { get; protected set; }
        public RoomCallBillingRatesSvc.RoomCallBillingRatesSvcClient RoomCallBillingRatesSvc { get; protected set; }
        public RoomStatusColorsSvc.RoomStatusColorsSvcClient RoomStatusColorsSvc { get; protected set; }
        public RoomStatusSettingsSvc.RoomStatusSettingsSvcClient RoomStatusSettingsSvc { get; protected set; }
        public TaxExemptCategorySvc.TaxExemptCategorySvcClient TaxExemptCategorySvc { get; protected set; }
        public ReportingConfigurationSvc.ReportingConfigurationSvcClient ReportingConfigurationSvc { get; protected set; }
        public DefaultSettingsSvc.DefaultSettingsSvcClient DefaultSettingsSvc { get; protected set; }
        public RoomStatusSvc.RoomStatusSvcClient RoomStatusSvc { get; protected set; }
        public ReveneueManagementSvc.ReveneueManagementSvcClient RevManagementSvc { get; protected set; }
        #endregion

        #region Reporting
        public CardCaptureReportingSvc.CardCaptureReportingSvcClient CardCaptureReportingSvc { get; protected set; }
        public FoliosReportingSvc.FoliosReportingSvcClient FoliosReportingSvc { get; protected set; }
        public FrontDeskReportingSvc.FrontDeskReportingSvcClient FrontDeskReportingSvc { get; protected set; }
        public ManagementReportingSvc.ManagementReportingSvcClient ManagementReportingSvc { get; protected set; }
        public OperationsReportingSvc.OperationsReportingSvcClient OperationsReportingSvc { get; protected set; }
        public ReportingDefaultSvc.ReportingDefaultSvcClient ReportingDefaultSvc { get; protected set; }
        #endregion

        public SessionService SS { get; protected set; }
        public SessionContext SC => SS?.SessionContext;
        public string TenancyName => SC.TenancyName;
        public string UserName => SC.UserName;
        public StaffMemberIndicator AuthenticatedUser => SC.User;

        public ApplicationClient(IApplicationClientConfig config, ILogger logger, string oauth2ClientId) {
            _sp = config;
            Logger = logger;
            _clientId = oauth2ClientId;
        }

        public string ServerName => _sp.AppSvcHostname;

        public virtual void EndSession() {
            if (SC?.RefreshToken != null) {
                InvalidateRefreshToken();
            }

            _refreshTimer?.Dispose();
            _refreshTimer = null;
            _authenticatedChannel?.ShutdownAsync().Wait();
            //Kill everything else we might have missed
            GrpcEnvironment.ShutdownChannelsAsync().Wait();
            _authenticatedChannel = null;
        }

        public virtual async Task<SessionSvcStartSessionResult> StartSession(string candidateUsername, string candidatePassword
                                                                                                , ClientInstance clientInstance)
        {
            var clientInstanceIndicator = new ClientInstanceIndicator(_sp.ClientInstanceId);
            if (clientInstance != null) { clientInstance.InstanceId = clientInstanceIndicator; }
            var startReq = new SessionSvcStartSessionRequest {
                CandidateUsername = candidateUsername,
                CandidatePassword = candidatePassword,
                ClientInstanceId = clientInstanceIndicator,
                OauthClientId = _clientId,
                ClientInstance = clientInstance
            };

            // NOTE(DA) This section of the code has given me more grief than would be expected.
            //
            // Our gRPC server only uses SSL. We have one port open and it expects all incoming
            // traffic to be SSL. This means our client has to speak SSL to the server.
            //
            // Somewhat annoyingly (though we'll grudgingly admit the safety benefits), gRPC is
            // very opinionated in its use of SSL. There is only one way to get it to use SSL --
            // supply a bearer credential -- which is exactly what we don't have, we're trying to
            // get one with this call! (Chicken and egg problem).
            //
            // We resort to forgery to trick gRPC into using SSL. We keep this forged channel
            // separate and use it only for authentication purposes, throwing it out after we use
            // it here.
            //
            // We were originally keeping the channel around to avoid recreating it, but it's used
            // pretty infrequently, which means (1) we don't care about performance and (2) it was
            // sitting idle too long, and NAT rules were killing it off. Don't try it, we did it
            // and it didn't work.
            //
            // Future: currently, we don't support "session multiplexing" -- users of this
            // component (AppClient) start a single session, and expect it to stay open for the
            // life of the client. We need session multiplexing for service-service communication
            // where we have numerous security contexts existing side-by-side. We need to do some
            // thinking on how to design an interface that facilitates both use cases without making
            // either needlessly complicated. One option would be to force the client to suply a
            // credential at call time, implementing an optional ApplicationClient-maintained
            // "credential registry" or "session registry" that the client could use to retrieve
            // the token at call-time, if desired.

            var loginChannel = new Channel($"{_sp.AppSvcHostname}:{_sp.AppSvcPort}",
                AccessToken.NullToken.ToChannelCredentials());
            var ss = new SessionSvc.SessionSvcClient(loginChannel);

            var sessionResponse = await ss.TryStartSessionAsync(startReq, new CallOptions(null, DateTime.UtcNow.AddSeconds(30)));
            if (sessionResponse.Result == SessionSvcStartSessionResult.Success) {
                SS = new SessionService(sessionResponse.SessionContext);
                StartServicesChannelRefresh(sessionResponse.SessionContext);
            }

            await loginChannel.ShutdownAsync();
            return sessionResponse.Result;
        }

        private void StartServicesChannelRefresh(SessionContext sessionContext) {
            var sessionContextToken = new AccessToken(sessionContext);
            var priorChannel = _authenticatedChannel;

            _authenticatedChannel = new Channel($"{_sp.AppSvcHostname}:{_sp.AppSvcPort}",
                sessionContextToken.ToChannelCredentials());

            MakeServices();

            _refreshTimer?.Dispose();
            int millisecondsToTokenRefresh = (int)(sessionContext.ExpiresIn -
                AutoRefreshMinsBeforeExpiry * MinutesToSeconds) * SecondsToMilliseconds;
            _refreshTimer = new Timer(RefreshTimerCallback, null, millisecondsToTokenRefresh,
                Timeout.Infinite);

            Logger.LogInformation($"Next session refresh in {(millisecondsToTokenRefresh / SecondsToMilliseconds) / MinutesToSeconds} minutes.");
            priorChannel?.ShutdownAsync().Wait();
        }

        private void MakeServices() {
            #region Booking
            BkPricingSvc = new BookingPricingSvc.BookingPricingSvcClient(_authenticatedChannel);
            CancellationPolicySvc = new CancellationPolicySvc.CancellationPolicySvcClient(_authenticatedChannel);
            CancellationReasonSvc = new CancellationReasonSvc.CancellationReasonSvcClient(_authenticatedChannel);
            CheckInSvc = new CheckInService.CheckInServiceClient(_authenticatedChannel);
            CheckOutSvc = new CheckoutSvc.CheckoutSvcClient(_authenticatedChannel);
            GroupBookingSvc = new GroupBookingSvc.GroupBookingSvcClient(_authenticatedChannel);
            GroupBookingSearchSvc = new GroupBookingSearchSvc.GroupBookingSearchSvcClient(_authenticatedChannel);
            IncidentalResSvc = new IncidentalItemReservationSvc.IncidentalItemReservationSvcClient(_authenticatedChannel);
            LodgingBookingSvc = new LodgingBookingSvc.LodgingBookingSvcClient(_authenticatedChannel);
            OTAChannelProviderSvc = new OTAChannelProviderSvc.OTAChannelProviderSvcClient(_authenticatedChannel);
            OpenLodgingReservationSvc = new OpenLodgingReservationSvc.OpenLodgingReservationSvcClient(_authenticatedChannel);
            ResCancellationSvc = new ReservationCancellationSvc.ReservationCancellationSvcClient(_authenticatedChannel);
            ResGuaranteeSvc = new ReservationGuaranteeSvc.ReservationGuaranteeSvcClient(_authenticatedChannel);
            ReservationNoteSvc = new ReservationNoteSvc.ReservationNoteSvcClient(_authenticatedChannel);
            ReservationTagsSvc = new ReservationTagsSvc.ReservationTagsSvcClient(_authenticatedChannel);
            ReservationSearchSvc = new ReservationSearchSvc.ReservationSearchSvcClient(_authenticatedChannel);
            RestrictionSvc = new RestrictionSvc.RestrictionSvcClient(_authenticatedChannel);
            TravelAgentSvc = new TravelAgentSvc.TravelAgentSvcClient(_authenticatedChannel);
            TurnAwayReasonSvc = new TurnAwayReasonSvc.TurnAwayReasonSvcClient(_authenticatedChannel);
            GuaranteeAuthorizerService = new GuaranteeAuthorizerService.GuaranteeAuthorizerServiceClient(_authenticatedChannel);
            OTASyncSvc = new OTASyncSvc.OTASyncSvcClient(_authenticatedChannel);
            #endregion

            #region CRM
            GroupSvc = new GroupSvc.GroupSvcClient(_authenticatedChannel);
            GuestSvc = new GuestSvc.GuestSvcClient(_authenticatedChannel);
            CorrespondenceSvc = new HOLMS.Types.CRM.RPC.CorrespondenceSvc.CorrespondenceSvcClient(_authenticatedChannel);
            GuestHistorySvc = new GuestHistorySvc.GuestHistorySvcClient(_authenticatedChannel);
            #endregion

            #region IAM
            ClientInstancesSvc = new ClientInstanceSvc.ClientInstanceSvcClient(_authenticatedChannel);
            DepartmentsSvc = new DepartmentSvc.DepartmentSvcClient(_authenticatedChannel);
            StaffSvc = new StaffSvc.StaffSvcClient(_authenticatedChannel);
            #endregion

            #region Money
            AccountSvc = new AccountSvc.AccountSvcClient(_authenticatedChannel);
            AccountingTxnSvc = new AccountingTxnSvc.AccountingTxnSvcClient(_authenticatedChannel);
            CardMerchantSvc = new CardMerchantSvc.CardMerchantSvcClient(_authenticatedChannel);
            CardProcessingSvc = new CardProcessingSvc.CardProcessingSvcClient(_authenticatedChannel);
            CardTerminalSvc = new CardTerminalSvc.CardTerminalSvcClient(_authenticatedChannel);
            TaxFeeSvc = new TaxFeeSvc.TaxFeeSvcClient(_authenticatedChannel);
            #endregion

            #region Folio
            GroupBookingFolioSvc = new GroupBookingFolioSvc.GroupBookingFolioSvcClient(_authenticatedChannel);
            ReservationFolioSvc = new ReservationFolioSvc.ReservationFolioSvcClient(_authenticatedChannel);
            FolioAuthCleanupSvc = new FolioAuthCleanupSvc.FolioAuthCleanupSvcClient(_authenticatedChannel);
            MasterFolioSvc = new MasterFolioSvc.MasterFolioSvcClient(_authenticatedChannel);
            TaxAssessmentSvc = new TaxAssessmentSvc.TaxAssessmentSvcClient(_authenticatedChannel);
            #endregion

            #region Operations
            AttractionCategorySvc = new AttractionCategorySvc.AttractionCategorySvcClient(_authenticatedChannel);
            CalendarMsgSvc = new CalendarMsgSvc.CalendarMsgSvcClient(_authenticatedChannel);
            GuestFolioTmplSvc = new GuestFolioTemplateSvc.GuestFolioTemplateSvcClient(_authenticatedChannel);
            HKDirtyTrackingSvc = new HKDirtyTrackingSvc.HKDirtyTrackingSvcClient(_authenticatedChannel);
            HousekeepingManagementSvc = new HousekeepingManagementSvc.HousekeepingManagementSvcClient(_authenticatedChannel);
            HousekeepingTimeSvc = new HousekeepingTimeSvc.HousekeepingTimeSvcClient(_authenticatedChannel);
            NoteRequestSvc = new NoteRequestSvc.NoteRequestSvcClient(_authenticatedChannel);
            OutOfOrderRecordSvc = new OutOfOrderRecordSvc.OutOfOrderRecordSvcClient(_authenticatedChannel);
            PBXSvc = new PBXSvc.PBXSvcClient(_authenticatedChannel);
            RoomClaimsSvc = new RoomClaimsSvc.RoomClaimsSvcClient(_authenticatedChannel);
            RoomSvc = new RoomSvc.RoomSvcClient(_authenticatedChannel);
            StaffMsgSvc = new StaffMsgSvc.StaffMsgSvcClient(_authenticatedChannel);
            #endregion

            #region Supply
            HoldsSvc = new HoldsSvc.HoldsSvcClient(_authenticatedChannel);
            IncidentalSupplySvc = new IncidentalSupplySvc.IncidentalSupplySvcClient(_authenticatedChannel);
            IncidentalItemSvc = new IncidentalItemSvc.IncidentalItemSvcClient(_authenticatedChannel);
            PricingSvc = new PricingSvc.PricingSvcClient(_authenticatedChannel);
            RateScheduleSvc = new RateScheduleSvc.RateScheduleSvcClient(_authenticatedChannel);
            RoomTypeSvc = new RoomTypeSvc.RoomTypeSvcClient(_authenticatedChannel);
            SupplyHistorySnapshotSvc = new SupplyHistorySnapshotSvc.SupplyHistorySnapshotSvcClient(_authenticatedChannel);
            SupplySnapshotSvc = new SupplySnapshotSvc.SupplySnapshotSvcClient(_authenticatedChannel);
            OtaBaseSupplySvc = new OtaBaseSupplySvc.OtaBaseSupplySvcClient(_authenticatedChannel);
            PricingOverrideSvc = new PricingOverrideSvc.PricingOverrideSvcClient(_authenticatedChannel);
            #endregion

            #region Tenancy Config
            AccountAssignmentSvc = new AccountAssignmentsSvc.AccountAssignmentsSvcClient(_authenticatedChannel);
            ChannelManagerConfigurationSvc = new ChannelManagerConfigurationSvc.ChannelManagerConfigurationSvcClient(_authenticatedChannel);
            ChimeSvcClient = new ChimeSvc.ChimeSvcClient(_authenticatedChannel);
            ForeignPropertyConfigurationSvc = new ForeignPropertyConfigurationSvc.ForeignPropertyConfigurationSvcClient(_authenticatedChannel);
            GroupBookingMethodSvc = new GroupBookingMethodSvc.GroupBookingMethodSvcClient(_authenticatedChannel);
            KCEConfigSvc = new KCEConfigSvc.KCEConfigSvcClient(_authenticatedChannel);
            HkPhoneCodeSvc = new HkPhoneCodeSvc.HkPhoneCodeSvcClient(_authenticatedChannel);
            IIFExportConfigSvc = new IIFExportConfigSvc.IIFExportConfigSvcClient(_authenticatedChannel);
            PhoneCodeSvc = new PhoneCodeSvc.PhoneCodeSvcClient(_authenticatedChannel);
            PropertySvc = new PropertySvc.PropertySvcClient(_authenticatedChannel);
            ReservationDefaultsSvc = new ReservationDefaultsSvc.ReservationDefaultsSvcClient(_authenticatedChannel);
            ReservationSourceSvc = new ReservationSourceSvc.ReservationSourceSvcClient(_authenticatedChannel);
            ReservationStatusColorsSvc = new ReservationStatusColorsSvc.ReservationStatusColorsSvcClient(_authenticatedChannel);
            RoomCallBillingRatesSvc = new RoomCallBillingRatesSvc.RoomCallBillingRatesSvcClient(_authenticatedChannel);
            RoomStatusColorsSvc = new RoomStatusColorsSvc.RoomStatusColorsSvcClient(_authenticatedChannel);
            RoomStatusSettingsSvc = new RoomStatusSettingsSvc.RoomStatusSettingsSvcClient(_authenticatedChannel);
            TaxExemptCategorySvc = new HOLMS.Types.TenancyConfig.RPC.TaxExemptCategorySvc.TaxExemptCategorySvcClient(_authenticatedChannel);
            ReportingConfigurationSvc = new ReportingConfigurationSvc.ReportingConfigurationSvcClient(_authenticatedChannel);
            DefaultSettingsSvc = new DefaultSettingsSvc.DefaultSettingsSvcClient(_authenticatedChannel);
            RoomStatusSvc = new RoomStatusSvc.RoomStatusSvcClient(_authenticatedChannel);
            RevManagementSvc = new ReveneueManagementSvc.ReveneueManagementSvcClient(_authenticatedChannel);
            #endregion

            #region Reporting

            CardCaptureReportingSvc = new CardCaptureReportingSvc.CardCaptureReportingSvcClient(_authenticatedChannel);
            FoliosReportingSvc = new FoliosReportingSvc.FoliosReportingSvcClient(_authenticatedChannel);
            FrontDeskReportingSvc = new FrontDeskReportingSvc.FrontDeskReportingSvcClient(_authenticatedChannel);
            ManagementReportingSvc = new ManagementReportingSvc.ManagementReportingSvcClient(_authenticatedChannel);
            OperationsReportingSvc = new OperationsReportingSvc.OperationsReportingSvcClient(_authenticatedChannel);
            ReportingDefaultSvc = new ReportingDefaultSvc.ReportingDefaultSvcClient(_authenticatedChannel);
            #endregion
        }

        private async void RefreshTimerCallback(object state) {
            Logger.LogInformation($"Access token is {AutoRefreshMinsBeforeExpiry} minutes out from expiration - attempting refresh.");
            var refreshRequest = new TokenRefreshRequest {
                GrantType = "refresh_token",
                RefreshToken = SC.RefreshToken,
            };

            var refreshChannel = new Channel($"{_sp.AppSvcHostname}:{_sp.AppSvcPort}",
                AccessToken.NullToken.ToChannelCredentials());
            var ss = new SessionSvc.SessionSvcClient(refreshChannel);
            var sessionResponse = await ss.RefreshAccessTokenAsync(refreshRequest, new CallOptions(null, DateTime.UtcNow.AddSeconds(30)));
            await refreshChannel.ShutdownAsync();

            if (sessionResponse.Result == SessionSvcStartSessionResult.Success) {
                Logger.LogInformation($"Successfully refreshed session");
                SS = new SessionService(sessionResponse.SessionContext);
                StartServicesChannelRefresh(sessionResponse.SessionContext);
            }
            else {
                Logger.LogInformation($"Failed to refresh session. Session will continue with existing access token, and will end in less than {AutoRefreshMinsBeforeExpiry} minutes.");
            }
        }

        public void Dispose() {
            EndSession();
        }

        private void InvalidateRefreshToken() {
            var refreshChannel = new Channel($"{_sp.AppSvcHostname}:{_sp.AppSvcPort}",
                AccessToken.NullToken.ToChannelCredentials());
            var ss = new SessionSvc.SessionSvcClient(refreshChannel);
            var request = new TokenInvalidationRequest {
                RefreshToken = SC.RefreshToken,
            };
            var invalidationResponse = ss.InvalidateRefreshToken(request);
            var loggingInfo = invalidationResponse.Result == TokenInvalidationResult.InvalidationFailure ? "un" : "";
            Logger.LogInformation($"Invalidation of Refresh Token was {loggingInfo}successful");
        }
    }
}
