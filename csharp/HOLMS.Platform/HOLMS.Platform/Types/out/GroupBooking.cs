// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/groups/group_booking.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Groups {

  /// <summary>Holder for reflection information generated from booking/groups/group_booking.proto</summary>
  public static partial class GroupBookingReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/groups/group_booking.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupBookingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJib29raW5nL2dyb3Vwcy9ncm91cF9ib29raW5nLnByb3RvEhpob2xtcy50",
            "eXBlcy5ib29raW5nLmdyb3VwcxoqcHJpbWl0aXZlL3BiX2luY2x1c2l2ZV9v",
            "cHNkYXRlX3JhbmdlLnByb3RvGhRwcmltaXRpdmUvdXVpZC5wcm90bxo2Ym9v",
            "a2luZy9pbmRpY2F0b3JzL2NhbmNlbGxhdGlvbl9wb2xpY3lfaW5kaWNhdG9y",
            "LnByb3RvGi9ib29raW5nL2luZGljYXRvcnMvdHJhdmVsX2FnZW50X2luZGlj",
            "YXRvci5wcm90bxowYm9va2luZy9pbmRpY2F0b3JzL2dyb3VwX2Jvb2tpbmdf",
            "aW5kaWNhdG9yLnByb3RvGilib29raW5nL2dyb3Vwcy9ncm91cF9ib29raW5n",
            "X3N0YXR1cy5wcm90bxogY3JtL2dyb3Vwcy9ncm91cF9pbmRpY2F0b3IucHJv",
            "dG8aJHN1cHBseS9yYXRlX3NjaGVkdWxlX2luZGljYXRvci5wcm90bxo+dGVu",
            "YW5jeV9jb25maWcvaW5kaWNhdG9ycy9ncm91cF9ib29raW5nX21ldGhvZF9p",
            "bmRpY2F0b3IucHJvdG8aMnRlbmFuY3lfY29uZmlnL2luZGljYXRvcnMvcHJv",
            "cGVydHlfaW5kaWNhdG9yLnByb3RvIr0ICgxHcm91cEJvb2tpbmcSSAoJZW50",
            "aXR5X2lkGAEgASgLMjUuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3Jz",
            "Lkdyb3VwQm9va2luZ0luZGljYXRvchI+CgZzdGF0dXMYAiABKA4yLi5ob2xt",
            "cy50eXBlcy5ib29raW5nLmdyb3Vwcy5Hcm91cEJvb2tpbmdTdGF0dXMSEgoK",
            "dGF4X2V4ZW1wdBgDIAEoCBIOCgZ0YXhfaWQYBCABKAkSGgoSZ3JvdXBfcGF5",
            "c19sb2RnaW5nGAUgASgIEh4KFmdyb3VwX3BheXNfaW5jaWRlbnRhbHMYBiAB",
            "KAgSGAoQYWRkaXRpb25hbF9ub3RlcxgHIAEoCRIbChNjdXN0b21lcl9ib29r",
            "aW5nX2lkGAggASgJEkIKCmRhdGVfcmFuZ2UYCSABKAsyLi5ob2xtcy50eXBl",
            "cy5wcmltaXRpdmUuUGJJbmNsdXNpdmVPcHNkYXRlUmFuZ2USQAoNcmF0ZV9z",
            "Y2hlZHVsZRgLIAEoCzIpLmhvbG1zLnR5cGVzLnN1cHBseS5SYXRlU2NoZWR1",
            "bGVJbmRpY2F0b3ISNQoFZ3JvdXAYDCABKAsyJi5ob2xtcy50eXBlcy5jcm0u",
            "Z3JvdXBzLkdyb3VwSW5kaWNhdG9yEj0KGGNvbmZpcm1hdGlvbl90ZW1wbGF0",
            "ZV9pZBgNIAEoCzIbLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5VdWlkEloKDmJv",
            "b2tpbmdfbWV0aG9kGA4gASgLMkIuaG9sbXMudHlwZXMudGVuYW5jeV9jb25m",
            "aWcuaW5kaWNhdG9ycy5Hcm91cEJvb2tpbmdNZXRob2RJbmRpY2F0b3ISOAoT",
            "YXJyaXZhbF90ZW1wbGF0ZV9pZBgPIAEoCzIbLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5VdWlkEjoKFXJlc2VydmF0aW9uX3NvdXJjZV9pZBgQIAEoCzIbLmhv",
            "bG1zLnR5cGVzLnByaW1pdGl2ZS5VdWlkEkoKDHRyYXZlbF9hZ2VudBgRIAEo",
            "CzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5UcmF2ZWxBZ2Vu",
            "dEluZGljYXRvchJYChNjYW5jZWxsYXRpb25fcG9saWN5GBIgASgLMjsuaG9s",
            "bXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLkNhbmNlbGxhdGlvblBvbGlj",
            "eUluZGljYXRvchISCgpncm91cF9uYW1lGBMgASgJEhoKEnN1cnByZXNzX3Jh",
            "dGVfaW5mbxgUIAEoCBIUCgx0YXhfY2F0ZWdvcnkYFSABKAkSUgoQYm9va2lu",
            "Z19wcm9wZXJ0eRgWIAEoCzI4LmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmln",
            "LmluZGljYXRvcnMuUHJvcGVydHlJbmRpY2F0b3JCLVoOYm9va2luZy9ncm91",
            "cHOqAhpIT0xNUy5UeXBlcy5Cb29raW5nLkdyb3Vwc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Primitive.UuidReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.TravelAgentIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Groups.GroupBookingStatusReflection.Descriptor, global::HOLMS.Types.CRM.Groups.GroupIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.RateScheduleIndicatorReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.GroupBookingMethodIndicatorReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Groups.GroupBooking), global::HOLMS.Types.Booking.Groups.GroupBooking.Parser, new[]{ "EntityId", "Status", "TaxExempt", "TaxId", "GroupPaysLodging", "GroupPaysIncidentals", "AdditionalNotes", "CustomerBookingId", "DateRange", "RateSchedule", "Group", "ConfirmationTemplateId", "BookingMethod", "ArrivalTemplateId", "ReservationSourceId", "TravelAgent", "CancellationPolicy", "GroupName", "SurpressRateInfo", "TaxCategory", "BookingProperty" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupBooking : pb::IMessage<GroupBooking> {
    private static readonly pb::MessageParser<GroupBooking> _parser = new pb::MessageParser<GroupBooking>(() => new GroupBooking());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroupBooking> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Groups.GroupBookingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBooking() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBooking(GroupBooking other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      status_ = other.status_;
      taxExempt_ = other.taxExempt_;
      taxId_ = other.taxId_;
      groupPaysLodging_ = other.groupPaysLodging_;
      groupPaysIncidentals_ = other.groupPaysIncidentals_;
      additionalNotes_ = other.additionalNotes_;
      customerBookingId_ = other.customerBookingId_;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      RateSchedule = other.rateSchedule_ != null ? other.RateSchedule.Clone() : null;
      Group = other.group_ != null ? other.Group.Clone() : null;
      ConfirmationTemplateId = other.confirmationTemplateId_ != null ? other.ConfirmationTemplateId.Clone() : null;
      BookingMethod = other.bookingMethod_ != null ? other.BookingMethod.Clone() : null;
      ArrivalTemplateId = other.arrivalTemplateId_ != null ? other.ArrivalTemplateId.Clone() : null;
      ReservationSourceId = other.reservationSourceId_ != null ? other.ReservationSourceId.Clone() : null;
      TravelAgent = other.travelAgent_ != null ? other.TravelAgent.Clone() : null;
      CancellationPolicy = other.cancellationPolicy_ != null ? other.CancellationPolicy.Clone() : null;
      groupName_ = other.groupName_;
      surpressRateInfo_ = other.surpressRateInfo_;
      taxCategory_ = other.taxCategory_;
      BookingProperty = other.bookingProperty_ != null ? other.BookingProperty.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroupBooking Clone() {
      return new GroupBooking(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::HOLMS.Types.Booking.Groups.GroupBookingStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Groups.GroupBookingStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "tax_exempt" field.</summary>
    public const int TaxExemptFieldNumber = 3;
    private bool taxExempt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TaxExempt {
      get { return taxExempt_; }
      set {
        taxExempt_ = value;
      }
    }

    /// <summary>Field number for the "tax_id" field.</summary>
    public const int TaxIdFieldNumber = 4;
    private string taxId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TaxId {
      get { return taxId_; }
      set {
        taxId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "group_pays_lodging" field.</summary>
    public const int GroupPaysLodgingFieldNumber = 5;
    private bool groupPaysLodging_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GroupPaysLodging {
      get { return groupPaysLodging_; }
      set {
        groupPaysLodging_ = value;
      }
    }

    /// <summary>Field number for the "group_pays_incidentals" field.</summary>
    public const int GroupPaysIncidentalsFieldNumber = 6;
    private bool groupPaysIncidentals_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool GroupPaysIncidentals {
      get { return groupPaysIncidentals_; }
      set {
        groupPaysIncidentals_ = value;
      }
    }

    /// <summary>Field number for the "additional_notes" field.</summary>
    public const int AdditionalNotesFieldNumber = 7;
    private string additionalNotes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdditionalNotes {
      get { return additionalNotes_; }
      set {
        additionalNotes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customer_booking_id" field.</summary>
    public const int CustomerBookingIdFieldNumber = 8;
    private string customerBookingId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerBookingId {
      get { return customerBookingId_; }
      set {
        customerBookingId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 9;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    /// <summary>Field number for the "rate_schedule" field.</summary>
    public const int RateScheduleFieldNumber = 11;
    private global::HOLMS.Types.Supply.RateScheduleIndicator rateSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RateScheduleIndicator RateSchedule {
      get { return rateSchedule_; }
      set {
        rateSchedule_ = value;
      }
    }

    /// <summary>Field number for the "group" field.</summary>
    public const int GroupFieldNumber = 12;
    private global::HOLMS.Types.CRM.Groups.GroupIndicator group_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Groups.GroupIndicator Group {
      get { return group_; }
      set {
        group_ = value;
      }
    }

    /// <summary>Field number for the "confirmation_template_id" field.</summary>
    public const int ConfirmationTemplateIdFieldNumber = 13;
    private global::HOLMS.Types.Primitive.Uuid confirmationTemplateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid ConfirmationTemplateId {
      get { return confirmationTemplateId_; }
      set {
        confirmationTemplateId_ = value;
      }
    }

    /// <summary>Field number for the "booking_method" field.</summary>
    public const int BookingMethodFieldNumber = 14;
    private global::HOLMS.Types.TenancyConfig.Indicators.GroupBookingMethodIndicator bookingMethod_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.GroupBookingMethodIndicator BookingMethod {
      get { return bookingMethod_; }
      set {
        bookingMethod_ = value;
      }
    }

    /// <summary>Field number for the "arrival_template_id" field.</summary>
    public const int ArrivalTemplateIdFieldNumber = 15;
    private global::HOLMS.Types.Primitive.Uuid arrivalTemplateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid ArrivalTemplateId {
      get { return arrivalTemplateId_; }
      set {
        arrivalTemplateId_ = value;
      }
    }

    /// <summary>Field number for the "reservation_source_id" field.</summary>
    public const int ReservationSourceIdFieldNumber = 16;
    private global::HOLMS.Types.Primitive.Uuid reservationSourceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid ReservationSourceId {
      get { return reservationSourceId_; }
      set {
        reservationSourceId_ = value;
      }
    }

    /// <summary>Field number for the "travel_agent" field.</summary>
    public const int TravelAgentFieldNumber = 17;
    private global::HOLMS.Types.Booking.Indicators.TravelAgentIndicator travelAgent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.TravelAgentIndicator TravelAgent {
      get { return travelAgent_; }
      set {
        travelAgent_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_policy" field.</summary>
    public const int CancellationPolicyFieldNumber = 18;
    private global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator cancellationPolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator CancellationPolicy {
      get { return cancellationPolicy_; }
      set {
        cancellationPolicy_ = value;
      }
    }

    /// <summary>Field number for the "group_name" field.</summary>
    public const int GroupNameFieldNumber = 19;
    private string groupName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GroupName {
      get { return groupName_; }
      set {
        groupName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "surpress_rate_info" field.</summary>
    public const int SurpressRateInfoFieldNumber = 20;
    private bool surpressRateInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SurpressRateInfo {
      get { return surpressRateInfo_; }
      set {
        surpressRateInfo_ = value;
      }
    }

    /// <summary>Field number for the "tax_category" field.</summary>
    public const int TaxCategoryFieldNumber = 21;
    private string taxCategory_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TaxCategory {
      get { return taxCategory_; }
      set {
        taxCategory_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "booking_property" field.</summary>
    public const int BookingPropertyFieldNumber = 22;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator bookingProperty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator BookingProperty {
      get { return bookingProperty_; }
      set {
        bookingProperty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroupBooking);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroupBooking other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Status != other.Status) return false;
      if (TaxExempt != other.TaxExempt) return false;
      if (TaxId != other.TaxId) return false;
      if (GroupPaysLodging != other.GroupPaysLodging) return false;
      if (GroupPaysIncidentals != other.GroupPaysIncidentals) return false;
      if (AdditionalNotes != other.AdditionalNotes) return false;
      if (CustomerBookingId != other.CustomerBookingId) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (!object.Equals(RateSchedule, other.RateSchedule)) return false;
      if (!object.Equals(Group, other.Group)) return false;
      if (!object.Equals(ConfirmationTemplateId, other.ConfirmationTemplateId)) return false;
      if (!object.Equals(BookingMethod, other.BookingMethod)) return false;
      if (!object.Equals(ArrivalTemplateId, other.ArrivalTemplateId)) return false;
      if (!object.Equals(ReservationSourceId, other.ReservationSourceId)) return false;
      if (!object.Equals(TravelAgent, other.TravelAgent)) return false;
      if (!object.Equals(CancellationPolicy, other.CancellationPolicy)) return false;
      if (GroupName != other.GroupName) return false;
      if (SurpressRateInfo != other.SurpressRateInfo) return false;
      if (TaxCategory != other.TaxCategory) return false;
      if (!object.Equals(BookingProperty, other.BookingProperty)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (TaxExempt != false) hash ^= TaxExempt.GetHashCode();
      if (TaxId.Length != 0) hash ^= TaxId.GetHashCode();
      if (GroupPaysLodging != false) hash ^= GroupPaysLodging.GetHashCode();
      if (GroupPaysIncidentals != false) hash ^= GroupPaysIncidentals.GetHashCode();
      if (AdditionalNotes.Length != 0) hash ^= AdditionalNotes.GetHashCode();
      if (CustomerBookingId.Length != 0) hash ^= CustomerBookingId.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      if (rateSchedule_ != null) hash ^= RateSchedule.GetHashCode();
      if (group_ != null) hash ^= Group.GetHashCode();
      if (confirmationTemplateId_ != null) hash ^= ConfirmationTemplateId.GetHashCode();
      if (bookingMethod_ != null) hash ^= BookingMethod.GetHashCode();
      if (arrivalTemplateId_ != null) hash ^= ArrivalTemplateId.GetHashCode();
      if (reservationSourceId_ != null) hash ^= ReservationSourceId.GetHashCode();
      if (travelAgent_ != null) hash ^= TravelAgent.GetHashCode();
      if (cancellationPolicy_ != null) hash ^= CancellationPolicy.GetHashCode();
      if (GroupName.Length != 0) hash ^= GroupName.GetHashCode();
      if (SurpressRateInfo != false) hash ^= SurpressRateInfo.GetHashCode();
      if (TaxCategory.Length != 0) hash ^= TaxCategory.GetHashCode();
      if (bookingProperty_ != null) hash ^= BookingProperty.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (entityId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EntityId);
      }
      if (Status != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (TaxExempt != false) {
        output.WriteRawTag(24);
        output.WriteBool(TaxExempt);
      }
      if (TaxId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TaxId);
      }
      if (GroupPaysLodging != false) {
        output.WriteRawTag(40);
        output.WriteBool(GroupPaysLodging);
      }
      if (GroupPaysIncidentals != false) {
        output.WriteRawTag(48);
        output.WriteBool(GroupPaysIncidentals);
      }
      if (AdditionalNotes.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(AdditionalNotes);
      }
      if (CustomerBookingId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(CustomerBookingId);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(DateRange);
      }
      if (rateSchedule_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RateSchedule);
      }
      if (group_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Group);
      }
      if (confirmationTemplateId_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ConfirmationTemplateId);
      }
      if (bookingMethod_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(BookingMethod);
      }
      if (arrivalTemplateId_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(ArrivalTemplateId);
      }
      if (reservationSourceId_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(ReservationSourceId);
      }
      if (travelAgent_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(TravelAgent);
      }
      if (cancellationPolicy_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(CancellationPolicy);
      }
      if (GroupName.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(GroupName);
      }
      if (SurpressRateInfo != false) {
        output.WriteRawTag(160, 1);
        output.WriteBool(SurpressRateInfo);
      }
      if (TaxCategory.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(TaxCategory);
      }
      if (bookingProperty_ != null) {
        output.WriteRawTag(178, 1);
        output.WriteMessage(BookingProperty);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (TaxExempt != false) {
        size += 1 + 1;
      }
      if (TaxId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TaxId);
      }
      if (GroupPaysLodging != false) {
        size += 1 + 1;
      }
      if (GroupPaysIncidentals != false) {
        size += 1 + 1;
      }
      if (AdditionalNotes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdditionalNotes);
      }
      if (CustomerBookingId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerBookingId);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (rateSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RateSchedule);
      }
      if (group_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Group);
      }
      if (confirmationTemplateId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConfirmationTemplateId);
      }
      if (bookingMethod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BookingMethod);
      }
      if (arrivalTemplateId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ArrivalTemplateId);
      }
      if (reservationSourceId_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ReservationSourceId);
      }
      if (travelAgent_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TravelAgent);
      }
      if (cancellationPolicy_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CancellationPolicy);
      }
      if (GroupName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(GroupName);
      }
      if (SurpressRateInfo != false) {
        size += 2 + 1;
      }
      if (TaxCategory.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TaxCategory);
      }
      if (bookingProperty_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BookingProperty);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroupBooking other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.TaxExempt != false) {
        TaxExempt = other.TaxExempt;
      }
      if (other.TaxId.Length != 0) {
        TaxId = other.TaxId;
      }
      if (other.GroupPaysLodging != false) {
        GroupPaysLodging = other.GroupPaysLodging;
      }
      if (other.GroupPaysIncidentals != false) {
        GroupPaysIncidentals = other.GroupPaysIncidentals;
      }
      if (other.AdditionalNotes.Length != 0) {
        AdditionalNotes = other.AdditionalNotes;
      }
      if (other.CustomerBookingId.Length != 0) {
        CustomerBookingId = other.CustomerBookingId;
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
      }
      if (other.rateSchedule_ != null) {
        if (rateSchedule_ == null) {
          rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
        }
        RateSchedule.MergeFrom(other.RateSchedule);
      }
      if (other.group_ != null) {
        if (group_ == null) {
          group_ = new global::HOLMS.Types.CRM.Groups.GroupIndicator();
        }
        Group.MergeFrom(other.Group);
      }
      if (other.confirmationTemplateId_ != null) {
        if (confirmationTemplateId_ == null) {
          confirmationTemplateId_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        ConfirmationTemplateId.MergeFrom(other.ConfirmationTemplateId);
      }
      if (other.bookingMethod_ != null) {
        if (bookingMethod_ == null) {
          bookingMethod_ = new global::HOLMS.Types.TenancyConfig.Indicators.GroupBookingMethodIndicator();
        }
        BookingMethod.MergeFrom(other.BookingMethod);
      }
      if (other.arrivalTemplateId_ != null) {
        if (arrivalTemplateId_ == null) {
          arrivalTemplateId_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        ArrivalTemplateId.MergeFrom(other.ArrivalTemplateId);
      }
      if (other.reservationSourceId_ != null) {
        if (reservationSourceId_ == null) {
          reservationSourceId_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        ReservationSourceId.MergeFrom(other.ReservationSourceId);
      }
      if (other.travelAgent_ != null) {
        if (travelAgent_ == null) {
          travelAgent_ = new global::HOLMS.Types.Booking.Indicators.TravelAgentIndicator();
        }
        TravelAgent.MergeFrom(other.TravelAgent);
      }
      if (other.cancellationPolicy_ != null) {
        if (cancellationPolicy_ == null) {
          cancellationPolicy_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
        }
        CancellationPolicy.MergeFrom(other.CancellationPolicy);
      }
      if (other.GroupName.Length != 0) {
        GroupName = other.GroupName;
      }
      if (other.SurpressRateInfo != false) {
        SurpressRateInfo = other.SurpressRateInfo;
      }
      if (other.TaxCategory.Length != 0) {
        TaxCategory = other.TaxCategory;
      }
      if (other.bookingProperty_ != null) {
        if (bookingProperty_ == null) {
          bookingProperty_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        BookingProperty.MergeFrom(other.BookingProperty);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 16: {
            status_ = (global::HOLMS.Types.Booking.Groups.GroupBookingStatus) input.ReadEnum();
            break;
          }
          case 24: {
            TaxExempt = input.ReadBool();
            break;
          }
          case 34: {
            TaxId = input.ReadString();
            break;
          }
          case 40: {
            GroupPaysLodging = input.ReadBool();
            break;
          }
          case 48: {
            GroupPaysIncidentals = input.ReadBool();
            break;
          }
          case 58: {
            AdditionalNotes = input.ReadString();
            break;
          }
          case 66: {
            CustomerBookingId = input.ReadString();
            break;
          }
          case 74: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
          case 90: {
            if (rateSchedule_ == null) {
              rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
            }
            input.ReadMessage(rateSchedule_);
            break;
          }
          case 98: {
            if (group_ == null) {
              group_ = new global::HOLMS.Types.CRM.Groups.GroupIndicator();
            }
            input.ReadMessage(group_);
            break;
          }
          case 106: {
            if (confirmationTemplateId_ == null) {
              confirmationTemplateId_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(confirmationTemplateId_);
            break;
          }
          case 114: {
            if (bookingMethod_ == null) {
              bookingMethod_ = new global::HOLMS.Types.TenancyConfig.Indicators.GroupBookingMethodIndicator();
            }
            input.ReadMessage(bookingMethod_);
            break;
          }
          case 122: {
            if (arrivalTemplateId_ == null) {
              arrivalTemplateId_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(arrivalTemplateId_);
            break;
          }
          case 130: {
            if (reservationSourceId_ == null) {
              reservationSourceId_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(reservationSourceId_);
            break;
          }
          case 138: {
            if (travelAgent_ == null) {
              travelAgent_ = new global::HOLMS.Types.Booking.Indicators.TravelAgentIndicator();
            }
            input.ReadMessage(travelAgent_);
            break;
          }
          case 146: {
            if (cancellationPolicy_ == null) {
              cancellationPolicy_ = new global::HOLMS.Types.Booking.Indicators.CancellationPolicyIndicator();
            }
            input.ReadMessage(cancellationPolicy_);
            break;
          }
          case 154: {
            GroupName = input.ReadString();
            break;
          }
          case 160: {
            SurpressRateInfo = input.ReadBool();
            break;
          }
          case 170: {
            TaxCategory = input.ReadString();
            break;
          }
          case 178: {
            if (bookingProperty_ == null) {
              bookingProperty_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(bookingProperty_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
