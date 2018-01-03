// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/fsv2/folio_indicator.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.FSv2 {

  /// <summary>Holder for reflection information generated from folio/fsv2/folio_indicator.proto</summary>
  public static partial class FolioIndicatorReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/fsv2/folio_indicator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioIndicatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBmb2xpby9mc3YyL2ZvbGlvX2luZGljYXRvci5wcm90bxIWaG9sbXMudHlw",
            "ZXMuZm9saW8uZnN2MhowYm9va2luZy9pbmRpY2F0b3JzL2dyb3VwX2Jvb2tp",
            "bmdfaW5kaWNhdG9yLnByb3RvGi5ib29raW5nL2luZGljYXRvcnMvcmVzZXJ2",
            "YXRpb25faW5kaWNhdG9yLnByb3RvIqkBCg5Gb2xpb0luZGljYXRvchJJCgty",
            "ZXNlcnZhdGlvbhgBIAEoCzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNh",
            "dG9ycy5SZXNlcnZhdGlvbkluZGljYXRvchJMCg1ncm91cF9ib29raW5nGAIg",
            "ASgLMjUuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLkdyb3VwQm9v",
            "a2luZ0luZGljYXRvckIZqgIWSE9MTVMuVHlwZXMuRm9saW8uRlN2MmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.FSv2.FolioIndicator), global::HOLMS.Types.Folio.FSv2.FolioIndicator.Parser, new[]{ "Reservation", "GroupBooking" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FolioIndicator : pb::IMessage<FolioIndicator> {
    private static readonly pb::MessageParser<FolioIndicator> _parser = new pb::MessageParser<FolioIndicator>(() => new FolioIndicator());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioIndicator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.FSv2.FolioIndicatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioIndicator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioIndicator(FolioIndicator other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      GroupBooking = other.groupBooking_ != null ? other.GroupBooking.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioIndicator Clone() {
      return new FolioIndicator(this);
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

    /// <summary>Field number for the "group_booking" field.</summary>
    public const int GroupBookingFieldNumber = 2;
    private global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator groupBooking_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator GroupBooking {
      get { return groupBooking_; }
      set {
        groupBooking_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FolioIndicator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioIndicator other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if (!object.Equals(GroupBooking, other.GroupBooking)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      if (groupBooking_ != null) hash ^= GroupBooking.GetHashCode();
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
      if (groupBooking_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GroupBooking);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      if (groupBooking_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GroupBooking);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioIndicator other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      if (other.groupBooking_ != null) {
        if (groupBooking_ == null) {
          groupBooking_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
        }
        GroupBooking.MergeFrom(other.GroupBooking);
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
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 18: {
            if (groupBooking_ == null) {
              groupBooking_ = new global::HOLMS.Types.Booking.Indicators.GroupBookingIndicator();
            }
            input.ReadMessage(groupBooking_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code