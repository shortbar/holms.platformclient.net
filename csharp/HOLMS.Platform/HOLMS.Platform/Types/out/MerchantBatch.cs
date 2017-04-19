// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/transactions/merchant_batch.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards.Transactions {

  /// <summary>Holder for reflection information generated from money/cards/transactions/merchant_batch.proto</summary>
  public static partial class MerchantBatchReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/transactions/merchant_batch.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MerchantBatchReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1tb25leS9jYXJkcy90cmFuc2FjdGlvbnMvbWVyY2hhbnRfYmF0Y2gucHJv",
            "dG8SJGhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucxopbW9u",
            "ZXkvY2FyZHMvY2FyZF9tZXJjaGFudF9pbmRpY2F0b3IucHJvdG8aN21vbmV5",
            "L2NhcmRzL3RyYW5zYWN0aW9ucy9tZXJjaGFudF9iYXRjaF9pbmRpY2F0b3Iu",
            "cHJvdG8aQW1vbmV5L2NhcmRzL3RyYW5zYWN0aW9ucy9wYXltZW50X2NhcmRf",
            "YXV0aG9yaXphdGlvbl9jYXB0dXJlLnByb3RvGjttb25leS9jYXJkcy90cmFu",
            "c2FjdGlvbnMvcHJvY2Vzc29yX3RyYW5zYWN0aW9uX3Jlc3VsdC5wcm90bxof",
            "cHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3VudC5wcm90byLmAwoNTWVyY2hhbnRC",
            "YXRjaBJPCgllbnRpdHlfaWQYASABKAsyPC5ob2xtcy50eXBlcy5tb25leS5j",
            "YXJkcy50cmFuc2FjdGlvbnMuTWVyY2hhbnRCYXRjaEluZGljYXRvchJDCgtt",
            "ZXJjaGFudF9pZBgCIAEoCzIuLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLkNh",
            "cmRNZXJjaGFudEluZGljYXRvchIVCg1tZXJjaGFudF9uYW1lGAMgASgJElAK",
            "BnJlc3VsdBgEIAEoDjJALmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5z",
            "YWN0aW9ucy5Qcm9jZXNzb3JUcmFuc2FjdGlvblJlc3VsdBIXCg9zZXF1ZW5j",
            "ZV9udW1iZXIYBSABKAUSGQoRdHJhbnNhY3Rpb25fY291bnQYBiABKAUSOwoM",
            "dG90YWxfYW1vdW50GAcgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1v",
            "bmV0YXJ5QW1vdW50EgwKBGRhdGUYCCABKAkSVwoIY2FwdHVyZXMYCSADKAsy",
            "RS5ob2xtcy50eXBlcy5tb25leS5jYXJkcy50cmFuc2FjdGlvbnMuUGF5bWVu",
            "dENhcmRBdXRob3JpemF0aW9uQ2FwdHVyZUInqgIkSE9MTVMuVHlwZXMuTW9u",
            "ZXkuQ2FyZHMuVHJhbnNhY3Rpb25zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Cards.CardMerchantIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.MerchantBatchIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationCaptureReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResultReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Cards.Transactions.MerchantBatch), global::HOLMS.Types.Money.Cards.Transactions.MerchantBatch.Parser, new[]{ "EntityId", "MerchantId", "MerchantName", "Result", "SequenceNumber", "TransactionCount", "TotalAmount", "Date", "Captures" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MerchantBatch : pb::IMessage<MerchantBatch> {
    private static readonly pb::MessageParser<MerchantBatch> _parser = new pb::MessageParser<MerchantBatch>(() => new MerchantBatch());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MerchantBatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Cards.Transactions.MerchantBatchReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatch(MerchantBatch other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      MerchantId = other.merchantId_ != null ? other.MerchantId.Clone() : null;
      merchantName_ = other.merchantName_;
      result_ = other.result_;
      sequenceNumber_ = other.sequenceNumber_;
      transactionCount_ = other.transactionCount_;
      TotalAmount = other.totalAmount_ != null ? other.TotalAmount.Clone() : null;
      date_ = other.date_;
      captures_ = other.captures_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatch Clone() {
      return new MerchantBatch(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.Transactions.MerchantBatchIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.MerchantBatchIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "merchant_id" field.</summary>
    public const int MerchantIdFieldNumber = 2;
    private global::HOLMS.Types.Money.Cards.CardMerchantIndicator merchantId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CardMerchantIndicator MerchantId {
      get { return merchantId_; }
      set {
        merchantId_ = value;
      }
    }

    /// <summary>Field number for the "merchant_name" field.</summary>
    public const int MerchantNameFieldNumber = 3;
    private string merchantName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MerchantName {
      get { return merchantName_; }
      set {
        merchantName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 4;
    private global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "sequence_number" field.</summary>
    public const int SequenceNumberFieldNumber = 5;
    private int sequenceNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SequenceNumber {
      get { return sequenceNumber_; }
      set {
        sequenceNumber_ = value;
      }
    }

    /// <summary>Field number for the "transaction_count" field.</summary>
    public const int TransactionCountFieldNumber = 6;
    private int transactionCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TransactionCount {
      get { return transactionCount_; }
      set {
        transactionCount_ = value;
      }
    }

    /// <summary>Field number for the "total_amount" field.</summary>
    public const int TotalAmountFieldNumber = 7;
    private global::HOLMS.Types.Primitive.MonetaryAmount totalAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount TotalAmount {
      get { return totalAmount_; }
      set {
        totalAmount_ = value;
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 8;
    private string date_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Date {
      get { return date_; }
      set {
        date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "captures" field.</summary>
    public const int CapturesFieldNumber = 9;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationCapture> _repeated_captures_codec
        = pb::FieldCodec.ForMessage(74, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationCapture.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationCapture> captures_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationCapture>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.PaymentCardAuthorizationCapture> Captures {
      get { return captures_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MerchantBatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MerchantBatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (!object.Equals(MerchantId, other.MerchantId)) return false;
      if (MerchantName != other.MerchantName) return false;
      if (Result != other.Result) return false;
      if (SequenceNumber != other.SequenceNumber) return false;
      if (TransactionCount != other.TransactionCount) return false;
      if (!object.Equals(TotalAmount, other.TotalAmount)) return false;
      if (Date != other.Date) return false;
      if(!captures_.Equals(other.captures_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (merchantId_ != null) hash ^= MerchantId.GetHashCode();
      if (MerchantName.Length != 0) hash ^= MerchantName.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      if (SequenceNumber != 0) hash ^= SequenceNumber.GetHashCode();
      if (TransactionCount != 0) hash ^= TransactionCount.GetHashCode();
      if (totalAmount_ != null) hash ^= TotalAmount.GetHashCode();
      if (Date.Length != 0) hash ^= Date.GetHashCode();
      hash ^= captures_.GetHashCode();
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
      if (merchantId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MerchantId);
      }
      if (MerchantName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MerchantName);
      }
      if (Result != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Result);
      }
      if (SequenceNumber != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(SequenceNumber);
      }
      if (TransactionCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(TransactionCount);
      }
      if (totalAmount_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(TotalAmount);
      }
      if (Date.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Date);
      }
      captures_.WriteTo(output, _repeated_captures_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (merchantId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MerchantId);
      }
      if (MerchantName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MerchantName);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (SequenceNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SequenceNumber);
      }
      if (TransactionCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TransactionCount);
      }
      if (totalAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TotalAmount);
      }
      if (Date.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Date);
      }
      size += captures_.CalculateSize(_repeated_captures_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MerchantBatch other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Money.Cards.Transactions.MerchantBatchIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.merchantId_ != null) {
        if (merchantId_ == null) {
          merchantId_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
        }
        MerchantId.MergeFrom(other.MerchantId);
      }
      if (other.MerchantName.Length != 0) {
        MerchantName = other.MerchantName;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.SequenceNumber != 0) {
        SequenceNumber = other.SequenceNumber;
      }
      if (other.TransactionCount != 0) {
        TransactionCount = other.TransactionCount;
      }
      if (other.totalAmount_ != null) {
        if (totalAmount_ == null) {
          totalAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        TotalAmount.MergeFrom(other.TotalAmount);
      }
      if (other.Date.Length != 0) {
        Date = other.Date;
      }
      captures_.Add(other.captures_);
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
              entityId_ = new global::HOLMS.Types.Money.Cards.Transactions.MerchantBatchIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            if (merchantId_ == null) {
              merchantId_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
            }
            input.ReadMessage(merchantId_);
            break;
          }
          case 26: {
            MerchantName = input.ReadString();
            break;
          }
          case 32: {
            result_ = (global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult) input.ReadEnum();
            break;
          }
          case 40: {
            SequenceNumber = input.ReadInt32();
            break;
          }
          case 48: {
            TransactionCount = input.ReadInt32();
            break;
          }
          case 58: {
            if (totalAmount_ == null) {
              totalAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(totalAmount_);
            break;
          }
          case 66: {
            Date = input.ReadString();
            break;
          }
          case 74: {
            captures_.AddEntriesFrom(input, _repeated_captures_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
