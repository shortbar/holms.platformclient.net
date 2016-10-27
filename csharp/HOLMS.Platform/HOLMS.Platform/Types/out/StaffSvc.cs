// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: iam/rpc/staff_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.IAM.RPC {

  /// <summary>Holder for reflection information generated from iam/rpc/staff_svc.proto</summary>
  public static partial class StaffSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for iam/rpc/staff_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StaffSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdpYW0vcnBjL3N0YWZmX3N2Yy5wcm90bxITaG9sbXMudHlwZXMuaWFtLnJw",
            "YxoqcHJpbWl0aXZlL3NlcnZlcl9hY3Rpb25fY29uZmlybWF0aW9uLnByb3Rv",
            "Ghtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aFmlhbS9zdGFmZl9tZW1i",
            "ZXIucHJvdG8aIGlhbS9zdGFmZl9tZW1iZXJfaW5kaWNhdG9yLnByb3RvIk0K",
            "FlN0YWZmU3ZjR2V0QWxsUmVzcG9uc2USMwoNc3RhZmZfbWVtYmVycxgBIAMo",
            "CzIcLmhvbG1zLnR5cGVzLmlhbS5TdGFmZk1lbWJlcjLjAwoIU3RhZmZTdmMS",
            "SgoDQWxsEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GisuaG9sbXMudHlwZXMu",
            "aWFtLnJwYy5TdGFmZlN2Y0dldEFsbFJlc3BvbnNlElYKD0dldEhvdXNla2Vl",
            "cGVycxIWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRorLmhvbG1zLnR5cGVzLmlh",
            "bS5ycGMuU3RhZmZTdmNHZXRBbGxSZXNwb25zZRJOCgdHZXRCeUlkEiUuaG9s",
            "bXMudHlwZXMuaWFtLlN0YWZmTWVtYmVySW5kaWNhdG9yGhwuaG9sbXMudHlw",
            "ZXMuaWFtLlN0YWZmTWVtYmVyEkQKBkNyZWF0ZRIcLmhvbG1zLnR5cGVzLmlh",
            "bS5TdGFmZk1lbWJlchocLmhvbG1zLnR5cGVzLmlhbS5TdGFmZk1lbWJlchJE",
            "CgZVcGRhdGUSHC5ob2xtcy50eXBlcy5pYW0uU3RhZmZNZW1iZXIaHC5ob2xt",
            "cy50eXBlcy5pYW0uU3RhZmZNZW1iZXISVwoGRGVsZXRlEhwuaG9sbXMudHlw",
            "ZXMuaWFtLlN0YWZmTWVtYmVyGi8uaG9sbXMudHlwZXMucHJpbWl0aXZlLlNl",
            "cnZlckFjdGlvbkNvbmZpcm1hdGlvbkIfWgdpYW0vcnBjqgITSE9MTVMuVHlw",
            "ZXMuSUFNLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.ServerActionConfirmationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberReflection.Descriptor, global::HOLMS.Types.IAM.StaffMemberIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse), global::HOLMS.Types.IAM.RPC.StaffSvcGetAllResponse.Parser, new[]{ "StaffMembers" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StaffSvcGetAllResponse : pb::IMessage<StaffSvcGetAllResponse> {
    private static readonly pb::MessageParser<StaffSvcGetAllResponse> _parser = new pb::MessageParser<StaffSvcGetAllResponse>(() => new StaffSvcGetAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StaffSvcGetAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.IAM.RPC.StaffSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcGetAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcGetAllResponse(StaffSvcGetAllResponse other) : this() {
      staffMembers_ = other.staffMembers_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StaffSvcGetAllResponse Clone() {
      return new StaffSvcGetAllResponse(this);
    }

    /// <summary>Field number for the "staff_members" field.</summary>
    public const int StaffMembersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.IAM.StaffMember> _repeated_staffMembers_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.IAM.StaffMember.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMember> staffMembers_ = new pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMember>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.IAM.StaffMember> StaffMembers {
      get { return staffMembers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StaffSvcGetAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StaffSvcGetAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!staffMembers_.Equals(other.staffMembers_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= staffMembers_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      staffMembers_.WriteTo(output, _repeated_staffMembers_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += staffMembers_.CalculateSize(_repeated_staffMembers_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StaffSvcGetAllResponse other) {
      if (other == null) {
        return;
      }
      staffMembers_.Add(other.staffMembers_);
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
            staffMembers_.AddEntriesFrom(input, _repeated_staffMembers_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
