// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/rpc/folio_svc_post_check_payment_result.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.RPC {

  /// <summary>Holder for reflection information generated from folio/rpc/folio_svc_post_check_payment_result.proto</summary>
  public static partial class FolioSvcPostCheckPaymentResultReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/rpc/folio_svc_post_check_payment_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioSvcPostCheckPaymentResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNmb2xpby9ycGMvZm9saW9fc3ZjX3Bvc3RfY2hlY2tfcGF5bWVudF9yZXN1",
            "bHQucHJvdG8SFWhvbG1zLnR5cGVzLmZvbGlvLnJwYyquAQoeRm9saW9TdmNQ",
            "b3N0Q2hlY2tQYXltZW50UmVzdWx0EiMKH0ZPTElPX1NWQ19QT1NUX0NIRUNL",
            "X1BBWU1FTlRfT0sQABI2CjJGT0xJT19TVkNfUE9TVF9DSEVDS19QQVlNRU5U",
            "X01JU1NJTkdfSE9VU0VfQUNDT1VOVBABEi8KK0ZPTElPX1NWQ19QT1NUX0NI",
            "RUNLX1BBWU1FTlRfSU5WQUxJRF9BTU9VTlQQAkIYqgIVSE9MTVMuVHlwZXMu",
            "Rm9saW8uUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Folio.RPC.FolioSvcPostCheckPaymentResult), }, null));
    }
    #endregion

  }
  #region Enums
  public enum FolioSvcPostCheckPaymentResult {
    [pbr::OriginalName("FOLIO_SVC_POST_CHECK_PAYMENT_OK")] FolioSvcPostCheckPaymentOk = 0,
    [pbr::OriginalName("FOLIO_SVC_POST_CHECK_PAYMENT_MISSING_HOUSE_ACCOUNT")] FolioSvcPostCheckPaymentMissingHouseAccount = 1,
    [pbr::OriginalName("FOLIO_SVC_POST_CHECK_PAYMENT_INVALID_AMOUNT")] FolioSvcPostCheckPaymentInvalidAmount = 2,
  }

  #endregion

}

#endregion Designer generated code
