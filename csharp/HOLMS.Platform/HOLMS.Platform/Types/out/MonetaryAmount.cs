// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: primitive/monetary_amount.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Primitive {

  /// <summary>Holder for reflection information generated from primitive/monetary_amount.proto</summary>
  public static partial class MonetaryAmountReflection {

    #region Descriptor
    /// <summary>File descriptor for primitive/monetary_amount.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonetaryAmountReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9wcmltaXRpdmUvbW9uZXRhcnlfYW1vdW50LnByb3RvEhVob2xtcy50eXBl",
            "cy5wcmltaXRpdmUiJgoOTW9uZXRhcnlBbW91bnQSFAoMbWljcm9kb2xsYXJz",
            "GAEgASgSQiNaCXByaW1pdGl2ZaoCFUhPTE1TLlR5cGVzLlByaW1pdGl2ZWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Primitive.MonetaryAmount), global::HOLMS.Types.Primitive.MonetaryAmount.Parser, new[]{ "Microdollars" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MonetaryAmount : pb::IMessage<MonetaryAmount> {
    private static readonly pb::MessageParser<MonetaryAmount> _parser = new pb::MessageParser<MonetaryAmount>(() => new MonetaryAmount());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MonetaryAmount> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonetaryAmount() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonetaryAmount(MonetaryAmount other) : this() {
      microdollars_ = other.microdollars_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonetaryAmount Clone() {
      return new MonetaryAmount(this);
    }

    /// <summary>Field number for the "microdollars" field.</summary>
    public const int MicrodollarsFieldNumber = 1;
    private long microdollars_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Microdollars {
      get { return microdollars_; }
      set {
        microdollars_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MonetaryAmount);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MonetaryAmount other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Microdollars != other.Microdollars) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Microdollars != 0L) hash ^= Microdollars.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Microdollars != 0L) {
        output.WriteRawTag(8);
        output.WriteSInt64(Microdollars);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Microdollars != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(Microdollars);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MonetaryAmount other) {
      if (other == null) {
        return;
      }
      if (other.Microdollars != 0L) {
        Microdollars = other.Microdollars;
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
            Microdollars = input.ReadSInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
