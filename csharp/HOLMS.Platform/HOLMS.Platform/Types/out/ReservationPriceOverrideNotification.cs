// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/pricing/reservation_price_override_notification.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Pricing {

  /// <summary>Holder for reflection information generated from booking/pricing/reservation_price_override_notification.proto</summary>
  public static partial class ReservationPriceOverrideNotificationReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/pricing/reservation_price_override_notification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationPriceOverrideNotificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1ib29raW5nL3ByaWNpbmcvcmVzZXJ2YXRpb25fcHJpY2Vfb3ZlcnJpZGVf",
            "bm90aWZpY2F0aW9uLnByb3RvEhtob2xtcy50eXBlcy5ib29raW5nLnByaWNp",
            "bmcaLmJvb2tpbmcvcmVzZXJ2YXRpb25zL3Jlc2VydmF0aW9uX3N1bW1hcnku",
            "cHJvdG8aLmJvb2tpbmcvcHJpY2luZy9wcmV0YXhfcmVzZXJ2YXRpb25fcXVv",
            "dGUucHJvdG8i3AEKJFJlc2VydmF0aW9uUHJpY2VPdmVycmlkZU5vdGlmaWNh",
            "dGlvbhIRCglqX3dfdG9rZW4YASABKAkSUQoTcmVzZXJ2YXRpb25fc3VtbWFy",
            "eRgCIAEoCzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcucmVzZXJ2YXRpb25zLlJl",
            "c2VydmF0aW9uU3VtbWFyeRJOChFyZXNlcnZhdGlvbl9xdW90ZRgDIAEoCzIz",
            "LmhvbG1zLnR5cGVzLmJvb2tpbmcucHJpY2luZy5QcmV0YXhSZXNlcnZhdGlv",
            "blF1b3RlQjRaFGJvb2tpbmcvcmVzZXJ2YXRpb25zqgIbSE9MTVMuVHlwZXMu",
            "Qm9va2luZy5QcmljaW5nYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Reservations.ReservationSummaryReflection.Descriptor, global::HOLMS.Types.Booking.Pricing.PretaxReservationQuoteReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Pricing.ReservationPriceOverrideNotification), global::HOLMS.Types.Booking.Pricing.ReservationPriceOverrideNotification.Parser, new[]{ "JWToken", "ReservationSummary", "ReservationQuote" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationPriceOverrideNotification : pb::IMessage<ReservationPriceOverrideNotification> {
    private static readonly pb::MessageParser<ReservationPriceOverrideNotification> _parser = new pb::MessageParser<ReservationPriceOverrideNotification>(() => new ReservationPriceOverrideNotification());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationPriceOverrideNotification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Pricing.ReservationPriceOverrideNotificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationPriceOverrideNotification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationPriceOverrideNotification(ReservationPriceOverrideNotification other) : this() {
      jWToken_ = other.jWToken_;
      ReservationSummary = other.reservationSummary_ != null ? other.ReservationSummary.Clone() : null;
      ReservationQuote = other.reservationQuote_ != null ? other.ReservationQuote.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationPriceOverrideNotification Clone() {
      return new ReservationPriceOverrideNotification(this);
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

    /// <summary>Field number for the "reservation_summary" field.</summary>
    public const int ReservationSummaryFieldNumber = 2;
    private global::HOLMS.Types.Booking.Reservations.ReservationSummary reservationSummary_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Reservations.ReservationSummary ReservationSummary {
      get { return reservationSummary_; }
      set {
        reservationSummary_ = value;
      }
    }

    /// <summary>Field number for the "reservation_quote" field.</summary>
    public const int ReservationQuoteFieldNumber = 3;
    private global::HOLMS.Types.Booking.Pricing.PretaxReservationQuote reservationQuote_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Pricing.PretaxReservationQuote ReservationQuote {
      get { return reservationQuote_; }
      set {
        reservationQuote_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationPriceOverrideNotification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationPriceOverrideNotification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (!object.Equals(ReservationSummary, other.ReservationSummary)) return false;
      if (!object.Equals(ReservationQuote, other.ReservationQuote)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (reservationSummary_ != null) hash ^= ReservationSummary.GetHashCode();
      if (reservationQuote_ != null) hash ^= ReservationQuote.GetHashCode();
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
      if (reservationSummary_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReservationSummary);
      }
      if (reservationQuote_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ReservationQuote);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JWToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JWToken);
      }
      if (reservationSummary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReservationSummary);
      }
      if (reservationQuote_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReservationQuote);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationPriceOverrideNotification other) {
      if (other == null) {
        return;
      }
      if (other.JWToken.Length != 0) {
        JWToken = other.JWToken;
      }
      if (other.reservationSummary_ != null) {
        if (reservationSummary_ == null) {
          reservationSummary_ = new global::HOLMS.Types.Booking.Reservations.ReservationSummary();
        }
        ReservationSummary.MergeFrom(other.ReservationSummary);
      }
      if (other.reservationQuote_ != null) {
        if (reservationQuote_ == null) {
          reservationQuote_ = new global::HOLMS.Types.Booking.Pricing.PretaxReservationQuote();
        }
        ReservationQuote.MergeFrom(other.ReservationQuote);
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
            if (reservationSummary_ == null) {
              reservationSummary_ = new global::HOLMS.Types.Booking.Reservations.ReservationSummary();
            }
            input.ReadMessage(reservationSummary_);
            break;
          }
          case 26: {
            if (reservationQuote_ == null) {
              reservationQuote_ = new global::HOLMS.Types.Booking.Pricing.PretaxReservationQuote();
            }
            input.ReadMessage(reservationQuote_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
