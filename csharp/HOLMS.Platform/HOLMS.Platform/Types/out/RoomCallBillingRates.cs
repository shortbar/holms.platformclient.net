// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/room_call_billing_rates.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/room_call_billing_rates.proto</summary>
  public static partial class RoomCallBillingRatesReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/room_call_billing_rates.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomCallBillingRatesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cix0ZW5hbmN5X2NvbmZpZy9yb29tX2NhbGxfYmlsbGluZ19yYXRlcy5wcm90",
            "bxIaaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcaHmdvb2dsZS9wcm90b2J1",
            "Zi9kdXJhdGlvbi5wcm90bxofcHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3VudC5w",
            "cm90byLoBQoUUm9vbUNhbGxCaWxsaW5nUmF0ZXMSOQoWZnJlZV9jYWxsX2dy",
            "YWNlX3BlcmlvZBgBIAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbhIX",
            "Cg9sb2NhbF9hcmVhX2NvZGUYAiABKAkSSAoZbG9jYWxfZmlyc3RfbWludXRl",
            "X2NoYXJnZRgDIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFy",
            "eUFtb3VudBJNCh5sb2NhbF9hZGRpdGlvbmFsX21pbnV0ZV9jaGFyZ2UYBCAB",
            "KAsyJS5ob2xtcy50eXBlcy5wcmltaXRpdmUuTW9uZXRhcnlBbW91bnQSUAoh",
            "bG9uZ19kaXN0YW5jZV9maXJzdF9taW51dGVfY2hhcmdlGAUgASgLMiUuaG9s",
            "bXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50ElUKJmxvbmdfZGlz",
            "dGFuY2VfYWRkaXRpb25hbF9taW51dGVfY2hhcmdlGAYgASgLMiUuaG9sbXMu",
            "dHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50ElAKIWludGVybmF0aW9u",
            "YWxfZmlyc3RfbWludXRlX2NoYXJnZRgHIAEoCzIlLmhvbG1zLnR5cGVzLnBy",
            "aW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJVCiZpbnRlcm5hdGlvbmFsX2FkZGl0",
            "aW9uYWxfbWludXRlX2NoYXJnZRgIIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5Nb25ldGFyeUFtb3VudBJCChN0b2xsX2ZyZWVfZmxhdF9yYXRlGAkg",
            "ASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50Ek0K",
            "HmRpcmVjdG9yeV9hc3Npc3RhbmNlX2ZsYXRfcmF0ZRgKIAEoCzIlLmhvbG1z",
            "LnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudEIrWg10ZW5hbmN5Y29u",
            "ZmlnqgIZSE9MTVMuVHlwZXMuVGVuYW5jeUNvbmZpZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.RoomCallBillingRates), global::HOLMS.Types.TenancyConfig.RoomCallBillingRates.Parser, new[]{ "FreeCallGracePeriod", "LocalAreaCode", "LocalFirstMinuteCharge", "LocalAdditionalMinuteCharge", "LongDistanceFirstMinuteCharge", "LongDistanceAdditionalMinuteCharge", "InternationalFirstMinuteCharge", "InternationalAdditionalMinuteCharge", "TollFreeFlatRate", "DirectoryAssistanceFlatRate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoomCallBillingRates : pb::IMessage<RoomCallBillingRates> {
    private static readonly pb::MessageParser<RoomCallBillingRates> _parser = new pb::MessageParser<RoomCallBillingRates>(() => new RoomCallBillingRates());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomCallBillingRates> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.RoomCallBillingRatesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomCallBillingRates() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomCallBillingRates(RoomCallBillingRates other) : this() {
      FreeCallGracePeriod = other.freeCallGracePeriod_ != null ? other.FreeCallGracePeriod.Clone() : null;
      localAreaCode_ = other.localAreaCode_;
      LocalFirstMinuteCharge = other.localFirstMinuteCharge_ != null ? other.LocalFirstMinuteCharge.Clone() : null;
      LocalAdditionalMinuteCharge = other.localAdditionalMinuteCharge_ != null ? other.LocalAdditionalMinuteCharge.Clone() : null;
      LongDistanceFirstMinuteCharge = other.longDistanceFirstMinuteCharge_ != null ? other.LongDistanceFirstMinuteCharge.Clone() : null;
      LongDistanceAdditionalMinuteCharge = other.longDistanceAdditionalMinuteCharge_ != null ? other.LongDistanceAdditionalMinuteCharge.Clone() : null;
      InternationalFirstMinuteCharge = other.internationalFirstMinuteCharge_ != null ? other.InternationalFirstMinuteCharge.Clone() : null;
      InternationalAdditionalMinuteCharge = other.internationalAdditionalMinuteCharge_ != null ? other.InternationalAdditionalMinuteCharge.Clone() : null;
      TollFreeFlatRate = other.tollFreeFlatRate_ != null ? other.TollFreeFlatRate.Clone() : null;
      DirectoryAssistanceFlatRate = other.directoryAssistanceFlatRate_ != null ? other.DirectoryAssistanceFlatRate.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomCallBillingRates Clone() {
      return new RoomCallBillingRates(this);
    }

    /// <summary>Field number for the "free_call_grace_period" field.</summary>
    public const int FreeCallGracePeriodFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration freeCallGracePeriod_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration FreeCallGracePeriod {
      get { return freeCallGracePeriod_; }
      set {
        freeCallGracePeriod_ = value;
      }
    }

    /// <summary>Field number for the "local_area_code" field.</summary>
    public const int LocalAreaCodeFieldNumber = 2;
    private string localAreaCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LocalAreaCode {
      get { return localAreaCode_; }
      set {
        localAreaCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "local_first_minute_charge" field.</summary>
    public const int LocalFirstMinuteChargeFieldNumber = 3;
    private global::HOLMS.Types.Primitive.MonetaryAmount localFirstMinuteCharge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount LocalFirstMinuteCharge {
      get { return localFirstMinuteCharge_; }
      set {
        localFirstMinuteCharge_ = value;
      }
    }

    /// <summary>Field number for the "local_additional_minute_charge" field.</summary>
    public const int LocalAdditionalMinuteChargeFieldNumber = 4;
    private global::HOLMS.Types.Primitive.MonetaryAmount localAdditionalMinuteCharge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount LocalAdditionalMinuteCharge {
      get { return localAdditionalMinuteCharge_; }
      set {
        localAdditionalMinuteCharge_ = value;
      }
    }

    /// <summary>Field number for the "long_distance_first_minute_charge" field.</summary>
    public const int LongDistanceFirstMinuteChargeFieldNumber = 5;
    private global::HOLMS.Types.Primitive.MonetaryAmount longDistanceFirstMinuteCharge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount LongDistanceFirstMinuteCharge {
      get { return longDistanceFirstMinuteCharge_; }
      set {
        longDistanceFirstMinuteCharge_ = value;
      }
    }

    /// <summary>Field number for the "long_distance_additional_minute_charge" field.</summary>
    public const int LongDistanceAdditionalMinuteChargeFieldNumber = 6;
    private global::HOLMS.Types.Primitive.MonetaryAmount longDistanceAdditionalMinuteCharge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount LongDistanceAdditionalMinuteCharge {
      get { return longDistanceAdditionalMinuteCharge_; }
      set {
        longDistanceAdditionalMinuteCharge_ = value;
      }
    }

    /// <summary>Field number for the "international_first_minute_charge" field.</summary>
    public const int InternationalFirstMinuteChargeFieldNumber = 7;
    private global::HOLMS.Types.Primitive.MonetaryAmount internationalFirstMinuteCharge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount InternationalFirstMinuteCharge {
      get { return internationalFirstMinuteCharge_; }
      set {
        internationalFirstMinuteCharge_ = value;
      }
    }

    /// <summary>Field number for the "international_additional_minute_charge" field.</summary>
    public const int InternationalAdditionalMinuteChargeFieldNumber = 8;
    private global::HOLMS.Types.Primitive.MonetaryAmount internationalAdditionalMinuteCharge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount InternationalAdditionalMinuteCharge {
      get { return internationalAdditionalMinuteCharge_; }
      set {
        internationalAdditionalMinuteCharge_ = value;
      }
    }

    /// <summary>Field number for the "toll_free_flat_rate" field.</summary>
    public const int TollFreeFlatRateFieldNumber = 9;
    private global::HOLMS.Types.Primitive.MonetaryAmount tollFreeFlatRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount TollFreeFlatRate {
      get { return tollFreeFlatRate_; }
      set {
        tollFreeFlatRate_ = value;
      }
    }

    /// <summary>Field number for the "directory_assistance_flat_rate" field.</summary>
    public const int DirectoryAssistanceFlatRateFieldNumber = 10;
    private global::HOLMS.Types.Primitive.MonetaryAmount directoryAssistanceFlatRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount DirectoryAssistanceFlatRate {
      get { return directoryAssistanceFlatRate_; }
      set {
        directoryAssistanceFlatRate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomCallBillingRates);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomCallBillingRates other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FreeCallGracePeriod, other.FreeCallGracePeriod)) return false;
      if (LocalAreaCode != other.LocalAreaCode) return false;
      if (!object.Equals(LocalFirstMinuteCharge, other.LocalFirstMinuteCharge)) return false;
      if (!object.Equals(LocalAdditionalMinuteCharge, other.LocalAdditionalMinuteCharge)) return false;
      if (!object.Equals(LongDistanceFirstMinuteCharge, other.LongDistanceFirstMinuteCharge)) return false;
      if (!object.Equals(LongDistanceAdditionalMinuteCharge, other.LongDistanceAdditionalMinuteCharge)) return false;
      if (!object.Equals(InternationalFirstMinuteCharge, other.InternationalFirstMinuteCharge)) return false;
      if (!object.Equals(InternationalAdditionalMinuteCharge, other.InternationalAdditionalMinuteCharge)) return false;
      if (!object.Equals(TollFreeFlatRate, other.TollFreeFlatRate)) return false;
      if (!object.Equals(DirectoryAssistanceFlatRate, other.DirectoryAssistanceFlatRate)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (freeCallGracePeriod_ != null) hash ^= FreeCallGracePeriod.GetHashCode();
      if (LocalAreaCode.Length != 0) hash ^= LocalAreaCode.GetHashCode();
      if (localFirstMinuteCharge_ != null) hash ^= LocalFirstMinuteCharge.GetHashCode();
      if (localAdditionalMinuteCharge_ != null) hash ^= LocalAdditionalMinuteCharge.GetHashCode();
      if (longDistanceFirstMinuteCharge_ != null) hash ^= LongDistanceFirstMinuteCharge.GetHashCode();
      if (longDistanceAdditionalMinuteCharge_ != null) hash ^= LongDistanceAdditionalMinuteCharge.GetHashCode();
      if (internationalFirstMinuteCharge_ != null) hash ^= InternationalFirstMinuteCharge.GetHashCode();
      if (internationalAdditionalMinuteCharge_ != null) hash ^= InternationalAdditionalMinuteCharge.GetHashCode();
      if (tollFreeFlatRate_ != null) hash ^= TollFreeFlatRate.GetHashCode();
      if (directoryAssistanceFlatRate_ != null) hash ^= DirectoryAssistanceFlatRate.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (freeCallGracePeriod_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FreeCallGracePeriod);
      }
      if (LocalAreaCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LocalAreaCode);
      }
      if (localFirstMinuteCharge_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(LocalFirstMinuteCharge);
      }
      if (localAdditionalMinuteCharge_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LocalAdditionalMinuteCharge);
      }
      if (longDistanceFirstMinuteCharge_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LongDistanceFirstMinuteCharge);
      }
      if (longDistanceAdditionalMinuteCharge_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LongDistanceAdditionalMinuteCharge);
      }
      if (internationalFirstMinuteCharge_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(InternationalFirstMinuteCharge);
      }
      if (internationalAdditionalMinuteCharge_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(InternationalAdditionalMinuteCharge);
      }
      if (tollFreeFlatRate_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(TollFreeFlatRate);
      }
      if (directoryAssistanceFlatRate_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(DirectoryAssistanceFlatRate);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (freeCallGracePeriod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FreeCallGracePeriod);
      }
      if (LocalAreaCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocalAreaCode);
      }
      if (localFirstMinuteCharge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalFirstMinuteCharge);
      }
      if (localAdditionalMinuteCharge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocalAdditionalMinuteCharge);
      }
      if (longDistanceFirstMinuteCharge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LongDistanceFirstMinuteCharge);
      }
      if (longDistanceAdditionalMinuteCharge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LongDistanceAdditionalMinuteCharge);
      }
      if (internationalFirstMinuteCharge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InternationalFirstMinuteCharge);
      }
      if (internationalAdditionalMinuteCharge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InternationalAdditionalMinuteCharge);
      }
      if (tollFreeFlatRate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TollFreeFlatRate);
      }
      if (directoryAssistanceFlatRate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DirectoryAssistanceFlatRate);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomCallBillingRates other) {
      if (other == null) {
        return;
      }
      if (other.freeCallGracePeriod_ != null) {
        if (freeCallGracePeriod_ == null) {
          freeCallGracePeriod_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        FreeCallGracePeriod.MergeFrom(other.FreeCallGracePeriod);
      }
      if (other.LocalAreaCode.Length != 0) {
        LocalAreaCode = other.LocalAreaCode;
      }
      if (other.localFirstMinuteCharge_ != null) {
        if (localFirstMinuteCharge_ == null) {
          localFirstMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        LocalFirstMinuteCharge.MergeFrom(other.LocalFirstMinuteCharge);
      }
      if (other.localAdditionalMinuteCharge_ != null) {
        if (localAdditionalMinuteCharge_ == null) {
          localAdditionalMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        LocalAdditionalMinuteCharge.MergeFrom(other.LocalAdditionalMinuteCharge);
      }
      if (other.longDistanceFirstMinuteCharge_ != null) {
        if (longDistanceFirstMinuteCharge_ == null) {
          longDistanceFirstMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        LongDistanceFirstMinuteCharge.MergeFrom(other.LongDistanceFirstMinuteCharge);
      }
      if (other.longDistanceAdditionalMinuteCharge_ != null) {
        if (longDistanceAdditionalMinuteCharge_ == null) {
          longDistanceAdditionalMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        LongDistanceAdditionalMinuteCharge.MergeFrom(other.LongDistanceAdditionalMinuteCharge);
      }
      if (other.internationalFirstMinuteCharge_ != null) {
        if (internationalFirstMinuteCharge_ == null) {
          internationalFirstMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        InternationalFirstMinuteCharge.MergeFrom(other.InternationalFirstMinuteCharge);
      }
      if (other.internationalAdditionalMinuteCharge_ != null) {
        if (internationalAdditionalMinuteCharge_ == null) {
          internationalAdditionalMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        InternationalAdditionalMinuteCharge.MergeFrom(other.InternationalAdditionalMinuteCharge);
      }
      if (other.tollFreeFlatRate_ != null) {
        if (tollFreeFlatRate_ == null) {
          tollFreeFlatRate_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        TollFreeFlatRate.MergeFrom(other.TollFreeFlatRate);
      }
      if (other.directoryAssistanceFlatRate_ != null) {
        if (directoryAssistanceFlatRate_ == null) {
          directoryAssistanceFlatRate_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        DirectoryAssistanceFlatRate.MergeFrom(other.DirectoryAssistanceFlatRate);
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
            if (freeCallGracePeriod_ == null) {
              freeCallGracePeriod_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(freeCallGracePeriod_);
            break;
          }
          case 18: {
            LocalAreaCode = input.ReadString();
            break;
          }
          case 26: {
            if (localFirstMinuteCharge_ == null) {
              localFirstMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(localFirstMinuteCharge_);
            break;
          }
          case 34: {
            if (localAdditionalMinuteCharge_ == null) {
              localAdditionalMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(localAdditionalMinuteCharge_);
            break;
          }
          case 42: {
            if (longDistanceFirstMinuteCharge_ == null) {
              longDistanceFirstMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(longDistanceFirstMinuteCharge_);
            break;
          }
          case 50: {
            if (longDistanceAdditionalMinuteCharge_ == null) {
              longDistanceAdditionalMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(longDistanceAdditionalMinuteCharge_);
            break;
          }
          case 58: {
            if (internationalFirstMinuteCharge_ == null) {
              internationalFirstMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(internationalFirstMinuteCharge_);
            break;
          }
          case 66: {
            if (internationalAdditionalMinuteCharge_ == null) {
              internationalAdditionalMinuteCharge_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(internationalAdditionalMinuteCharge_);
            break;
          }
          case 74: {
            if (tollFreeFlatRate_ == null) {
              tollFreeFlatRate_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(tollFreeFlatRate_);
            break;
          }
          case 82: {
            if (directoryAssistanceFlatRate_ == null) {
              directoryAssistanceFlatRate_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(directoryAssistanceFlatRate_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
