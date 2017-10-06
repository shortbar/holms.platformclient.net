// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/posted_charge_credit_tax_fee.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/posted_charge_credit_tax_fee.proto</summary>
  public static partial class PostedChargeCreditTaxFeeReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/posted_charge_credit_tax_fee.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PostedChargeCreditTaxFeeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihmb2xpby9wb3N0ZWRfY2hhcmdlX2NyZWRpdF90YXhfZmVlLnByb3RvEhFI",
            "T0xNUy5UeXBlcy5Gb2xpbxofcHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3VudC5w",
            "cm90byJmChhQb3N0ZWRDaGFyZ2VDcmVkaXRUYXhGZWUSEwoLZGVzY3JpcHRp",
            "b24YASABKAkSNQoGYW1vdW50GAIgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0",
            "aXZlLk1vbmV0YXJ5QW1vdW50QhtaBWZvbGlvqgIRSE9MTVMuVHlwZXMuRm9s",
            "aW9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.PostedChargeCreditTaxFee), global::HOLMS.Types.Folio.PostedChargeCreditTaxFee.Parser, new[]{ "Description", "Amount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PostedChargeCreditTaxFee : pb::IMessage<PostedChargeCreditTaxFee> {
    private static readonly pb::MessageParser<PostedChargeCreditTaxFee> _parser = new pb::MessageParser<PostedChargeCreditTaxFee>(() => new PostedChargeCreditTaxFee());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostedChargeCreditTaxFee> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.PostedChargeCreditTaxFeeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCreditTaxFee() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCreditTaxFee(PostedChargeCreditTaxFee other) : this() {
      description_ = other.description_;
      Amount = other.amount_ != null ? other.Amount.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCreditTaxFee Clone() {
      return new PostedChargeCreditTaxFee(this);
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 1;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostedChargeCreditTaxFee);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostedChargeCreditTaxFee other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      if (!object.Equals(Amount, other.Amount)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (amount_ != null) hash ^= Amount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Description.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Description);
      }
      if (amount_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Amount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (amount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Amount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostedChargeCreditTaxFee other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.amount_ != null) {
        if (amount_ == null) {
          amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Amount.MergeFrom(other.Amount);
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
            Description = input.ReadString();
            break;
          }
          case 18: {
            if (amount_ == null) {
              amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amount_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
