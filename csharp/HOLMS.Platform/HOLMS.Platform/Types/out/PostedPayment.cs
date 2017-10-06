// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/posted_payment.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/posted_payment.proto</summary>
  public static partial class PostedPaymentReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/posted_payment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PostedPaymentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chpmb2xpby9wb3N0ZWRfcGF5bWVudC5wcm90bxIRSE9MTVMuVHlwZXMuRm9s",
            "aW8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aH3ByaW1pdGl2",
            "ZS9tb25ldGFyeV9hbW91bnQucHJvdG8aGGZvbGlvL3BheW1lbnRfdHlwZS5w",
            "cm90byLWAQoNUG9zdGVkUGF5bWVudBItCglwb3N0ZWRfYXQYASABKAsyGi5n",
            "b29nbGUucHJvdG9idWYuVGltZXN0YW1wEjUKBmFtb3VudBgCIAEoCzIlLmhv",
            "bG1zLnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBIRCgluYXJyYXRp",
            "b24YAyABKAkSNAoMcGF5bWVudF90eXBlGAQgASgOMh4uSE9MTVMuVHlwZXMu",
            "Rm9saW8uUGF5bWVudFR5cGUSFgoOaXNfY2FuY2VsbGFibGUYBSABKAhCG1oF",
            "Zm9saW+qAhFIT0xNUy5UeXBlcy5Gb2xpb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Folio.PaymentTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.PostedPayment), global::HOLMS.Types.Folio.PostedPayment.Parser, new[]{ "PostedAt", "Amount", "Narration", "PaymentType", "IsCancellable" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PostedPayment : pb::IMessage<PostedPayment> {
    private static readonly pb::MessageParser<PostedPayment> _parser = new pb::MessageParser<PostedPayment>(() => new PostedPayment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostedPayment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.PostedPaymentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedPayment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedPayment(PostedPayment other) : this() {
      PostedAt = other.postedAt_ != null ? other.PostedAt.Clone() : null;
      Amount = other.amount_ != null ? other.Amount.Clone() : null;
      narration_ = other.narration_;
      paymentType_ = other.paymentType_;
      isCancellable_ = other.isCancellable_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedPayment Clone() {
      return new PostedPayment(this);
    }

    /// <summary>Field number for the "posted_at" field.</summary>
    public const int PostedAtFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp postedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp PostedAt {
      get { return postedAt_; }
      set {
        postedAt_ = value;
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

    /// <summary>Field number for the "narration" field.</summary>
    public const int NarrationFieldNumber = 3;
    private string narration_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Narration {
      get { return narration_; }
      set {
        narration_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payment_type" field.</summary>
    public const int PaymentTypeFieldNumber = 4;
    private global::HOLMS.Types.Folio.PaymentType paymentType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.PaymentType PaymentType {
      get { return paymentType_; }
      set {
        paymentType_ = value;
      }
    }

    /// <summary>Field number for the "is_cancellable" field.</summary>
    public const int IsCancellableFieldNumber = 5;
    private bool isCancellable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCancellable {
      get { return isCancellable_; }
      set {
        isCancellable_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostedPayment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostedPayment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PostedAt, other.PostedAt)) return false;
      if (!object.Equals(Amount, other.Amount)) return false;
      if (Narration != other.Narration) return false;
      if (PaymentType != other.PaymentType) return false;
      if (IsCancellable != other.IsCancellable) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (postedAt_ != null) hash ^= PostedAt.GetHashCode();
      if (amount_ != null) hash ^= Amount.GetHashCode();
      if (Narration.Length != 0) hash ^= Narration.GetHashCode();
      if (PaymentType != 0) hash ^= PaymentType.GetHashCode();
      if (IsCancellable != false) hash ^= IsCancellable.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (postedAt_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PostedAt);
      }
      if (amount_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Amount);
      }
      if (Narration.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Narration);
      }
      if (PaymentType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) PaymentType);
      }
      if (IsCancellable != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCancellable);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (postedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedAt);
      }
      if (amount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Amount);
      }
      if (Narration.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Narration);
      }
      if (PaymentType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PaymentType);
      }
      if (IsCancellable != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostedPayment other) {
      if (other == null) {
        return;
      }
      if (other.postedAt_ != null) {
        if (postedAt_ == null) {
          postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        PostedAt.MergeFrom(other.PostedAt);
      }
      if (other.amount_ != null) {
        if (amount_ == null) {
          amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Amount.MergeFrom(other.Amount);
      }
      if (other.Narration.Length != 0) {
        Narration = other.Narration;
      }
      if (other.PaymentType != 0) {
        PaymentType = other.PaymentType;
      }
      if (other.IsCancellable != false) {
        IsCancellable = other.IsCancellable;
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
            if (postedAt_ == null) {
              postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(postedAt_);
            break;
          }
          case 18: {
            if (amount_ == null) {
              amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amount_);
            break;
          }
          case 26: {
            Narration = input.ReadString();
            break;
          }
          case 32: {
            paymentType_ = (global::HOLMS.Types.Folio.PaymentType) input.ReadEnum();
            break;
          }
          case 40: {
            IsCancellable = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
