// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/posted_charge_credit.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/posted_charge_credit.proto</summary>
  public static partial class PostedChargeCreditReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/posted_charge_credit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PostedChargeCreditReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBmb2xpby9wb3N0ZWRfY2hhcmdlX2NyZWRpdC5wcm90bxIRaG9sbXMudHlw",
            "ZXMuZm9saW8aH3ByaW1pdGl2ZS9tb25ldGFyeV9hbW91bnQucHJvdG8aKGZv",
            "bGlvL3Bvc3RlZF9jaGFyZ2VfY3JlZGl0X3RheF9mZWUucHJvdG8aH2dvb2ds",
            "ZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aPG1vbmV5L2FjY291bnRpbmcv",
            "YWNjb3VudGluZ190cmFuc2FjdGlvbl9saW5lX2luZGljYXRvci5wcm90bxor",
            "Zm9saW8vcG9zdGVkX2NoYXJnZV9jcmVkaXRfZm9saW9fc3dhcC5wcm90byLz",
            "AwoSUG9zdGVkQ2hhcmdlQ3JlZGl0EhMKC2Rlc2NyaXB0aW9uGAEgASgJEkMK",
            "FHByZV90YXhfZmVlX3N1YnRvdGFsGAIgASgLMiUuaG9sbXMudHlwZXMucHJp",
            "bWl0aXZlLk1vbmV0YXJ5QW1vdW50Ej8KCnRheGVzX2ZlZXMYBCADKAsyKy5o",
            "b2xtcy50eXBlcy5mb2xpby5Qb3N0ZWRDaGFyZ2VDcmVkaXRUYXhGZWUSLwoL",
            "cG9zdGVkX3RpbWUYBSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "EjoKBXRheGVzGAYgAygLMisuaG9sbXMudHlwZXMuZm9saW8uUG9zdGVkQ2hh",
            "cmdlQ3JlZGl0VGF4RmVlEjkKBGZlZXMYByADKAsyKy5ob2xtcy50eXBlcy5m",
            "b2xpby5Qb3N0ZWRDaGFyZ2VDcmVkaXRUYXhGZWUSVQoLcGFyZW50X2xpbmUY",
            "CCABKAsyQC5ob2xtcy50eXBlcy5tb25leS5hY2NvdW50aW5nLkFjY291bnRp",
            "bmdUcmFuc2FjdGlvbkxpbmVJbmRpY2F0b3ISQwoLZm9saW9fc3dhcHMYCSAD",
            "KAsyLi5ob2xtcy50eXBlcy5mb2xpby5Qb3N0ZWRDaGFyZ2VDcmVkaXRGb2xp",
            "b1N3YXBCG1oFZm9saW+qAhFIT0xNUy5UeXBlcy5Gb2xpb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Folio.PostedChargeCreditTaxFeeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Money.Accounting.AccountingTransactionLineIndicatorReflection.Descriptor, global::HOLMS.Types.Folio.PostedChargeCreditFolioSwapReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.PostedChargeCredit), global::HOLMS.Types.Folio.PostedChargeCredit.Parser, new[]{ "Description", "PreTaxFeeSubtotal", "TaxesFees", "PostedTime", "Taxes", "Fees", "ParentLine", "FolioSwaps" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PostedChargeCredit : pb::IMessage<PostedChargeCredit> {
    private static readonly pb::MessageParser<PostedChargeCredit> _parser = new pb::MessageParser<PostedChargeCredit>(() => new PostedChargeCredit());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostedChargeCredit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.PostedChargeCreditReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCredit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCredit(PostedChargeCredit other) : this() {
      description_ = other.description_;
      PreTaxFeeSubtotal = other.preTaxFeeSubtotal_ != null ? other.PreTaxFeeSubtotal.Clone() : null;
      taxesFees_ = other.taxesFees_.Clone();
      PostedTime = other.postedTime_ != null ? other.PostedTime.Clone() : null;
      taxes_ = other.taxes_.Clone();
      fees_ = other.fees_.Clone();
      ParentLine = other.parentLine_ != null ? other.ParentLine.Clone() : null;
      folioSwaps_ = other.folioSwaps_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedChargeCredit Clone() {
      return new PostedChargeCredit(this);
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

    /// <summary>Field number for the "pre_tax_fee_subtotal" field.</summary>
    public const int PreTaxFeeSubtotalFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount preTaxFeeSubtotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount PreTaxFeeSubtotal {
      get { return preTaxFeeSubtotal_; }
      set {
        preTaxFeeSubtotal_ = value;
      }
    }

    /// <summary>Field number for the "taxes_fees" field.</summary>
    public const int TaxesFeesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> _repeated_taxesFees_codec
        = pb::FieldCodec.ForMessage(34, global::HOLMS.Types.Folio.PostedChargeCreditTaxFee.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> taxesFees_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> TaxesFees {
      get { return taxesFees_; }
    }

    /// <summary>Field number for the "posted_time" field.</summary>
    public const int PostedTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp postedTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp PostedTime {
      get { return postedTime_; }
      set {
        postedTime_ = value;
      }
    }

    /// <summary>Field number for the "taxes" field.</summary>
    public const int TaxesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> _repeated_taxes_codec
        = pb::FieldCodec.ForMessage(50, global::HOLMS.Types.Folio.PostedChargeCreditTaxFee.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> taxes_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> Taxes {
      get { return taxes_; }
    }

    /// <summary>Field number for the "fees" field.</summary>
    public const int FeesFieldNumber = 7;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> _repeated_fees_codec
        = pb::FieldCodec.ForMessage(58, global::HOLMS.Types.Folio.PostedChargeCreditTaxFee.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> fees_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditTaxFee> Fees {
      get { return fees_; }
    }

    /// <summary>Field number for the "parent_line" field.</summary>
    public const int ParentLineFieldNumber = 8;
    private global::HOLMS.Types.Money.Accounting.AccountingTransactionLineIndicator parentLine_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Accounting.AccountingTransactionLineIndicator ParentLine {
      get { return parentLine_; }
      set {
        parentLine_ = value;
      }
    }

    /// <summary>Field number for the "folio_swaps" field.</summary>
    public const int FolioSwapsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.PostedChargeCreditFolioSwap> _repeated_folioSwaps_codec
        = pb::FieldCodec.ForMessage(74, global::HOLMS.Types.Folio.PostedChargeCreditFolioSwap.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditFolioSwap> folioSwaps_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditFolioSwap>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.PostedChargeCreditFolioSwap> FolioSwaps {
      get { return folioSwaps_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostedChargeCredit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostedChargeCredit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      if (!object.Equals(PreTaxFeeSubtotal, other.PreTaxFeeSubtotal)) return false;
      if(!taxesFees_.Equals(other.taxesFees_)) return false;
      if (!object.Equals(PostedTime, other.PostedTime)) return false;
      if(!taxes_.Equals(other.taxes_)) return false;
      if(!fees_.Equals(other.fees_)) return false;
      if (!object.Equals(ParentLine, other.ParentLine)) return false;
      if(!folioSwaps_.Equals(other.folioSwaps_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (preTaxFeeSubtotal_ != null) hash ^= PreTaxFeeSubtotal.GetHashCode();
      hash ^= taxesFees_.GetHashCode();
      if (postedTime_ != null) hash ^= PostedTime.GetHashCode();
      hash ^= taxes_.GetHashCode();
      hash ^= fees_.GetHashCode();
      if (parentLine_ != null) hash ^= ParentLine.GetHashCode();
      hash ^= folioSwaps_.GetHashCode();
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
      if (preTaxFeeSubtotal_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PreTaxFeeSubtotal);
      }
      taxesFees_.WriteTo(output, _repeated_taxesFees_codec);
      if (postedTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PostedTime);
      }
      taxes_.WriteTo(output, _repeated_taxes_codec);
      fees_.WriteTo(output, _repeated_fees_codec);
      if (parentLine_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ParentLine);
      }
      folioSwaps_.WriteTo(output, _repeated_folioSwaps_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (preTaxFeeSubtotal_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PreTaxFeeSubtotal);
      }
      size += taxesFees_.CalculateSize(_repeated_taxesFees_codec);
      if (postedTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedTime);
      }
      size += taxes_.CalculateSize(_repeated_taxes_codec);
      size += fees_.CalculateSize(_repeated_fees_codec);
      if (parentLine_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ParentLine);
      }
      size += folioSwaps_.CalculateSize(_repeated_folioSwaps_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostedChargeCredit other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.preTaxFeeSubtotal_ != null) {
        if (preTaxFeeSubtotal_ == null) {
          preTaxFeeSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        PreTaxFeeSubtotal.MergeFrom(other.PreTaxFeeSubtotal);
      }
      taxesFees_.Add(other.taxesFees_);
      if (other.postedTime_ != null) {
        if (postedTime_ == null) {
          postedTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        PostedTime.MergeFrom(other.PostedTime);
      }
      taxes_.Add(other.taxes_);
      fees_.Add(other.fees_);
      if (other.parentLine_ != null) {
        if (parentLine_ == null) {
          parentLine_ = new global::HOLMS.Types.Money.Accounting.AccountingTransactionLineIndicator();
        }
        ParentLine.MergeFrom(other.ParentLine);
      }
      folioSwaps_.Add(other.folioSwaps_);
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
            if (preTaxFeeSubtotal_ == null) {
              preTaxFeeSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(preTaxFeeSubtotal_);
            break;
          }
          case 34: {
            taxesFees_.AddEntriesFrom(input, _repeated_taxesFees_codec);
            break;
          }
          case 42: {
            if (postedTime_ == null) {
              postedTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(postedTime_);
            break;
          }
          case 50: {
            taxes_.AddEntriesFrom(input, _repeated_taxes_codec);
            break;
          }
          case 58: {
            fees_.AddEntriesFrom(input, _repeated_fees_codec);
            break;
          }
          case 66: {
            if (parentLine_ == null) {
              parentLine_ = new global::HOLMS.Types.Money.Accounting.AccountingTransactionLineIndicator();
            }
            input.ReadMessage(parentLine_);
            break;
          }
          case 74: {
            folioSwaps_.AddEntriesFrom(input, _repeated_folioSwaps_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
