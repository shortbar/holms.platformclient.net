// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/checkout/reservation_check_out_notification.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.CheckOut {

  /// <summary>Holder for reflection information generated from booking/checkout/reservation_check_out_notification.proto</summary>
  public static partial class ReservationCheckOutNotificationReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/checkout/reservation_check_out_notification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationCheckOutNotificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlib29raW5nL2NoZWNrb3V0L3Jlc2VydmF0aW9uX2NoZWNrX291dF9ub3Rp",
            "ZmljYXRpb24ucHJvdG8SHWhvbG1zLnR5cGVzLmJvb2tpbmcuY2hlY2tfb3V0",
            "Gi5ib29raW5nL2luZGljYXRvcnMvcmVzZXJ2YXRpb25faW5kaWNhdG9yLnBy",
            "b3RvGiBjcm0vZ3Vlc3RzL2d1ZXN0X2luZGljYXRvci5wcm90byLdAQofUmVz",
            "ZXJ2YXRpb25DaGVja091dE5vdGlmaWNhdGlvbhIRCglqX3dfdG9rZW4YASAB",
            "KAkSSQoLcmVzZXJ2YXRpb24YAiABKAsyNC5ob2xtcy50eXBlcy5ib29raW5n",
            "LmluZGljYXRvcnMuUmVzZXJ2YXRpb25JbmRpY2F0b3ISOAoIZ3Vlc3RfaWQY",
            "AyABKAsyJi5ob2xtcy50eXBlcy5jcm0uZ3Vlc3RzLkd1ZXN0SW5kaWNhdG9y",
            "EiIKGnJlc2VydmF0aW9uX2Jvb2tpbmdfbnVtYmVyGAQgASgJQjFaEGJvb2tp",
            "bmcvY2hlY2tvdXSqAhxIT0xNUy5UeXBlcy5Cb29raW5nLkNoZWNrT3V0YgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.CheckOut.ReservationCheckOutNotification), global::HOLMS.Types.Booking.CheckOut.ReservationCheckOutNotification.Parser, new[]{ "JWToken", "Reservation", "GuestId", "ReservationBookingNumber" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationCheckOutNotification : pb::IMessage<ReservationCheckOutNotification> {
    private static readonly pb::MessageParser<ReservationCheckOutNotification> _parser = new pb::MessageParser<ReservationCheckOutNotification>(() => new ReservationCheckOutNotification());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationCheckOutNotification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.CheckOut.ReservationCheckOutNotificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationCheckOutNotification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationCheckOutNotification(ReservationCheckOutNotification other) : this() {
      jWToken_ = other.jWToken_;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      GuestId = other.guestId_ != null ? other.GuestId.Clone() : null;
      reservationBookingNumber_ = other.reservationBookingNumber_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationCheckOutNotification Clone() {
      return new ReservationCheckOutNotification(this);
    }

    /// <summary>Field number for the "j_w_token" field.</summary>
    public const int JWTokenFieldNumber = 1;
    private string jWToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JWToken {
      get { return jWToken_; }
      set {
        jWToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "guest_id" field.</summary>
    public const int GuestIdFieldNumber = 3;
    private global::HOLMS.Types.CRM.Guests.GuestIndicator guestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.GuestIndicator GuestId {
      get { return guestId_; }
      set {
        guestId_ = value;
      }
    }

    /// <summary>Field number for the "reservation_booking_number" field.</summary>
    public const int ReservationBookingNumberFieldNumber = 4;
    private string reservationBookingNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReservationBookingNumber {
      get { return reservationBookingNumber_; }
      set {
        reservationBookingNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationCheckOutNotification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationCheckOutNotification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(GuestId, other.GuestId)) return false;
      if (ReservationBookingNumber != other.ReservationBookingNumber) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (guestId_ != null) hash ^= GuestId.GetHashCode();
      if (ReservationBookingNumber.Length != 0) hash ^= ReservationBookingNumber.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (JWToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JWToken);
      }
      if (reservation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reservation);
      }
      if (guestId_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GuestId);
      }
      if (ReservationBookingNumber.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ReservationBookingNumber);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JWToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JWToken);
      }
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (guestId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GuestId);
      }
      if (ReservationBookingNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReservationBookingNumber);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationCheckOutNotification other) {
      if (other == null) {
        return;
      }
      if (other.JWToken.Length != 0) {
        JWToken = other.JWToken;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.guestId_ != null) {
        if (guestId_ == null) {
          guestId_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
        }
        GuestId.MergeFrom(other.GuestId);
      }
      if (other.ReservationBookingNumber.Length != 0) {
        ReservationBookingNumber = other.ReservationBookingNumber;
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
            JWToken = input.ReadString();
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
            if (guestId_ == null) {
              guestId_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
            }
            input.ReadMessage(guestId_);
            break;
          }
          case 34: {
            ReservationBookingNumber = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
