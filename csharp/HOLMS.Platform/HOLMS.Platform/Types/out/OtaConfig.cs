// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/ota_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/ota_config.proto</summary>
  public static partial class OtaConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/ota_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OtaConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch90ZW5hbmN5X2NvbmZpZy9vdGFfY29uZmlnLnByb3RvEhpob2xtcy50eXBl",
            "cy50ZW5hbmN5X2NvbmZpZyJrCglPVEFDb25maWcSFAoMcHJvdmlkZXJfaV9k",
            "GAEgASgJEhoKEnByb3ZpZGVyX3VzZXJfbmFtZRgCIAEoCRIZChFwcm92aWRl",
            "cl9wYXNzd29yZBgDIAEoCRIRCglob3RlbF9pX2QYBCABKAlCK1oNdGVuYW5j",
            "eWNvbmZpZ6oCGUhPTE1TLlR5cGVzLlRlbmFuY3lDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.OTAConfig), global::HOLMS.Types.TenancyConfig.OTAConfig.Parser, new[]{ "ProviderID", "ProviderUserName", "ProviderPassword", "HotelID" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OTAConfig : pb::IMessage<OTAConfig> {
    private static readonly pb::MessageParser<OTAConfig> _parser = new pb::MessageParser<OTAConfig>(() => new OTAConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OTAConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.OtaConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTAConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTAConfig(OTAConfig other) : this() {
      providerID_ = other.providerID_;
      providerUserName_ = other.providerUserName_;
      providerPassword_ = other.providerPassword_;
      hotelID_ = other.hotelID_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OTAConfig Clone() {
      return new OTAConfig(this);
    }

    /// <summary>Field number for the "provider_i_d" field.</summary>
    public const int ProviderIDFieldNumber = 1;
    private string providerID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderID {
      get { return providerID_; }
      set {
        providerID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "provider_user_name" field.</summary>
    public const int ProviderUserNameFieldNumber = 2;
    private string providerUserName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderUserName {
      get { return providerUserName_; }
      set {
        providerUserName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "provider_password" field.</summary>
    public const int ProviderPasswordFieldNumber = 3;
    private string providerPassword_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProviderPassword {
      get { return providerPassword_; }
      set {
        providerPassword_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hotel_i_d" field.</summary>
    public const int HotelIDFieldNumber = 4;
    private string hotelID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HotelID {
      get { return hotelID_; }
      set {
        hotelID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OTAConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OTAConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProviderID != other.ProviderID) return false;
      if (ProviderUserName != other.ProviderUserName) return false;
      if (ProviderPassword != other.ProviderPassword) return false;
      if (HotelID != other.HotelID) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProviderID.Length != 0) hash ^= ProviderID.GetHashCode();
      if (ProviderUserName.Length != 0) hash ^= ProviderUserName.GetHashCode();
      if (ProviderPassword.Length != 0) hash ^= ProviderPassword.GetHashCode();
      if (HotelID.Length != 0) hash ^= HotelID.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ProviderID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProviderID);
      }
      if (ProviderUserName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProviderUserName);
      }
      if (ProviderPassword.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProviderPassword);
      }
      if (HotelID.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HotelID);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProviderID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderID);
      }
      if (ProviderUserName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderUserName);
      }
      if (ProviderPassword.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProviderPassword);
      }
      if (HotelID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HotelID);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OTAConfig other) {
      if (other == null) {
        return;
      }
      if (other.ProviderID.Length != 0) {
        ProviderID = other.ProviderID;
      }
      if (other.ProviderUserName.Length != 0) {
        ProviderUserName = other.ProviderUserName;
      }
      if (other.ProviderPassword.Length != 0) {
        ProviderPassword = other.ProviderPassword;
      }
      if (other.HotelID.Length != 0) {
        HotelID = other.HotelID;
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
            ProviderID = input.ReadString();
            break;
          }
          case 18: {
            ProviderUserName = input.ReadString();
            break;
          }
          case 26: {
            ProviderPassword = input.ReadString();
            break;
          }
          case 34: {
            HotelID = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
