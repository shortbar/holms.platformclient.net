// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/folio/requested_reservation_posting.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Folio {

  /// <summary>Holder for reflection information generated from money/folio/requested_reservation_posting.proto</summary>
  public static partial class RequestedReservationPostingReflection {

    #region Descriptor
    /// <summary>File descriptor for money/folio/requested_reservation_posting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestedReservationPostingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9tb25leS9mb2xpby9yZXF1ZXN0ZWRfcmVzZXJ2YXRpb25fcG9zdGluZy5w",
            "cm90bxIXaG9sbXMudHlwZXMubW9uZXkuZm9saW8aLmJvb2tpbmcvaW5kaWNh",
            "dG9ycy9yZXNlcnZhdGlvbl9pbmRpY2F0b3IucHJvdG8aMW1vbmV5L2ZvbGlv",
            "L3JlcXVlc3RlZF9jaGFyZ2VfY3JlZGl0X3Bvc3RpbmcucHJvdG8irgEKG1Jl",
            "cXVlc3RlZFJlc2VydmF0aW9uUG9zdGluZxJJCgtyZXNlcnZhdGlvbhgBIAEo",
            "CzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5SZXNlcnZhdGlv",
            "bkluZGljYXRvchJECgVsaW5lcxgCIAMoCzI1LmhvbG1zLnR5cGVzLm1vbmV5",
            "LmZvbGlvLlJlcXVlc3RlZENoYXJnZUNyZWRpdFBvc3RpbmdCJ1oLbW9uZXkv",
            "Zm9saW+qAhdIT0xNUy5UeXBlcy5Nb25leS5Gb2xpb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Folio.RequestedChargeCreditPostingReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Folio.RequestedReservationPosting), global::HOLMS.Types.Money.Folio.RequestedReservationPosting.Parser, new[]{ "Reservation", "Lines" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RequestedReservationPosting : pb::IMessage<RequestedReservationPosting> {
    private static readonly pb::MessageParser<RequestedReservationPosting> _parser = new pb::MessageParser<RequestedReservationPosting>(() => new RequestedReservationPosting());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestedReservationPosting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Folio.RequestedReservationPostingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestedReservationPosting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestedReservationPosting(RequestedReservationPosting other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      lines_ = other.lines_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestedReservationPosting Clone() {
      return new RequestedReservationPosting(this);
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "lines" field.</summary>
    public const int LinesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Folio.RequestedChargeCreditPosting> _repeated_lines_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Money.Folio.RequestedChargeCreditPosting.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Folio.RequestedChargeCreditPosting> lines_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Folio.RequestedChargeCreditPosting>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Folio.RequestedChargeCreditPosting> Lines {
      get { return lines_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestedReservationPosting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestedReservationPosting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if(!lines_.Equals(other.lines_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      hash ^= lines_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reservation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Reservation);
      }
      lines_.WriteTo(output, _repeated_lines_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      size += lines_.CalculateSize(_repeated_lines_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RequestedReservationPosting other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      lines_.Add(other.lines_);
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
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 18: {
            lines_.AddEntriesFrom(input, _repeated_lines_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
