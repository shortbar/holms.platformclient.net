// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/guarantees/guarantee_type.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Guarantees {

  /// <summary>Holder for reflection information generated from booking/guarantees/guarantee_type.proto</summary>
  public static partial class GuaranteeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/guarantees/guarantee_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GuaranteeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidib29raW5nL2d1YXJhbnRlZXMvZ3VhcmFudGVlX3R5cGUucHJvdG8SHmhv",
            "bG1zLnR5cGVzLmJvb2tpbmcuZ3VhcmFudGVlcyokCg1HdWFyYW50ZWVUeXBl",
            "EgkKBUNIRUNLEAASCAoEQ0FSRBABQjVaEmJvb2tpbmcvZ3VhcmFudGVlc6oC",
            "HkhPTE1TLlR5cGVzLkJvb2tpbmcuR3VhcmFudGVlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Booking.Guarantees.GuaranteeType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum GuaranteeType {
    [pbr::OriginalName("CHECK")] Check = 0,
    [pbr::OriginalName("CARD")] Card = 1,
  }

  #endregion

}

#endregion Designer generated code
