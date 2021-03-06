// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: iam/client_instance.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.IAM {

  /// <summary>Holder for reflection information generated from iam/client_instance.proto</summary>
  public static partial class ClientInstanceReflection {

    #region Descriptor
    /// <summary>File descriptor for iam/client_instance.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientInstanceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlpYW0vY2xpZW50X2luc3RhbmNlLnByb3RvEg9ob2xtcy50eXBlcy5pYW0a",
            "I2lhbS9jbGllbnRfaW5zdGFuY2VfaW5kaWNhdG9yLnByb3RvInIKDkNsaWVu",
            "dEluc3RhbmNlEj0KC2luc3RhbmNlX2lkGAEgASgLMiguaG9sbXMudHlwZXMu",
            "aWFtLkNsaWVudEluc3RhbmNlSW5kaWNhdG9yEgwKBG5hbWUYAiABKAkSEwoL",
            "YXBwX3ZlcnNpb24YAyABKAlCF1oDaWFtqgIPSE9MTVMuVHlwZXMuSUFNYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.IAM.ClientInstanceIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.IAM.ClientInstance), global::HOLMS.Types.IAM.ClientInstance.Parser, new[]{ "InstanceId", "Name", "AppVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientInstance : pb::IMessage<ClientInstance> {
    private static readonly pb::MessageParser<ClientInstance> _parser = new pb::MessageParser<ClientInstance>(() => new ClientInstance());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientInstance> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.IAM.ClientInstanceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientInstance() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientInstance(ClientInstance other) : this() {
      InstanceId = other.instanceId_ != null ? other.InstanceId.Clone() : null;
      name_ = other.name_;
      appVersion_ = other.appVersion_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientInstance Clone() {
      return new ClientInstance(this);
    }

    /// <summary>Field number for the "instance_id" field.</summary>
    public const int InstanceIdFieldNumber = 1;
    private global::HOLMS.Types.IAM.ClientInstanceIndicator instanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.ClientInstanceIndicator InstanceId {
      get { return instanceId_; }
      set {
        instanceId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "app_version" field.</summary>
    public const int AppVersionFieldNumber = 3;
    private string appVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppVersion {
      get { return appVersion_; }
      set {
        appVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientInstance);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientInstance other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(InstanceId, other.InstanceId)) return false;
      if (Name != other.Name) return false;
      if (AppVersion != other.AppVersion) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (instanceId_ != null) hash ^= InstanceId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (AppVersion.Length != 0) hash ^= AppVersion.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (instanceId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(InstanceId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (AppVersion.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AppVersion);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (instanceId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InstanceId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (AppVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppVersion);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientInstance other) {
      if (other == null) {
        return;
      }
      if (other.instanceId_ != null) {
        if (instanceId_ == null) {
          instanceId_ = new global::HOLMS.Types.IAM.ClientInstanceIndicator();
        }
        InstanceId.MergeFrom(other.InstanceId);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.AppVersion.Length != 0) {
        AppVersion = other.AppVersion;
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
            if (instanceId_ == null) {
              instanceId_ = new global::HOLMS.Types.IAM.ClientInstanceIndicator();
            }
            input.ReadMessage(instanceId_);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            AppVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
