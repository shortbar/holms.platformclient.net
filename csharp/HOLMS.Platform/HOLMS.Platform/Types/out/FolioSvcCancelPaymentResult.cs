// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/rpc/folio_svc_cancel_payment_result.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.RPC {

  /// <summary>Holder for reflection information generated from folio/rpc/folio_svc_cancel_payment_result.proto</summary>
  public static partial class FolioSvcCancelPaymentResultReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/rpc/folio_svc_cancel_payment_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioSvcCancelPaymentResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9mb2xpby9ycGMvZm9saW9fc3ZjX2NhbmNlbF9wYXltZW50X3Jlc3VsdC5w",
            "cm90bxIVaG9sbXMudHlwZXMuZm9saW8ucnBjKv4BChtGb2xpb1N2Y0NhbmNl",
            "bFBheW1lbnRSZXN1bHQSJAogRk9MSU9fU1ZDX0NBTkNFTF9QQVlNRU5UX1NV",
            "Q0NFU1MQABIsCihGT0xJT19TVkNfQ0FOQ0VMX1BBWU1FTlRfVU5LTk9XTl9G",
            "QUlMVVJFEAESKwonRk9MSU9fU1ZDX0NBTkNFTF9QQVlNRU5UX1NBTEVfTk9U",
            "X0ZPVU5EEAISMgouRk9MSU9fU1ZDX0NBTkNFTF9QQVlNRU5UX1JFSkVDVEVE",
            "X0JZX1BST0NFU1NPUhADEioKJkZPTElPX1NWQ19DQU5DRUxfUEFZTUVOVF9J",
            "TlZBTElEX1NUQVRFEARCGKoCFUhPTE1TLlR5cGVzLkZvbGlvLlJQQ2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Folio.RPC.FolioSvcCancelPaymentResult), }, null));
    }
    #endregion

  }
  #region Enums
  public enum FolioSvcCancelPaymentResult {
    [pbr::OriginalName("FOLIO_SVC_CANCEL_PAYMENT_SUCCESS")] FolioSvcCancelPaymentSuccess = 0,
    [pbr::OriginalName("FOLIO_SVC_CANCEL_PAYMENT_UNKNOWN_FAILURE")] FolioSvcCancelPaymentUnknownFailure = 1,
    [pbr::OriginalName("FOLIO_SVC_CANCEL_PAYMENT_SALE_NOT_FOUND")] FolioSvcCancelPaymentSaleNotFound = 2,
    [pbr::OriginalName("FOLIO_SVC_CANCEL_PAYMENT_REJECTED_BY_PROCESSOR")] FolioSvcCancelPaymentRejectedByProcessor = 3,
    [pbr::OriginalName("FOLIO_SVC_CANCEL_PAYMENT_INVALID_STATE")] FolioSvcCancelPaymentInvalidState = 4,
  }

  #endregion

}

#endregion Designer generated code
