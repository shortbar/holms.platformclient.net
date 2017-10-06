// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/requested_charge_credit_posting.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/requested_charge_credit_posting.proto</summary>
  public static partial class RequestedChargeCreditPostingReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/requested_charge_credit_posting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestedChargeCreditPostingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citmb2xpby9yZXF1ZXN0ZWRfY2hhcmdlX2NyZWRpdF9wb3N0aW5nLnByb3Rv",
            "EhFIT0xNUy5UeXBlcy5Gb2xpbxofcHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3Vu",
            "dC5wcm90bxodcHJpbWl0aXZlL3BiX2xvY2FsX2RhdGUucHJvdG8aHmZvbGlv",
            "L2NoYXJnZV9jcmVkaXRfdHlwZS5wcm90bxo3c3VwcGx5L2luY2lkZW50YWxf",
            "aXRlbXMvaW5jaWRlbnRhbF9pdGVtX2luZGljYXRvci5wcm90byLaAgocUmVx",
            "dWVzdGVkQ2hhcmdlQ3JlZGl0UG9zdGluZxITCgtkZXNjcmlwdGlvbhgBIAEo",
            "CRI/ChJjaGFyZ2VfY3JlZGl0X3R5cGUYAiABKA4yIy5IT0xNUy5UeXBlcy5G",
            "b2xpby5DaGFyZ2VDcmVkaXRUeXBlEj0KDnVudGF4ZWRfYW1vdW50GAMgASgL",
            "MiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50EhIKCnRh",
            "eF9leGVtcHQYBCABKAgSVQoPaW5jaWRlbnRhbF9pdGVtGAUgASgLMjwuaG9s",
            "bXMudHlwZXMuc3VwcGx5LmluY2lkZW50YWxfaXRlbXMuSW5jaWRlbnRhbEl0",
            "ZW1JbmRpY2F0b3ISOgoOY2hhcmdlX29wc2RhdGUYBiABKAsyIi5ob2xtcy50",
            "eXBlcy5wcmltaXRpdmUuUGJMb2NhbERhdGVCG1oFZm9saW+qAhFIT0xNUy5U",
            "eXBlcy5Gb2xpb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Folio.ChargeCreditTypeReflection.Descriptor, global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RequestedChargeCreditPosting), global::HOLMS.Types.Folio.RequestedChargeCreditPosting.Parser, new[]{ "Description", "ChargeCreditType", "UntaxedAmount", "TaxExempt", "IncidentalItem", "ChargeOpsdate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RequestedChargeCreditPosting : pb::IMessage<RequestedChargeCreditPosting> {
    private static readonly pb::MessageParser<RequestedChargeCreditPosting> _parser = new pb::MessageParser<RequestedChargeCreditPosting>(() => new RequestedChargeCreditPosting());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestedChargeCreditPosting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RequestedChargeCreditPostingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestedChargeCreditPosting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestedChargeCreditPosting(RequestedChargeCreditPosting other) : this() {
      description_ = other.description_;
      chargeCreditType_ = other.chargeCreditType_;
      UntaxedAmount = other.untaxedAmount_ != null ? other.UntaxedAmount.Clone() : null;
      taxExempt_ = other.taxExempt_;
      IncidentalItem = other.incidentalItem_ != null ? other.IncidentalItem.Clone() : null;
      ChargeOpsdate = other.chargeOpsdate_ != null ? other.ChargeOpsdate.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestedChargeCreditPosting Clone() {
      return new RequestedChargeCreditPosting(this);
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

    /// <summary>Field number for the "charge_credit_type" field.</summary>
    public const int ChargeCreditTypeFieldNumber = 2;
    private global::HOLMS.Types.Folio.ChargeCreditType chargeCreditType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.ChargeCreditType ChargeCreditType {
      get { return chargeCreditType_; }
      set {
        chargeCreditType_ = value;
      }
    }

    /// <summary>Field number for the "untaxed_amount" field.</summary>
    public const int UntaxedAmountFieldNumber = 3;
    private global::HOLMS.Types.Primitive.MonetaryAmount untaxedAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount UntaxedAmount {
      get { return untaxedAmount_; }
      set {
        untaxedAmount_ = value;
      }
    }

    /// <summary>Field number for the "tax_exempt" field.</summary>
    public const int TaxExemptFieldNumber = 4;
    private bool taxExempt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TaxExempt {
      get { return taxExempt_; }
      set {
        taxExempt_ = value;
      }
    }

    /// <summary>Field number for the "incidental_item" field.</summary>
    public const int IncidentalItemFieldNumber = 5;
    private global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator incidentalItem_;
    /// <summary>
    ///  Only used when charge type == incidental item
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator IncidentalItem {
      get { return incidentalItem_; }
      set {
        incidentalItem_ = value;
      }
    }

    /// <summary>Field number for the "charge_opsdate" field.</summary>
    public const int ChargeOpsdateFieldNumber = 6;
    private global::HOLMS.Types.Primitive.PbLocalDate chargeOpsdate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate ChargeOpsdate {
      get { return chargeOpsdate_; }
      set {
        chargeOpsdate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestedChargeCreditPosting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestedChargeCreditPosting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      if (ChargeCreditType != other.ChargeCreditType) return false;
      if (!object.Equals(UntaxedAmount, other.UntaxedAmount)) return false;
      if (TaxExempt != other.TaxExempt) return false;
      if (!object.Equals(IncidentalItem, other.IncidentalItem)) return false;
      if (!object.Equals(ChargeOpsdate, other.ChargeOpsdate)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (ChargeCreditType != 0) hash ^= ChargeCreditType.GetHashCode();
      if (untaxedAmount_ != null) hash ^= UntaxedAmount.GetHashCode();
      if (TaxExempt != false) hash ^= TaxExempt.GetHashCode();
      if (incidentalItem_ != null) hash ^= IncidentalItem.GetHashCode();
      if (chargeOpsdate_ != null) hash ^= ChargeOpsdate.GetHashCode();
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
      if (ChargeCreditType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ChargeCreditType);
      }
      if (untaxedAmount_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UntaxedAmount);
      }
      if (TaxExempt != false) {
        output.WriteRawTag(32);
        output.WriteBool(TaxExempt);
      }
      if (incidentalItem_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(IncidentalItem);
      }
      if (chargeOpsdate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ChargeOpsdate);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (ChargeCreditType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChargeCreditType);
      }
      if (untaxedAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UntaxedAmount);
      }
      if (TaxExempt != false) {
        size += 1 + 1;
      }
      if (incidentalItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IncidentalItem);
      }
      if (chargeOpsdate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChargeOpsdate);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestedChargeCreditPosting other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.ChargeCreditType != 0) {
        ChargeCreditType = other.ChargeCreditType;
      }
      if (other.untaxedAmount_ != null) {
        if (untaxedAmount_ == null) {
          untaxedAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        UntaxedAmount.MergeFrom(other.UntaxedAmount);
      }
      if (other.TaxExempt != false) {
        TaxExempt = other.TaxExempt;
      }
      if (other.incidentalItem_ != null) {
        if (incidentalItem_ == null) {
          incidentalItem_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
        }
        IncidentalItem.MergeFrom(other.IncidentalItem);
      }
      if (other.chargeOpsdate_ != null) {
        if (chargeOpsdate_ == null) {
          chargeOpsdate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        ChargeOpsdate.MergeFrom(other.ChargeOpsdate);
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
          case 16: {
            chargeCreditType_ = (global::HOLMS.Types.Folio.ChargeCreditType) input.ReadEnum();
            break;
          }
          case 26: {
            if (untaxedAmount_ == null) {
              untaxedAmount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(untaxedAmount_);
            break;
          }
          case 32: {
            TaxExempt = input.ReadBool();
            break;
          }
          case 42: {
            if (incidentalItem_ == null) {
              incidentalItem_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
            }
            input.ReadMessage(incidentalItem_);
            break;
          }
          case 50: {
            if (chargeOpsdate_ == null) {
              chargeOpsdate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(chargeOpsdate_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
