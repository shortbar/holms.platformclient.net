// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: reporting/rpc/management_reporting_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Reporting.RPC {

  /// <summary>Holder for reflection information generated from reporting/rpc/management_reporting_svc.proto</summary>
  public static partial class ManagementReportingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for reporting/rpc/management_reporting_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ManagementReportingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixyZXBvcnRpbmcvcnBjL21hbmFnZW1lbnRfcmVwb3J0aW5nX3N2Yy5wcm90",
            "bxIZaG9sbXMudHlwZXMucmVwb3J0aW5nLnJwYxobZ29vZ2xlL3Byb3RvYnVm",
            "L2VtcHR5LnByb3RvGjVyZXBvcnRpbmcvaW5wdXRfcGFyYW1zL3Byb3BlcnR5",
            "X2Nsb2NrdGltZV9yYW5nZS5wcm90bxoscmVwb3J0aW5nL291dHB1dHMvaHRt",
            "bF9yZXBvcnRfcmVzcG9uc2UucHJvdG8aM3JlcG9ydGluZy9pbnB1dF9wYXJh",
            "bXMvcHJvcGVydHlfb3BzZGF0ZV9yYW5nZS5wcm90bzLbCQoWTWFuYWdlbWVu",
            "dFJlcG9ydGluZ1N2YxJjChZHZXRGb2xpb0JhbGFuY2VzUmVwb3J0EhYuZ29v",
            "Z2xlLnByb3RvYnVmLkVtcHR5GjEuaG9sbXMudHlwZXMucmVwb3J0aW5nLm91",
            "dHB1dHMuSHRtbFJlcG9ydFJlc3BvbnNlEosBChpHZXRGb2xpb0dyb3NzQ2hh",
            "cmdlc1JlcG9ydBI6LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5pbnB1dF9wYXJh",
            "bXMuUHJvcGVydHlDbG9ja1RpbWVSYW5nZRoxLmhvbG1zLnR5cGVzLnJlcG9y",
            "dGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZRKHAQoWR2V0Rm9saW9Q",
            "YXltZW50c1JlcG9ydBI6LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5pbnB1dF9w",
            "YXJhbXMuUHJvcGVydHlDbG9ja1RpbWVSYW5nZRoxLmhvbG1zLnR5cGVzLnJl",
            "cG9ydGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZRKKAQoZR2V0Rm9s",
            "aW9BZGp1c3RtZW50c1JlcG9ydBI6LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5p",
            "bnB1dF9wYXJhbXMuUHJvcGVydHlDbG9ja1RpbWVSYW5nZRoxLmhvbG1zLnR5",
            "cGVzLnJlcG9ydGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNwb25zZRKIAQoX",
            "R2V0Q2FsbEFjY291bnRpbmdSZXBvcnQSOi5ob2xtcy50eXBlcy5yZXBvcnRp",
            "bmcuaW5wdXRfcGFyYW1zLlByb3BlcnR5Q2xvY2tUaW1lUmFuZ2UaMS5ob2xt",
            "cy50eXBlcy5yZXBvcnRpbmcub3V0cHV0cy5IdG1sUmVwb3J0UmVzcG9uc2US",
            "iQEKGEdldExlZGdlckFjdGl2aXR5U3VtbWFyeRI6LmhvbG1zLnR5cGVzLnJl",
            "cG9ydGluZy5pbnB1dF9wYXJhbXMuUHJvcGVydHlDbG9ja1RpbWVSYW5nZRox",
            "LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5vdXRwdXRzLkh0bWxSZXBvcnRSZXNw",
            "b25zZRKIAQoXR2V0TGVkZ2VySm91cm5hbEVudHJpZXMSOi5ob2xtcy50eXBl",
            "cy5yZXBvcnRpbmcuaW5wdXRfcGFyYW1zLlByb3BlcnR5Q2xvY2tUaW1lUmFu",
            "Z2UaMS5ob2xtcy50eXBlcy5yZXBvcnRpbmcub3V0cHV0cy5IdG1sUmVwb3J0",
            "UmVzcG9uc2USiQEKGkdldFJvb21Vc2FnZVJlcG9ydERldGFpbGVkEjguaG9s",
            "bXMudHlwZXMucmVwb3J0aW5nLmlucHV0X3BhcmFtcy5Qcm9wZXJ0eU9wc2Rh",
            "dGVSYW5nZRoxLmhvbG1zLnR5cGVzLnJlcG9ydGluZy5vdXRwdXRzLkh0bWxS",
            "ZXBvcnRSZXNwb25zZRKIAQoZR2V0Um9vbVVzYWdlUmVwb3J0U3VtbWFyeRI4",
            "LmhvbG1zLnR5cGVzLnJlcG9ydGluZy5pbnB1dF9wYXJhbXMuUHJvcGVydHlP",
            "cHNkYXRlUmFuZ2UaMS5ob2xtcy50eXBlcy5yZXBvcnRpbmcub3V0cHV0cy5I",
            "dG1sUmVwb3J0UmVzcG9uc2VCK1oNcmVwb3J0aW5nL3JwY6oCGUhPTE1TLlR5",
            "cGVzLlJlcG9ydGluZy5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Reporting.ReportParams.PropertyClocktimeRangeReflection.Descriptor, global::HOLMS.Types.Reporting.Outputs.HtmlReportResponseReflection.Descriptor, global::HOLMS.Types.Reporting.ReportParams.PropertyOpsdateRangeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
