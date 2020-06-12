// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/time_factor_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/time_factor_config.proto</summary>
  public static partial class TimeFactorConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/time_factor_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TimeFactorConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cid0ZW5hbmN5X2NvbmZpZy90aW1lX2ZhY3Rvcl9jb25maWcucHJvdG8SGmhv",
            "bG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnGjx0ZW5hbmN5X2NvbmZpZy9pbmRp",
            "Y2F0b3JzL3RpbWVfZmFjdG9yX2NvbmZpZ19pbmRpY2F0b3IucHJvdG8isAEK",
            "EFRpbWVGYWN0b3JDb25maWcSUwoJZW50aXR5X2lkGAEgASgLMkAuaG9sbXMu",
            "dHlwZXMudGVuYW5jeV9jb25maWcuaW5kaWNhdG9ycy5UaW1lRmFjdG9yQ29u",
            "ZmlnSW5kaWNhdG9yEhoKEnRpbWVfaW50ZXJ2YWxfbmFtZRgCIAEoCRISCgpm",
            "YXRvcl9yYXRlGAMgASgBEhcKD2hvdXJfb2ZfdGhlX2RheRgEIAEoBUIrWg10",
            "ZW5hbmN5Y29uZmlnqgIZSE9MTVMuVHlwZXMuVGVuYW5jeUNvbmZpZ2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.TenancyConfig.Indicators.TimeFactorConfigIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.TimeFactorConfig), global::HOLMS.Types.TenancyConfig.TimeFactorConfig.Parser, new[]{ "EntityId", "TimeIntervalName", "FatorRate", "HourOfTheDay" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TimeFactorConfig : pb::IMessage<TimeFactorConfig> {
    private static readonly pb::MessageParser<TimeFactorConfig> _parser = new pb::MessageParser<TimeFactorConfig>(() => new TimeFactorConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeFactorConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.TimeFactorConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeFactorConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeFactorConfig(TimeFactorConfig other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      timeIntervalName_ = other.timeIntervalName_;
      fatorRate_ = other.fatorRate_;
      hourOfTheDay_ = other.hourOfTheDay_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeFactorConfig Clone() {
      return new TimeFactorConfig(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.Indicators.TimeFactorConfigIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.TimeFactorConfigIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "time_interval_name" field.</summary>
    public const int TimeIntervalNameFieldNumber = 2;
    private string timeIntervalName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeIntervalName {
      get { return timeIntervalName_; }
      set {
        timeIntervalName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fator_rate" field.</summary>
    public const int FatorRateFieldNumber = 3;
    private double fatorRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FatorRate {
      get { return fatorRate_; }
      set {
        fatorRate_ = value;
      }
    }

    /// <summary>Field number for the "hour_of_the_day" field.</summary>
    public const int HourOfTheDayFieldNumber = 4;
    private int hourOfTheDay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int HourOfTheDay {
      get { return hourOfTheDay_; }
      set {
        hourOfTheDay_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeFactorConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeFactorConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (TimeIntervalName != other.TimeIntervalName) return false;
      if (FatorRate != other.FatorRate) return false;
      if (HourOfTheDay != other.HourOfTheDay) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (TimeIntervalName.Length != 0) hash ^= TimeIntervalName.GetHashCode();
      if (FatorRate != 0D) hash ^= FatorRate.GetHashCode();
      if (HourOfTheDay != 0) hash ^= HourOfTheDay.GetHashCode();
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
      if (TimeIntervalName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TimeIntervalName);
      }
      if (FatorRate != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(FatorRate);
      }
      if (HourOfTheDay != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HourOfTheDay);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (TimeIntervalName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeIntervalName);
      }
      if (FatorRate != 0D) {
        size += 1 + 8;
      }
      if (HourOfTheDay != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HourOfTheDay);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeFactorConfig other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.TenancyConfig.Indicators.TimeFactorConfigIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.TimeIntervalName.Length != 0) {
        TimeIntervalName = other.TimeIntervalName;
      }
      if (other.FatorRate != 0D) {
        FatorRate = other.FatorRate;
      }
      if (other.HourOfTheDay != 0) {
        HourOfTheDay = other.HourOfTheDay;
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
              entityId_ = new global::HOLMS.Types.TenancyConfig.Indicators.TimeFactorConfigIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            TimeIntervalName = input.ReadString();
            break;
          }
          case 25: {
            FatorRate = input.ReadDouble();
            break;
          }
          case 32: {
            HourOfTheDay = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code