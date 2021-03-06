// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/check_in/check_in_request_result.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.CheckIn {

  /// <summary>Holder for reflection information generated from booking/check_in/check_in_request_result.proto</summary>
  public static partial class CheckInRequestResultReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/check_in/check_in_request_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckInRequestResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5ib29raW5nL2NoZWNrX2luL2NoZWNrX2luX3JlcXVlc3RfcmVzdWx0LnBy",
            "b3RvEhxob2xtcy50eXBlcy5ib29raW5nLmNoZWNrX2luKpcCChRDaGVja0lu",
            "UmVxdWVzdFJlc3VsdBIGCgJPSxAAEhYKEkFMUkVBRFlfQ0hFQ0tFRF9JThAB",
            "EhkKFU1JU1NJTkdfQVNTSUdORURfUk9PTRACEhAKDE1JU1NJTkdfQ0FSRBAD",
            "EhYKEk1JU1NJTkdfR1VFU1RfTkFNRRAEEhcKE05PX09QRU5fUkVTRVJWQVRJ",
            "T04QBRIsCihQT0xJQ1lfVklPTEFUSU9OX1RPT19NQU5ZX0dVRVNUU19JTl9S",
            "T09NEAYSGAoUVE9PX0VBUkxZX1RPX0NIRUNLSU4QBxIeChpSRVNFUlZBVElP",
            "Tl9OT1RfR1VBUkFOVEVFRBAIEhkKFVJPT01fQUxSRUFEWV9PQ0NVUElFRBAJ",
            "Qi9aD2Jvb2tpbmcvY2hlY2tpbqoCG0hPTE1TLlR5cGVzLkJvb2tpbmcuQ2hl",
            "Y2tJbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Booking.CheckIn.CheckInRequestResult), }, null));
    }
    #endregion

  }
  #region Enums
  public enum CheckInRequestResult {
    [pbr::OriginalName("OK")] Ok = 0,
    [pbr::OriginalName("ALREADY_CHECKED_IN")] AlreadyCheckedIn = 1,
    [pbr::OriginalName("MISSING_ASSIGNED_ROOM")] MissingAssignedRoom = 2,
    [pbr::OriginalName("MISSING_CARD")] MissingCard = 3,
    [pbr::OriginalName("MISSING_GUEST_NAME")] MissingGuestName = 4,
    [pbr::OriginalName("NO_OPEN_RESERVATION")] NoOpenReservation = 5,
    [pbr::OriginalName("POLICY_VIOLATION_TOO_MANY_GUESTS_IN_ROOM")] PolicyViolationTooManyGuestsInRoom = 6,
    [pbr::OriginalName("TOO_EARLY_TO_CHECKIN")] TooEarlyToCheckin = 7,
    [pbr::OriginalName("RESERVATION_NOT_GUARANTEED")] ReservationNotGuaranteed = 8,
    [pbr::OriginalName("ROOM_ALREADY_OCCUPIED")] RoomAlreadyOccupied = 9,
  }

  #endregion

}

#endregion Designer generated code
