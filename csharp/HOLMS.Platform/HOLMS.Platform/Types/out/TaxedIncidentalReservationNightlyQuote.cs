// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/taxed_incidental_reservation_nightly_quote.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/taxed_incidental_reservation_nightly_quote.proto</summary>
  public static partial class TaxedIncidentalReservationNightlyQuoteReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/taxed_incidental_reservation_nightly_quote.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaxedIncidentalReservationNightlyQuoteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZmb2xpby90YXhlZF9pbmNpZGVudGFsX3Jlc2VydmF0aW9uX25pZ2h0bHlf",
            "cXVvdGUucHJvdG8SEWhvbG1zLnR5cGVzLmZvbGlvGh9wcmltaXRpdmUvbW9u",
            "ZXRhcnlfYW1vdW50LnByb3RvGh5mb2xpby90YXhfZmVlX2Fzc2Vzc21lbnQu",
            "cHJvdG8aHXByaW1pdGl2ZS9wYl9sb2NhbF9kYXRlLnByb3RvGjdzdXBwbHkv",
            "aW5jaWRlbnRhbF9pdGVtcy9pbmNpZGVudGFsX2l0ZW1faW5kaWNhdG9yLnBy",
            "b3RvIrwCCiZUYXhlZEluY2lkZW50YWxSZXNlcnZhdGlvbk5pZ2h0bHlRdW90",
            "ZRIzCgdvcHNkYXRlGAEgASgLMiIuaG9sbXMudHlwZXMucHJpbWl0aXZlLlBi",
            "TG9jYWxEYXRlEkYKF3ByZXRheF9pbmNpZGVudGFsX3ByaWNlGAIgASgLMiUu",
            "aG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50Ej4KEXRheF9m",
            "ZWVfYXNzZW1lbnRzGAMgAygLMiMuaG9sbXMudHlwZXMuZm9saW8uVGF4RmVl",
            "QXNzZXNzbWVudBJVCg9pbmNpZGVudGFsX2l0ZW0YBCABKAsyPC5ob2xtcy50",
            "eXBlcy5zdXBwbHkuaW5jaWRlbnRhbF9pdGVtcy5JbmNpZGVudGFsSXRlbUlu",
            "ZGljYXRvckIbWgVmb2xpb6oCEUhPTE1TLlR5cGVzLkZvbGlvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Folio.TaxFeeAssessmentReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.TaxedIncidentalReservationNightlyQuote), global::HOLMS.Types.Folio.TaxedIncidentalReservationNightlyQuote.Parser, new[]{ "Opsdate", "PretaxIncidentalPrice", "TaxFeeAssements", "IncidentalItem" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TaxedIncidentalReservationNightlyQuote : pb::IMessage<TaxedIncidentalReservationNightlyQuote> {
    private static readonly pb::MessageParser<TaxedIncidentalReservationNightlyQuote> _parser = new pb::MessageParser<TaxedIncidentalReservationNightlyQuote>(() => new TaxedIncidentalReservationNightlyQuote());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TaxedIncidentalReservationNightlyQuote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.TaxedIncidentalReservationNightlyQuoteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxedIncidentalReservationNightlyQuote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxedIncidentalReservationNightlyQuote(TaxedIncidentalReservationNightlyQuote other) : this() {
      Opsdate = other.opsdate_ != null ? other.Opsdate.Clone() : null;
      PretaxIncidentalPrice = other.pretaxIncidentalPrice_ != null ? other.PretaxIncidentalPrice.Clone() : null;
      taxFeeAssements_ = other.taxFeeAssements_.Clone();
      IncidentalItem = other.incidentalItem_ != null ? other.IncidentalItem.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxedIncidentalReservationNightlyQuote Clone() {
      return new TaxedIncidentalReservationNightlyQuote(this);
    }

    /// <summary>Field number for the "opsdate" field.</summary>
    public const int OpsdateFieldNumber = 1;
    private global::HOLMS.Types.Primitive.PbLocalDate opsdate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate Opsdate {
      get { return opsdate_; }
      set {
        opsdate_ = value;
      }
    }

    /// <summary>Field number for the "pretax_incidental_price" field.</summary>
    public const int PretaxIncidentalPriceFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount pretaxIncidentalPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount PretaxIncidentalPrice {
      get { return pretaxIncidentalPrice_; }
      set {
        pretaxIncidentalPrice_ = value;
      }
    }

    /// <summary>Field number for the "tax_fee_assements" field.</summary>
    public const int TaxFeeAssementsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Folio.TaxFeeAssessment> _repeated_taxFeeAssements_codec
        = pb::FieldCodec.ForMessage(26, global::HOLMS.Types.Folio.TaxFeeAssessment.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Folio.TaxFeeAssessment> taxFeeAssements_ = new pbc::RepeatedField<global::HOLMS.Types.Folio.TaxFeeAssessment>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Folio.TaxFeeAssessment> TaxFeeAssements {
      get { return taxFeeAssements_; }
    }

    /// <summary>Field number for the "incidental_item" field.</summary>
    public const int IncidentalItemFieldNumber = 4;
    private global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator incidentalItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator IncidentalItem {
      get { return incidentalItem_; }
      set {
        incidentalItem_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TaxedIncidentalReservationNightlyQuote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TaxedIncidentalReservationNightlyQuote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Opsdate, other.Opsdate)) return false;
      if (!object.Equals(PretaxIncidentalPrice, other.PretaxIncidentalPrice)) return false;
      if(!taxFeeAssements_.Equals(other.taxFeeAssements_)) return false;
      if (!object.Equals(IncidentalItem, other.IncidentalItem)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (opsdate_ != null) hash ^= Opsdate.GetHashCode();
      if (pretaxIncidentalPrice_ != null) hash ^= PretaxIncidentalPrice.GetHashCode();
      hash ^= taxFeeAssements_.GetHashCode();
      if (incidentalItem_ != null) hash ^= IncidentalItem.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (opsdate_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Opsdate);
      }
      if (pretaxIncidentalPrice_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PretaxIncidentalPrice);
      }
      taxFeeAssements_.WriteTo(output, _repeated_taxFeeAssements_codec);
      if (incidentalItem_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(IncidentalItem);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (opsdate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Opsdate);
      }
      if (pretaxIncidentalPrice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PretaxIncidentalPrice);
      }
      size += taxFeeAssements_.CalculateSize(_repeated_taxFeeAssements_codec);
      if (incidentalItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IncidentalItem);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TaxedIncidentalReservationNightlyQuote other) {
      if (other == null) {
        return;
      }
      if (other.opsdate_ != null) {
        if (opsdate_ == null) {
          opsdate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        Opsdate.MergeFrom(other.Opsdate);
      }
      if (other.pretaxIncidentalPrice_ != null) {
        if (pretaxIncidentalPrice_ == null) {
          pretaxIncidentalPrice_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        PretaxIncidentalPrice.MergeFrom(other.PretaxIncidentalPrice);
      }
      taxFeeAssements_.Add(other.taxFeeAssements_);
      if (other.incidentalItem_ != null) {
        if (incidentalItem_ == null) {
          incidentalItem_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
        }
        IncidentalItem.MergeFrom(other.IncidentalItem);
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
            if (opsdate_ == null) {
              opsdate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(opsdate_);
            break;
          }
          case 18: {
            if (pretaxIncidentalPrice_ == null) {
              pretaxIncidentalPrice_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(pretaxIncidentalPrice_);
            break;
          }
          case 26: {
            taxFeeAssements_.AddEntriesFrom(input, _repeated_taxFeeAssements_codec);
            break;
          }
          case 34: {
            if (incidentalItem_ == null) {
              incidentalItem_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
            }
            input.ReadMessage(incidentalItem_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
