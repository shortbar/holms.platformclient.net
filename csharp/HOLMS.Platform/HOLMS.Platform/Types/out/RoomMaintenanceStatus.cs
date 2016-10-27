// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/room_maintenance_status.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations {

  /// <summary>Holder for reflection information generated from operations/room_maintenance_status.proto</summary>
  public static partial class RoomMaintenanceStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/room_maintenance_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomMaintenanceStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihvcGVyYXRpb25zL3Jvb21fbWFpbnRlbmFuY2Vfc3RhdHVzLnByb3RvEhZo",
            "b2xtcy50eXBlcy5vcGVyYXRpb25zKqoBChRSb29tTWFpbnRlbmFuY2VTdGF0",
            "ZRIJCgVDTEVBThAAEhwKGENMRUFOX0FORF9TSEVFVFNfQ0hBTkdFRBABEhEK",
            "DURFRVBfQ0xFQU5JTkcQAhIJCgVESVJUWRADEg0KCURVU1RfUk9PTRAEEgsK",
            "B0lOU1BFQ1QQBRIOCgpMRUZUX0RJUlRZEAYSEAoMTUFJRF9JTl9ST09NEAcS",
            "DQoJU0hPV19ST09NEAhCJVoKb3BlcmF0aW9uc6oCFkhPTE1TLlR5cGVzLk9w",
            "ZXJhdGlvbnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Operations.RoomMaintenanceState), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RoomMaintenanceState {
    [pbr::OriginalName("CLEAN")] Clean = 0,
    [pbr::OriginalName("CLEAN_AND_SHEETS_CHANGED")] CleanAndSheetsChanged = 1,
    [pbr::OriginalName("DEEP_CLEANING")] DeepCleaning = 2,
    [pbr::OriginalName("DIRTY")] Dirty = 3,
    [pbr::OriginalName("DUST_ROOM")] DustRoom = 4,
    [pbr::OriginalName("INSPECT")] Inspect = 5,
    [pbr::OriginalName("LEFT_DIRTY")] LeftDirty = 6,
    [pbr::OriginalName("MAID_IN_ROOM")] MaidInRoom = 7,
    [pbr::OriginalName("SHOW_ROOM")] ShowRoom = 8,
  }

  #endregion

}

#endregion Designer generated code
