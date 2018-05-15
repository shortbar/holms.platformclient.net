// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/opsday_start_chime.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/opsday_start_chime.proto</summary>
  public static partial class OpsdayStartChimeReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/opsday_start_chime.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpsdayStartChimeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cid0ZW5hbmN5X2NvbmZpZy9vcHNkYXlfc3RhcnRfY2hpbWUucHJvdG8SGmhv",
            "bG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnGjJ0ZW5hbmN5X2NvbmZpZy9pbmRp",
            "Y2F0b3JzL3Byb3BlcnR5X2luZGljYXRvci5wcm90byJhChBPcHNkYXlTdGFy",
            "dENoaW1lEk0KC3Byb3BlcnR5X2lkGAEgASgLMjguaG9sbXMudHlwZXMudGVu",
            "YW5jeV9jb25maWcuaW5kaWNhdG9ycy5Qcm9wZXJ0eUluZGljYXRvckIcqgIZ",
            "SE9MTVMuVHlwZXMuVGVuYW5jeUNvbmZpZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.OpsdayStartChime), global::HOLMS.Types.TenancyConfig.OpsdayStartChime.Parser, new[]{ "PropertyId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OpsdayStartChime : pb::IMessage<OpsdayStartChime> {
    private static readonly pb::MessageParser<OpsdayStartChime> _parser = new pb::MessageParser<OpsdayStartChime>(() => new OpsdayStartChime());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OpsdayStartChime> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.OpsdayStartChimeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpsdayStartChime() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpsdayStartChime(OpsdayStartChime other) : this() {
      PropertyId = other.propertyId_ != null ? other.PropertyId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpsdayStartChime Clone() {
      return new OpsdayStartChime(this);
    }

    /// <summary>Field number for the "property_id" field.</summary>
    public const int PropertyIdFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator propertyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator PropertyId {
      get { return propertyId_; }
      set {
        propertyId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OpsdayStartChime);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OpsdayStartChime other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PropertyId, other.PropertyId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (propertyId_ != null) hash ^= PropertyId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (propertyId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PropertyId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (propertyId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PropertyId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OpsdayStartChime other) {
      if (other == null) {
        return;
      }
      if (other.propertyId_ != null) {
        if (propertyId_ == null) {
          propertyId_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        PropertyId.MergeFrom(other.PropertyId);
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
            if (propertyId_ == null) {
              propertyId_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(propertyId_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
