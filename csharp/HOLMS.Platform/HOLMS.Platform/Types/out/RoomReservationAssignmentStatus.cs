// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/housekeeping/room_reservation_assignment_status.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Housekeeping {

  /// <summary>Holder for reflection information generated from operations/housekeeping/room_reservation_assignment_status.proto</summary>
  public static partial class RoomReservationAssignmentStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/housekeeping/room_reservation_assignment_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomReservationAssignmentStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBvcGVyYXRpb25zL2hvdXNla2VlcGluZy9yb29tX3Jlc2VydmF0aW9uX2Fz",
            "c2lnbm1lbnRfc3RhdHVzLnByb3RvEiNob2xtcy50eXBlcy5vcGVyYXRpb25z",
            "LmhvdXNla2VlcGluZyqeBwofUm9vbVJlc2VydmF0aW9uQXNzaWdubWVudFN0",
            "YXR1cxI0CjBST09NX1JFU0VSVkFUSU9OX0FTU0lHTk1FTlRfU1RBVFVTX1ZB",
            "Q0FOVF9WQUNBTlQQABI7CjdST09NX1JFU0VSVkFUSU9OX0FTU0lHTk1FTlRf",
            "U1RBVFVTX1ZBQ0FOVF9XSVRIX0lOQ09NSU5HEAESLworUk9PTV9SRVNFUlZB",
            "VElPTl9BU1NJR05NRU5UX1NUQVRVU19TVEFZT1ZFUhACEjwKOFJPT01fUkVT",
            "RVJWQVRJT05fQVNTSUdOTUVOVF9TVEFUVVNfTEVBVklOR19OT05FX0lOQ09N",
            "SU5HEAMSOQo1Uk9PTV9SRVNFUlZBVElPTl9BU1NJR05NRU5UX1NUQVRVU19M",
            "RUZUX05PTkVfSU5DT01JTkcQBBI8CjhST09NX1JFU0VSVkFUSU9OX0FTU0lH",
            "Tk1FTlRfU1RBVFVTX0xFRlRfSU5DT01JTkdfQVJSSVZFRBAFEjwKOFJPT01f",
            "UkVTRVJWQVRJT05fQVNTSUdOTUVOVF9TVEFUVVNfTEVBVklOR19XSVRIX0lO",
            "Q09NSU5HEAYSOQo1Uk9PTV9SRVNFUlZBVElPTl9BU1NJR05NRU5UX1NUQVRV",
            "U19MRUZUX1dJVEhfSU5DT01JTkcQBxI8CjhST09NX1JFU0VSVkFUSU9OX0FT",
            "U0lHTk1FTlRfU1RBVFVTX0FSUklWRURfQUZURVJfVkFDQU5DWRAIEiwKKFJP",
            "T01fUkVTRVJWQVRJT05fQVNTSUdOTUVOVF9PVVRfT0ZfT1JERVIQCRIsCihS",
            "T09NX1JFU0VSVkFUSU9OX0FTU0lHTk1FTlRfU1RBVFVTX09USEVSEAoSPQo5",
            "Uk9PTV9SRVNFUlZBVElPTl9BU1NJR05NRU5UX1NUQVRVU19MRUZUX1dJVEhf",
            "T1VUX09GX09SREVSEAsSQAo8Uk9PTV9SRVNFUlZBVElPTl9BU1NJR05NRU5U",
            "X1NUQVRVU19MRUFWSU5HX1dJVEhfT1VUX09GX09SREVSEAwSQwo/Uk9PTV9S",
            "RVNFUlZBVElPTl9BU1NJR05NRU5UX1NUQVRVU19WQUNBTlRfTEVBVklOR19X",
            "SVRIX0lOQ09NSU5HEA0SRwpDUk9PTV9SRVNFUlZBVElPTl9BU1NJR05NRU5U",
            "X1NUQVRVU19WQUNBTlRfTEVBVklOR19XSVRIX09VVF9PRl9PUkRFUhAOQiaq",
            "AiNIT0xNUy5UeXBlcy5PcGVyYXRpb25zLkhvdXNla2VlcGluZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Operations.Housekeeping.RoomReservationAssignmentStatus), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RoomReservationAssignmentStatus {
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_VACANT_VACANT")] VacantVacant = 0,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_VACANT_WITH_INCOMING")] VacantWithIncoming = 1,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_STAYOVER")] Stayover = 2,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_LEAVING_NONE_INCOMING")] LeavingNoneIncoming = 3,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_LEFT_NONE_INCOMING")] LeftNoneIncoming = 4,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_LEFT_INCOMING_ARRIVED")] LeftIncomingArrived = 5,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_LEAVING_WITH_INCOMING")] LeavingWithIncoming = 6,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_LEFT_WITH_INCOMING")] LeftWithIncoming = 7,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_ARRIVED_AFTER_VACANCY")] ArrivedAfterVacancy = 8,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_OUT_OF_ORDER")] RoomReservationAssignmentOutOfOrder = 9,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_OTHER")] Other = 10,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_LEFT_WITH_OUT_OF_ORDER")] LeftWithOutOfOrder = 11,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_LEAVING_WITH_OUT_OF_ORDER")] LeavingWithOutOfOrder = 12,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_VACANT_LEAVING_WITH_INCOMING")] VacantLeavingWithIncoming = 13,
    [pbr::OriginalName("ROOM_RESERVATION_ASSIGNMENT_STATUS_VACANT_LEAVING_WITH_OUT_OF_ORDER")] VacantLeavingWithOutOfOrder = 14,
  }

  #endregion

}

#endregion Designer generated code
