// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/pricing/reservation_price_estimate.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Pricing {

  /// <summary>Holder for reflection information generated from booking/pricing/reservation_price_estimate.proto</summary>
  public static partial class ReservationPriceEstimateReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/pricing/reservation_price_estimate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationPriceEstimateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBib29raW5nL3ByaWNpbmcvcmVzZXJ2YXRpb25fcHJpY2VfZXN0aW1hdGUu",
            "cHJvdG8SG2hvbG1zLnR5cGVzLmJvb2tpbmcucHJpY2luZxofcHJpbWl0aXZl",
            "L21vbmV0YXJ5X2Ftb3VudC5wcm90bxohYm9va2luZy9wcmljaW5nL3ByaWNl",
            "X25pZ2h0LnByb3RvIrMEChhSZXNlcnZhdGlvblByaWNlRXN0aW1hdGUSNwoG",
            "cHJpY2VzGAEgAygLMicuaG9sbXMudHlwZXMuYm9va2luZy5wcmljaW5nLlBy",
            "aWNlTmlnaHQSPwoQbG9kZ2luZ19zdWJ0b3RhbBgCIAEoCzIlLmhvbG1zLnR5",
            "cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJCChNpbmNpZGVudGFsX3N1",
            "YnRvdGFsGAMgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5",
            "QW1vdW50Ej0KDnRheGVzX3N1YnRvdGFsGAQgASgLMiUuaG9sbXMudHlwZXMu",
            "cHJpbWl0aXZlLk1vbmV0YXJ5QW1vdW50EjwKDWZlZXNfc3VidG90YWwYBSAB",
            "KAsyJS5ob2xtcy50eXBlcy5wcmltaXRpdmUuTW9uZXRhcnlBbW91bnQSPgoP",
            "ZXN0aW1hdGVkX3RvdGFsGAYgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZl",
            "Lk1vbmV0YXJ5QW1vdW50EhQKDGlzX3ByaWNlYWJsZRgHIAEoCBIUCgxpc19h",
            "dmFpbGFibGUYCCABKAgSFQoNdmlvbGF0ZXNfbWxvcxgJIAEoCBIUCgx2aW9s",
            "YXRlc19jdGEYCiABKAgSQwoSc3VwcGxpZWRfc3VidG90YWxzGAsgAygLMicu",
            "aG9sbXMudHlwZXMuYm9va2luZy5wcmljaW5nLlByaWNlTmlnaHRCL1oPYm9v",
            "a2luZy9wcmljaW5nqgIbSE9MTVMuVHlwZXMuQm9va2luZy5QcmljaW5nYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Booking.Pricing.PriceNightReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Pricing.ReservationPriceEstimate), global::HOLMS.Types.Booking.Pricing.ReservationPriceEstimate.Parser, new[]{ "Prices", "LodgingSubtotal", "IncidentalSubtotal", "TaxesSubtotal", "FeesSubtotal", "EstimatedTotal", "IsPriceable", "IsAvailable", "ViolatesMlos", "ViolatesCta", "SuppliedSubtotals" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationPriceEstimate : pb::IMessage<ReservationPriceEstimate> {
    private static readonly pb::MessageParser<ReservationPriceEstimate> _parser = new pb::MessageParser<ReservationPriceEstimate>(() => new ReservationPriceEstimate());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationPriceEstimate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Pricing.ReservationPriceEstimateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationPriceEstimate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationPriceEstimate(ReservationPriceEstimate other) : this() {
      prices_ = other.prices_.Clone();
      LodgingSubtotal = other.lodgingSubtotal_ != null ? other.LodgingSubtotal.Clone() : null;
      IncidentalSubtotal = other.incidentalSubtotal_ != null ? other.IncidentalSubtotal.Clone() : null;
      TaxesSubtotal = other.taxesSubtotal_ != null ? other.TaxesSubtotal.Clone() : null;
      FeesSubtotal = other.feesSubtotal_ != null ? other.FeesSubtotal.Clone() : null;
      EstimatedTotal = other.estimatedTotal_ != null ? other.EstimatedTotal.Clone() : null;
      isPriceable_ = other.isPriceable_;
      isAvailable_ = other.isAvailable_;
      violatesMlos_ = other.violatesMlos_;
      violatesCta_ = other.violatesCta_;
      suppliedSubtotals_ = other.suppliedSubtotals_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationPriceEstimate Clone() {
      return new ReservationPriceEstimate(this);
    }

    /// <summary>Field number for the "prices" field.</summary>
    public const int PricesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Pricing.PriceNight> _repeated_prices_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Booking.Pricing.PriceNight.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> prices_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> Prices {
      get { return prices_; }
    }

    /// <summary>Field number for the "lodging_subtotal" field.</summary>
    public const int LodgingSubtotalFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount lodgingSubtotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount LodgingSubtotal {
      get { return lodgingSubtotal_; }
      set {
        lodgingSubtotal_ = value;
      }
    }

    /// <summary>Field number for the "incidental_subtotal" field.</summary>
    public const int IncidentalSubtotalFieldNumber = 3;
    private global::HOLMS.Types.Primitive.MonetaryAmount incidentalSubtotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount IncidentalSubtotal {
      get { return incidentalSubtotal_; }
      set {
        incidentalSubtotal_ = value;
      }
    }

    /// <summary>Field number for the "taxes_subtotal" field.</summary>
    public const int TaxesSubtotalFieldNumber = 4;
    private global::HOLMS.Types.Primitive.MonetaryAmount taxesSubtotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount TaxesSubtotal {
      get { return taxesSubtotal_; }
      set {
        taxesSubtotal_ = value;
      }
    }

    /// <summary>Field number for the "fees_subtotal" field.</summary>
    public const int FeesSubtotalFieldNumber = 5;
    private global::HOLMS.Types.Primitive.MonetaryAmount feesSubtotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount FeesSubtotal {
      get { return feesSubtotal_; }
      set {
        feesSubtotal_ = value;
      }
    }

    /// <summary>Field number for the "estimated_total" field.</summary>
    public const int EstimatedTotalFieldNumber = 6;
    private global::HOLMS.Types.Primitive.MonetaryAmount estimatedTotal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount EstimatedTotal {
      get { return estimatedTotal_; }
      set {
        estimatedTotal_ = value;
      }
    }

    /// <summary>Field number for the "is_priceable" field.</summary>
    public const int IsPriceableFieldNumber = 7;
    private bool isPriceable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsPriceable {
      get { return isPriceable_; }
      set {
        isPriceable_ = value;
      }
    }

    /// <summary>Field number for the "is_available" field.</summary>
    public const int IsAvailableFieldNumber = 8;
    private bool isAvailable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsAvailable {
      get { return isAvailable_; }
      set {
        isAvailable_ = value;
      }
    }

    /// <summary>Field number for the "violates_mlos" field.</summary>
    public const int ViolatesMlosFieldNumber = 9;
    private bool violatesMlos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ViolatesMlos {
      get { return violatesMlos_; }
      set {
        violatesMlos_ = value;
      }
    }

    /// <summary>Field number for the "violates_cta" field.</summary>
    public const int ViolatesCtaFieldNumber = 10;
    private bool violatesCta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ViolatesCta {
      get { return violatesCta_; }
      set {
        violatesCta_ = value;
      }
    }

    /// <summary>Field number for the "supplied_subtotals" field.</summary>
    public const int SuppliedSubtotalsFieldNumber = 11;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Pricing.PriceNight> _repeated_suppliedSubtotals_codec
        = pb::FieldCodec.ForMessage(90, global::HOLMS.Types.Booking.Pricing.PriceNight.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> suppliedSubtotals_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight>();
    /// <summary>
    /// Raw lodging subtotals before comp stay or taxes
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Pricing.PriceNight> SuppliedSubtotals {
      get { return suppliedSubtotals_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationPriceEstimate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationPriceEstimate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!prices_.Equals(other.prices_)) return false;
      if (!object.Equals(LodgingSubtotal, other.LodgingSubtotal)) return false;
      if (!object.Equals(IncidentalSubtotal, other.IncidentalSubtotal)) return false;
      if (!object.Equals(TaxesSubtotal, other.TaxesSubtotal)) return false;
      if (!object.Equals(FeesSubtotal, other.FeesSubtotal)) return false;
      if (!object.Equals(EstimatedTotal, other.EstimatedTotal)) return false;
      if (IsPriceable != other.IsPriceable) return false;
      if (IsAvailable != other.IsAvailable) return false;
      if (ViolatesMlos != other.ViolatesMlos) return false;
      if (ViolatesCta != other.ViolatesCta) return false;
      if(!suppliedSubtotals_.Equals(other.suppliedSubtotals_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= prices_.GetHashCode();
      if (lodgingSubtotal_ != null) hash ^= LodgingSubtotal.GetHashCode();
      if (incidentalSubtotal_ != null) hash ^= IncidentalSubtotal.GetHashCode();
      if (taxesSubtotal_ != null) hash ^= TaxesSubtotal.GetHashCode();
      if (feesSubtotal_ != null) hash ^= FeesSubtotal.GetHashCode();
      if (estimatedTotal_ != null) hash ^= EstimatedTotal.GetHashCode();
      if (IsPriceable != false) hash ^= IsPriceable.GetHashCode();
      if (IsAvailable != false) hash ^= IsAvailable.GetHashCode();
      if (ViolatesMlos != false) hash ^= ViolatesMlos.GetHashCode();
      if (ViolatesCta != false) hash ^= ViolatesCta.GetHashCode();
      hash ^= suppliedSubtotals_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      prices_.WriteTo(output, _repeated_prices_codec);
      if (lodgingSubtotal_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(LodgingSubtotal);
      }
      if (incidentalSubtotal_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(IncidentalSubtotal);
      }
      if (taxesSubtotal_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TaxesSubtotal);
      }
      if (feesSubtotal_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(FeesSubtotal);
      }
      if (estimatedTotal_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EstimatedTotal);
      }
      if (IsPriceable != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsPriceable);
      }
      if (IsAvailable != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsAvailable);
      }
      if (ViolatesMlos != false) {
        output.WriteRawTag(72);
        output.WriteBool(ViolatesMlos);
      }
      if (ViolatesCta != false) {
        output.WriteRawTag(80);
        output.WriteBool(ViolatesCta);
      }
      suppliedSubtotals_.WriteTo(output, _repeated_suppliedSubtotals_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += prices_.CalculateSize(_repeated_prices_codec);
      if (lodgingSubtotal_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LodgingSubtotal);
      }
      if (incidentalSubtotal_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IncidentalSubtotal);
      }
      if (taxesSubtotal_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TaxesSubtotal);
      }
      if (feesSubtotal_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FeesSubtotal);
      }
      if (estimatedTotal_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EstimatedTotal);
      }
      if (IsPriceable != false) {
        size += 1 + 1;
      }
      if (IsAvailable != false) {
        size += 1 + 1;
      }
      if (ViolatesMlos != false) {
        size += 1 + 1;
      }
      if (ViolatesCta != false) {
        size += 1 + 1;
      }
      size += suppliedSubtotals_.CalculateSize(_repeated_suppliedSubtotals_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationPriceEstimate other) {
      if (other == null) {
        return;
      }
      prices_.Add(other.prices_);
      if (other.lodgingSubtotal_ != null) {
        if (lodgingSubtotal_ == null) {
          lodgingSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        LodgingSubtotal.MergeFrom(other.LodgingSubtotal);
      }
      if (other.incidentalSubtotal_ != null) {
        if (incidentalSubtotal_ == null) {
          incidentalSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        IncidentalSubtotal.MergeFrom(other.IncidentalSubtotal);
      }
      if (other.taxesSubtotal_ != null) {
        if (taxesSubtotal_ == null) {
          taxesSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        TaxesSubtotal.MergeFrom(other.TaxesSubtotal);
      }
      if (other.feesSubtotal_ != null) {
        if (feesSubtotal_ == null) {
          feesSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        FeesSubtotal.MergeFrom(other.FeesSubtotal);
      }
      if (other.estimatedTotal_ != null) {
        if (estimatedTotal_ == null) {
          estimatedTotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        EstimatedTotal.MergeFrom(other.EstimatedTotal);
      }
      if (other.IsPriceable != false) {
        IsPriceable = other.IsPriceable;
      }
      if (other.IsAvailable != false) {
        IsAvailable = other.IsAvailable;
      }
      if (other.ViolatesMlos != false) {
        ViolatesMlos = other.ViolatesMlos;
      }
      if (other.ViolatesCta != false) {
        ViolatesCta = other.ViolatesCta;
      }
      suppliedSubtotals_.Add(other.suppliedSubtotals_);
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
            prices_.AddEntriesFrom(input, _repeated_prices_codec);
            break;
          }
          case 18: {
            if (lodgingSubtotal_ == null) {
              lodgingSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(lodgingSubtotal_);
            break;
          }
          case 26: {
            if (incidentalSubtotal_ == null) {
              incidentalSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(incidentalSubtotal_);
            break;
          }
          case 34: {
            if (taxesSubtotal_ == null) {
              taxesSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(taxesSubtotal_);
            break;
          }
          case 42: {
            if (feesSubtotal_ == null) {
              feesSubtotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(feesSubtotal_);
            break;
          }
          case 50: {
            if (estimatedTotal_ == null) {
              estimatedTotal_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(estimatedTotal_);
            break;
          }
          case 56: {
            IsPriceable = input.ReadBool();
            break;
          }
          case 64: {
            IsAvailable = input.ReadBool();
            break;
          }
          case 72: {
            ViolatesMlos = input.ReadBool();
            break;
          }
          case 80: {
            ViolatesCta = input.ReadBool();
            break;
          }
          case 90: {
            suppliedSubtotals_.AddEntriesFrom(input, _repeated_suppliedSubtotals_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
