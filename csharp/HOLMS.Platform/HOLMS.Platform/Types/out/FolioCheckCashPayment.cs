// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/folio_check_cash_payment.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/folio_check_cash_payment.proto</summary>
  public static partial class FolioCheckCashPaymentReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/folio_check_cash_payment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioCheckCashPaymentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRmb2xpby9mb2xpb19jaGVja19jYXNoX3BheW1lbnQucHJvdG8SEWhvbG1z",
            "LnR5cGVzLmZvbGlvGhhmb2xpby9wYXltZW50X3R5cGUucHJvdG8aH2dvb2ds",
            "ZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aIGlhbS9zdGFmZl9tZW1iZXJf",
            "aW5kaWNhdG9yLnByb3RvGh9wcmltaXRpdmUvbW9uZXRhcnlfYW1vdW50LnBy",
            "b3RvGi5mb2xpby9mb2xpb19jaGVja19jYXNoX3BheW1lbnRfaW5kaWNhdG9y",
            "LnByb3RvIsoCChVGb2xpb0NoZWNrQ2FzaFBheW1lbnQSNQoGYW1vdW50GAEg",
            "ASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50EhMK",
            "C2lzX2NhbmNlbGVkGAIgASgIEjQKDHBheW1lbnRfdHlwZRgDIAEoDjIeLmhv",
            "bG1zLnR5cGVzLmZvbGlvLlBheW1lbnRUeXBlEjoKC3JlY2VpdmVkX2J5GAQg",
            "ASgLMiUuaG9sbXMudHlwZXMuaWFtLlN0YWZmTWVtYmVySW5kaWNhdG9yEi0K",
            "CXBvc3RlZF9hdBgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAS",
            "RAoJZW50aXR5X2lkGAYgASgLMjEuaG9sbXMudHlwZXMuZm9saW8uRm9saW9D",
            "aGVja0Nhc2hQYXltZW50SW5kaWNhdG9yQhSqAhFIT0xNUy5UeXBlcy5Gb2xp",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Folio.PaymentTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Folio.FolioCheckCashPaymentIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.FolioCheckCashPayment), global::HOLMS.Types.Folio.FolioCheckCashPayment.Parser, new[]{ "Amount", "IsCanceled", "PaymentType", "ReceivedBy", "PostedAt", "EntityId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FolioCheckCashPayment : pb::IMessage<FolioCheckCashPayment> {
    private static readonly pb::MessageParser<FolioCheckCashPayment> _parser = new pb::MessageParser<FolioCheckCashPayment>(() => new FolioCheckCashPayment());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioCheckCashPayment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.FolioCheckCashPaymentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCheckCashPayment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCheckCashPayment(FolioCheckCashPayment other) : this() {
      Amount = other.amount_ != null ? other.Amount.Clone() : null;
      isCanceled_ = other.isCanceled_;
      paymentType_ = other.paymentType_;
      ReceivedBy = other.receivedBy_ != null ? other.ReceivedBy.Clone() : null;
      PostedAt = other.postedAt_ != null ? other.PostedAt.Clone() : null;
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCheckCashPayment Clone() {
      return new FolioCheckCashPayment(this);
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 1;
    private global::HOLMS.Types.Primitive.MonetaryAmount amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "is_canceled" field.</summary>
    public const int IsCanceledFieldNumber = 2;
    private bool isCanceled_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCanceled {
      get { return isCanceled_; }
      set {
        isCanceled_ = value;
      }
    }

    /// <summary>Field number for the "payment_type" field.</summary>
    public const int PaymentTypeFieldNumber = 3;
    private global::HOLMS.Types.Folio.PaymentType paymentType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.PaymentType PaymentType {
      get { return paymentType_; }
      set {
        paymentType_ = value;
      }
    }

    /// <summary>Field number for the "received_by" field.</summary>
    public const int ReceivedByFieldNumber = 4;
    private global::HOLMS.Types.IAM.StaffMemberIndicator receivedBy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.IAM.StaffMemberIndicator ReceivedBy {
      get { return receivedBy_; }
      set {
        receivedBy_ = value;
      }
    }

    /// <summary>Field number for the "posted_at" field.</summary>
    public const int PostedAtFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp postedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp PostedAt {
      get { return postedAt_; }
      set {
        postedAt_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 6;
    private global::HOLMS.Types.Folio.FolioCheckCashPaymentIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.FolioCheckCashPaymentIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FolioCheckCashPayment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioCheckCashPayment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Amount, other.Amount)) return false;
      if (IsCanceled != other.IsCanceled) return false;
      if (PaymentType != other.PaymentType) return false;
      if (!object.Equals(ReceivedBy, other.ReceivedBy)) return false;
      if (!object.Equals(PostedAt, other.PostedAt)) return false;
      if (!object.Equals(EntityId, other.EntityId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (amount_ != null) hash ^= Amount.GetHashCode();
      if (IsCanceled != false) hash ^= IsCanceled.GetHashCode();
      if (PaymentType != 0) hash ^= PaymentType.GetHashCode();
      if (receivedBy_ != null) hash ^= ReceivedBy.GetHashCode();
      if (postedAt_ != null) hash ^= PostedAt.GetHashCode();
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (amount_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Amount);
      }
      if (IsCanceled != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsCanceled);
      }
      if (PaymentType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PaymentType);
      }
      if (receivedBy_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReceivedBy);
      }
      if (postedAt_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PostedAt);
      }
      if (entityId_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EntityId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (amount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Amount);
      }
      if (IsCanceled != false) {
        size += 1 + 1;
      }
      if (PaymentType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PaymentType);
      }
      if (receivedBy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReceivedBy);
      }
      if (postedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedAt);
      }
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioCheckCashPayment other) {
      if (other == null) {
        return;
      }
      if (other.amount_ != null) {
        if (amount_ == null) {
          amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Amount.MergeFrom(other.Amount);
      }
      if (other.IsCanceled != false) {
        IsCanceled = other.IsCanceled;
      }
      if (other.PaymentType != 0) {
        PaymentType = other.PaymentType;
      }
      if (other.receivedBy_ != null) {
        if (receivedBy_ == null) {
          receivedBy_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
        }
        ReceivedBy.MergeFrom(other.ReceivedBy);
      }
      if (other.postedAt_ != null) {
        if (postedAt_ == null) {
          postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        PostedAt.MergeFrom(other.PostedAt);
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Folio.FolioCheckCashPaymentIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
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
            if (amount_ == null) {
              amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amount_);
            break;
          }
          case 16: {
            IsCanceled = input.ReadBool();
            break;
          }
          case 24: {
            paymentType_ = (global::HOLMS.Types.Folio.PaymentType) input.ReadEnum();
            break;
          }
          case 34: {
            if (receivedBy_ == null) {
              receivedBy_ = new global::HOLMS.Types.IAM.StaffMemberIndicator();
            }
            input.ReadMessage(receivedBy_);
            break;
          }
          case 42: {
            if (postedAt_ == null) {
              postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(postedAt_);
            break;
          }
          case 50: {
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.Folio.FolioCheckCashPaymentIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
