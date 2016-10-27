// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/pricing/open_price_estimate_request.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Pricing {

  /// <summary>Holder for reflection information generated from booking/pricing/open_price_estimate_request.proto</summary>
  public static partial class OpenPriceEstimateRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/pricing/open_price_estimate_request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpenPriceEstimateRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFib29raW5nL3ByaWNpbmcvb3Blbl9wcmljZV9lc3RpbWF0ZV9yZXF1ZXN0",
            "LnByb3RvEhtob2xtcy50eXBlcy5ib29raW5nLnByaWNpbmcaKnByaW1pdGl2",
            "ZS9wYl9pbmNsdXNpdmVfb3BzZGF0ZV9yYW5nZS5wcm90bxouYm9va2luZy9p",
            "bmRpY2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRvci5wcm90bxokc3VwcGx5",
            "L3F1YWxpZmljYXRpb25faW5kaWNhdG9yLnByb3RvGitzdXBwbHkvcm9vbV90",
            "eXBlcy9yb29tX3R5cGVfaW5kaWNhdG9yLnByb3RvItQCChhPcGVuUHJpY2VF",
            "c3RpbWF0ZVJlcXVlc3QSQgoKZGF0ZV9yYW5nZRgBIAEoCzIuLmhvbG1zLnR5",
            "cGVzLnByaW1pdGl2ZS5QYkluY2x1c2l2ZU9wc2RhdGVSYW5nZRJJCgtyZXNl",
            "cnZhdGlvbhgCIAEoCzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9y",
            "cy5SZXNlcnZhdGlvbkluZGljYXRvchJDCglyb29tX3R5cGUYAyABKAsyMC5o",
            "b2xtcy50eXBlcy5zdXBwbHkucm9vbV90eXBlcy5Sb29tVHlwZUluZGljYXRv",
            "chI1CgFxGAQgASgLMiouaG9sbXMudHlwZXMuc3VwcGx5LlF1YWxpZmljYXRp",
            "b25JbmRpY2F0b3ISEgoKdGF4X2V4ZW1wdBgFIAEoCBIZChFhZHVsdF9ndWVz",
            "dF9jb3VudBgGIAEoBUIvWg9ib29raW5nL3ByaWNpbmeqAhtIT0xNUy5UeXBl",
            "cy5Cb29raW5nLlByaWNpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.QualificationIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Pricing.OpenPriceEstimateRequest), global::HOLMS.Types.Booking.Pricing.OpenPriceEstimateRequest.Parser, new[]{ "DateRange", "Reservation", "RoomType", "Q", "TaxExempt", "AdultGuestCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OpenPriceEstimateRequest : pb::IMessage<OpenPriceEstimateRequest> {
    private static readonly pb::MessageParser<OpenPriceEstimateRequest> _parser = new pb::MessageParser<OpenPriceEstimateRequest>(() => new OpenPriceEstimateRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OpenPriceEstimateRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Pricing.OpenPriceEstimateRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenPriceEstimateRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenPriceEstimateRequest(OpenPriceEstimateRequest other) : this() {
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      RoomType = other.roomType_ != null ? other.RoomType.Clone() : null;
      Q = other.q_ != null ? other.Q.Clone() : null;
      taxExempt_ = other.taxExempt_;
      adultGuestCount_ = other.adultGuestCount_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenPriceEstimateRequest Clone() {
      return new OpenPriceEstimateRequest(this);
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 1;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 2;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "room_type" field.</summary>
    public const int RoomTypeFieldNumber = 3;
    private global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator roomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator RoomType {
      get { return roomType_; }
      set {
        roomType_ = value;
      }
    }

    /// <summary>Field number for the "q" field.</summary>
    public const int QFieldNumber = 4;
    private global::HOLMS.Types.Supply.QualificationIndicator q_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.QualificationIndicator Q {
      get { return q_; }
      set {
        q_ = value;
      }
    }

    /// <summary>Field number for the "tax_exempt" field.</summary>
    public const int TaxExemptFieldNumber = 5;
    private bool taxExempt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TaxExempt {
      get { return taxExempt_; }
      set {
        taxExempt_ = value;
      }
    }

    /// <summary>Field number for the "adult_guest_count" field.</summary>
    public const int AdultGuestCountFieldNumber = 6;
    private int adultGuestCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AdultGuestCount {
      get { return adultGuestCount_; }
      set {
        adultGuestCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OpenPriceEstimateRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OpenPriceEstimateRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(RoomType, other.RoomType)) return false;
      if (!object.Equals(Q, other.Q)) return false;
      if (TaxExempt != other.TaxExempt) return false;
      if (AdultGuestCount != other.AdultGuestCount) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (roomType_ != null) hash ^= RoomType.GetHashCode();
      if (q_ != null) hash ^= Q.GetHashCode();
      if (TaxExempt != false) hash ^= TaxExempt.GetHashCode();
      if (AdultGuestCount != 0) hash ^= AdultGuestCount.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (dateRange_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DateRange);
      }
      if (reservation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reservation);
      }
      if (roomType_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RoomType);
      }
      if (q_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Q);
      }
      if (TaxExempt != false) {
        output.WriteRawTag(40);
        output.WriteBool(TaxExempt);
      }
      if (AdultGuestCount != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(AdultGuestCount);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (roomType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomType);
      }
      if (q_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Q);
      }
      if (TaxExempt != false) {
        size += 1 + 1;
      }
      if (AdultGuestCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdultGuestCount);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OpenPriceEstimateRequest other) {
      if (other == null) {
        return;
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.roomType_ != null) {
        if (roomType_ == null) {
          roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
        }
        RoomType.MergeFrom(other.RoomType);
      }
      if (other.q_ != null) {
        if (q_ == null) {
          q_ = new global::HOLMS.Types.Supply.QualificationIndicator();
        }
        Q.MergeFrom(other.Q);
      }
      if (other.TaxExempt != false) {
        TaxExempt = other.TaxExempt;
      }
      if (other.AdultGuestCount != 0) {
        AdultGuestCount = other.AdultGuestCount;
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
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
          case 18: {
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 26: {
            if (roomType_ == null) {
              roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
            }
            input.ReadMessage(roomType_);
            break;
          }
          case 34: {
            if (q_ == null) {
              q_ = new global::HOLMS.Types.Supply.QualificationIndicator();
            }
            input.ReadMessage(q_);
            break;
          }
          case 40: {
            TaxExempt = input.ReadBool();
            break;
          }
          case 48: {
            AdultGuestCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
