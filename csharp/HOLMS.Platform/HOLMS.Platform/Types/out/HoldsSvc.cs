// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/rpc/holds_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.RPC {

  /// <summary>Holder for reflection information generated from supply/rpc/holds_svc.proto</summary>
  public static partial class HoldsSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/rpc/holds_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HoldsSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpzdXBwbHkvcnBjL2hvbGRzX3N2Yy5wcm90bxIWaG9sbXMudHlwZXMuc3Vw",
            "cGx5LnJwYxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvGjBib29raW5n",
            "L2luZGljYXRvcnMvZ3JvdXBfYm9va2luZ19pbmRpY2F0b3IucHJvdG8aH3N1",
            "cHBseS9ncm91cF9ib29raW5nX2hvbGQucHJvdG8aHHN1cHBseS9ob2xkX2Fk",
            "anVzdG1lbnQucHJvdG8aJ3N1cHBseS9tYWludGVuYW5jZV9ob2xkX2luZGlj",
            "YXRvci5wcm90byJkCiRIb2xkc1N2Y0FkanVzdE1hbmFnZW1lbnRIb2xkc1Jl",
            "cXVlc3QSPAoQaG9sZF9hZGp1c3RtZW50cxgCIAMoCzIiLmhvbG1zLnR5cGVz",
            "LnN1cHBseS5Ib2xkQWRqdXN0bWVudCJpCiRIb2xkc1N2Y0dldEdyb3VwQm9v",
            "a2luZ0hvbGRzUmVzcG9uc2USQQoTZ3JvdXBfYm9va2luZ19ob2xkcxgBIAMo",
            "CzIkLmhvbG1zLnR5cGVzLnN1cHBseS5Hcm91cEJvb2tpbmdIb2xkIrwBCiVI",
            "b2xkc1N2Y0NyZWF0ZU1haW50ZW5hbmNlSG9sZFJlc3BvbnNlEksKBnJlc3Vs",
            "dBgBIAEoDjI7LmhvbG1zLnR5cGVzLnN1cHBseS5ycGMuSG9sZHNTdmNDcmVh",
            "dGVNYWludGVuYW5jZUhvbGRSZXN1bHQSRgoQbWFpbnRlbmFuY2VfaG9sZBgC",
            "IAEoCzIsLmhvbG1zLnR5cGVzLnN1cHBseS5NYWludGVuYW5jZUhvbGRJbmRp",
            "Y2F0b3IivAEKJUhvbGRzU3ZjVXBkYXRlTWFpbnRlbmFuY2VIb2xkUmVzcG9u",
            "c2USSwoGcmVzdWx0GAEgASgOMjsuaG9sbXMudHlwZXMuc3VwcGx5LnJwYy5I",
            "b2xkc1N2Y1VwZGF0ZU1haW50ZW5hbmNlSG9sZFJlc3VsdBJGChBtYWludGVu",
            "YW5jZV9ob2xkGAIgASgLMiwuaG9sbXMudHlwZXMuc3VwcGx5Lk1haW50ZW5h",
            "bmNlSG9sZEluZGljYXRvciK8AQolSG9sZHNTdmNEZWxldGVNYWludGVuYW5j",
            "ZUhvbGRSZXNwb25zZRJLCgZyZXN1bHQYASABKA4yOy5ob2xtcy50eXBlcy5z",
            "dXBwbHkucnBjLkhvbGRzU3ZjRGVsZXRlTWFpbnRlbmFuY2VIb2xkUmVzdWx0",
            "EkYKEG1haW50ZW5hbmNlX2hvbGQYAyABKAsyLC5ob2xtcy50eXBlcy5zdXBw",
            "bHkuTWFpbnRlbmFuY2VIb2xkSW5kaWNhdG9yKqgBCiNIb2xkc1N2Y0NyZWF0",
            "ZU1haW50ZW5hbmNlSG9sZFJlc3VsdBIjCh9DUkVBVEVfTUFJTlRFTkFOQ0Vf",
            "SE9MRF9TVUNDRVNTEAASLworQ1JFQVRFX01BSU5URU5BTkNFX0hPTERfUk9P",
            "TV9UWVBFX05PVF9GT1VORBABEisKJ0NSRUFURV9NQUlOVEVOQU5DRV9IT0xE",
            "X05PX0FWQUlMQUJJTElUWRACKtIBCiNIb2xkc1N2Y1VwZGF0ZU1haW50ZW5h",
            "bmNlSG9sZFJlc3VsdBIjCh9VUERBVEVfTUFJTlRFTkFOQ0VfSE9MRF9TVUND",
            "RVNTEAASKAokVVBEQVRFX01BSU5URU5BTkNFX0hPTERfTUlTU0lOR19IT0xE",
            "EAESLworVVBEQVRFX01BSU5URU5BTkNFX0hPTERfUk9PTV9UWVBFX05PVF9G",
            "T1VORBACEisKJ1VQREFURV9NQUlOVEVOQU5DRV9IT0xEX05PX0FWQUlMQUJJ",
            "TElUWRADKnQKI0hvbGRzU3ZjRGVsZXRlTWFpbnRlbmFuY2VIb2xkUmVzdWx0",
            "EiMKH0RFTEVURV9NQUlOVEVOQU5DRV9IT0xEX1NVQ0NFU1MQABIoCiRERUxF",
            "VEVfTUFJTlRFTkFOQ0VfSE9MRF9NSVNTSU5HX0hPTEQQATKHAgoISG9sZHNT",
            "dmMSbQoVQWRqdXN0TWFuYWdlbWVudEhvbGRzEjwuaG9sbXMudHlwZXMuc3Vw",
            "cGx5LnJwYy5Ib2xkc1N2Y0FkanVzdE1hbmFnZW1lbnRIb2xkc1JlcXVlc3Qa",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHkSiwEKFEdldEdyb3VwQm9va2luZ0hv",
            "bGRzEjUuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLkdyb3VwQm9v",
            "a2luZ0luZGljYXRvcho8LmhvbG1zLnR5cGVzLnN1cHBseS5ycGMuSG9sZHNT",
            "dmNHZXRHcm91cEJvb2tpbmdIb2xkc1Jlc3BvbnNlQiVaCnN1cHBseS9ycGOq",
            "AhZIT0xNUy5UeXBlcy5TdXBwbHkuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.GroupBookingHoldReflection.Descriptor, global::HOLMS.Types.Supply.HoldAdjustmentReflection.Descriptor, global::HOLMS.Types.Supply.MaintenanceHoldIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcCreateMaintenanceHoldResult), typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcUpdateMaintenanceHoldResult), typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcDeleteMaintenanceHoldResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest), global::HOLMS.Types.Supply.RPC.HoldsSvcAdjustManagementHoldsRequest.Parser, new[]{ "HoldAdjustments" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse), global::HOLMS.Types.Supply.RPC.HoldsSvcGetGroupBookingHoldsResponse.Parser, new[]{ "GroupBookingHolds" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcCreateMaintenanceHoldResponse), global::HOLMS.Types.Supply.RPC.HoldsSvcCreateMaintenanceHoldResponse.Parser, new[]{ "Result", "MaintenanceHold" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcUpdateMaintenanceHoldResponse), global::HOLMS.Types.Supply.RPC.HoldsSvcUpdateMaintenanceHoldResponse.Parser, new[]{ "Result", "MaintenanceHold" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RPC.HoldsSvcDeleteMaintenanceHoldResponse), global::HOLMS.Types.Supply.RPC.HoldsSvcDeleteMaintenanceHoldResponse.Parser, new[]{ "Result", "MaintenanceHold" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum HoldsSvcCreateMaintenanceHoldResult {
    [pbr::OriginalName("CREATE_MAINTENANCE_HOLD_SUCCESS")] CreateMaintenanceHoldSuccess = 0,
    [pbr::OriginalName("CREATE_MAINTENANCE_HOLD_ROOM_TYPE_NOT_FOUND")] CreateMaintenanceHoldRoomTypeNotFound = 1,
    [pbr::OriginalName("CREATE_MAINTENANCE_HOLD_NO_AVAILABILITY")] CreateMaintenanceHoldNoAvailability = 2,
  }

  public enum HoldsSvcUpdateMaintenanceHoldResult {
    [pbr::OriginalName("UPDATE_MAINTENANCE_HOLD_SUCCESS")] UpdateMaintenanceHoldSuccess = 0,
    [pbr::OriginalName("UPDATE_MAINTENANCE_HOLD_MISSING_HOLD")] UpdateMaintenanceHoldMissingHold = 1,
    [pbr::OriginalName("UPDATE_MAINTENANCE_HOLD_ROOM_TYPE_NOT_FOUND")] UpdateMaintenanceHoldRoomTypeNotFound = 2,
    [pbr::OriginalName("UPDATE_MAINTENANCE_HOLD_NO_AVAILABILITY")] UpdateMaintenanceHoldNoAvailability = 3,
  }

  public enum HoldsSvcDeleteMaintenanceHoldResult {
    [pbr::OriginalName("DELETE_MAINTENANCE_HOLD_SUCCESS")] DeleteMaintenanceHoldSuccess = 0,
    [pbr::OriginalName("DELETE_MAINTENANCE_HOLD_MISSING_HOLD")] DeleteMaintenanceHoldMissingHold = 1,
  }

  #endregion

  #region Messages
  public sealed partial class HoldsSvcAdjustManagementHoldsRequest : pb::IMessage<HoldsSvcAdjustManagementHoldsRequest> {
    private static readonly pb::MessageParser<HoldsSvcAdjustManagementHoldsRequest> _parser = new pb::MessageParser<HoldsSvcAdjustManagementHoldsRequest>(() => new HoldsSvcAdjustManagementHoldsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HoldsSvcAdjustManagementHoldsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.HoldsSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcAdjustManagementHoldsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcAdjustManagementHoldsRequest(HoldsSvcAdjustManagementHoldsRequest other) : this() {
      holdAdjustments_ = other.holdAdjustments_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcAdjustManagementHoldsRequest Clone() {
      return new HoldsSvcAdjustManagementHoldsRequest(this);
    }

    /// <summary>Field number for the "hold_adjustments" field.</summary>
    public const int HoldAdjustmentsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.HoldAdjustment> _repeated_holdAdjustments_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Supply.HoldAdjustment.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.HoldAdjustment> holdAdjustments_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.HoldAdjustment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.HoldAdjustment> HoldAdjustments {
      get { return holdAdjustments_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HoldsSvcAdjustManagementHoldsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HoldsSvcAdjustManagementHoldsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!holdAdjustments_.Equals(other.holdAdjustments_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= holdAdjustments_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      holdAdjustments_.WriteTo(output, _repeated_holdAdjustments_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += holdAdjustments_.CalculateSize(_repeated_holdAdjustments_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HoldsSvcAdjustManagementHoldsRequest other) {
      if (other == null) {
        return;
      }
      holdAdjustments_.Add(other.holdAdjustments_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 18: {
            holdAdjustments_.AddEntriesFrom(input, _repeated_holdAdjustments_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class HoldsSvcGetGroupBookingHoldsResponse : pb::IMessage<HoldsSvcGetGroupBookingHoldsResponse> {
    private static readonly pb::MessageParser<HoldsSvcGetGroupBookingHoldsResponse> _parser = new pb::MessageParser<HoldsSvcGetGroupBookingHoldsResponse>(() => new HoldsSvcGetGroupBookingHoldsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HoldsSvcGetGroupBookingHoldsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.HoldsSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcGetGroupBookingHoldsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcGetGroupBookingHoldsResponse(HoldsSvcGetGroupBookingHoldsResponse other) : this() {
      groupBookingHolds_ = other.groupBookingHolds_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcGetGroupBookingHoldsResponse Clone() {
      return new HoldsSvcGetGroupBookingHoldsResponse(this);
    }

    /// <summary>Field number for the "group_booking_holds" field.</summary>
    public const int GroupBookingHoldsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.GroupBookingHold> _repeated_groupBookingHolds_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Supply.GroupBookingHold.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.GroupBookingHold> groupBookingHolds_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.GroupBookingHold>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.GroupBookingHold> GroupBookingHolds {
      get { return groupBookingHolds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HoldsSvcGetGroupBookingHoldsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HoldsSvcGetGroupBookingHoldsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!groupBookingHolds_.Equals(other.groupBookingHolds_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= groupBookingHolds_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      groupBookingHolds_.WriteTo(output, _repeated_groupBookingHolds_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += groupBookingHolds_.CalculateSize(_repeated_groupBookingHolds_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HoldsSvcGetGroupBookingHoldsResponse other) {
      if (other == null) {
        return;
      }
      groupBookingHolds_.Add(other.groupBookingHolds_);
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
            groupBookingHolds_.AddEntriesFrom(input, _repeated_groupBookingHolds_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class HoldsSvcCreateMaintenanceHoldResponse : pb::IMessage<HoldsSvcCreateMaintenanceHoldResponse> {
    private static readonly pb::MessageParser<HoldsSvcCreateMaintenanceHoldResponse> _parser = new pb::MessageParser<HoldsSvcCreateMaintenanceHoldResponse>(() => new HoldsSvcCreateMaintenanceHoldResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HoldsSvcCreateMaintenanceHoldResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.HoldsSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcCreateMaintenanceHoldResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcCreateMaintenanceHoldResponse(HoldsSvcCreateMaintenanceHoldResponse other) : this() {
      result_ = other.result_;
      MaintenanceHold = other.maintenanceHold_ != null ? other.MaintenanceHold.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcCreateMaintenanceHoldResponse Clone() {
      return new HoldsSvcCreateMaintenanceHoldResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Supply.RPC.HoldsSvcCreateMaintenanceHoldResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RPC.HoldsSvcCreateMaintenanceHoldResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "maintenance_hold" field.</summary>
    public const int MaintenanceHoldFieldNumber = 2;
    private global::HOLMS.Types.Supply.MaintenanceHoldIndicator maintenanceHold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.MaintenanceHoldIndicator MaintenanceHold {
      get { return maintenanceHold_; }
      set {
        maintenanceHold_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HoldsSvcCreateMaintenanceHoldResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HoldsSvcCreateMaintenanceHoldResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(MaintenanceHold, other.MaintenanceHold)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (maintenanceHold_ != null) hash ^= MaintenanceHold.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (maintenanceHold_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MaintenanceHold);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (maintenanceHold_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaintenanceHold);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HoldsSvcCreateMaintenanceHoldResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.maintenanceHold_ != null) {
        if (maintenanceHold_ == null) {
          maintenanceHold_ = new global::HOLMS.Types.Supply.MaintenanceHoldIndicator();
        }
        MaintenanceHold.MergeFrom(other.MaintenanceHold);
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
          case 8: {
            result_ = (global::HOLMS.Types.Supply.RPC.HoldsSvcCreateMaintenanceHoldResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (maintenanceHold_ == null) {
              maintenanceHold_ = new global::HOLMS.Types.Supply.MaintenanceHoldIndicator();
            }
            input.ReadMessage(maintenanceHold_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class HoldsSvcUpdateMaintenanceHoldResponse : pb::IMessage<HoldsSvcUpdateMaintenanceHoldResponse> {
    private static readonly pb::MessageParser<HoldsSvcUpdateMaintenanceHoldResponse> _parser = new pb::MessageParser<HoldsSvcUpdateMaintenanceHoldResponse>(() => new HoldsSvcUpdateMaintenanceHoldResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HoldsSvcUpdateMaintenanceHoldResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.HoldsSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcUpdateMaintenanceHoldResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcUpdateMaintenanceHoldResponse(HoldsSvcUpdateMaintenanceHoldResponse other) : this() {
      result_ = other.result_;
      MaintenanceHold = other.maintenanceHold_ != null ? other.MaintenanceHold.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcUpdateMaintenanceHoldResponse Clone() {
      return new HoldsSvcUpdateMaintenanceHoldResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Supply.RPC.HoldsSvcUpdateMaintenanceHoldResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RPC.HoldsSvcUpdateMaintenanceHoldResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "maintenance_hold" field.</summary>
    public const int MaintenanceHoldFieldNumber = 2;
    private global::HOLMS.Types.Supply.MaintenanceHoldIndicator maintenanceHold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.MaintenanceHoldIndicator MaintenanceHold {
      get { return maintenanceHold_; }
      set {
        maintenanceHold_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HoldsSvcUpdateMaintenanceHoldResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HoldsSvcUpdateMaintenanceHoldResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(MaintenanceHold, other.MaintenanceHold)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (maintenanceHold_ != null) hash ^= MaintenanceHold.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (maintenanceHold_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MaintenanceHold);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (maintenanceHold_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaintenanceHold);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HoldsSvcUpdateMaintenanceHoldResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.maintenanceHold_ != null) {
        if (maintenanceHold_ == null) {
          maintenanceHold_ = new global::HOLMS.Types.Supply.MaintenanceHoldIndicator();
        }
        MaintenanceHold.MergeFrom(other.MaintenanceHold);
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
          case 8: {
            result_ = (global::HOLMS.Types.Supply.RPC.HoldsSvcUpdateMaintenanceHoldResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (maintenanceHold_ == null) {
              maintenanceHold_ = new global::HOLMS.Types.Supply.MaintenanceHoldIndicator();
            }
            input.ReadMessage(maintenanceHold_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class HoldsSvcDeleteMaintenanceHoldResponse : pb::IMessage<HoldsSvcDeleteMaintenanceHoldResponse> {
    private static readonly pb::MessageParser<HoldsSvcDeleteMaintenanceHoldResponse> _parser = new pb::MessageParser<HoldsSvcDeleteMaintenanceHoldResponse>(() => new HoldsSvcDeleteMaintenanceHoldResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HoldsSvcDeleteMaintenanceHoldResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RPC.HoldsSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcDeleteMaintenanceHoldResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcDeleteMaintenanceHoldResponse(HoldsSvcDeleteMaintenanceHoldResponse other) : this() {
      result_ = other.result_;
      MaintenanceHold = other.maintenanceHold_ != null ? other.MaintenanceHold.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HoldsSvcDeleteMaintenanceHoldResponse Clone() {
      return new HoldsSvcDeleteMaintenanceHoldResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Supply.RPC.HoldsSvcDeleteMaintenanceHoldResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RPC.HoldsSvcDeleteMaintenanceHoldResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "maintenance_hold" field.</summary>
    public const int MaintenanceHoldFieldNumber = 3;
    private global::HOLMS.Types.Supply.MaintenanceHoldIndicator maintenanceHold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.MaintenanceHoldIndicator MaintenanceHold {
      get { return maintenanceHold_; }
      set {
        maintenanceHold_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HoldsSvcDeleteMaintenanceHoldResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HoldsSvcDeleteMaintenanceHoldResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(MaintenanceHold, other.MaintenanceHold)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (maintenanceHold_ != null) hash ^= MaintenanceHold.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (maintenanceHold_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MaintenanceHold);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (maintenanceHold_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaintenanceHold);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HoldsSvcDeleteMaintenanceHoldResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.maintenanceHold_ != null) {
        if (maintenanceHold_ == null) {
          maintenanceHold_ = new global::HOLMS.Types.Supply.MaintenanceHoldIndicator();
        }
        MaintenanceHold.MergeFrom(other.MaintenanceHold);
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
          case 8: {
            result_ = (global::HOLMS.Types.Supply.RPC.HoldsSvcDeleteMaintenanceHoldResult) input.ReadEnum();
            break;
          }
          case 26: {
            if (maintenanceHold_ == null) {
              maintenanceHold_ = new global::HOLMS.Types.Supply.MaintenanceHoldIndicator();
            }
            input.ReadMessage(maintenanceHold_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
