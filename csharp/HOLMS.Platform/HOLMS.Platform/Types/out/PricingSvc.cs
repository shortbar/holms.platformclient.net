// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/rpc/pricing_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.RPC {

  /// <summary>Holder for reflection information generated from supply/rpc/pricing_svc.proto</summary>
  public static partial class PricingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/rpc/pricing_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PricingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxzdXBwbHkvcnBjL3ByaWNpbmdfc3ZjLnByb3RvEhZob2xtcy50eXBlcy5z",
            "dXBwbHkucnBjGipwcmltaXRpdmUvcGJfaW5jbHVzaXZlX29wc2RhdGVfcmFu",
            "Z2UucHJvdG8aK3N1cHBseS9yb29tX3R5cGVzL3Jvb21fdHlwZV9pbmRpY2F0",
            "b3IucHJvdG8aIXN1cHBseS9wcmljZV91cGRhdGVfcmVxdWVzdC5wcm90bxok",
            "c3VwcGx5L3JhdGVfc2NoZWR1bGVfaW5kaWNhdG9yLnByb3RvGhxzdXBwbHkv",
            "c2NoZWR1bGVkX3ByaWNlLnByb3RvGjJ0ZW5hbmN5X2NvbmZpZy9pbmRpY2F0",
            "b3JzL3Byb3BlcnR5X2luZGljYXRvci5wcm90byLsAQoeUHJpY2luZ1N2Y1Jv",
            "b21UeXBlUXVlcnlSZXF1ZXN0EkAKDXJhdGVfc2NoZWR1bGUYASABKAsyKS5o",
            "b2xtcy50eXBlcy5zdXBwbHkuUmF0ZVNjaGVkdWxlSW5kaWNhdG9yEkQKCnJv",
            "b21fdHlwZXMYAiADKAsyMC5ob2xtcy50eXBlcy5zdXBwbHkucm9vbV90eXBl",
            "cy5Sb29tVHlwZUluZGljYXRvchJCCgpkYXRlX3JhbmdlGAMgASgLMi4uaG9s",
            "bXMudHlwZXMucHJpbWl0aXZlLlBiSW5jbHVzaXZlT3BzZGF0ZVJhbmdlIvIB",
            "Ch5QcmljaW5nU3ZjUHJvcGVydHlRdWVyeVJlcXVlc3QSQAoNcmF0ZV9zY2hl",
            "ZHVsZRgBIAEoCzIpLmhvbG1zLnR5cGVzLnN1cHBseS5SYXRlU2NoZWR1bGVJ",
            "bmRpY2F0b3ISSgoIcHJvcGVydHkYAiABKAsyOC5ob2xtcy50eXBlcy50ZW5h",
            "bmN5X2NvbmZpZy5pbmRpY2F0b3JzLlByb3BlcnR5SW5kaWNhdG9yEkIKCmRh",
            "dGVfcmFuZ2UYAyABKAsyLi5ob2xtcy50eXBlcy5wcmltaXRpdmUuUGJJbmNs",
            "dXNpdmVPcHNkYXRlUmFuZ2UirQEKJVByaWNpbmdTdmNXaXRob3V0UHJvcGVy",
            "dHlRdWVyeVJlcXVlc3QSQAoNcmF0ZV9zY2hlZHVsZRgBIAEoCzIpLmhvbG1z",
            "LnR5cGVzLnN1cHBseS5SYXRlU2NoZWR1bGVJbmRpY2F0b3ISQgoKZGF0ZV9y",
            "YW5nZRgCIAEoCzIuLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5QYkluY2x1c2l2",
            "ZU9wc2RhdGVSYW5nZSJNChdQcmljaW5nU3ZjUXVlcnlSZXNwb25zZRIyCgZw",
            "cmljZXMYASADKAsyIi5ob2xtcy50eXBlcy5zdXBwbHkuU2NoZWR1bGVkUHJp",
            "Y2UimgEKF1ByaWNpbmdTdmNVcGRhdGVSZXF1ZXN0EkAKDXJhdGVfc2NoZWR1",
            "bGUYASABKAsyKS5ob2xtcy50eXBlcy5zdXBwbHkuUmF0ZVNjaGVkdWxlSW5k",
            "aWNhdG9yEj0KDXByaWNlX3VwZGF0ZXMYAiADKAsyJi5ob2xtcy50eXBlcy5z",
            "dXBwbHkuUHJpY2VVcGRhdGVSZXF1ZXN0IjYKHVByaWNpbmdTdmNDaGFubmVs",
            "UnVzaFJlc3BvbnNlEhUKDUVycm9yTWVzc2FnZXMYASADKAkygQQKClByaWNp",
            "bmdTdmMSegoPUXVlcnlCeVJvb21UeXBlEjYuaG9sbXMudHlwZXMuc3VwcGx5",
            "LnJwYy5QcmljaW5nU3ZjUm9vbVR5cGVRdWVyeVJlcXVlc3QaLy5ob2xtcy50",
            "eXBlcy5zdXBwbHkucnBjLlByaWNpbmdTdmNRdWVyeVJlc3BvbnNlEnoKD1F1",
            "ZXJ5QnlQcm9wZXJ0eRI2LmhvbG1zLnR5cGVzLnN1cHBseS5ycGMuUHJpY2lu",
            "Z1N2Y1Byb3BlcnR5UXVlcnlSZXF1ZXN0Gi8uaG9sbXMudHlwZXMuc3VwcGx5",
            "LnJwYy5QcmljaW5nU3ZjUXVlcnlSZXNwb25zZRJwCgZVcGRhdGUSLy5ob2xt",
            "cy50eXBlcy5zdXBwbHkucnBjLlByaWNpbmdTdmNVcGRhdGVSZXF1ZXN0GjUu",
            "aG9sbXMudHlwZXMuc3VwcGx5LnJwYy5QcmljaW5nU3ZjQ2hhbm5lbFJ1c2hS",
            "ZXNwb25zZRKIAQoWUXVlcnlCeVdpdGhvdXRQcm9wZXJ0eRI9LmhvbG1zLnR5",
            "cGVzLnN1cHBseS5ycGMuUHJpY2luZ1N2Y1dpdGhvdXRQcm9wZXJ0eVF1ZXJ5",
            "UmVxdWVzdBovLmhvbG1zLnR5cGVzLnN1cHBseS5ycGMuUHJpY2luZ1N2Y1F1",
            "ZXJ5UmVzcG9uc2VCJVoKc3VwcGx5L3JwY6oCFkhPTE1TLlR5cGVzLlN1cHBs",
            "eS5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.PriceUpdateRequestReflection.Descriptor, global::HOLMS.Types.Supply.RateScheduleIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.ScheduledPriceReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingSvcRoomTypeQueryRequest), global::HOLMS.Types.Supply.RPC.PricingSvcRoomTypeQueryRequest.Parser, new[]{ "RateSchedule", "RoomTypes", "DateRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingSvcPropertyQueryRequest), global::HOLMS.Types.Supply.RPC.PricingSvcPropertyQueryRequest.Parser, new[]{ "RateSchedule", "Property", "DateRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingSvcWithoutPropertyQueryRequest), global::HOLMS.Types.Supply.RPC.PricingSvcWithoutPropertyQueryRequest.Parser, new[]{ "RateSchedule", "DateRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingSvcQueryResponse), global::HOLMS.Types.Supply.RPC.PricingSvcQueryResponse.Parser, new[]{ "Prices" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingSvcUpdateRequest), global::HOLMS.Types.Supply.RPC.PricingSvcUpdateRequest.Parser, new[]{ "RateSchedule", "PriceUpdates" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.PricingSvcChannelRushResponse), global::HOLMS.Types.Supply.RPC.PricingSvcChannelRushResponse.Parser, new[]{ "ErrorMessages" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PricingSvcRoomTypeQueryRequest : pb::IMessage<PricingSvcRoomTypeQueryRequest> {
    private static readonly pb::MessageParser<PricingSvcRoomTypeQueryRequest> _parser = new pb::MessageParser<PricingSvcRoomTypeQueryRequest>(() => new PricingSvcRoomTypeQueryRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingSvcRoomTypeQueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcRoomTypeQueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcRoomTypeQueryRequest(PricingSvcRoomTypeQueryRequest other) : this() {
      RateSchedule = other.rateSchedule_ != null ? other.RateSchedule.Clone() : null;
      roomTypes_ = other.roomTypes_.Clone();
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcRoomTypeQueryRequest Clone() {
      return new PricingSvcRoomTypeQueryRequest(this);
    }

    /// <summary>Field number for the "rate_schedule" field.</summary>
    public const int RateScheduleFieldNumber = 1;
    private global::HOLMS.Types.Supply.RateScheduleIndicator rateSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RateScheduleIndicator RateSchedule {
      get { return rateSchedule_; }
      set {
        rateSchedule_ = value;
      }
    }

    /// <summary>Field number for the "room_types" field.</summary>
    public const int RoomTypesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator> _repeated_roomTypes_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator> roomTypes_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator> RoomTypes {
      get { return roomTypes_; }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingSvcRoomTypeQueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingSvcRoomTypeQueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RateSchedule, other.RateSchedule)) return false;
      if(!roomTypes_.Equals(other.roomTypes_)) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rateSchedule_ != null) hash ^= RateSchedule.GetHashCode();
      hash ^= roomTypes_.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (rateSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RateSchedule);
      }
      roomTypes_.WriteTo(output, _repeated_roomTypes_codec);
      if (dateRange_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DateRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rateSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RateSchedule);
      }
      size += roomTypes_.CalculateSize(_repeated_roomTypes_codec);
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingSvcRoomTypeQueryRequest other) {
      if (other == null) {
        return;
      }
      if (other.rateSchedule_ != null) {
        if (rateSchedule_ == null) {
          rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
        }
        RateSchedule.MergeFrom(other.RateSchedule);
      }
      roomTypes_.Add(other.roomTypes_);
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
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
            if (rateSchedule_ == null) {
              rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
            }
            input.ReadMessage(rateSchedule_);
            break;
          }
          case 18: {
            roomTypes_.AddEntriesFrom(input, _repeated_roomTypes_codec);
            break;
          }
          case 26: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PricingSvcPropertyQueryRequest : pb::IMessage<PricingSvcPropertyQueryRequest> {
    private static readonly pb::MessageParser<PricingSvcPropertyQueryRequest> _parser = new pb::MessageParser<PricingSvcPropertyQueryRequest>(() => new PricingSvcPropertyQueryRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingSvcPropertyQueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcPropertyQueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcPropertyQueryRequest(PricingSvcPropertyQueryRequest other) : this() {
      RateSchedule = other.rateSchedule_ != null ? other.RateSchedule.Clone() : null;
      Property = other.property_ != null ? other.Property.Clone() : null;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcPropertyQueryRequest Clone() {
      return new PricingSvcPropertyQueryRequest(this);
    }

    /// <summary>Field number for the "rate_schedule" field.</summary>
    public const int RateScheduleFieldNumber = 1;
    private global::HOLMS.Types.Supply.RateScheduleIndicator rateSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RateScheduleIndicator RateSchedule {
      get { return rateSchedule_; }
      set {
        rateSchedule_ = value;
      }
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 2;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingSvcPropertyQueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingSvcPropertyQueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RateSchedule, other.RateSchedule)) return false;
      if (!object.Equals(Property, other.Property)) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rateSchedule_ != null) hash ^= RateSchedule.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (rateSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RateSchedule);
      }
      if (property_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Property);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DateRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rateSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RateSchedule);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingSvcPropertyQueryRequest other) {
      if (other == null) {
        return;
      }
      if (other.rateSchedule_ != null) {
        if (rateSchedule_ == null) {
          rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
        }
        RateSchedule.MergeFrom(other.RateSchedule);
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
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
            if (rateSchedule_ == null) {
              rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
            }
            input.ReadMessage(rateSchedule_);
            break;
          }
          case 18: {
            if (property_ == null) {
              property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(property_);
            break;
          }
          case 26: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PricingSvcWithoutPropertyQueryRequest : pb::IMessage<PricingSvcWithoutPropertyQueryRequest> {
    private static readonly pb::MessageParser<PricingSvcWithoutPropertyQueryRequest> _parser = new pb::MessageParser<PricingSvcWithoutPropertyQueryRequest>(() => new PricingSvcWithoutPropertyQueryRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingSvcWithoutPropertyQueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcWithoutPropertyQueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcWithoutPropertyQueryRequest(PricingSvcWithoutPropertyQueryRequest other) : this() {
      RateSchedule = other.rateSchedule_ != null ? other.RateSchedule.Clone() : null;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcWithoutPropertyQueryRequest Clone() {
      return new PricingSvcWithoutPropertyQueryRequest(this);
    }

    /// <summary>Field number for the "rate_schedule" field.</summary>
    public const int RateScheduleFieldNumber = 1;
    private global::HOLMS.Types.Supply.RateScheduleIndicator rateSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RateScheduleIndicator RateSchedule {
      get { return rateSchedule_; }
      set {
        rateSchedule_ = value;
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 2;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingSvcWithoutPropertyQueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingSvcWithoutPropertyQueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RateSchedule, other.RateSchedule)) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rateSchedule_ != null) hash ^= RateSchedule.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (rateSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RateSchedule);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DateRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rateSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RateSchedule);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingSvcWithoutPropertyQueryRequest other) {
      if (other == null) {
        return;
      }
      if (other.rateSchedule_ != null) {
        if (rateSchedule_ == null) {
          rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
        }
        RateSchedule.MergeFrom(other.RateSchedule);
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
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
            if (rateSchedule_ == null) {
              rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
            }
            input.ReadMessage(rateSchedule_);
            break;
          }
          case 18: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PricingSvcQueryResponse : pb::IMessage<PricingSvcQueryResponse> {
    private static readonly pb::MessageParser<PricingSvcQueryResponse> _parser = new pb::MessageParser<PricingSvcQueryResponse>(() => new PricingSvcQueryResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingSvcQueryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcQueryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcQueryResponse(PricingSvcQueryResponse other) : this() {
      prices_ = other.prices_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcQueryResponse Clone() {
      return new PricingSvcQueryResponse(this);
    }

    /// <summary>Field number for the "prices" field.</summary>
    public const int PricesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.ScheduledPrice> _repeated_prices_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Supply.ScheduledPrice.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.ScheduledPrice> prices_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.ScheduledPrice>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.ScheduledPrice> Prices {
      get { return prices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingSvcQueryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingSvcQueryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!prices_.Equals(other.prices_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= prices_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      prices_.WriteTo(output, _repeated_prices_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += prices_.CalculateSize(_repeated_prices_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingSvcQueryResponse other) {
      if (other == null) {
        return;
      }
      prices_.Add(other.prices_);
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
            prices_.AddEntriesFrom(input, _repeated_prices_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PricingSvcUpdateRequest : pb::IMessage<PricingSvcUpdateRequest> {
    private static readonly pb::MessageParser<PricingSvcUpdateRequest> _parser = new pb::MessageParser<PricingSvcUpdateRequest>(() => new PricingSvcUpdateRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingSvcUpdateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcUpdateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcUpdateRequest(PricingSvcUpdateRequest other) : this() {
      RateSchedule = other.rateSchedule_ != null ? other.RateSchedule.Clone() : null;
      priceUpdates_ = other.priceUpdates_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcUpdateRequest Clone() {
      return new PricingSvcUpdateRequest(this);
    }

    /// <summary>Field number for the "rate_schedule" field.</summary>
    public const int RateScheduleFieldNumber = 1;
    private global::HOLMS.Types.Supply.RateScheduleIndicator rateSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RateScheduleIndicator RateSchedule {
      get { return rateSchedule_; }
      set {
        rateSchedule_ = value;
      }
    }

    /// <summary>Field number for the "price_updates" field.</summary>
    public const int PriceUpdatesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.PriceUpdateRequest> _repeated_priceUpdates_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Supply.PriceUpdateRequest.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.PriceUpdateRequest> priceUpdates_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.PriceUpdateRequest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.PriceUpdateRequest> PriceUpdates {
      get { return priceUpdates_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingSvcUpdateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingSvcUpdateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RateSchedule, other.RateSchedule)) return false;
      if(!priceUpdates_.Equals(other.priceUpdates_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rateSchedule_ != null) hash ^= RateSchedule.GetHashCode();
      hash ^= priceUpdates_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (rateSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RateSchedule);
      }
      priceUpdates_.WriteTo(output, _repeated_priceUpdates_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rateSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RateSchedule);
      }
      size += priceUpdates_.CalculateSize(_repeated_priceUpdates_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingSvcUpdateRequest other) {
      if (other == null) {
        return;
      }
      if (other.rateSchedule_ != null) {
        if (rateSchedule_ == null) {
          rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
        }
        RateSchedule.MergeFrom(other.RateSchedule);
      }
      priceUpdates_.Add(other.priceUpdates_);
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
            if (rateSchedule_ == null) {
              rateSchedule_ = new global::HOLMS.Types.Supply.RateScheduleIndicator();
            }
            input.ReadMessage(rateSchedule_);
            break;
          }
          case 18: {
            priceUpdates_.AddEntriesFrom(input, _repeated_priceUpdates_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PricingSvcChannelRushResponse : pb::IMessage<PricingSvcChannelRushResponse> {
    private static readonly pb::MessageParser<PricingSvcChannelRushResponse> _parser = new pb::MessageParser<PricingSvcChannelRushResponse>(() => new PricingSvcChannelRushResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricingSvcChannelRushResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.PricingSvcReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcChannelRushResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcChannelRushResponse(PricingSvcChannelRushResponse other) : this() {
      errorMessages_ = other.errorMessages_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricingSvcChannelRushResponse Clone() {
      return new PricingSvcChannelRushResponse(this);
    }

    /// <summary>Field number for the "ErrorMessages" field.</summary>
    public const int ErrorMessagesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_errorMessages_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> errorMessages_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ErrorMessages {
      get { return errorMessages_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricingSvcChannelRushResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricingSvcChannelRushResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!errorMessages_.Equals(other.errorMessages_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= errorMessages_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      errorMessages_.WriteTo(output, _repeated_errorMessages_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += errorMessages_.CalculateSize(_repeated_errorMessages_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PricingSvcChannelRushResponse other) {
      if (other == null) {
        return;
      }
      errorMessages_.Add(other.errorMessages_);
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
            errorMessages_.AddEntriesFrom(input, _repeated_errorMessages_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
