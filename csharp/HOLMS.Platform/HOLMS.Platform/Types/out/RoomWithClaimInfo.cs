// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rooms/room_with_claim_info.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Rooms {

  /// <summary>Holder for reflection information generated from operations/rooms/room_with_claim_info.proto</summary>
  public static partial class RoomWithClaimInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rooms/room_with_claim_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomWithClaimInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitvcGVyYXRpb25zL3Jvb21zL3Jvb21fd2l0aF9jbGFpbV9pbmZvLnByb3Rv",
            "Ehxob2xtcy50eXBlcy5vcGVyYXRpb25zLnJvb21zGi5ib29raW5nL3Jlc2Vy",
            "dmF0aW9ucy9yZXNlcnZhdGlvbl9zdW1tYXJ5LnByb3RvGhtvcGVyYXRpb25z",
            "L3Jvb21zL3Jvb20ucHJvdG8izwEKEVJvb21XaXRoQ2xhaW1JbmZvEjAKBHJv",
            "b20YASABKAsyIi5ob2xtcy50eXBlcy5vcGVyYXRpb25zLnJvb21zLlJvb20S",
            "HQoVaGFzX3Jlc2VydmF0aW9uX2NsYWltGAIgASgIEhUKDWhhc19vb29fY2xh",
            "aW0YAyABKAgSUgoUY2xhaW1pbmdfcmVzZXJ2YXRpb24YBCABKAsyNC5ob2xt",
            "cy50eXBlcy5ib29raW5nLnJlc2VydmF0aW9ucy5SZXNlcnZhdGlvblN1bW1h",
            "cnlCMVoQb3BlcmF0aW9ucy9yb29tc6oCHEhPTE1TLlR5cGVzLk9wZXJhdGlv",
            "bnMuUm9vbXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Reservations.ReservationSummaryReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Rooms.RoomWithClaimInfo), global::HOLMS.Types.Operations.Rooms.RoomWithClaimInfo.Parser, new[]{ "Room", "HasReservationClaim", "HasOooClaim", "ClaimingReservation" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoomWithClaimInfo : pb::IMessage<RoomWithClaimInfo> {
    private static readonly pb::MessageParser<RoomWithClaimInfo> _parser = new pb::MessageParser<RoomWithClaimInfo>(() => new RoomWithClaimInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomWithClaimInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Rooms.RoomWithClaimInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomWithClaimInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomWithClaimInfo(RoomWithClaimInfo other) : this() {
      Room = other.room_ != null ? other.Room.Clone() : null;
      hasReservationClaim_ = other.hasReservationClaim_;
      hasOooClaim_ = other.hasOooClaim_;
      ClaimingReservation = other.claimingReservation_ != null ? other.ClaimingReservation.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomWithClaimInfo Clone() {
      return new RoomWithClaimInfo(this);
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 1;
    private global::HOLMS.Types.Operations.Rooms.Room room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.Room Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    /// <summary>Field number for the "has_reservation_claim" field.</summary>
    public const int HasReservationClaimFieldNumber = 2;
    private bool hasReservationClaim_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasReservationClaim {
      get { return hasReservationClaim_; }
      set {
        hasReservationClaim_ = value;
      }
    }

    /// <summary>Field number for the "has_ooo_claim" field.</summary>
    public const int HasOooClaimFieldNumber = 3;
    private bool hasOooClaim_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasOooClaim {
      get { return hasOooClaim_; }
      set {
        hasOooClaim_ = value;
      }
    }

    /// <summary>Field number for the "claiming_reservation" field.</summary>
    public const int ClaimingReservationFieldNumber = 4;
    private global::HOLMS.Types.Booking.Reservations.ReservationSummary claimingReservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Reservations.ReservationSummary ClaimingReservation {
      get { return claimingReservation_; }
      set {
        claimingReservation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomWithClaimInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomWithClaimInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Room, other.Room)) return false;
      if (HasReservationClaim != other.HasReservationClaim) return false;
      if (HasOooClaim != other.HasOooClaim) return false;
      if (!object.Equals(ClaimingReservation, other.ClaimingReservation)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (room_ != null) hash ^= Room.GetHashCode();
      if (HasReservationClaim != false) hash ^= HasReservationClaim.GetHashCode();
      if (HasOooClaim != false) hash ^= HasOooClaim.GetHashCode();
      if (claimingReservation_ != null) hash ^= ClaimingReservation.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (room_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Room);
      }
      if (HasReservationClaim != false) {
        output.WriteRawTag(16);
        output.WriteBool(HasReservationClaim);
      }
      if (HasOooClaim != false) {
        output.WriteRawTag(24);
        output.WriteBool(HasOooClaim);
      }
      if (claimingReservation_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ClaimingReservation);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (HasReservationClaim != false) {
        size += 1 + 1;
      }
      if (HasOooClaim != false) {
        size += 1 + 1;
      }
      if (claimingReservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClaimingReservation);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomWithClaimInfo other) {
      if (other == null) {
        return;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HOLMS.Types.Operations.Rooms.Room();
        }
        Room.MergeFrom(other.Room);
      }
      if (other.HasReservationClaim != false) {
        HasReservationClaim = other.HasReservationClaim;
      }
      if (other.HasOooClaim != false) {
        HasOooClaim = other.HasOooClaim;
      }
      if (other.claimingReservation_ != null) {
        if (claimingReservation_ == null) {
          claimingReservation_ = new global::HOLMS.Types.Booking.Reservations.ReservationSummary();
        }
        ClaimingReservation.MergeFrom(other.ClaimingReservation);
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
            if (room_ == null) {
              room_ = new global::HOLMS.Types.Operations.Rooms.Room();
            }
            input.ReadMessage(room_);
            break;
          }
          case 16: {
            HasReservationClaim = input.ReadBool();
            break;
          }
          case 24: {
            HasOooClaim = input.ReadBool();
            break;
          }
          case 34: {
            if (claimingReservation_ == null) {
              claimingReservation_ = new global::HOLMS.Types.Booking.Reservations.ReservationSummary();
            }
            input.ReadMessage(claimingReservation_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
