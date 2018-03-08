// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/housekeeping/housekeeping_room_status.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Housekeeping {

  /// <summary>Holder for reflection information generated from operations/housekeeping/housekeeping_room_status.proto</summary>
  public static partial class HousekeepingRoomStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/housekeeping/housekeeping_room_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HousekeepingRoomStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZvcGVyYXRpb25zL2hvdXNla2VlcGluZy9ob3VzZWtlZXBpbmdfcm9vbV9z",
            "dGF0dXMucHJvdG8SI2hvbG1zLnR5cGVzLm9wZXJhdGlvbnMuaG91c2VrZWVw",
            "aW5nGjtvcGVyYXRpb25zL2hvdXNla2VlcGluZy9yb29tX2Fycml2YWxfZGVw",
            "YXJ0dXJlX3N0YXR1cy5wcm90bxolb3BlcmF0aW9ucy9yb29tcy9yb29tX2lu",
            "ZGljYXRvci5wcm90byKkAQoWSG91c2VrZWVwaW5nUm9vbVN0YXR1cxI5CgRy",
            "b29tGAEgASgLMisuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5yb29tcy5Sb29t",
            "SW5kaWNhdG9yEk8KBnN0YXR1cxgCIAEoDjI/LmhvbG1zLnR5cGVzLm9wZXJh",
            "dGlvbnMuaG91c2VrZWVwaW5nLlJvb21BcnJpdmFsRGVwYXJ0dXJlU3RhdHVz",
            "QiaqAiNIT0xNUy5UeXBlcy5PcGVyYXRpb25zLkhvdXNla2VlcGluZ2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Operations.Housekeeping.RoomArrivalDepartureStatusReflection.Descriptor, global::HOLMS.Types.Operations.Rooms.RoomIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatus), global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatus.Parser, new[]{ "Room", "Status" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HousekeepingRoomStatus : pb::IMessage<HousekeepingRoomStatus> {
    private static readonly pb::MessageParser<HousekeepingRoomStatus> _parser = new pb::MessageParser<HousekeepingRoomStatus>(() => new HousekeepingRoomStatus());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HousekeepingRoomStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Housekeeping.HousekeepingRoomStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingRoomStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingRoomStatus(HousekeepingRoomStatus other) : this() {
      Room = other.room_ != null ? other.Room.Clone() : null;
      status_ = other.status_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HousekeepingRoomStatus Clone() {
      return new HousekeepingRoomStatus(this);
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 1;
    private global::HOLMS.Types.Operations.Rooms.RoomIndicator room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Rooms.RoomIndicator Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::HOLMS.Types.Operations.Housekeeping.RoomArrivalDepartureStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Housekeeping.RoomArrivalDepartureStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HousekeepingRoomStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HousekeepingRoomStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Room, other.Room)) return false;
      if (Status != other.Status) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (room_ != null) hash ^= Room.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HousekeepingRoomStatus other) {
      if (other == null) {
        return;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
        }
        Room.MergeFrom(other.Room);
      }
      if (other.Status != 0) {
        Status = other.Status;
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
              room_ = new global::HOLMS.Types.Operations.Rooms.RoomIndicator();
            }
            input.ReadMessage(room_);
            break;
          }
          case 16: {
            status_ = (global::HOLMS.Types.Operations.Housekeeping.RoomArrivalDepartureStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
