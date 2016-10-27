// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: primitive/zip_code.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Primitive {

  /// <summary>Holder for reflection information generated from primitive/zip_code.proto</summary>
  public static partial class ZipCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for primitive/zip_code.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZipCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhwcmltaXRpdmUvemlwX2NvZGUucHJvdG8SFWhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZSJdCgdaaXBDb2RlEhMKC3Bvc3RhbF9jb2RlGAEgASgJEhAKCHppcF90",
            "eXBlGAIgASgJEhQKDHByaW1hcnlfY2l0eRgDIAEoCRIVCg1wcmltYXJ5X3N0",
            "YXRlGAQgASgJQiNaCXByaW1pdGl2ZaoCFUhPTE1TLlR5cGVzLlByaW1pdGl2",
            "ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Primitive.ZipCode), global::HOLMS.Types.Primitive.ZipCode.Parser, new[]{ "PostalCode", "ZipType", "PrimaryCity", "PrimaryState" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ZipCode : pb::IMessage<ZipCode> {
    private static readonly pb::MessageParser<ZipCode> _parser = new pb::MessageParser<ZipCode>(() => new ZipCode());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ZipCode> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Primitive.ZipCodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZipCode() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZipCode(ZipCode other) : this() {
      postalCode_ = other.postalCode_;
      zipType_ = other.zipType_;
      primaryCity_ = other.primaryCity_;
      primaryState_ = other.primaryState_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZipCode Clone() {
      return new ZipCode(this);
    }

    /// <summary>Field number for the "postal_code" field.</summary>
    public const int PostalCodeFieldNumber = 1;
    private string postalCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PostalCode {
      get { return postalCode_; }
      set {
        postalCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "zip_type" field.</summary>
    public const int ZipTypeFieldNumber = 2;
    private string zipType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ZipType {
      get { return zipType_; }
      set {
        zipType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "primary_city" field.</summary>
    public const int PrimaryCityFieldNumber = 3;
    private string primaryCity_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PrimaryCity {
      get { return primaryCity_; }
      set {
        primaryCity_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "primary_state" field.</summary>
    public const int PrimaryStateFieldNumber = 4;
    private string primaryState_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PrimaryState {
      get { return primaryState_; }
      set {
        primaryState_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ZipCode);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ZipCode other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PostalCode != other.PostalCode) return false;
      if (ZipType != other.ZipType) return false;
      if (PrimaryCity != other.PrimaryCity) return false;
      if (PrimaryState != other.PrimaryState) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PostalCode.Length != 0) hash ^= PostalCode.GetHashCode();
      if (ZipType.Length != 0) hash ^= ZipType.GetHashCode();
      if (PrimaryCity.Length != 0) hash ^= PrimaryCity.GetHashCode();
      if (PrimaryState.Length != 0) hash ^= PrimaryState.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PostalCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PostalCode);
      }
      if (ZipType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ZipType);
      }
      if (PrimaryCity.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PrimaryCity);
      }
      if (PrimaryState.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PrimaryState);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PostalCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostalCode);
      }
      if (ZipType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ZipType);
      }
      if (PrimaryCity.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PrimaryCity);
      }
      if (PrimaryState.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PrimaryState);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ZipCode other) {
      if (other == null) {
        return;
      }
      if (other.PostalCode.Length != 0) {
        PostalCode = other.PostalCode;
      }
      if (other.ZipType.Length != 0) {
        ZipType = other.ZipType;
      }
      if (other.PrimaryCity.Length != 0) {
        PrimaryCity = other.PrimaryCity;
      }
      if (other.PrimaryState.Length != 0) {
        PrimaryState = other.PrimaryState;
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
            PostalCode = input.ReadString();
            break;
          }
          case 18: {
            ZipType = input.ReadString();
            break;
          }
          case 26: {
            PrimaryCity = input.ReadString();
            break;
          }
          case 34: {
            PrimaryState = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
