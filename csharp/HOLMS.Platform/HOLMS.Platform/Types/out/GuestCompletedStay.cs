// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: crm/guests/guest_completed_stay.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.CRM.Guests {

  /// <summary>Holder for reflection information generated from crm/guests/guest_completed_stay.proto</summary>
  public static partial class GuestCompletedStayReflection {

    #region Descriptor
    /// <summary>File descriptor for crm/guests/guest_completed_stay.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GuestCompletedStayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVjcm0vZ3Vlc3RzL2d1ZXN0X2NvbXBsZXRlZF9zdGF5LnByb3RvEhZob2xt",
            "cy50eXBlcy5jcm0uZ3Vlc3RzGh9wcmltaXRpdmUvbW9uZXRhcnlfYW1vdW50",
            "LnByb3RvGh1wcmltaXRpdmUvcGJfbG9jYWxfZGF0ZS5wcm90bxouYm9va2lu",
            "Zy9pbmRpY2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRvci5wcm90bxogY3Jt",
            "L2d1ZXN0cy9ndWVzdF9pbmRpY2F0b3IucHJvdG8aJW9wZXJhdGlvbnMvcm9v",
            "bXMvcm9vbV9pbmRpY2F0b3IucHJvdG8izQIKEkd1ZXN0Q29tcGxldGVkU3Rh",
            "eRI5Cg1jaGVja19pbl9kYXRlGAEgASgLMiIuaG9sbXMudHlwZXMucHJpbWl0",
            "aXZlLlBiTG9jYWxEYXRlEjsKDGF2ZXJhZ2VfcmF0ZRgCIAEoCzIlLmhvbG1z",
            "LnR5cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBIiChpyZXNlcnZhdGlv",
            "bl9ib29raW5nX251bWJlchgDIAEoCRJMCg5yZXNlcnZhdGlvbl9pZBgEIAEo",
            "CzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5SZXNlcnZhdGlv",
            "bkluZGljYXRvchITCgtyb29tX251bWJlchgFIAEoCRI4CghndWVzdF9pZBgG",
            "IAEoCzImLmhvbG1zLnR5cGVzLmNybS5ndWVzdHMuR3Vlc3RJbmRpY2F0b3JC",
            "JVoKY3JtL2d1ZXN0c6oCFkhPTE1TLlR5cGVzLkNSTS5HdWVzdHNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.Guests.GuestCompletedStay), global::HOLMS.Types.CRM.Guests.GuestCompletedStay.Parser, new[]{ "CheckInDate", "AverageRate", "ReservationBookingNumber", "ReservationId", "RoomNumber", "GuestId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GuestCompletedStay : pb::IMessage<GuestCompletedStay> {
    private static readonly pb::MessageParser<GuestCompletedStay> _parser = new pb::MessageParser<GuestCompletedStay>(() => new GuestCompletedStay());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GuestCompletedStay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.Guests.GuestCompletedStayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GuestCompletedStay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GuestCompletedStay(GuestCompletedStay other) : this() {
      CheckInDate = other.checkInDate_ != null ? other.CheckInDate.Clone() : null;
      AverageRate = other.averageRate_ != null ? other.AverageRate.Clone() : null;
      reservationBookingNumber_ = other.reservationBookingNumber_;
      ReservationId = other.reservationId_ != null ? other.ReservationId.Clone() : null;
      roomNumber_ = other.roomNumber_;
      GuestId = other.guestId_ != null ? other.GuestId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GuestCompletedStay Clone() {
      return new GuestCompletedStay(this);
    }

    /// <summary>Field number for the "check_in_date" field.</summary>
    public const int CheckInDateFieldNumber = 1;
    private global::HOLMS.Types.Primitive.PbLocalDate checkInDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate CheckInDate {
      get { return checkInDate_; }
      set {
        checkInDate_ = value;
      }
    }

    /// <summary>Field number for the "average_rate" field.</summary>
    public const int AverageRateFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount averageRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount AverageRate {
      get { return averageRate_; }
      set {
        averageRate_ = value;
      }
    }

    /// <summary>Field number for the "reservation_booking_number" field.</summary>
    public const int ReservationBookingNumberFieldNumber = 3;
    private string reservationBookingNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReservationBookingNumber {
      get { return reservationBookingNumber_; }
      set {
        reservationBookingNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reservation_id" field.</summary>
    public const int ReservationIdFieldNumber = 4;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator ReservationId {
      get { return reservationId_; }
      set {
        reservationId_ = value;
      }
    }

    /// <summary>Field number for the "room_number" field.</summary>
    public const int RoomNumberFieldNumber = 5;
    private string roomNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomNumber {
      get { return roomNumber_; }
      set {
        roomNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "guest_id" field.</summary>
    public const int GuestIdFieldNumber = 6;
    private global::HOLMS.Types.CRM.Guests.GuestIndicator guestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.GuestIndicator GuestId {
      get { return guestId_; }
      set {
        guestId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GuestCompletedStay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GuestCompletedStay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CheckInDate, other.CheckInDate)) return false;
      if (!object.Equals(AverageRate, other.AverageRate)) return false;
      if (ReservationBookingNumber != other.ReservationBookingNumber) return false;
      if (!object.Equals(ReservationId, other.ReservationId)) return false;
      if (RoomNumber != other.RoomNumber) return false;
      if (!object.Equals(GuestId, other.GuestId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (checkInDate_ != null) hash ^= CheckInDate.GetHashCode();
      if (averageRate_ != null) hash ^= AverageRate.GetHashCode();
      if (ReservationBookingNumber.Length != 0) hash ^= ReservationBookingNumber.GetHashCode();
      if (reservationId_ != null) hash ^= ReservationId.GetHashCode();
      if (RoomNumber.Length != 0) hash ^= RoomNumber.GetHashCode();
      if (guestId_ != null) hash ^= GuestId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (checkInDate_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CheckInDate);
      }
      if (averageRate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AverageRate);
      }
      if (ReservationBookingNumber.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ReservationBookingNumber);
      }
      if (reservationId_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReservationId);
      }
      if (RoomNumber.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(RoomNumber);
      }
      if (guestId_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(GuestId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (checkInDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CheckInDate);
      }
      if (averageRate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AverageRate);
      }
      if (ReservationBookingNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReservationBookingNumber);
      }
      if (reservationId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReservationId);
      }
      if (RoomNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomNumber);
      }
      if (guestId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GuestId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GuestCompletedStay other) {
      if (other == null) {
        return;
      }
      if (other.checkInDate_ != null) {
        if (checkInDate_ == null) {
          checkInDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        CheckInDate.MergeFrom(other.CheckInDate);
      }
      if (other.averageRate_ != null) {
        if (averageRate_ == null) {
          averageRate_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        AverageRate.MergeFrom(other.AverageRate);
      }
      if (other.ReservationBookingNumber.Length != 0) {
        ReservationBookingNumber = other.ReservationBookingNumber;
      }
      if (other.reservationId_ != null) {
        if (reservationId_ == null) {
          reservationId_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        ReservationId.MergeFrom(other.ReservationId);
      }
      if (other.RoomNumber.Length != 0) {
        RoomNumber = other.RoomNumber;
      }
      if (other.guestId_ != null) {
        if (guestId_ == null) {
          guestId_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
        }
        GuestId.MergeFrom(other.GuestId);
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
            if (checkInDate_ == null) {
              checkInDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(checkInDate_);
            break;
          }
          case 18: {
            if (averageRate_ == null) {
              averageRate_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(averageRate_);
            break;
          }
          case 26: {
            ReservationBookingNumber = input.ReadString();
            break;
          }
          case 34: {
            if (reservationId_ == null) {
              reservationId_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservationId_);
            break;
          }
          case 42: {
            RoomNumber = input.ReadString();
            break;
          }
          case 50: {
            if (guestId_ == null) {
              guestId_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
            }
            input.ReadMessage(guestId_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
