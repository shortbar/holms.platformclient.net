// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/accounting/iif_export_configuration.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Accounting {

  /// <summary>Holder for reflection information generated from money/accounting/iif_export_configuration.proto</summary>
  public static partial class IifExportConfigurationReflection {

    #region Descriptor
    /// <summary>File descriptor for money/accounting/iif_export_configuration.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IifExportConfigurationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9tb25leS9hY2NvdW50aW5nL2lpZl9leHBvcnRfY29uZmlndXJhdGlvbi5w",
            "cm90bxIcaG9sbXMudHlwZXMubW9uZXkuYWNjb3VudGluZyKUAQoWSUlGRXhw",
            "b3J0Q29uZmlndXJhdGlvbhIdChVyZWN1cnJlbmNlX2Rlc2NyaXB0b3IYASAB",
            "KAkSJAocZGlzYWJsZV9hc3NldF9hY2NvdW50X2V4cG9ydBgCIAEoCBIaChJk",
            "cm9wYm94X3VzZXJfdG9rZW4YAyABKAkSGQoRZHJvcGJveF9ob2xtc19rZXkY",
            "BCABKAlCMVoQbW9uZXkvYWNjb3VudGluZ6oCHEhPTE1TLlR5cGVzLk1vbmV5",
            "LkFjY291bnRpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Accounting.IIFExportConfiguration), global::HOLMS.Types.Money.Accounting.IIFExportConfiguration.Parser, new[]{ "RecurrenceDescriptor", "DisableAssetAccountExport", "DropboxUserToken", "DropboxHolmsKey" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IIFExportConfiguration : pb::IMessage<IIFExportConfiguration> {
    private static readonly pb::MessageParser<IIFExportConfiguration> _parser = new pb::MessageParser<IIFExportConfiguration>(() => new IIFExportConfiguration());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IIFExportConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Accounting.IifExportConfigurationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IIFExportConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IIFExportConfiguration(IIFExportConfiguration other) : this() {
      recurrenceDescriptor_ = other.recurrenceDescriptor_;
      disableAssetAccountExport_ = other.disableAssetAccountExport_;
      dropboxUserToken_ = other.dropboxUserToken_;
      dropboxHolmsKey_ = other.dropboxHolmsKey_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IIFExportConfiguration Clone() {
      return new IIFExportConfiguration(this);
    }

    /// <summary>Field number for the "recurrence_descriptor" field.</summary>
    public const int RecurrenceDescriptorFieldNumber = 1;
    private string recurrenceDescriptor_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RecurrenceDescriptor {
      get { return recurrenceDescriptor_; }
      set {
        recurrenceDescriptor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "disable_asset_account_export" field.</summary>
    public const int DisableAssetAccountExportFieldNumber = 2;
    private bool disableAssetAccountExport_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DisableAssetAccountExport {
      get { return disableAssetAccountExport_; }
      set {
        disableAssetAccountExport_ = value;
      }
    }

    /// <summary>Field number for the "dropbox_user_token" field.</summary>
    public const int DropboxUserTokenFieldNumber = 3;
    private string dropboxUserToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DropboxUserToken {
      get { return dropboxUserToken_; }
      set {
        dropboxUserToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dropbox_holms_key" field.</summary>
    public const int DropboxHolmsKeyFieldNumber = 4;
    private string dropboxHolmsKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DropboxHolmsKey {
      get { return dropboxHolmsKey_; }
      set {
        dropboxHolmsKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IIFExportConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IIFExportConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RecurrenceDescriptor != other.RecurrenceDescriptor) return false;
      if (DisableAssetAccountExport != other.DisableAssetAccountExport) return false;
      if (DropboxUserToken != other.DropboxUserToken) return false;
      if (DropboxHolmsKey != other.DropboxHolmsKey) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RecurrenceDescriptor.Length != 0) hash ^= RecurrenceDescriptor.GetHashCode();
      if (DisableAssetAccountExport != false) hash ^= DisableAssetAccountExport.GetHashCode();
      if (DropboxUserToken.Length != 0) hash ^= DropboxUserToken.GetHashCode();
      if (DropboxHolmsKey.Length != 0) hash ^= DropboxHolmsKey.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RecurrenceDescriptor.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RecurrenceDescriptor);
      }
      if (DisableAssetAccountExport != false) {
        output.WriteRawTag(16);
        output.WriteBool(DisableAssetAccountExport);
      }
      if (DropboxUserToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DropboxUserToken);
      }
      if (DropboxHolmsKey.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DropboxHolmsKey);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RecurrenceDescriptor.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RecurrenceDescriptor);
      }
      if (DisableAssetAccountExport != false) {
        size += 1 + 1;
      }
      if (DropboxUserToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DropboxUserToken);
      }
      if (DropboxHolmsKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DropboxHolmsKey);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IIFExportConfiguration other) {
      if (other == null) {
        return;
      }
      if (other.RecurrenceDescriptor.Length != 0) {
        RecurrenceDescriptor = other.RecurrenceDescriptor;
      }
      if (other.DisableAssetAccountExport != false) {
        DisableAssetAccountExport = other.DisableAssetAccountExport;
      }
      if (other.DropboxUserToken.Length != 0) {
        DropboxUserToken = other.DropboxUserToken;
      }
      if (other.DropboxHolmsKey.Length != 0) {
        DropboxHolmsKey = other.DropboxHolmsKey;
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
            RecurrenceDescriptor = input.ReadString();
            break;
          }
          case 16: {
            DisableAssetAccountExport = input.ReadBool();
            break;
          }
          case 26: {
            DropboxUserToken = input.ReadString();
            break;
          }
          case 34: {
            DropboxHolmsKey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
