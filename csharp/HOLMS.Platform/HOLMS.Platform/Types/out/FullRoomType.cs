// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/room_types/full_room_type.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.RoomTypes {

  /// <summary>Holder for reflection information generated from supply/room_types/full_room_type.proto</summary>
  public static partial class FullRoomTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/room_types/full_room_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FullRoomTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZzdXBwbHkvcm9vbV90eXBlcy9mdWxsX3Jvb21fdHlwZS5wcm90bxIdaG9s",
            "bXMudHlwZXMuc3VwcGx5LnJvb21fdHlwZXMaG29wZXJhdGlvbnMvcm9vbXMv",
            "cm9vbS5wcm90bxohc3VwcGx5L3Jvb21fdHlwZXMvcm9vbV90eXBlLnByb3Rv",
            "In0KDEZ1bGxSb29tVHlwZRI6Cglyb29tX3R5cGUYASABKAsyJy5ob2xtcy50",
            "eXBlcy5zdXBwbHkucm9vbV90eXBlcy5Sb29tVHlwZRIxCgVyb29tcxgCIAMo",
            "CzIiLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMucm9vbXMuUm9vbUIxWhBzdXBw",
            "bHkvcm9vbXR5cGVzqgIcSE9MTVMuVHlwZXMuU3VwcGx5LlJvb21UeXBlc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Operations.Rooms.RoomReflection.Descriptor, global::HOLMS.Types.Supply.RoomTypes.RoomTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RoomTypes.FullRoomType), global::HOLMS.Types.Supply.RoomTypes.FullRoomType.Parser, new[]{ "RoomType", "Rooms" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FullRoomType : pb::IMessage<FullRoomType> {
    private static readonly pb::MessageParser<FullRoomType> _parser = new pb::MessageParser<FullRoomType>(() => new FullRoomType());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FullRoomType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RoomTypes.FullRoomTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FullRoomType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FullRoomType(FullRoomType other) : this() {
      RoomType = other.roomType_ != null ? other.RoomType.Clone() : null;
      rooms_ = other.rooms_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FullRoomType Clone() {
      return new FullRoomType(this);
    }

    /// <summary>Field number for the "room_type" field.</summary>
    public const int RoomTypeFieldNumber = 1;
    private global::HOLMS.Types.Supply.RoomTypes.RoomType roomType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomType RoomType {
      get { return roomType_; }
      set {
        roomType_ = value;
      }
    }

    /// <summary>Field number for the "rooms" field.</summary>
    public const int RoomsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Operations.Rooms.Room> _repeated_rooms_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.Operations.Rooms.Room.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Operations.Rooms.Room> rooms_ = new pbc::RepeatedField<global::HOLMS.Types.Operations.Rooms.Room>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Operations.Rooms.Room> Rooms {
      get { return rooms_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FullRoomType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FullRoomType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RoomType, other.RoomType)) return false;
      if(!rooms_.Equals(other.rooms_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (roomType_ != null) hash ^= RoomType.GetHashCode();
      hash ^= rooms_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (roomType_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RoomType);
      }
      rooms_.WriteTo(output, _repeated_rooms_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (roomType_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomType);
      }
      size += rooms_.CalculateSize(_repeated_rooms_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FullRoomType other) {
      if (other == null) {
        return;
      }
      if (other.roomType_ != null) {
        if (roomType_ == null) {
          roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
        }
        RoomType.MergeFrom(other.RoomType);
      }
      rooms_.Add(other.rooms_);
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
            if (roomType_ == null) {
              roomType_ = new global::HOLMS.Types.Supply.RoomTypes.RoomType();
            }
            input.ReadMessage(roomType_);
            break;
          }
          case 18: {
            rooms_.AddEntriesFrom(input, _repeated_rooms_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
