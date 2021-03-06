// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/reservation_folio_close_notification.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/reservation_folio_close_notification.proto</summary>
  public static partial class ReservationFolioCloseNotificationReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/reservation_folio_close_notification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationFolioCloseNotificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBmb2xpby9yZXNlcnZhdGlvbl9mb2xpb19jbG9zZV9ub3RpZmljYXRpb24u",
            "cHJvdG8SEWhvbG1zLnR5cGVzLmZvbGlvGi5ib29raW5nL2luZGljYXRvcnMv",
            "cmVzZXJ2YXRpb25faW5kaWNhdG9yLnByb3RvGh9nb29nbGUvcHJvdG9idWYv",
            "VGltZXN0YW1wLnByb3RvIrsBCiFSZXNlcnZhdGlvbkZvbGlvQ2xvc2VOb3Rp",
            "ZmljYXRpb24SEQoJal93X3Rva2VuGAEgASgJEkkKC3Jlc2VydmF0aW9uGAIg",
            "ASgLMjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2VydmF0",
            "aW9uSW5kaWNhdG9yEjgKFHByZXZpb3VzbHlfY2xvc2VkX2F0GAMgASgLMhou",
            "Z29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEIUqgIRSE9MTVMuVHlwZXMuRm9s",
            "aW9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.ReservationFolioCloseNotification), global::HOLMS.Types.Folio.ReservationFolioCloseNotification.Parser, new[]{ "JWToken", "Reservation", "PreviouslyClosedAt" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationFolioCloseNotification : pb::IMessage<ReservationFolioCloseNotification> {
    private static readonly pb::MessageParser<ReservationFolioCloseNotification> _parser = new pb::MessageParser<ReservationFolioCloseNotification>(() => new ReservationFolioCloseNotification());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationFolioCloseNotification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.ReservationFolioCloseNotificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioCloseNotification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioCloseNotification(ReservationFolioCloseNotification other) : this() {
      jWToken_ = other.jWToken_;
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      PreviouslyClosedAt = other.previouslyClosedAt_ != null ? other.PreviouslyClosedAt.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationFolioCloseNotification Clone() {
      return new ReservationFolioCloseNotification(this);
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

    /// <summary>Field number for the "previously_closed_at" field.</summary>
    public const int PreviouslyClosedAtFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp previouslyClosedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp PreviouslyClosedAt {
      get { return previouslyClosedAt_; }
      set {
        previouslyClosedAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReservationFolioCloseNotification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationFolioCloseNotification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JWToken != other.JWToken) return false;
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(PreviouslyClosedAt, other.PreviouslyClosedAt)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JWToken.Length != 0) hash ^= JWToken.GetHashCode();
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (previouslyClosedAt_ != null) hash ^= PreviouslyClosedAt.GetHashCode();
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
      if (previouslyClosedAt_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PreviouslyClosedAt);
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
      if (previouslyClosedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PreviouslyClosedAt);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReservationFolioCloseNotification other) {
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
      if (other.previouslyClosedAt_ != null) {
        if (previouslyClosedAt_ == null) {
          previouslyClosedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        PreviouslyClosedAt.MergeFrom(other.PreviouslyClosedAt);
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
            if (previouslyClosedAt_ == null) {
              previouslyClosedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(previouslyClosedAt_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
